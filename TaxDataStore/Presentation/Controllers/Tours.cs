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


        internal static void Edit(Entities.Tour tour)
        {
            using (FrmTourEditor frmTourEditor = new FrmTourEditor(tour))
            {
                frmTourEditor.ShowDialog();
            }
        }


        internal static void AddMember(Entities.Tour tour)
        {/*
            using (FrmTourMemberEditor frm = new FrmTourMemberEditor(tour.Members))
            {
                frm.ShowDialog();
            }*/
        }


        internal static void EditMember(Entities.TourMember member)
        {
            using (FrmTourMemberEditor frm = new FrmTourMemberEditor(member))
            {
                frm.ShowDialog();
            }
        }


        internal static void EditPayment(Entities.TourPayment payment)
        {
            using (FrmTourPaymentEditor frm = new FrmTourPaymentEditor(payment))
            {
                frm.ShowDialog();
            }
        }


        internal static void AddPayment(Entities.TourPaymentCollection payments)
        {
            using (FrmTourPaymentEditor frm = new FrmTourPaymentEditor(payments))
            {
                frm.ShowDialog();
            }
        }
    }
}
