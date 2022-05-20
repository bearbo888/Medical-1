
namespace Medical.UserControls
{
    partial class Schedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTimePicker1 = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cmbRoom = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cmbPeriod = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cmbDepartment = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cmbDoctor = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.gvSchedule = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DateTimePicker1);
            this.panel1.Controls.Add(this.siticoneHtmlLabel5);
            this.panel1.Controls.Add(this.cmbRoom);
            this.panel1.Controls.Add(this.siticoneHtmlLabel4);
            this.panel1.Controls.Add(this.cmbPeriod);
            this.panel1.Controls.Add(this.siticoneHtmlLabel3);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.cmbDoctor);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.siticoneHtmlLabel2);
            this.panel1.Controls.Add(this.siticoneHtmlLabel1);
            this.panel1.Controls.Add(this.gvSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 525);
            this.panel1.TabIndex = 0;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.AutoRoundedCorners = true;
            this.DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DateTimePicker1.BorderRadius = 13;
            this.DateTimePicker1.CheckedState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.HoverState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Location = new System.Drawing.Point(64, 129);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.ShadowDecoration.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Size = new System.Drawing.Size(150, 29);
            this.DateTimePicker1.TabIndex = 13;
            this.DateTimePicker1.Value = new System.DateTime(2022, 5, 11, 14, 33, 27, 825);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(20, 137);
            this.siticoneHtmlLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel5.TabIndex = 12;
            this.siticoneHtmlLabel5.Text = "日期";
            // 
            // cmbRoom
            // 
            this.cmbRoom.AutoRoundedCorners = true;
            this.cmbRoom.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoom.BorderRadius = 17;
            this.cmbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoom.FocusedState.Parent = this.cmbRoom;
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRoom.HoverState.Parent = this.cmbRoom;
            this.cmbRoom.ItemHeight = 30;
            this.cmbRoom.ItemsAppearance.Parent = this.cmbRoom;
            this.cmbRoom.Location = new System.Drawing.Point(64, 25);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.ShadowDecoration.Parent = this.cmbRoom;
            this.cmbRoom.Size = new System.Drawing.Size(122, 36);
            this.cmbRoom.TabIndex = 11;
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(20, 33);
            this.siticoneHtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel4.TabIndex = 10;
            this.siticoneHtmlLabel4.Text = "診間";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.AutoRoundedCorners = true;
            this.cmbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriod.BorderRadius = 17;
            this.cmbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriod.FocusedState.Parent = this.cmbPeriod;
            this.cmbPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriod.HoverState.Parent = this.cmbPeriod;
            this.cmbPeriod.ItemHeight = 30;
            this.cmbPeriod.ItemsAppearance.Parent = this.cmbPeriod;
            this.cmbPeriod.Location = new System.Drawing.Point(258, 26);
            this.cmbPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.ShadowDecoration.Parent = this.cmbPeriod;
            this.cmbPeriod.Size = new System.Drawing.Size(122, 36);
            this.cmbPeriod.TabIndex = 9;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(214, 34);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel3.TabIndex = 8;
            this.siticoneHtmlLabel3.Text = "時段";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoRoundedCorners = true;
            this.cmbDepartment.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepartment.BorderRadius = 17;
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.FocusedState.Parent = this.cmbDepartment;
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepartment.HoverState.Parent = this.cmbDepartment;
            this.cmbDepartment.ItemHeight = 30;
            this.cmbDepartment.ItemsAppearance.Parent = this.cmbDepartment;
            this.cmbDepartment.Location = new System.Drawing.Point(258, 75);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.ShadowDecoration.Parent = this.cmbDepartment;
            this.cmbDepartment.Size = new System.Drawing.Size(122, 36);
            this.cmbDepartment.TabIndex = 7;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AutoRoundedCorners = true;
            this.cmbDoctor.BackColor = System.Drawing.Color.Transparent;
            this.cmbDoctor.BorderRadius = 17;
            this.cmbDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDoctor.FocusedState.Parent = this.cmbDoctor;
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDoctor.HoverState.Parent = this.cmbDoctor;
            this.cmbDoctor.ItemHeight = 30;
            this.cmbDoctor.ItemsAppearance.Parent = this.cmbDoctor;
            this.cmbDoctor.Location = new System.Drawing.Point(64, 75);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.ShadowDecoration.Parent = this.cmbDoctor;
            this.cmbDoctor.Size = new System.Drawing.Size(122, 36);
            this.cmbDoctor.TabIndex = 6;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderRadius = 14;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(251, 129);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(129, 30);
            this.siticoneButton1.TabIndex = 5;
            this.siticoneButton1.Text = "新增";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(214, 83);
            this.siticoneHtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel2.TabIndex = 2;
            this.siticoneHtmlLabel2.Text = "科別";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(20, 83);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel1.TabIndex = 1;
            this.siticoneHtmlLabel1.Text = "醫生";
            // 
            // gvSchedule
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvSchedule.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSchedule.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvSchedule.EnableHeadersVisualStyles = false;
            this.gvSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvSchedule.Location = new System.Drawing.Point(20, 178);
            this.gvSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.gvSchedule.MaximumSize = new System.Drawing.Size(800, 180);
            this.gvSchedule.Name = "gvSchedule";
            this.gvSchedule.RowHeadersVisible = false;
            this.gvSchedule.RowHeadersWidth = 51;
            this.gvSchedule.RowTemplate.Height = 27;
            this.gvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSchedule.Size = new System.Drawing.Size(800, 180);
            this.gvSchedule.TabIndex = 0;
            this.gvSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvSchedule.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvSchedule.ThemeStyle.HeaderStyle.Height = 20;
            this.gvSchedule.ThemeStyle.ReadOnly = false;
            this.gvSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvSchedule.ThemeStyle.RowsStyle.Height = 27;
            this.gvSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(854, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gvSchedule;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker DateTimePicker1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbRoom;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbDepartment;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbDoctor;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbPeriod;
    }
}
