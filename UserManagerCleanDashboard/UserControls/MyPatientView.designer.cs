
namespace Medical.UserControls
{
    partial class MyPatientView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.splitContainer1.Size = new System.Drawing.Size(1138, 656);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnDocID2
            // 
            this.btnDocID2.ForeColor = System.Drawing.Color.Black;
            this.btnDocID2.Location = new System.Drawing.Point(86, 30);
            this.btnDocID2.Name = "btnDocID2";
            this.btnDocID2.Size = new System.Drawing.Size(75, 38);
            this.btnDocID2.TabIndex = 17;
            this.btnDocID2.Text = "DocID=2的病患";
            this.btnDocID2.UseVisualStyleBackColor = true;
            this.btnDocID2.Click += new System.EventHandler(this.btnDocID2_Click);
            // 
            // lbday
            // 
            this.lbday.AutoSize = true;
            this.lbday.ForeColor = System.Drawing.Color.Black;
            this.lbday.Location = new System.Drawing.Point(670, 69);
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(17, 12);
            this.lbday.TabIndex = 16;
            this.lbday.Text = "日";
            // 
            // cb_Day
            // 
            this.cb_Day.FormattingEnabled = true;
            this.cb_Day.Location = new System.Drawing.Point(530, 66);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(121, 20);
            this.cb_Day.TabIndex = 15;
            this.cb_Day.SelectedIndexChanged += new System.EventHandler(this.cb_Day_SelectedIndexChanged);
            // 
            // lbmonth
            // 
            this.lbmonth.AutoSize = true;
            this.lbmonth.ForeColor = System.Drawing.Color.Black;
            this.lbmonth.Location = new System.Drawing.Point(670, 42);
            this.lbmonth.Name = "lbmonth";
            this.lbmonth.Size = new System.Drawing.Size(17, 12);
            this.lbmonth.TabIndex = 14;
            this.lbmonth.Text = "月";
            // 
            // lbyear
            // 
            this.lbyear.AutoSize = true;
            this.lbyear.ForeColor = System.Drawing.Color.Black;
            this.lbyear.Location = new System.Drawing.Point(670, 19);
            this.lbyear.Name = "lbyear";
            this.lbyear.Size = new System.Drawing.Size(17, 12);
            this.lbyear.TabIndex = 13;
            this.lbyear.Text = "年";
            // 
            // lbKeyword
            // 
            this.lbKeyword.AutoSize = true;
            this.lbKeyword.ForeColor = System.Drawing.Color.Black;
            this.lbKeyword.Location = new System.Drawing.Point(312, 11);
            this.lbKeyword.Name = "lbKeyword";
            this.lbKeyword.Size = new System.Drawing.Size(65, 12);
            this.lbKeyword.TabIndex = 12;
            this.lbKeyword.Text = "姓名關鍵字";
            // 
            // cb_Month
            // 
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Location = new System.Drawing.Point(530, 39);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(121, 20);
            this.cb_Month.TabIndex = 11;
            this.cb_Month.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Location = new System.Drawing.Point(530, 11);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(121, 20);
            this.cb_Year.TabIndex = 10;
            this.cb_Year.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cb_Mypatient
            // 
            this.cb_Mypatient.FormattingEnabled = true;
            this.cb_Mypatient.Location = new System.Drawing.Point(14, 74);
            this.cb_Mypatient.Name = "cb_Mypatient";
            this.cb_Mypatient.Size = new System.Drawing.Size(121, 20);
            this.cb_Mypatient.TabIndex = 9;
            this.cb_Mypatient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_PatientDetail
            // 
            this.btn_PatientDetail.ForeColor = System.Drawing.Color.Black;
            this.btn_PatientDetail.Location = new System.Drawing.Point(300, 57);
            this.btn_PatientDetail.Name = "btn_PatientDetail";
            this.btn_PatientDetail.Size = new System.Drawing.Size(77, 37);
            this.btn_PatientDetail.TabIndex = 8;
            this.btn_PatientDetail.Text = "看診紀錄查詢";
            this.btn_PatientDetail.UseVisualStyleBackColor = true;
            this.btn_PatientDetail.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "登入會員後就不需輸入會員ID";
            // 
            // btn_DocID1
            // 
            this.btn_DocID1.ForeColor = System.Drawing.Color.Black;
            this.btn_DocID1.Location = new System.Drawing.Point(14, 30);
            this.btn_DocID1.Name = "btn_DocID1";
            this.btn_DocID1.Size = new System.Drawing.Size(65, 38);
            this.btn_DocID1.TabIndex = 1;
            this.btn_DocID1.Text = "DocID=1的病患";
            this.btn_DocID1.UseVisualStyleBackColor = true;
            this.btn_DocID1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_KeyWrod
            // 
            this.txt_KeyWrod.Location = new System.Drawing.Point(293, 29);
            this.txt_KeyWrod.Name = "txt_KeyWrod";
            this.txt_KeyWrod.Size = new System.Drawing.Size(100, 22);
            this.txt_KeyWrod.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 537);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MyPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MyPatientView";
            this.Size = new System.Drawing.Size(1138, 656);
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
