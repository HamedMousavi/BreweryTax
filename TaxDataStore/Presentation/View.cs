using System.Windows.Forms;
using System;


namespace TaxDataStore.Presentation
{

    public class View
    {
        public static RightToLeft LayoutDirection { get; set; }
        public static FrmMain MainWindow { get; set; }
        public static string Locale
        {
            set
            {
                System.Threading.Thread.CurrentThread.CurrentCulture =
                   new System.Globalization.CultureInfo(value);

                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo(value);

                LayoutDirection =
                    Resources.Texts.direction.Equals(
                        "rtl",
                        StringComparison.InvariantCulture) ?
                    System.Windows.Forms.RightToLeft.Yes :
                    System.Windows.Forms.RightToLeft.No;

                DomainModel.Application.ResourceManager.SetCulture(value);
            }
        }
    }
}
