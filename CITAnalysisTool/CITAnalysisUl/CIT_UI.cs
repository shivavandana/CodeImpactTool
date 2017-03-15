// author: shivavandana

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dev1;


namespace Dev1Forms
{
    public partial class CIT_UI : Form
    {
        public CIT_UI()
        {
            InitializeComponent();

        }

        ListToExcel ListtoExcel = new ListToExcel();
        string foldername = "";

        #region Input Browse
        private void inputBrowse_Click(object sender, EventArgs e)
        {
            input_Text.Text = string.Empty;
            output_Text.Text = string.Empty;
            processButton.Enabled = false;
            List<string> listBox1 = new List<string>();
            List<ExcelSource> lstEnrollment = new List<ExcelSource>();
            if (this.dataGridView1.DataSource != null)
            {
               this.dataGridView1.DataSource = null;
             
            }
            else
            {
               this.dataGridView1.Rows.Clear();
               this.dataGridView1.Columns.Clear();
            }
            try
            {
               this.folderBrowserDialog1.ShowNewFolderButton = false;
               this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
               DialogResult result = this.folderBrowserDialog1.ShowDialog();
               if (result == DialogResult.OK)
               {
                 string foldername = this.folderBrowserDialog1.SelectedPath;
                 foreach (string f in Directory.GetFiles(foldername))
                 {
                    listBox1.Add(f);
                    //input_Text.Text = foldername;
                 }
                    input_Text.Text = foldername;
                    Browsefiles(foldername);

               }
            }
            catch
            {
               #region Error Log
               DateTime appStart = DateTime.Now;
               string fn = @"D:\ErrorLog.txt";
               StreamWriter sw = File.AppendText(fn);
               sw.WriteLine("");
              //  sw.WriteLine(DateTime.Now + "  |  Error - " + e.Message);
               sw.Flush();
               sw.Close();
               #endregion
            }
        }
        #endregion 

        #region Browse files
        public void Browsefiles(string folder)
        {
            ExceltoListCls ar = new ExceltoListCls();
            ListToExcel li = new ListToExcel();
            List<string> files = new List<string>();
            foreach (var file in Directory.EnumerateFiles(folder, "*.xlsx", SearchOption.AllDirectories))
            {
                Console.WriteLine(file.ToString());
                if (!file.Contains("~"))
                {
                    files.Add(file);
                }
            }
            dataGridView1.Columns.Add("Filename", "Filename");
            dataGridView1.Columns[0].Width = 470;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //chk.Selected = true;
            //dataGridView1.Rows[0].Cells[2].Selected=true;
            dataGridView1.Columns.Add(chk);
            dataGridView1.Columns[1].Width = 50;            
            chk.HeaderText = "Select";
            chk.Name = "chk";
            foreach (string a in files)
            {
                dataGridView1.Rows.Add(a);                
               
            }
            processButton.Enabled = false;
            if (dataGridView1.RowCount != 0)
            {
                processButton.Enabled = true;
            }
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blink.Visible = false;
            path.Visible = true;
            processButton.Enabled = false;
        }
          

        #region Process the excel sheets
        private void processButton_Click(object sender, EventArgs e)
        {

            int count = 0;
            string str="";
            ExceltoListCls ExceltoList = new ExceltoListCls();

            if (input_Text.Text == string.Empty)
            {
                MessageBox.Show("Please select the input file path");
            }

            else if (output_Text.Text == string.Empty)
            {
                MessageBox.Show("Please select the output file path");
            }
            else
            {
                List<ExcelSource> lst = new List<ExcelSource>();
               // ExceltoListCls ExceltoList = new ExceltoListCls();
                string check = string.Empty;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    check = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();

                    if (check.Equals("True"))
                    {
                         str = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                        count++;
                    }
                }
                if (count != 0)
                {
                    blink.Visible = true;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        check = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();
                        if (check.Equals("True"))
                        {
                            str = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                         
                            ExceltoList.AddtoList(str);
                            //to get the file name here if the check the check box
                        }
                        if (ExceltoList.lstEnrollment != null)
                        {
                            foreach (ExcelSource es in ExceltoList.lstEnrollment)
                                lst.Add(es);
                        }
                    }
                    ListtoExcel.lstEnrollment = ExceltoList.lstEnrollment;
                    blink.Visible = false;
                    Wait.Visible = true;
                    Wait.Text = "Please wait...";
                    ListtoExcel.Providepath(foldername);
                    Wait.Visible = false;
                    Msg.Text = "Your final excel is in" + " "+ foldername;
                }
                else
                {
                    
                    MessageBox.Show("Please select the files in the grid view to compare");
                }
            }
            
           
        }
        #endregion

        #region Output Browse
        private void outputBrowse_Click(object sender, EventArgs e)
        {
            output_Text.Text = string.Empty;
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                foldername = this.folderBrowserDialog1.SelectedPath;
            }
           
            foldername=foldername + "\\Combined.xlsx" ;
           
            output_Text.Text = foldername;
          
            //Msg.Text = "Your final excel is in" + " "+ foldername;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.blink.Visible = !this.blink.Visible;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}





