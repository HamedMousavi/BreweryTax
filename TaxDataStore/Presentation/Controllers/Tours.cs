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


        internal static Entities.TourGroup AddGroup(Entities.Tour tour)
        {
            Entities.TourGroup group = new Entities.TourGroup();
            group.Status = DomainModel.TourStates.GetByIndex(0);
            group.SignUpType = DomainModel.SignUpTypes.GetByIndex(0);
            tour.Groups.Add(group);

            if (!DomainModel.TourGroups.Save(tour))
            {
                tour.Groups.Remove(group);
                return null;
            }

            return group;
        }


        internal static void AddMember(Entities.TourGroup tourGroup)
        {
            using (FrmTourMemberEditor frm = new FrmTourMemberEditor(tourGroup))
            {
                frm.ShowDialog();
            }
        }


        internal static bool DeleteTour(Entities.Tour tour)
        {
            if (Controllers.MessageBox.ConfirmDelete())
            {
                return DomainModel.Tours.Delete(tour);
            }

            return false;
        }


        internal static bool DeleteGroup(Entities.TourGroup group)
        {
            if (Controllers.MessageBox.ConfirmDelete())
            {
                return DomainModel.TourGroups.Delete(group);
            }

            return false;
        }
    }
}
