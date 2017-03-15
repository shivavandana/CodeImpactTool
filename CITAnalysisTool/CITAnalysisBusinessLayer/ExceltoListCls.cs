
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace Dev1
{
    public class ExceltoListCls
    {
        #region Declare variables
        Excel.Workbook xlWorkbook;
        private string fullFileName;
        public List<ExcelSource> lstEnrollment { get; set; }
        #endregion

        public ExceltoListCls()
        {
            lstEnrollment = new List<ExcelSource>();
        }
        #region Reading Excel
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>

        #endregion
        #region Add the records to list
        public void AddtoList(string files)
        {
            if ((files.Contains(".xlsx") && (!files.Contains('~'))))
            {
                var excel = new ExcelQueryFactory(files);
                try
                {
                    Logger LoggDetails = new Logger();
                    LoggDetails.StartWriteLog(excel.FileName); 
                    var getRecords = from records in excel.Worksheet(0)
                                     where records["New Column/Value Description"] != "******* NO CODE CHANGES IDENTIFIED *******" && records["New Column/Value Description"] != ""
                                     select records;
                    int row = 0; 
                    foreach (var item in getRecords)
                    {
                       string fileName=excel.FileName;
                       string lastPart = fileName.Split('\\').Last();
                       lstEnrollment.Add(new ExcelSource
                       {
                            file = lastPart,
                            file_Name = item[0],
                            column_Name = item[1],
                            from_Table = item[2],
                            from_Column = item[3],
                            change_Description = item[4],
                            newTable_Description = item[5],
                            newColumn_Description = item[6],
                            line_Number = item[7] != null ? item[7] : string.Empty,
                            line_Of_Code = item[8] != null ? item[8] : string.Empty,
                            source_Code = item[9],
                            details = item[10],
                            comments = item[11],
                            facets_Change_Description = item[12],
                       });
                       row++;
                    }
                    Logger LoggDetails1 = new Logger();
                    LoggDetails1.EndWriteLog(row); 
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        #endregion
        }
    }
}

