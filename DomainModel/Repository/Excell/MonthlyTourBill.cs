using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.UserModel.Contrib;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;


namespace DomainModel.Repository.Excell
{

    public class MonthlyTourBill
    {

        private class HeaderCell
        {
            public int Index { get; set; }
            public string Text { get; set; }

            public HeaderCell()
            {
            }

            public HeaderCell(int index)
                : this()
            {
                this.Index = index;
            }
        }


        private class HeaderRow : List<HeaderCell>
        {
        }


        private class ServiceCell
        {
            public int Index  { get; set; }
            public int Count { get; set; }
            public decimal Value { get; set; }

            public ServiceCell()
            {
            }

            public ServiceCell(int index)
                : this()
            {
                this.Index = index;
            }
        }


        private class ServiceDic : Dictionary<Entities.Service, ServiceCell>
        {
        }


        private class TypeDic : Dictionary<Entities.GeneralType, ServiceCell>
        {
        }


        public static bool Generate(Entities.ReportInfo info)
        {
            bool res = false;

            try
            {
                string title = DomainModel.Application.
                    ResourceManager.GetText("rep_monthly_bill_title");

                int colnum = 0;
                int rownum = -1;
                Sheet sheet;
                Row row;
                Cell head;

                TypeDic typeDic = new TypeDic();
                ServiceDic srvDic = new ServiceDic();
                HeaderRow headRow = new HeaderRow();

                // Create header
                int index = 0;

                // Create first col: day#
                HeaderCell hc = new HeaderCell(index);
                hc.Text = DomainModel.
                    Application.ResourceManager.GetText("rep_monthly_bill_col_day");
                headRow.Add(hc);
                index++;

                // create service type cols
                srvDic.Clear();
                foreach (Entities.Service srv in DomainModel.Services.GetAll())
                {
                    hc = new HeaderCell(index);
                    hc.Text = string.Format("  {0} {1} ({2})  ",
                        srv.ServiceType.Name,
                        srv.Name,
                        srv.PricePerPerson.FormattedValue);

                    headRow.Add(hc);

                    srvDic.Add(srv, new ServiceCell(index));

                    index++;
                }

                // Create payment type columns
                foreach (Entities.GeneralType type in DomainModel.PaymentTypes.GetAll())
                {
                    hc = new HeaderCell(index);
                    hc.Text = "  " + type.Name + "  ";
                    headRow.Add(hc);

                    typeDic.Add(type, new ServiceCell(index));
                    index++;
                }

                HSSFWorkbook hssfworkbook = new HSSFWorkbook();

                // Create theme
                Font headFont = hssfworkbook.CreateFont();
                headFont.Color = HSSFColor.WHITE.index;
                headFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.BOLD;

                CellStyle headstyle = hssfworkbook.CreateCellStyle();
                headstyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.BLACK.index;
                headstyle.FillPattern = FillPatternType.SOLID_FOREGROUND;
                headstyle.SetFont(headFont);

                //// Create a entry of DocumentSummaryInformation
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "Ms. Anke Maass";
                hssfworkbook.DocumentSummaryInformation = dsi;

                //// Create a entry of SummaryInformation
                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Subject = "Tour monthly bill";
                hssfworkbook.SummaryInformation = si;

                // For each month in report inf
                for (DateTime date = info.StartTime; date.Month <= info.EndTime.Month; date = date.AddMonths(1))
                {
                    colnum = 0;

                    string month = date.ToString("MMMM");
                    string sheetTitle = string.Format("{0} {1:00} {2:0000}",
                            title, month, DateTime.Now.Year);

                    // Create sheet
                    sheet = hssfworkbook.CreateSheet(month);
                    //sheet.DefaultColumnWidth = 25;

                    rownum = -1;
                    row = sheet.CreateRow(++rownum); // Title
                    row = sheet.CreateRow(++rownum); // Space
                    row = sheet.CreateRow(++rownum); // Col. headers

                    // Set columns titles
                    foreach(HeaderCell headCell in headRow)
                    {
                        row.CreateCell(colnum).SetCellValue(headCell.Text);
                        row.GetCell(colnum).CellStyle = headstyle;
                        sheet.AutoSizeColumn(colnum);

                        colnum++;
                    }

                    // Set sheet title (After columns for autowidth calculations)
                    row = sheet.GetRow(0);
                    head = HSSFCellUtil.CreateCell(row, 0, sheetTitle);
                    head.CellStyle = headstyle;
                    sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 6));

                    row = sheet.GetRow(1);
                    head = HSSFCellUtil.CreateCell(row, 0, "");
                    head.CellStyle = headstyle;
                    sheet.AddMergedRegion(new CellRangeAddress(1, 1, 0, 6));

                    // Create count rows
                    for (DateTime dt = date; dt.Month <= date.Month; dt = dt.AddDays(1))
                    {
                        row = sheet.CreateRow(++rownum);

                        row.CreateCell(0).SetCellValue(dt.Day);
                        row.GetCell(0).CellStyle = headstyle;

                        Entities.TourCollection tours = new Entities.TourCollection();
                        DomainModel.Tours.LoadByDate(dt, tours);
                        
                        // Reset counters
                        foreach (Entities.Service key in srvDic.Keys)
                        {
                            srvDic[key].Count = 0;
                        }
                        
                        foreach (Entities.GeneralType key in typeDic.Keys)
                        {
                            typeDic[key].Value = 0;
                        }

                        // calc columns
                        foreach (Entities.Tour tour in tours)
                        {
                            foreach (Entities.TourGroup group in tour.Groups)
                            {
                                foreach (Entities.Abstract.ITourService srv in group.Services)
                                {
                                    srvDic[srv.Detail].Count += srv.CostDetails.ServiceCount;

                                    foreach (Entities.TourPayment payment in srv.Payments)
                                    {
                                        typeDic[payment.Type].Value += payment.Amount.Value;
                                    }
                                }
                            }
                        }

                        // Set row cells
                        foreach (Entities.Service key in srvDic.Keys)
                        {
                            if (srvDic[key].Count != 0)
                            {
                                row.CreateCell(srvDic[key].Index).SetCellValue(srvDic[key].Count);
                            }
                        }

                        foreach (Entities.GeneralType key in typeDic.Keys)
                        {
                            if (typeDic[key].Value > 0.0M)
                            {
                                row.CreateCell(typeDic[key].Index).SetCellValue(
                                    (double)typeDic[key].Value);
                            }
                        }

                    }
                }

                // Create footer

                //Write the stream data of workbook to the root directory
                FileStream file = new FileStream(info.Path, FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();

                res = true;
            }
            catch (Exception ex)
            {
            }

            return res;
        }

/*
        private static TypeColumnCollection CreateDailyBill(DateTime dt, TypeColumnCollection columns)
        {
            TypeColumnCollection row = new TypeColumnCollection();
            
            for (int i = 0; i < columns.Count; i++)
            {
                row.Add(new TypeColumn(i, null, columns[i].CellType));
            }

            
            // load tours
            Entities.TourCollection tours = new Entities.TourCollection();
            DomainModel.Tours.LoadByDate(dt, tours);

            foreach (Entities.Tour tour in tours)
            {
                foreach(Entities.TourCostDetail detail in tour.CostDetails)
                {
                    //row.AddToValue(detail.ParticipantsCount, tour.TourType);
                }
            }
            
            return row;
        }*/
    }
}