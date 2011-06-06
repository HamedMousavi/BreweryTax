using System.Drawing;


namespace TaxDataStore.Presentation.Models
{

    public class PriceOperationItem
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }

        public Image Image
        {
            get
            {
                return DomainModel.Application.ResourceManager.GetImage(ImageName);
            }
        }
    }
}
