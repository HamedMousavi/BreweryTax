

using System;
namespace TaxDataStore.Presentation.Controllers
{

    public class Tours
    {

        private static FrmDailyTours frmDailyTours;

        
        internal static void Today()
        {
            if (frmDailyTours == null)
            {
                frmDailyTours = new FrmDailyTours();
            }

            View.MainWindow.ClientFormManager.DisplayClientForm(frmDailyTours);
        }


        internal static void AddNew(DateTime? date = null)
        {
            using (FrmTourEditor frmTourEditor = new FrmTourEditor(date))
            {
                frmTourEditor.ShowDialog();
            }
        }


        internal static void Delete(Entities.Tour tour)
        {
            DomainModel.Tours.Delete(tour);
        }


        internal static void Edit(Entities.Tour tour)
        {
            using (FrmTourEditor frmTourEditor = new FrmTourEditor(tour))
            {
                frmTourEditor.ShowDialog();
            }
        }


        internal static void AddDetail(Entities.Tour tour)
        {
            using (FrmTourDetailEditor frm = new FrmTourDetailEditor(tour))
            {
                frm.ShowDialog();
            }
        }

        internal static void EditDetail(Entities.TourDetail detail)
        {
            using (FrmTourDetailEditor frm = new FrmTourDetailEditor(null, detail))
            {
                frm.ShowDialog();
            }
        }
    }
}
