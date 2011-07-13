
namespace TaxDataStore.Presentation.Controllers
{

    public class GroupServices
    {

        internal static void AddNew(Entities.TourGroup group, Entities.GeneralType serviceType)
        {
            using (FrmGroupServiceEditor frm = new FrmGroupServiceEditor(group, serviceType))
            {
                frm.ShowDialog();
            }
        }


        internal static void Edit(Entities.Abstract.ITourService service)
        {
            using (FrmGroupServiceEditor frm = new FrmGroupServiceEditor(
                (Entities.TourServiceBase)service))
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
