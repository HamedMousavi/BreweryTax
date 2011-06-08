using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Xml;
using System.Xml.Serialization;
using Ionic.Zip;


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
            if (!Directory.Exists(directoryPath))
            {
                SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                NTAccount acct = sid.Translate(typeof(NTAccount)) as NTAccount;
                string everyoneAccount = acct.ToString();

                FileSystemAccessRule fsr = new
                    FileSystemAccessRule(
                        everyoneAccount,
                        FileSystemRights.Modify,
                        InheritanceFlags.None,
                        PropagationFlags.InheritOnly,
                        AccessControlType.Allow
                    );

                DirectorySecurity ds = new DirectorySecurity();
                ds.AddAccessRule(fsr);

                Directory.CreateDirectory(
                    directoryPath,
                    ds);
            }
        }


        internal static AssemblyName GetUpdateAssembly()
        {
            string appPath =
                ServiceUtil.StartupPath +
                Path.DirectorySeparatorChar +
                Settings.Instance.UpdateApplicationName;

            return AssemblyName.GetAssemblyName(appPath);
        }


        internal static void CleanDownloadFolder()
        {
            string dirPath = GetDownloadDirectoryPath();

            Directory.Delete(dirPath, true);

            // This will ensure dir arch is rectreated
            GetDownloadDirectoryPath(true);
        }


        internal static UpdateManifestInfo LoadManifestFile()
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
                }
            }

            return info;
        }


        private static string ExtractFileNameFromUri(string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                int lastIndex = url.LastIndexOf('/');
                if (lastIndex > 0)
                {
                    return url.Substring(lastIndex, url.Length - lastIndex);
                }
            }

            return string.Empty;
        }


        internal static void OverwriteDownloadedFiles()
        {
            string src = GetDownloadDirectoryPath();
            string dst = ServiceUtil.StartupPath;

            CopyAll(src, dst);
        }


        private static void CopyAll(string src, string dst)
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
                File.Copy(file, file.Replace(src, dst));
            }
        }


        internal static string GetDownloadDirectoryPath(bool createIfNotExists = false)
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


        internal static bool ExtractDownloadedPackage(UpdateManifestInfo manifest)
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

            return false;
        }


        private static string CalculateHash(string path)
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
    }
}
