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


        internal static void EditRule(TourCostRule rule)
        {
            using (FrmRuleEditor frm = new FrmRuleEditor(rule))
            {
                frm.ShowDialog();
            }
        }


        internal static void DeleteRule(TourCostRule rule)
        {
            DomainModel.TourCostRules.Delete(rule);
        }


        internal static void AddGroup()
        {
            using (FrmTourCostGroupEditor frm = new FrmTourCostGroupEditor())
            {
                frm.ShowDialog();
            }
        }


        internal static void EditGroup(TourCostGroup group)
        {
            using (FrmTourCostGroupEditor frm = new FrmTourCostGroupEditor(group))
            {
                frm.ShowDialog();
            }
        }


        internal static void DeleteGroup(TourCostGroup group)
        {
            DomainModel.TourCostGroups.Delete(group);
        }

    }
}
