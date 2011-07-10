using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxDataStore.Presentation.Controllers
{
    public class GroupServices
    {
        internal static void AddNew(Entities.GeneralType serviceType)
        {
            using (FrmGroupServiceEditor frm = new FrmGroupServiceEditor(serviceType))
            {
                frm.ShowDialog();
            }
        }
    }
}
