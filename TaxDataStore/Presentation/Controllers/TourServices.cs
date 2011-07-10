using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TaxDataStore.Presentation.Controllers
{

    public class TourServices
    {

        internal static void AddNew()
        {
            using (FrmServiceSettingEditor frm = new FrmServiceSettingEditor())
            {
                frm.ShowDialog();
            }
        }


        internal static void Edit(Entities.Service service)
        {
            using (FrmServiceSettingEditor frm = new FrmServiceSettingEditor(service))
            {
                frm.ShowDialog();
            }
        }


        internal static void Delete(Entities.Service service)
        {
            DomainModel.Services.Delete(service);
        }
    }
}
