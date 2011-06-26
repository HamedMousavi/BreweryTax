using StatusController.Abstract;
using System;


namespace DomainModel
{

    public class ApplicationStatus
    {

        public StatusController.Controller.StatusController StatusController { get; set; }
       
        protected System.Timers.Timer timer;
        protected DateTime lastStatusUpdate;
        protected StatusController.Entities.StatusInfo readyState;


        public ApplicationStatus(StatusController.Controller.StatusController statusController)
        {
            this.StatusController = statusController;

            this.readyState = new StatusController.Entities.StatusInfo(
                        0, 0, StatusTypes.None, 0, null, "");

            this.lastStatusUpdate = DateTime.Now;
            this.timer = new System.Timers.Timer(10000);
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            this.timer.Start();
        }


        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan span = DateTime.Now - this.lastStatusUpdate;
            if (span.TotalSeconds >= 20.0)
            {
                this.StatusController.UpdateStatus(this.readyState);
            }
        }


        public void Update(StatusTypes type, string resourceName)
        {
            this.lastStatusUpdate = DateTime.Now;

            string text = Application.ResourceManager.GetText(resourceName);
            if (string.IsNullOrWhiteSpace(text))
            {
                text = resourceName;
            }

            this.StatusController.UpdateStatus(
                new StatusController.Entities.StatusInfo(0, 0, type, 0, null, text));
        }


        public void Update(StatusTypes type, string resourceName, string customText)
        {
            this.lastStatusUpdate = DateTime.Now;

            string text;

            if (!string.IsNullOrWhiteSpace(resourceName) &&
                Application.ResourceManager != null)
            {
                text = Application.ResourceManager.GetText(resourceName);
            }
            else
            {
                text = resourceName;
            }

            text += customText;

            this.StatusController.UpdateStatus(
                new StatusController.Entities.StatusInfo(0, 0, type, 0, null, text));
        }
    }
}
