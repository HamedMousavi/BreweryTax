using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Xml;
using System.Xml.Serialization;
using Ionic.Zip;
using System.Collections.Generic;


namespace TaxDataStoreUpdater
{

    public class ServiceIo
    {

        public static bool LoadSettings()
        {
            Stream stream = null;

            try
            {
                string path = ServiceUtil.StartupPath +
                    System.IO.Path.DirectorySeparatorChar +
                    Settings.Instance.DirectoryName +
                    System.IO.Path.DirectorySeparatorChar +
                    Settings.Instance.SettingsFileName;

                if (!File.Exists(path)) return false;

                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                Settings settings = (Settings)serializer.Deserialize(stream);
                stream.Close();
                settings.CopyTo(Settings.Instance);

                return true;
            }
            catch (Exception e)
            {
                if (stream != null) stream.Close();

                EventLogger.Instance.Add("Failed to load settings: " + e.Message);
            }

            return false;
        }


        public static void SaveSettings()
        {
            Stream stream = null;

            try
            {
                string path = ServiceUtil.StartupPath + Path.DirectorySeparatorChar + Settings.Instance.DirectoryName;
                EnsureDirectoryExists(path);
                path += (System.IO.Path.DirectorySeparatorChar + Settings.Instance.SettingsFileName);

                XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(stream, Settings.Instance);
                stream.Close();
            }
            catch (Exception e)
            {
                if (stream != null) stream.Close();

                EventLogger.Instance.Add("Failed to save settings: " + e.Message);
            }
        }


        private static void EnsureDirectoryExists(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                NTAccount account;
                string username;

                DirectoryInfo df = new DirectoryInfo(directoryPath);
                DirectorySecurity dirSec = df.GetAccessControl();

                FileSystemRights rights = FileSystemRights.FullControl;
                AccessControlType allowType = AccessControlType.Allow;
                InheritanceFlags inheritance = InheritanceFlags.None;
                PropagationFlags propagation = PropagationFlags.InheritOnly;

                SecurityIdentifier[] sids = new SecurityIdentifier[] 
                {
                    new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    new SecurityIdentifier(WellKnownSidType.LocalServiceSid, null),
                    new SecurityIdentifier(WellKnownSidType.LocalSystemSid, null),
                    new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null)
                };

                foreach (SecurityIdentifier sid in sids)
                {
                    account = (NTAccount)sid.Translate(typeof(NTAccount));
                    username = account.ToString();

                    dirSec.AddAccessRule(
                        new FileSystemAccessRule(
                            username,
                            rights,
                            inheritance,
                            propagation,
                            allowType));
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: EnsureDirectoryExists " + ex.Message);
            }
        }


        internal static AssemblyName GetUpdateAssembly()
        {
            try
            {
                string appPath =
                    ServiceUtil.StartupPath +
                    Path.DirectorySeparatorChar +
                    Settings.Instance.UpdateApplicationName;

                return AssemblyName.GetAssemblyName(appPath);
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: GetUpdateAssembly " + ex.Message);
            }

            return null;
        }


        internal static void CleanDownloadFolder()
        {
            try
            {
                string dirPath = GetDownloadDirectoryPath(true);

                Directory.Delete(dirPath, true);

                // This will ensure dir arch is rectreated
                GetDownloadDirectoryPath(true);
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: CleanDownloadFolder " + ex.Message);
            }
        }


        internal static UpdateManifestInfo LoadManifestFile()
        {
            try
            {
                UpdateManifestInfo info = null;

                string manifestFileName = ExtractFileNameFromUri(Settings.Instance.UpdateUri);

                string path =
                    GetDownloadDirectoryPath() +
                    Path.DirectorySeparatorChar +
                    manifestFileName;

                if (File.Exists(path))
                {

                    XmlDocument doc = new System.Xml.XmlDocument();
                    doc.Load(path);

                    XmlNode details = doc.SelectSingleNode("UpdateDetails");
                    if (details != null && details.HasChildNodes)
                    {
                        info = new UpdateManifestInfo();

                        XmlNode node = details.SelectSingleNode("Version");
                        if (node != null)
                        {
                            info.UpdateVersion = node.InnerText;
                        }

                        node = details.SelectSingleNode("URL");
                        if (node != null)
                        {
                            info.UpdatePackageUri = node.InnerText;
                        }

                        node = details.SelectSingleNode("ChangeLog");
                        if (node != null)
                        {
                            info.ChangeLog = node.InnerText;
                        }

                        node = details.SelectSingleNode("HashCode");
                        if (node != null)
                        {
                            info.HashCode = node.InnerText;
                        }
                    }
                }

                return info;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: LoadManifestFile " + ex.Message);
            }

            return null;
        }


        private static string ExtractFileNameFromUri(string url)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    int lastIndex = url.LastIndexOf('/');
                    if (lastIndex > 0)
                    {
                        lastIndex += 1;
                        return url.Substring(lastIndex, url.Length - lastIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: ExtractFileNameFromUri " + ex.Message);
            }

            return string.Empty;
        }


        internal static bool OverwriteDownloadedFiles()
        {
            string src = GetDownloadDirectoryPath();
            string dst = ServiceUtil.StartupPath;

            return CopyAll(src, dst);
        }


