using System.IO;
using System.Xml;
using Entities;
using System;


namespace DomainModel.Repository
{

    public class ApplicationUpdater
    {

        internal UpdaterSettings Load()
        {
            UpdaterSettings settings = null;
            try
            {
                string path =
                    Application.Settings.StartupPath +
                    Path.DirectorySeparatorChar +
                    "Updater" +
                    Path.DirectorySeparatorChar +
                    "UpdaterSettings.xml";

                if (File.Exists(path))
                {

                    XmlDocument doc = new System.Xml.XmlDocument();
                    doc.Load(path);

                    XmlNode details = doc.SelectSingleNode("Settings");
                    if (details != null && details.HasChildNodes)
                    {
                        settings = new UpdaterSettings();

                        XmlNode node = details.SelectSingleNode("UpdateUri");
                        if (node != null)
                        {
                            settings.UpdateUri = node.InnerText;
                        }

                        node = details.SelectSingleNode("AutoCheckForUpdates");
                        if (node != null)
                        {
                            settings.AutoCheckForUpdates = ConvertToBoolean(node.InnerText);
                        }

                        node = details.SelectSingleNode("AutoUpdateCheckInterval");
                        if (node != null)
                        {
                            settings.AutoUpdateCheckInterval = ConvertToInt(node.InnerText);
                        }

                        node = details.SelectSingleNode("AutoDownloadUpdate");
                        if (node != null)
                        {
                            settings.AutoDownloadUpdate = ConvertToBoolean(node.InnerText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //EventLogger.Instance.Add(ex.Message);
            }


            return settings;
        }


        private int ConvertToInt(string intStr)
        {
            if (!string.IsNullOrWhiteSpace(intStr))
            {
                try
                {
                    Int32 val = Convert.ToInt32(intStr);

                    return val;
                }
                catch (Exception ex)
                {
                    //EventLogger.Instance.Add(ex.Message);
                }
            }

            return 0;
        }


        private bool ConvertToBoolean(string boolStr)
        {
            if (!string.IsNullOrWhiteSpace(boolStr))
            {
                if (string.Equals(boolStr, "true", StringComparison.InvariantCulture))
                {
                    return true;
                }
            }

            return false;
        }


        internal bool Save(Entities.UpdaterSettings settings)
        {
            bool res = false;
            try
            {
                string path =
                    Application.Settings.StartupPath +
                    Path.DirectorySeparatorChar +
                    "Updater" +
                    Path.DirectorySeparatorChar +
                    "UpdaterSettings.xml";

                if (File.Exists(path))
                {

                    XmlDocument doc = new System.Xml.XmlDocument();
                    doc.Load(path);

                    XmlNode details = doc.SelectSingleNode("Settings");
                    if (details != null && details.HasChildNodes)
                    {
                        XmlNode node = details.SelectSingleNode("UpdateUri");
                        if (node != null)
                        {
                            node.InnerText = settings.UpdateUri;
                        }

                        node = details.SelectSingleNode("AutoCheckForUpdates");
                        if (node != null)
                        {
                            node.InnerText = ConvertFromBoolean(settings.AutoCheckForUpdates);
                        }

                        node = details.SelectSingleNode("AutoUpdateCheckInterval");
                        if (node != null)
                        {
                            node.InnerText = ConvertFromInt(settings.AutoUpdateCheckInterval);
                        }

                        node = details.SelectSingleNode("AutoDownloadUpdate");
                        if (node != null)
                        {
                            node.InnerText = ConvertFromBoolean(settings.AutoDownloadUpdate);
                        }
                    }

                    doc.Save(path);
                }
            }
            catch (Exception ex)
            {
                //EventLogger.Instance.Add(ex.Message);
            }


            return res;
        }


        private string ConvertFromInt(int value)
        {
            return value.ToString();
        }


        private string ConvertFromBoolean(bool value)
        {
            return value.ToString().ToLower();
        }
    }
}
