// author: shivavandana

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace Dev1
{
   public class ListToExcel
    {
       int temp = 0;
        public List<ExcelSource> lstEnrollment { get; set; }
        #region Defining the path where the final excel should be created
        public void Providepath(string strPath)
        {
            Excel.Application xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            MoveToExcel(xlWorkSheet);
            xlWorkBook.SaveAs(strPath, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }
        #endregion

        #region Moving data from List to Excel
        public void MoveToExcel(Excel.Worksheet xlWorkSheet)
        {
            xlWorkSheet.Cells[1, "A"] = "Version";
            xlWorkSheet.Cells[1, "B"] = "File_Name";
            xlWorkSheet.Cells[1, "C"] = "Category";
            xlWorkSheet.Cells[1, "D"] = "From Table";
            xlWorkSheet.Cells[1, "E"] = "From Column";
            xlWorkSheet.Cells[1, "F"] = "Change Description";
            xlWorkSheet.Cells[1, "G"] = "New Table/Value";
            xlWorkSheet.Cells[1, "H"] = "New Column/Value Description";
            xlWorkSheet.Cells[1, "I"] = "Line number";
            xlWorkSheet.Cells[1, "J"] = "Line of Code";
            xlWorkSheet.Cells[1, "K"] = "Source Code";
            xlWorkSheet.Cells[1, "L"] = "Details";
            xlWorkSheet.Cells[1, "M"] = "Comments";
            xlWorkSheet.Cells[1, "N"] = "Facets change description";
            int row = 2;
            // start row (in row 1 are header cells)   
            foreach(var item in lstEnrollment)
            {
                xlWorkSheet.Cells[row, "A"] = item.file;
                xlWorkSheet.Cells[row, "B"] = item.file_Name;
                xlWorkSheet.Cells[row, "C"] = item.column_Name;
                xlWorkSheet.Cells[row, "D"] = item.from_Table;
                xlWorkSheet.Cells[row, "E"] = item.from_Column;
                xlWorkSheet.Cells[row, "F"] = item.change_Description;
                xlWorkSheet.Cells[row, "G"] = item.newTable_Description;
                xlWorkSheet.Cells[row, "H"] = item.newColumn_Description;
                xlWorkSheet.Cells[row, "I"] = item.line_Number;
                xlWorkSheet.Cells[row, "J"] = item.line_Of_Code;
                xlWorkSheet.Cells[row, "K"] = item.source_Code;
                xlWorkSheet.Cells[row, "L"] = item.details;
                xlWorkSheet.Cells[row, "M"] = item.comments;
                xlWorkSheet.Cells[row, "N"] = item.facets_Change_Description;
                row++;
            }
            //Logger LoggDetails = new Logger();
            //LoggDetails.EndWriteLog(row, temp);
            
        }
        #endregion

    }
}