        private static bool CopyAll(string src, string dst)
        {
            try
            {
                string[] items;

                items = Directory.GetDirectories(src, "*", SearchOption.AllDirectories);
                foreach (string dir in items)
                {
                    Directory.CreateDirectory(dir.Replace(src, dst));
                }

                //Copy all the files
                items = Directory.GetFiles(src, "*.*", SearchOption.AllDirectories);
                foreach (string file in items)
                {
                    File.Copy(file, file.Replace(src, dst), true);
                }

                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: CopyAll " + ex.Message);
            }

            return false;
        }


        internal static string GetDownloadDirectoryPath(bool createIfNotExists = false)
        {
            try
            {
                string path =
                    ServiceUtil.StartupPath +
                    Path.DirectorySeparatorChar +
                    Settings.Instance.DirectoryName;
                if (createIfNotExists) EnsureDirectoryExists(path);

                path +=
                    Path.DirectorySeparatorChar +
                    Settings.Instance.DownloadDirectoryName;
                if (createIfNotExists) EnsureDirectoryExists(path);

                return path;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: GetDownloadDirectoryPath " + ex.Message);
            }

            return string.Empty;
        }


        internal static bool ExtractDownloadedPackage(UpdateManifestInfo manifest)
        {
            try
            {
                string packageName = ExtractFileNameFromUri(manifest.UpdatePackageUri);
                string path = GetDownloadDirectoryPath() + Path.DirectorySeparatorChar + packageName;

                string hash = CalculateHash(path);
                if (string.Equals(manifest.HashCode, hash, StringComparison.InvariantCulture))
                {
                    using (ZipFile zip = ZipFile.Read(path))
                    {
                        foreach (ZipEntry e in zip)
                        {
                            e.Extract(GetDownloadDirectoryPath(true), ExtractExistingFileAction.OverwriteSilently);  // overwrite == true
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: ExtractDownloadedPackage " + ex.Message);
            }

            return false;
        }


        private static string CalculateHash(string path)
        {
            try
            {
                // Not sure if BufferedStream should be wrapped in using block
                using (var stream = new BufferedStream(File.OpenRead(path), 1200000))
                {
                    //MD5 md5 = new MD5CryptoServiceProvider();
                    SHA256Managed sha = new SHA256Managed();
                    byte[] checksum = sha.ComputeHash(stream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: CalculateHash " + ex.Message);
            }

            return string.Empty;
        }


        internal static string GetManifestFilePath()
        {
            try
            {
                string path = GetDownloadDirectoryPath(true);
                string filename = ExtractFileNameFromUri(Settings.Instance.UpdateUri);

                return path +
                    System.IO.Path.DirectorySeparatorChar +
                    filename;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: GetManifestFilePath " + ex.Message);
            }

            return string.Empty;
        }


        internal static string GetPackageFilePath(UpdateManifestInfo manifest)
        {
            try
            {
                string path = GetDownloadDirectoryPath(true);
                string filename = ExtractFileNameFromUri(manifest.UpdatePackageUri);

                return path +
                    System.IO.Path.DirectorySeparatorChar +
                    filename;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: GetPackageFilePath " + ex.Message);
            }

            return string.Empty;
        }


        internal static void Cleanup(UpdateManifestInfo info)
        {
            try
            {
                string filename = GetManifestFilePath();
                File.Delete(filename);

                filename = GetPackageFilePath(info);
                File.Delete(filename);
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: Cleanup " + ex.Message);
            }
        }


        internal static bool BackupStartupDirectory()
        {
            try
            {
                string updaterDir = GetDownloadDirectoryPath();
                string zipFile = ServiceUtil.StartupPath + Path.DirectorySeparatorChar + "Backup.zip";
                string[] items = Directory.GetFiles(updaterDir, "*.*", SearchOption.AllDirectories);

                using (ZipFile zip = new ZipFile())
                {
                    zip.UseUnicodeAsNecessary = true;  // utf-8
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.None;
                    foreach (string file in items)
                    {
                        string path = file.Replace(updaterDir, ServiceUtil.StartupPath);
                        if (File.Exists(path))
                        {
                            zip.AddFile(path, "");
                        }
                    }

                    zip.Save(zipFile);
                }

                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: BackupStartupDirectory " + ex.Message);
            }

            return false;
        }


        internal static bool RestoreStartupDirectory()
        {
            try
            {
                string srcDir = ServiceUtil.StartupPath;
                string zipFile = srcDir + Path.DirectorySeparatorChar + "Backup.zip";

                using (ZipFile zip = ZipFile.Read(zipFile))
                {
                    foreach (ZipEntry e in zip)
                    {
                        e.Extract(srcDir, ExtractExistingFileAction.OverwriteSilently);  // overwrite == true
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                EventLogger.Instance.Add("Error: RestoreStartupDirectory " + ex.Message);
            }

            return false;
        }


        internal static void CleanupBackups()
        {
            string zipFile = ServiceUtil.StartupPath + Path.DirectorySeparatorChar + "Backup.zip";
            File.Delete(zipFile);
        }
    }
}
