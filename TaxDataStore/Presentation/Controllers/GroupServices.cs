
namespace TaxDataStore.Presentation.Controllers
{

    public class GroupServices
    {

        internal static void AddNew(Entities.Tour tour, Entities.TourGroup group, Entities.GeneralType serviceType)
        {
            using (FrmGroupServiceEditor frm = new 
                FrmGroupServiceEditor(tour, group, serviceType))
            {
                frm.ShowDialog();
            }
        }


        internal static void Edit(Entities.Tour tour, Entities.TourGroup group, Entities.Abstract.ITourService service)
        {
            using (FrmGroupServiceEditor frm = new FrmGroupServiceEditor(
                tour, group, (Entities.TourServiceBase)service))
            {
                frm.ShowDialog();
            }
        }


        internal static void Delete(Entities.TourGroup tourGroup, Entities.Abstract.ITourService service)
        {
            if (DomainModel.TourGroupServices.Delete(service))
            {
                tourGroup.Services.Remove(service);
            }
        }

    }
}
