

namespace Entities
{

    public class UpdaterSettings
    {
        public string UpdateUri { get; set; }


        public bool AutoCheckForUpdates { get; set; }


        public int AutoUpdateCheckInterval { get; set; }


        public bool AutoDownloadUpdate { get; set; }


        public string UpdateApplicationName { get; set; }
    }
}
