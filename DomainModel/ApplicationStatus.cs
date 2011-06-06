
namespace DomainModel
{

    public class ApplicationStatus
    {

        private StatusController.Controller.StatusController status;


        public void Update(StatusController.Abstract.StatusTypes type, string resourceName)
        {
            string text = Application.ResourceManager.GetText(resourceName);
            if (string.IsNullOrEmpty(text))
            {
                text = resourceName;
            }

            status.UpdateStatus(
                new StatusController.Entities.StatusInfo(0, 0, type, 0, null, text));
        }


        public void Update(StatusController.Abstract.StatusTypes type, string resourceName, string customText)
        {
            string text = Application.ResourceManager.GetText(resourceName);
            if (string.IsNullOrEmpty(text))
            {
                text = resourceName;
            }

            text += customText;

            status.UpdateStatus(
                new StatusController.Entities.StatusInfo(0, 0, type, 0, null, text));
        }


        internal void Init(StatusController.Controller.StatusController statusController)
        {
            status = statusController;
        }

        public StatusController.Controller.StatusController Controller { get { return status; } }
    }
}
