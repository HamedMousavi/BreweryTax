using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Repository.Excell
{
    class MonthlyTourBill
    {

        /*
        private static bool SaveAsExcel(Entities.Meter.Document document)
        {
            bool res = false;

            try
            {
                HSSFWorkbook hssfworkbook = new HSSFWorkbook();

                ////create a entry of DocumentSummaryInformation
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "Toos Fuse Co.";
                hssfworkbook.DocumentSummaryInformation = dsi;

                ////create a entry of SummaryInformation
                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Subject = "Toos fuse meter readout results";
                hssfworkbook.SummaryInformation = si;

                //here, we must insert at least one sheet to the workbook. otherwise, Excel will say 'data lost in file'
                //So we insert three sheet just like what Excel does
                Sheet sheet1 = hssfworkbook.CreateSheet("Sheet1");

                Font headFont = hssfworkbook.CreateFont();
                headFont.Color = HSSFColor.WHITE.index;
                headFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.BOLD;

                CellStyle headstyle = hssfworkbook.CreateCellStyle();
                headstyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.BLACK.index;
                headstyle.FillPattern = FillPatternType.SOLID_FOREGROUND;
                headstyle.SetFont(headFont);
                
                int rownum = -1;
                foreach (IMeterProfileItem item in document.Profile.Items)
                {
                    rownum++;

                    if (item != null)
                    {
                        IObisCommand obis = DomainModel.Repository.
                            Meter.Obis.Instance.GetByName(item.Name);

                        Row row = sheet1.CreateRow(rownum);

                        object formatted = item.FormattedValue;
                        if (formatted != null)
                        {
                            if (formatted is ProfileNameCollection)
                            {
                                Cell head = row.CreateCell(0);
                                head.CellStyle = headstyle;
                                head.SetCellValue(item.Name);
                                row.CreateCell(1).CellStyle = headstyle;
                                row.CreateCell(2).CellStyle = headstyle;
                                if (obis != null) row.GetCell(1).SetCellValue(obis.CommandStart);

                                ProfileNameCollection names =
                                    (ProfileNameCollection)formatted;

                                for (int i = 0; i < names.Count; i++)
                                {
                                    rownum++;
                                    row = sheet1.CreateRow(rownum);

                                    IObisCommand cmd = DomainModel.Repository.
                                        Meter.Obis.Instance.GetByName(names[i]);

                                    row.CreateCell(0).SetCellValue(names[i]);
                                    if (cmd != null) row.CreateCell(1).SetCellValue(cmd.CommandStart);
                                }
                            }
                            else if (formatted is TariffScheduleTable)
                            {
                                for (int i = 0; i < 8; i++)
                                {
                                    row.CreateCell(i).CellStyle = headstyle;
                                }
                                Cell head = row.GetCell(0);
                                head.CellStyle = headstyle;
                                head.SetCellValue(item.Name);
                                if (obis != null) row.GetCell(1).SetCellValue(obis.CommandStart);

                                rownum++;
                                row = sheet1.CreateRow(rownum);
                                row.CreateCell(1).SetCellValue("Sunday");
                                row.CreateCell(2).SetCellValue("Monday");
                                row.CreateCell(3).SetCellValue("Tuesday");
                                row.CreateCell(4).SetCellValue("Wednesday");
                                row.CreateCell(5).SetCellValue("Thursday");
                                row.CreateCell(6).SetCellValue("Friday");
                                row.CreateCell(7).SetCellValue("Saturday");

                                TariffScheduleTable table =
                                    (TariffScheduleTable)formatted;

                                for (int s = 0; s < 4; s++)
                                {
                                    rownum++;
                                    row = sheet1.CreateRow(rownum);
                                    row.CreateCell(0).SetCellValue("Seasons " + s.ToString());

                                    for (int d = 0; d < 7; d++)
                                    {
                                        string tariffId = table[s, d]; //tariffID = KK = meterId

                                        row.CreateCell(d + 1).SetCellValue("ID: [" + tariffId + "]");
                                    }
                                }
                            }
                            else if (formatted is TariffTable)
                            {
                                Cell head = row.CreateCell(0);
                                head.CellStyle = headstyle;
                                head.SetCellValue(item.Name);
                                row.CreateCell(1).CellStyle = headstyle;
                                row.CreateCell(2).CellStyle = headstyle;

                                string parentObisCode = "";

                                if (obis != null)
                                {
                                    int preIndex = obis.CommandStart.LastIndexOf('.');
                                    if (preIndex > 0)
                                    {
                                        parentObisCode = obis.CommandStart.Substring(0, preIndex);
                                        row.GetCell(1).SetCellValue(parentObisCode + ".[KK]");
                                    }
                                }

                                TariffTable table =
                                    (TariffTable)formatted;

                                foreach (DomainModel.Entities.Meter.Tariff tariff in table)
                                {
                                    rownum++;
                                    row = sheet1.CreateRow(rownum);
                                    head = row.CreateCell(1);
                                    head.CellStyle = headstyle;
                                    head.SetCellValue(string.Format(
                                        "Tariff ID [{0}]", tariff.MeterCode));
                                    row.CreateCell(2).CellStyle = headstyle;
                                    row.GetCell(2).SetCellValue(
                                        string.Format("{0}.{1}", parentObisCode, tariff.MeterCode));

                                    foreach (TariffInfo info in tariff.Details)
                                    {
                                        rownum++;
                                        row = sheet1.CreateRow(rownum);

                                        row.CreateCell(1).SetCellValue("Switch to:" + info.SwitchName);
                                        row.CreateCell(2).SetCellValue("At " + info.Time);
                                    }
                                }
                            }
                            else if (formatted is HolidayTariffTable)
                            {
                                Cell head = row.CreateCell(0);
                                head.CellStyle = headstyle;
                                head.SetCellValue(item.Name);
                                row.CreateCell(1).CellStyle = headstyle;
                                row.CreateCell(2).CellStyle = headstyle;
                                row.CreateCell(3).CellStyle = headstyle;
                                
                                rownum++;
                                row = sheet1.CreateRow(rownum);
                                row.CreateCell(1).SetCellValue("Switch to");
                                row.CreateCell(2).SetCellValue("Month");
                                row.CreateCell(3).SetCellValue("Day");

                                row.GetCell(1).CellStyle = headstyle;
                                row.GetCell(2).CellStyle = headstyle;
                                row.GetCell(3).CellStyle = headstyle;

                                string parentObisCode = "";

                                if (obis != null)
                                {
                                    int preIndex = obis.CommandStart.LastIndexOf('.');
                                    if (preIndex > 0)
                                    {
                                        parentObisCode = obis.CommandStart.Substring(0, preIndex);
                                    }
                                }

                                HolidayTariffTable table = 
                                    (HolidayTariffTable)formatted;
                                foreach (HolidayTariffEntry entry in table)
                                {
                                    rownum++;
                                    row = sheet1.CreateRow(rownum);

                                    row.CreateCell(1).SetCellValue(entry.SwitchId);
                                    row.CreateCell(2).SetCellValue(entry.Month);
                                    row.CreateCell(3).SetCellValue(entry.DayOfMonth);
                                }
                            }
                            else
                            {
                                if (item.ItemCount == 1)
                                {
                                    row.CreateCell(0).SetCellValue(item.Name);
                                    if (obis != null) row.CreateCell(1).SetCellValue(obis.CommandStart);
                                    if (item.StorageCryptographer == null)
                                    {
                                        row.CreateCell(2).SetCellValue((string)item.FormattedValue);
                                    }
                                    else
                                    {
                                        row.CreateCell(2).SetCellValue("Access denied");
                                    }
                                }
                                else
                                {
                                    Cell head = row.CreateCell(0);
                                    head.CellStyle = headstyle;
                                    head.SetCellValue(item.Name);
                                    row.CreateCell(1).CellStyle = headstyle;
                                    row.CreateCell(2).CellStyle = headstyle;

                                    if (obis != null) row.GetCell(1).SetCellValue(obis.CommandStart);

                                    for (int i = 0; i < item.ItemCount; i++)
                                    {
                                        rownum++;
                                        row = sheet1.CreateRow(rownum);

                                        row.CreateCell(0).SetCellValue(item.GetStorageKey(i));
                                        row.CreateCell(1).SetCellValue(item.GetStorageValue(i));
                                    }
                                }
                            }
                        }

                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    sheet1.AutoSizeColumn(i);
                }


                //Write the stream data of workbook to the root directory
                FileStream file = new FileStream(document.StoragePath, FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();

                res = true;
            }
            catch (Exception ex)
            {
                DomainModel.ApplicationState.Instance.Controller.UpdateStatus(
                    new StatusController.Entities.StatusInfo(
                    (Int16)StatusCodes.Assemblies.Codes.DomainModel,
                    (Int16)StatusCodes.Sections.Codes.Repository,
                    StatusController.Abstract.StatusTypes.Error,
                    (Int32)StatusCodes.Errors.Codes.SaveFailed,
                    null, ex.ToString()));
            }

            return res;
        }
         
         */
    }
}
