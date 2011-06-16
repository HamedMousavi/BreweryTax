using System;


namespace ApplicationUpdater
{

    public class DownloadCompleteEventArgs : EventArgs
    {

        public DownloadInfo DownloadInfo { get; set; }
    
        public DownloadCompleteEventArgs(DownloadInfo downloadInfo)
            : base()
        {
            this.DownloadInfo = downloadInfo;
        }
    }
}
