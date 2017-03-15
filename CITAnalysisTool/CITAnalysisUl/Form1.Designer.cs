// author: shivavandana

namespace Dev1Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.input_Text = new System.Windows.Forms.TextBox();
            this.inputBrowse = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBrowse = new System.Windows.Forms.Button();
            this.output_Text = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.blinkLabel = new System.Windows.Forms.Label();
            this.blink = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Msg = new System.Windows.Forms.Label();
            this.Wait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            // 
            // input_Text
            // 
            this.input_Text.Location = new System.Drawing.Point(34, 45);
            this.input_Text.Name = "input_Text";
            this.input_Text.ReadOnly = true;
            this.input_Text.Size = new System.Drawing.Size(500, 20);
            this.input_Text.TabIndex = 0;
            // 
            // inputBrowse
            // 
            this.inputBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBrowse.ForeColor = System.Drawing.Color.Crimson;
            this.inputBrowse.Location = new System.Drawing.Point(540, 42);
            this.inputBrowse.Name = "inputBrowse";
            this.inputBrowse.Size = new System.Drawing.Size(75, 23);
            this.inputBrowse.TabIndex = 2;
            this.inputBrowse.Text = "Browse";
            this.inputBrowse.UseVisualStyleBackColor = true;
            this.inputBrowse.Click += new System.EventHandler(this.inputBrowse_Click);
            // 
            // processButton
            // 
            this.processButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.ForeColor = System.Drawing.Color.Crimson;
            this.processButton.Location = new System.Drawing.Point(33, 357);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(33, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // outputBrowse
            // 
            this.outputBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBrowse.ForeColor = System.Drawing.Color.Crimson;
            this.outputBrowse.Location = new System.Drawing.Point(540, 106);
            this.outputBrowse.Name = "outputBrowse";
            this.outputBrowse.Size = new System.Drawing.Size(75, 23);
            this.outputBrowse.TabIndex = 5;
            this.outputBrowse.Text = "Browse";
            this.outputBrowse.UseVisualStyleBackColor = true;
            this.outputBrowse.Click += new System.EventHandler(this.outputBrowse_Click);
            // 
            // output_Text
            // 
            this.output_Text.Location = new System.Drawing.Point(34, 109);
            this.output_Text.Name = "output_Text";
            this.output_Text.ReadOnly = true;
            this.output_Text.Size = new System.Drawing.Size(500, 20);
            this.output_Text.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // blinkLabel
            // 
            this.blinkLabel.AutoSize = true;
            this.blinkLabel.Location = new System.Drawing.Point(432, 382);
            this.blinkLabel.Name = "blinkLabel";
            this.blinkLabel.Size = new System.Drawing.Size(0, 13);
            this.blinkLabel.TabIndex = 7;
            // 
            // blink
            // 
            this.blink.AutoSize = true;
            this.blink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blink.ForeColor = System.Drawing.Color.Red;
            this.blink.Location = new System.Drawing.Point(34, 396);
            this.blink.Name = "blink";
            this.blink.Size = new System.Drawing.Size(77, 13);
            this.blink.TabIndex = 8;
            this.blink.Text = "Processing..";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.ForeColor = System.Drawing.Color.Red;
            this.path.Location = new System.Drawing.Point(34, 79);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(122, 13);
            this.path.TabIndex = 9;
            this.path.Text = "Select an output file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Browse the input path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select the files you want to compare";
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.ForeColor = System.Drawing.Color.Red;
            this.Msg.Location = new System.Drawing.Point(34, 383);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(0, 13);
            this.Msg.TabIndex = 12;
            // 
            // Wait
            // 
            this.Wait.AutoSize = true;
            this.Wait.Location = new System.Drawing.Point(34, 383);
            this.Wait.Name = "Wait";
            this.Wait.Size = new System.Drawing.Size(0, 13);
            this.Wait.TabIndex = 13;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(957, 430);
            this.Controls.Add(this.Wait);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.blink);
            this.Controls.Add(this.blinkLabel);
            this.Controls.Add(this.output_Text);
            this.Controls.Add(this.outputBrowse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.inputBrowse);
            this.Controls.Add(this.input_Text);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "CIT Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox input_Text;
        private System.Windows.Forms.Button inputBrowse;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button outputBrowse;
        private System.Windows.Forms.TextBox output_Text;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label blinkLabel;
        private System.Windows.Forms.Label blink;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Label Wait;
    }
}

