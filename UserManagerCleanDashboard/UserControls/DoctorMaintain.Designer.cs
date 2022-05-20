
namespace Medical.UserControls
{
    partial class DoctorMaintain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.button_Add_Dorctor = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_Dorctor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_AddDorctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dorctor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneHtmlLabel2);
            this.panel1.Controls.Add(this.siticoneHtmlLabel1);
            this.panel1.Controls.Add(this.button_Add_Dorctor);
            this.panel1.Controls.Add(this.siticoneDataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 539);
            this.panel1.TabIndex = 0;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.AutoSize = false;
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(17, 52);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(142, 29);
            this.siticoneHtmlLabel2.TabIndex = 24;
            this.siticoneHtmlLabel2.Text = "醫生列表";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(17, 18);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(103, 28);
            this.siticoneHtmlLabel1.TabIndex = 23;
            this.siticoneHtmlLabel1.Text = "醫生維護";
            // 
            // button_Add_Dorctor
            // 
            this.button_Add_Dorctor.CheckedState.Parent = this.button_Add_Dorctor;
            this.button_Add_Dorctor.CustomImages.Parent = this.button_Add_Dorctor;
            this.button_Add_Dorctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Add_Dorctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Add_Dorctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Add_Dorctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Add_Dorctor.DisabledState.Parent = this.button_Add_Dorctor;
            this.button_Add_Dorctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Add_Dorctor.ForeColor = System.Drawing.Color.White;
            this.button_Add_Dorctor.HoverState.Parent = this.button_Add_Dorctor;
            this.button_Add_Dorctor.Location = new System.Drawing.Point(771, 18);
            this.button_Add_Dorctor.Name = "button_Add_Dorctor";
            this.button_Add_Dorctor.ShadowDecoration.Parent = this.button_Add_Dorctor;
            this.button_Add_Dorctor.Size = new System.Drawing.Size(173, 45);
            this.button_Add_Dorctor.TabIndex = 22;
            this.button_Add_Dorctor.Text = "+新增醫師";
            this.button_Add_Dorctor.Click += new System.EventHandler(this.button_AddDorctor_Click);
            // 
            // siticoneDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.siticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siticoneDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.siticoneDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeight = 27;
            this.siticoneDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.EnableHeadersVisualStyles = false;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.Location = new System.Drawing.Point(17, 99);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowHeadersWidth = 51;
            this.siticoneDataGridView1.RowTemplate.Height = 27;
            this.siticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(927, 410);
            this.siticoneDataGridView1.TabIndex = 21;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 27;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Dorctor_CellMouseDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "修改";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Text = "修改";
            this.Column3.ToolTipText = "修改";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "刪除";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Text = "刪除";
            this.Column4.ToolTipText = "刪除";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView_Dorctor
            // 
            this.dataGridView_Dorctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Dorctor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Dorctor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Dorctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dorctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_Dorctor.Location = new System.Drawing.Point(13, 63);
            this.dataGridView_Dorctor.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Dorctor.Name = "dataGridView_Dorctor";
            this.dataGridView_Dorctor.RowHeadersWidth = 51;
            this.dataGridView_Dorctor.RowTemplate.Height = 24;
            this.dataGridView_Dorctor.Size = new System.Drawing.Size(1581, 537);
            this.dataGridView_Dorctor.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "修改";
            this.Column1.ToolTipText = "修改";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "刪除";
            this.Column2.ToolTipText = "刪除";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // button_AddDorctor
            // 
            this.button_AddDorctor.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_AddDorctor.Location = new System.Drawing.Point(1363, 9);
            this.button_AddDorctor.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddDorctor.Name = "button_AddDorctor";
            this.button_AddDorctor.Size = new System.Drawing.Size(219, 46);
            this.button_AddDorctor.TabIndex = 16;
            this.button_AddDorctor.Text = "+新增醫師";
            this.button_AddDorctor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "醫生列表";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "醫生維護";
            // 
            // DoctorMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Name = "DoctorMaintain";
            this.Size = new System.Drawing.Size(1052, 539);
            this.Load += new System.EventHandler(this.醫生列表_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dorctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView_Dorctor;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button button_AddDorctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton button_Add_Dorctor;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}
