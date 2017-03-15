// author: shivavandana

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dev1
{
    class Logger
    {
        public void StartWriteLog(string lastPart)
        {
            #region LogFile
            DateTime appStart = DateTime.Now;
            string fn = @"D:\LogFile.txt";
            StreamWriter sw = File.AppendText(fn);
            sw.WriteLine("");
            sw.WriteLine("Start Time : " + DateTime.Now);
            sw.WriteLine("File Name : " + lastPart);
            //sw.WriteLine("Total Count (Rows) : " + totalrows); 
            sw.Flush();
            sw.Close();
            #endregion
            return;
        }


               
        public void EndWriteLog(int temp) 
        { 
            DateTime appStart = DateTime.Now; 
            string fn = @"D:\LogFile.txt"; 
            StreamWriter sw = File.AppendText(fn); 
            //sw.WriteLine(""); 
            sw.WriteLine("Filter Count (Row) : " + temp); 
            sw.WriteLine("End Time : " + DateTime.Now); 
            // sw.WriteLine("File Name : " + lastPart + " Total Count (Rows) : " + rowCount); 
            sw.Flush(); 
            sw.Close(); 
            return; 
        }
    }
}