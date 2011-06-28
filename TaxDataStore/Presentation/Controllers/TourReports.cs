using Entities;


namespace TaxDataStore.Presentation.Controllers
{

    public class TourReports
    {

        internal static void MonthlyBill()
        {
            ReportInfo info = new ReportInfo();

            using (FrmMonthlyReportInfo frm = new FrmMonthlyReportInfo(info))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // use info and generate report
                    if (DomainModel.Repository.Excell.MonthlyTourBill.Generate(info))
                    {
                    }
                }
            }
        }
    }
}
