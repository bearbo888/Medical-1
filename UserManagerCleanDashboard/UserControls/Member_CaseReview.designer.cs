
namespace Medical.UserControls
{
    partial class CaseReview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.對醫師評論 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_Day = new System.Windows.Forms.ComboBox();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.btn_Mycase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.對醫師評論});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(28, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(832, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 對醫師評論
            // 
            this.對醫師評論.HeaderText = "對醫師評論";
            this.對醫師評論.Name = "對醫師評論";
            this.對醫師評論.Text = "對醫師評論";
            this.對醫師評論.ToolTipText = "對醫師評論";
            this.對醫師評論.UseColumnTextForButtonValue = true;
            this.對醫師評論.Width = 71;
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.cb_Day);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Month);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Year);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Mycase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 791);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 3;
            // 
            // cb_Day
            // 
            this.cb_Day.FormattingEnabled = true;
            this.cb_Day.Location = new System.Drawing.Point(387, 40);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(121, 20);
            this.cb_Day.TabIndex = 7;
            this.cb_Day.SelectedIndexChanged += new System.EventHandler(this.cb_Day_SelectedIndexChanged);
            // 
            // cb_Month
            // 
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Location = new System.Drawing.Point(260, 41);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(121, 20);
            this.cb_Month.TabIndex = 6;
            this.cb_Month.SelectedIndexChanged += new System.EventHandler(this.cb_Month_SelectedIndexChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Location = new System.Drawing.Point(133, 40);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(121, 20);
            this.cb_Year.TabIndex = 5;
            this.cb_Year.SelectedIndexChanged += new System.EventHandler(this.cb_Year_SelectedIndexChanged);
            // 
            // btn_Mycase
            // 
            this.btn_Mycase.Location = new System.Drawing.Point(28, 31);
            this.btn_Mycase.Name = "btn_Mycase";
            this.btn_Mycase.Size = new System.Drawing.Size(79, 38);
            this.btn_Mycase.TabIndex = 4;
            this.btn_Mycase.Text = "我的病歷Demo";
            this.btn_Mycase.UseVisualStyleBackColor = true;
            this.btn_Mycase.Click += new System.EventHandler(this.btnCaseRecord_Click);
            // 
            // CaseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CaseReview";
            this.Size = new System.Drawing.Size(1193, 791);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Mycase;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.ComboBox cb_Day;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.DataGridViewButtonColumn 對醫師評論;
    }
}
