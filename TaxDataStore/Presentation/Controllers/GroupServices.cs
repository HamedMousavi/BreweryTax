
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


        internal static void Edit(Entities.Abstract.ITourService iTourService)
        {
            throw new System.NotImplementedException();
        }


        internal static void Delete(Entities.Abstract.ITourService iTourService)
        {
            throw new System.NotImplementedException();
        }
    }
}
