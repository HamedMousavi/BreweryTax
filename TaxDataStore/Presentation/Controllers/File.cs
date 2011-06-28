using System.Windows.Forms;

namespace TaxDataStore.Presentation.Controllers
{
    public class File
    {
        internal static string BrowseSave(string filter, string startup)
        {
            string selectedPath = string.Empty;

            using (SaveFileDialog frm = new SaveFileDialog())
            {
                frm.Filter = filter;
                if (!string.IsNullOrWhiteSpace(startup)) frm.FileName = startup;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = frm.FileName;
                }
            }

            return selectedPath;
        }
    }
}
