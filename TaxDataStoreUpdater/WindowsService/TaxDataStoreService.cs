using System.ServiceProcess;


namespace TaxDataStoreUpdater
{

    public class TaxDataStoreService : ServiceBase
    {

        protected Updater updater;
        protected UpdaterIpcServiceController ipcService;


        public TaxDataStoreService()
        {
            this.ServiceName = Settings.Instance.ServiceName;
            this.CanStop = true;
            this.AutoLog = true;
            this.CanPauseAndContinue = true;

            this.ipcService = new UpdaterIpcServiceController();

            SetupUpdater();
        }


        private void SetupUpdater()
        {
            this.updater = new Updater();
            /*
            this.updater.NewVersionFound += new
                Updater.NewVersionFoundEventHandler(updater_NewVersionFound);
            this.updater.NewVersionDownloadCompleted += new
                Updater.NewVersionDownloadedEventHandler(updater_NewVersionDownloadCompleted);*/
        }


        protected override void OnStart(string[] args)
        {
            this.updater.Start();
            this.ipcService.Start();
        }



        protected override void OnStop()
        {
            this.updater.Stop();
            this.ipcService.Stop();
        }



        protected override void OnContinue()
        {
            this.updater.Start();
            this.ipcService.Start();

            base.OnContinue();
        }



        protected override void OnPause()
        {
            this.updater.Stop();
            this.ipcService.Stop();
          
            base.OnPause();
        }



        protected override void OnShutdown()
        {
            this.updater.Stop();
            this.ipcService.Stop();
            
            base.OnShutdown();
        }



        protected override void OnCustomCommand(int command)
        {
            EventLogger.Instance.Add("On custom command....");
            base.OnCustomCommand(command);
        }
    }
}
