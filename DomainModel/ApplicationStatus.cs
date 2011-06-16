
using StatusController.Abstract;
namespace DomainModel
{

    public class ApplicationStatus
    {

        public StatusController.Controller.StatusController StatusController { get; set; }


        public ApplicationStatus(StatusController.Controller.StatusController statusController)
        {
            this.StatusController = statusController;
        }


        public void Update(StatusTypes type, string resourceName)
        {
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
            string text = Application.ResourceManager.GetText(resourceName);
            if (string.IsNullOrWhiteSpace(text))
            {
                text = resourceName;
            }

            text += customText;

            this.StatusController.UpdateStatus(
                new StatusController.Entities.StatusInfo(0, 0, type, 0, null, text));
        }
    }
}
