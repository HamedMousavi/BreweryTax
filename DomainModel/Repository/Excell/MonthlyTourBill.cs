using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.UserModel.Contrib;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;


namespace DomainModel.Repository.Excell
{

    public class MonthlyTourBill
    {
        protected enum CellTypes
        {
            RowNumber,
            TourType,
            PaymentType
        }


        protected class TypeColumn
        {
            public CellTypes CellType { get; set; }
            public Entities.GeneralType Type { get; set; }
            public Int32 ColumnIndex { get; set; }
            public object Value { get; set; }


            public TypeColumn(int index, string value)
            {
                this.ColumnIndex = index;
                this.Value = value;
                this.CellType = CellTypes.RowNumber;
            }


            public TypeColumn(int index, Entities.GeneralType type, CellTypes cellType)
            {
                this.CellType = cellType;
                this.ColumnIndex = index;
                this.Type = type;
                this.Value = type.Name;
            }
        };


        protected class TypeColumnCollection : List<TypeColumn>
        {
        };


        protected class DailyBillTable : List<TypeColumnCollection>
        {
        };


        public static bool Generate(Entities.ReportInfo info)
        {
            bool res = false;

            try
            {

                string title = DomainModel.Application.ResourceManager.GetText("rep_monthly_bill_title");

                TypeColumnCollection columns = new TypeColumnCollection();

                // Create columns
                int ColIndex = 0;
                columns.Add(new TypeColumn(ColIndex++, DomainModel.
                    Application.ResourceManager.GetText("rep_monthly_bill_col_day")));

                foreach (Entities.GeneralType type in DomainModel.TourTypes.GetAll())
                {
                    columns.Add(new TypeColumn(ColIndex++, type, CellTypes.TourType));
                }

                foreach (Entities.GeneralType type in DomainModel.PaymentTypes.GetAll())
                {
                    columns.Add(new TypeColumn(ColIndex++, type, CellTypes.PaymentType));
                }

                int colnum = 0;
                int rownum = -1;
                Sheet sheet;
                Row row;
                Cell head;

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
                for (DateTime date = info.StartTime; date.Month < info.EndTime.Month; date.AddMonths(1))
                {
                    string month = date.ToString("MMMM");
                    string sheetTitle = string.Format("{0} {1:00} {2:0000}",
                            title, month, DateTime.Now.Year);

                    // Create sheet
                    sheet = hssfworkbook.CreateSheet(month);

                    // Set sheet title
                    rownum = -1;
                    row = sheet.CreateRow(++rownum);
                    head = HSSFCellUtil.CreateCell(row, 1, sheetTitle);
                    head.CellStyle = headstyle;

                    // Set columns titles
                    row = sheet.CreateRow(++rownum);
                    foreach (TypeColumn column in columns)
                    {
                        row.CreateCell(colnum).SetCellValue((string)column.Value);
                        row.GetCell(colnum).CellStyle = headstyle;

                        colnum++;
                    }

                    // Create rows
                    for (int dayIndex = 1; dayIndex < 32; dayIndex++)
                    {
                        DateTime dt = new DateTime(
                            date.Year, date.Month, dayIndex, 1, 1, 0);

                        TypeColumnCollection dataRow = CreateDailyBill(dt, columns);

                        // load tours
                        row = sheet.CreateRow(++rownum);
                        foreach (TypeColumn col in dataRow)
                        {
                            switch (col.CellType)
                            {
                                case CellTypes.TourType:
                                case CellTypes.RowNumber:
                                    row.CreateCell(col.ColumnIndex).SetCellValue((Int32)col.Value);
                                    break;

                                case CellTypes.PaymentType:
                                    row.CreateCell(col.ColumnIndex).SetCellValue(Convert.ToDouble(col.Value));
                                    break;

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
        }
    }
}