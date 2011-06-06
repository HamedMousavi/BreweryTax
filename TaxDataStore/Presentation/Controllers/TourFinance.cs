using System;
using Entities;


namespace TaxDataStore.Presentation.Controllers
{

    public class TourFinance
    {

        internal static void EditBasePrice(TourBasePrice price)
        {
            using (FrmTourPriceEditor frm = new FrmTourPriceEditor(price))
            {
                frm.ShowDialog();
            }
        }


        internal static void AddRule()
        {
            using (FrmRuleEditor frm = new FrmRuleEditor())
            {
                frm.ShowDialog();
            }
        }


        internal static void EditRule(TourPaymentRule rule)
        {
            using (FrmRuleEditor frm = new FrmRuleEditor(rule))
            {
                frm.ShowDialog();
            }
        }


        internal static void DeleteRule(TourPaymentRule rule)
        {
            DomainModel.TourPaymentRules.Delete(rule);
        }


        internal static void AddGroup()
        {
            using (FrmTourPaymentGroupEditor frm = new FrmTourPaymentGroupEditor())
            {
                frm.ShowDialog();
            }
        }


        internal static void EditGroup(TourPaymentGroup group)
        {
            using (FrmTourPaymentGroupEditor frm = new FrmTourPaymentGroupEditor(group))
            {
                frm.ShowDialog();
            }
        }


        internal static void DeleteGroup(TourPaymentGroup group)
        {
            DomainModel.TourPaymentGroups.Delete(group);
        }

    }
}
