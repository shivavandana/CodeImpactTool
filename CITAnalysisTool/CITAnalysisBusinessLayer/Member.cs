// author: shivavandana

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev1
{
    class Member
    {
        public string EnrollID { get; set; }
        public string MemoID { get; set; }
    }

   public class ExcelSource
    {
        public string file { get; set; }
        public string file_Name { get; set; }
        public string column_Name { get; set; }
        public string from_Table{ get; set; }
        public string from_Column { get; set; }
        public string change_Description { get; set; }
        public string newTable_Description { get; set; }
        public string newColumn_Description { get; set; }
        public string line_Number { get; set; }
        public string line_Of_Code { get; set; }
        public string source_Code { get; set; }
        public string details { get; set; }
        public string comments { get; set; }
        public string facets_Change_Description { get; set; }
    }
}
