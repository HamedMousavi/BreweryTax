using System;


namespace TaxDataStoreUpdater
{

    public class DownloadInfo
    {
        public UpdateManifestInfo Manifest { get; set; }
        public bool Cancelled { get; set; }
        public Exception Error { get; set; }
        public Int32 DownloadId { get; set; }
    }
}
