
namespace Medical.UserControls
{
    partial class MyDoctor_PatientView
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDocID2 = new System.Windows.Forms.Button();
            this.lbday = new System.Windows.Forms.Label();
            this.cb_Day = new System.Windows.Forms.ComboBox();
            this.lbmonth = new System.Windows.Forms.Label();
            this.lbyear = new System.Windows.Forms.Label();
            this.lbKeyword = new System.Windows.Forms.Label();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.cb_Mypatient = new System.Windows.Forms.ComboBox();
            this.btn_PatientDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DocID1 = new System.Windows.Forms.Button();
            this.txt_KeyWrod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDocID2);
            this.splitContainer1.Panel1.Controls.Add(this.lbday);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Day);
            this.splitContainer1.Panel1.Controls.Add(this.lbmonth);
            this.splitContainer1.Panel1.Controls.Add(this.lbyear);
            this.splitContainer1.Panel1.Controls.Add(this.lbKeyword);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Month);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Year);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Mypatient);
            this.splitContainer1.Panel1.Controls.Add(this.btn_PatientDetail);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_DocID1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_KeyWrod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1517, 820);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnDocID2
            // 
            this.btnDocID2.Location = new System.Drawing.Point(114, 45);
            this.btnDocID2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocID2.Name = "btnDocID2";
            this.btnDocID2.Size = new System.Drawing.Size(100, 48);
            this.btnDocID2.TabIndex = 17;
            this.btnDocID2.Text = "DocID=2的病患";
            this.btnDocID2.UseVisualStyleBackColor = true;
            this.btnDocID2.Click += new System.EventHandler(this.btnDocID2_Click);
            // 
            // lbday
            // 
            this.lbday.AutoSize = true;
            this.lbday.Location = new System.Drawing.Point(1222, 119);
            this.lbday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(22, 15);
            this.lbday.TabIndex = 16;
            this.lbday.Text = "日";
            // 
            // cb_Day
            // 
            this.cb_Day.FormattingEnabled = true;
            this.cb_Day.Location = new System.Drawing.Point(1122, 115);
            this.cb_Day.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(98, 23);
            this.cb_Day.TabIndex = 15;
            this.cb_Day.SelectedIndexChanged += new System.EventHandler(this.cb_Day_SelectedIndexChanged);
            // 
            // lbmonth
            // 
            this.lbmonth.AutoSize = true;
            this.lbmonth.Location = new System.Drawing.Point(1096, 119);
            this.lbmonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmonth.Name = "lbmonth";
            this.lbmonth.Size = new System.Drawing.Size(22, 15);
            this.lbmonth.TabIndex = 14;
            this.lbmonth.Text = "月";
            // 
            // lbyear
            // 
            this.lbyear.AutoSize = true;
            this.lbyear.Location = new System.Drawing.Point(968, 119);
            this.lbyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyear.Name = "lbyear";
            this.lbyear.Size = new System.Drawing.Size(22, 15);
            this.lbyear.TabIndex = 13;
            this.lbyear.Text = "年";
            // 
            // lbKeyword
            // 
            this.lbKeyword.AutoSize = true;
            this.lbKeyword.Location = new System.Drawing.Point(474, 17);
            this.lbKeyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKeyword.Name = "lbKeyword";
            this.lbKeyword.Size = new System.Drawing.Size(82, 15);
            this.lbKeyword.TabIndex = 12;
            this.lbKeyword.Text = "姓名關鍵字";
            // 
            // cb_Month
            // 
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Location = new System.Drawing.Point(992, 115);
            this.cb_Month.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(98, 23);
            this.cb_Month.TabIndex = 11;
            this.cb_Month.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Location = new System.Drawing.Point(866, 115);
            this.cb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(98, 23);
            this.cb_Year.TabIndex = 10;
            this.cb_Year.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cb_Mypatient
            // 
            this.cb_Mypatient.FormattingEnabled = true;
            this.cb_Mypatient.Location = new System.Drawing.Point(233, 55);
            this.cb_Mypatient.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Mypatient.Name = "cb_Mypatient";
            this.cb_Mypatient.Size = new System.Drawing.Size(160, 23);
            this.cb_Mypatient.TabIndex = 9;
            this.cb_Mypatient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_PatientDetail
            // 
            this.btn_PatientDetail.Location = new System.Drawing.Point(731, 55);
            this.btn_PatientDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PatientDetail.Name = "btn_PatientDetail";
            this.btn_PatientDetail.Size = new System.Drawing.Size(103, 46);
            this.btn_PatientDetail.TabIndex = 8;
            this.btn_PatientDetail.Text = "看診紀錄查詢";
            this.btn_PatientDetail.UseVisualStyleBackColor = true;
            this.btn_PatientDetail.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "登入會員後就不需輸入會員ID";
            // 
            // btn_DocID1
            // 
            this.btn_DocID1.Location = new System.Drawing.Point(19, 45);
            this.btn_DocID1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DocID1.Name = "btn_DocID1";
            this.btn_DocID1.Size = new System.Drawing.Size(87, 48);
            this.btn_DocID1.TabIndex = 1;
            this.btn_DocID1.Text = "DocID=1的病患";
            this.btn_DocID1.UseVisualStyleBackColor = true;
            this.btn_DocID1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_KeyWrod
            // 
            this.txt_KeyWrod.Location = new System.Drawing.Point(564, 14);
            this.txt_KeyWrod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KeyWrod.Name = "txt_KeyWrod";
            this.txt_KeyWrod.Size = new System.Drawing.Size(132, 25);
            this.txt_KeyWrod.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1517, 672);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MyDoctor_PatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyDoctor_PatientView";
            this.Size = new System.Drawing.Size(1517, 820);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbmonth;
        private System.Windows.Forms.Label lbyear;
        private System.Windows.Forms.Label lbKeyword;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.ComboBox cb_Mypatient;
        private System.Windows.Forms.Button btn_PatientDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DocID1;
        private System.Windows.Forms.TextBox txt_KeyWrod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbday;
        private System.Windows.Forms.ComboBox cb_Day;
        private System.Windows.Forms.Button btnDocID2;
    }
}
