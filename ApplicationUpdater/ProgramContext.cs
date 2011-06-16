using System.Windows.Forms;


namespace ApplicationUpdater
{

    public class ProgramContext : ApplicationContext
    {

        protected Updater updater;
        protected UpdaterIpcServiceController ipcService;


        public ProgramContext()
        {
            this.updater = new Updater();
            this.ipcService = new UpdaterIpcServiceController();

            this.updater.Start();
            this.ipcService.Start(this.updater);
        }
    }
}
