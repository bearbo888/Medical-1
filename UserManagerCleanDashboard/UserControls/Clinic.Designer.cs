
namespace Medical.UserControls
{
    partial class Clinic
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbRoom = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cmbPeriod = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.cmbDepartment = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cmbDoctor = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox17 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox9 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb6 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb5 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb4 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tb7 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ckb00 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb10 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb20 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb30 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb40 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb50 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb60 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb01 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb11 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb21 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb31 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb41 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb51 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb61 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb62 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb52 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb42 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb02 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb12 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb22 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.ckb32 = new Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox();
            this.BtnSearch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(381, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
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
            this.cmbRoom.Location = new System.Drawing.Point(53, 492);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.ShadowDecoration.Parent = this.cmbRoom;
            this.cmbRoom.Size = new System.Drawing.Size(122, 36);
            this.cmbRoom.TabIndex = 19;
            this.cmbRoom.Visible = false;
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(9, 500);
            this.siticoneHtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel4.TabIndex = 18;
            this.siticoneHtmlLabel4.Text = "診間";
            this.siticoneHtmlLabel4.Visible = false;
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
            this.cmbPeriod.Location = new System.Drawing.Point(53, 532);
            this.cmbPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.ShadowDecoration.Parent = this.cmbPeriod;
            this.cmbPeriod.Size = new System.Drawing.Size(122, 36);
            this.cmbPeriod.TabIndex = 17;
            this.cmbPeriod.Visible = false;
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(9, 540);
            this.siticoneHtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel3.TabIndex = 16;
            this.siticoneHtmlLabel3.Text = "時段";
            this.siticoneHtmlLabel3.Visible = false;
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
            this.cmbDepartment.Location = new System.Drawing.Point(53, 572);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.ShadowDecoration.Parent = this.cmbDepartment;
            this.cmbDepartment.Size = new System.Drawing.Size(122, 36);
            this.cmbDepartment.TabIndex = 15;
            this.cmbDepartment.Visible = false;
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
            this.cmbDoctor.Location = new System.Drawing.Point(60, 15);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.ShadowDecoration.Parent = this.cmbDoctor;
            this.cmbDoctor.Size = new System.Drawing.Size(160, 36);
            this.cmbDoctor.TabIndex = 14;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(9, 580);
            this.siticoneHtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(27, 14);
            this.siticoneHtmlLabel2.TabIndex = 13;
            this.siticoneHtmlLabel2.Text = "科別";
            this.siticoneHtmlLabel2.Visible = false;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(9, 15);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(45, 32);
            this.siticoneHtmlLabel1.TabIndex = 12;
            this.siticoneHtmlLabel1.Text = "醫生";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderRadius = 17;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(183, 492);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(122, 36);
            this.siticoneButton1.TabIndex = 20;
            this.siticoneButton1.Text = "儲存";
            this.siticoneButton1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.siticoneTextBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.siticoneTextBox17, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.siticoneTextBox9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb6, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb5, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.siticoneTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckb00, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb20, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb30, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb40, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb50, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb60, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb01, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb21, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb31, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb41, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb51, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb61, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb62, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb52, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb42, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb02, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb22, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb32, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 171);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 278);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "晚上";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTextBox2.Enabled = false;
            this.siticoneTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneTextBox2.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.HoverState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Location = new System.Drawing.Point(0, 200);
            this.siticoneTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.SelectionStart = 2;
            this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Size = new System.Drawing.Size(87, 78);
            this.siticoneTextBox2.TabIndex = 52;
            this.siticoneTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneTextBox17
            // 
            this.siticoneTextBox17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox17.DefaultText = "中午";
            this.siticoneTextBox17.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox17.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox17.DisabledState.Parent = this.siticoneTextBox17;
            this.siticoneTextBox17.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTextBox17.Enabled = false;
            this.siticoneTextBox17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox17.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox17.FocusedState.Parent = this.siticoneTextBox17;
            this.siticoneTextBox17.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneTextBox17.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox17.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox17.HoverState.Parent = this.siticoneTextBox17;
            this.siticoneTextBox17.Location = new System.Drawing.Point(0, 125);
            this.siticoneTextBox17.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneTextBox17.Name = "siticoneTextBox17";
            this.siticoneTextBox17.PasswordChar = '\0';
            this.siticoneTextBox17.PlaceholderText = "";
            this.siticoneTextBox17.SelectedText = "";
            this.siticoneTextBox17.SelectionStart = 2;
            this.siticoneTextBox17.ShadowDecoration.Parent = this.siticoneTextBox17;
            this.siticoneTextBox17.Size = new System.Drawing.Size(87, 75);
            this.siticoneTextBox17.TabIndex = 16;
            this.siticoneTextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneTextBox9
            // 
            this.siticoneTextBox9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox9.DefaultText = "早上";
            this.siticoneTextBox9.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox9.DisabledState.Parent = this.siticoneTextBox9;
            this.siticoneTextBox9.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTextBox9.Enabled = false;
            this.siticoneTextBox9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.FocusedState.Parent = this.siticoneTextBox9;
            this.siticoneTextBox9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneTextBox9.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox9.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox9.HoverState.Parent = this.siticoneTextBox9;
            this.siticoneTextBox9.Location = new System.Drawing.Point(0, 50);
            this.siticoneTextBox9.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneTextBox9.Name = "siticoneTextBox9";
            this.siticoneTextBox9.PasswordChar = '\0';
            this.siticoneTextBox9.PlaceholderText = "";
            this.siticoneTextBox9.SelectedText = "";
            this.siticoneTextBox9.SelectionStart = 2;
            this.siticoneTextBox9.ShadowDecoration.Parent = this.siticoneTextBox9;
            this.siticoneTextBox9.Size = new System.Drawing.Size(87, 75);
            this.siticoneTextBox9.TabIndex = 8;
            this.siticoneTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb6
            // 
            this.tb6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb6.DefaultText = "";
            this.tb6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb6.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb6.DisabledState.Parent = this.tb6;
            this.tb6.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb6.Enabled = false;
            this.tb6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb6.FocusedState.Parent = this.tb6;
            this.tb6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.ForeColor = System.Drawing.Color.Black;
            this.tb6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb6.HoverState.Parent = this.tb6;
            this.tb6.Location = new System.Drawing.Point(609, 0);
            this.tb6.Margin = new System.Windows.Forms.Padding(0);
            this.tb6.Name = "tb6";
            this.tb6.PasswordChar = '\0';
            this.tb6.PlaceholderText = "";
            this.tb6.SelectedText = "";
            this.tb6.ShadowDecoration.Parent = this.tb6;
            this.tb6.Size = new System.Drawing.Size(88, 50);
            this.tb6.TabIndex = 7;
            // 
            // tb5
            // 
            this.tb5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb5.DefaultText = "";
            this.tb5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb5.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb5.DisabledState.Parent = this.tb5;
            this.tb5.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb5.Enabled = false;
            this.tb5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb5.FocusedState.Parent = this.tb5;
            this.tb5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.ForeColor = System.Drawing.Color.Black;
            this.tb5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb5.HoverState.Parent = this.tb5;
            this.tb5.Location = new System.Drawing.Point(522, 0);
            this.tb5.Margin = new System.Windows.Forms.Padding(0);
            this.tb5.Name = "tb5";
            this.tb5.PasswordChar = '\0';
            this.tb5.PlaceholderText = "";
            this.tb5.SelectedText = "";
            this.tb5.ShadowDecoration.Parent = this.tb5;
            this.tb5.Size = new System.Drawing.Size(87, 50);
            this.tb5.TabIndex = 6;
            // 
            // tb4
            // 
            this.tb4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb4.DefaultText = "";
            this.tb4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb4.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb4.DisabledState.Parent = this.tb4;
            this.tb4.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb4.Enabled = false;
            this.tb4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb4.FocusedState.Parent = this.tb4;
            this.tb4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.ForeColor = System.Drawing.Color.Black;
            this.tb4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb4.HoverState.Parent = this.tb4;
            this.tb4.Location = new System.Drawing.Point(435, 0);
            this.tb4.Margin = new System.Windows.Forms.Padding(0);
            this.tb4.Name = "tb4";
            this.tb4.PasswordChar = '\0';
            this.tb4.PlaceholderText = "";
            this.tb4.SelectedText = "";
            this.tb4.ShadowDecoration.Parent = this.tb4;
            this.tb4.Size = new System.Drawing.Size(87, 50);
            this.tb4.TabIndex = 5;
            // 
            // tb3
            // 
            this.tb3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb3.DefaultText = "";
            this.tb3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb3.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb3.DisabledState.Parent = this.tb3;
            this.tb3.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb3.Enabled = false;
            this.tb3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb3.FocusedState.Parent = this.tb3;
            this.tb3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.ForeColor = System.Drawing.Color.Black;
            this.tb3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb3.HoverState.Parent = this.tb3;
            this.tb3.Location = new System.Drawing.Point(348, 0);
            this.tb3.Margin = new System.Windows.Forms.Padding(0);
            this.tb3.Name = "tb3";
            this.tb3.PasswordChar = '\0';
            this.tb3.PlaceholderText = "";
            this.tb3.SelectedText = "";
            this.tb3.ShadowDecoration.Parent = this.tb3;
            this.tb3.Size = new System.Drawing.Size(87, 50);
            this.tb3.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb2.DefaultText = "";
            this.tb2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb2.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb2.DisabledState.Parent = this.tb2;
            this.tb2.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb2.Enabled = false;
            this.tb2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb2.FocusedState.Parent = this.tb2;
            this.tb2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.ForeColor = System.Drawing.Color.Black;
            this.tb2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb2.HoverState.Parent = this.tb2;
            this.tb2.Location = new System.Drawing.Point(261, 0);
            this.tb2.Margin = new System.Windows.Forms.Padding(0);
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '\0';
            this.tb2.PlaceholderText = "";
            this.tb2.SelectedText = "";
            this.tb2.ShadowDecoration.Parent = this.tb2;
            this.tb2.Size = new System.Drawing.Size(87, 50);
            this.tb2.TabIndex = 3;
            // 
            // tb1
            // 
            this.tb1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb1.DefaultText = "";
            this.tb1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb1.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb1.DisabledState.Parent = this.tb1;
            this.tb1.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb1.Enabled = false;
            this.tb1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb1.FocusedState.Parent = this.tb1;
            this.tb1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.ForeColor = System.Drawing.Color.Black;
            this.tb1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb1.HoverState.Parent = this.tb1;
            this.tb1.Location = new System.Drawing.Point(174, 0);
            this.tb1.Margin = new System.Windows.Forms.Padding(0);
            this.tb1.Name = "tb1";
            this.tb1.PasswordChar = '\0';
            this.tb1.PlaceholderText = "";
            this.tb1.SelectedText = "";
            this.tb1.ShadowDecoration.Parent = this.tb1;
            this.tb1.Size = new System.Drawing.Size(87, 50);
            this.tb1.TabIndex = 2;
            // 
            // tb7
            // 
            this.tb7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb7.DefaultText = "";
            this.tb7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb7.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.tb7.DisabledState.Parent = this.tb7;
            this.tb7.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tb7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb7.Enabled = false;
            this.tb7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb7.FocusedState.Parent = this.tb7;
            this.tb7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7.ForeColor = System.Drawing.Color.Black;
            this.tb7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb7.HoverState.Parent = this.tb7;
            this.tb7.Location = new System.Drawing.Point(87, 0);
            this.tb7.Margin = new System.Windows.Forms.Padding(0);
            this.tb7.Name = "tb7";
            this.tb7.PasswordChar = '\0';
            this.tb7.PlaceholderText = "";
            this.tb7.SelectedText = "";
            this.tb7.ShadowDecoration.Parent = this.tb7;
            this.tb7.Size = new System.Drawing.Size(87, 50);
            this.tb7.TabIndex = 1;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTextBox1.Enabled = false;
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoverState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(87, 50);
            this.siticoneTextBox1.TabIndex = 0;
            // 
            // ckb00
            // 
            this.ckb00.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb00.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb00.CheckedState.BorderRadius = 2;
            this.ckb00.CheckedState.BorderThickness = 1;
            this.ckb00.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb00.CheckedState.Parent = this.ckb00;
            this.ckb00.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb00.ForeColor = System.Drawing.Color.Red;
            this.ckb00.Location = new System.Drawing.Point(87, 50);
            this.ckb00.Margin = new System.Windows.Forms.Padding(0);
            this.ckb00.Name = "ckb00";
            this.ckb00.ShadowDecoration.Parent = this.ckb00;
            this.ckb00.Size = new System.Drawing.Size(87, 75);
            this.ckb00.TabIndex = 30;
            this.ckb00.Text = "siticoneCustomCheckBox1";
            this.ckb00.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb00.UncheckedState.BorderRadius = 2;
            this.ckb00.UncheckedState.BorderThickness = 1;
            this.ckb00.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb00.UncheckedState.Parent = this.ckb00;
            // 
            // ckb10
            // 
            this.ckb10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb10.CheckedState.BorderRadius = 2;
            this.ckb10.CheckedState.BorderThickness = 1;
            this.ckb10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb10.CheckedState.Parent = this.ckb10;
            this.ckb10.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb10.ForeColor = System.Drawing.Color.Red;
            this.ckb10.Location = new System.Drawing.Point(174, 50);
            this.ckb10.Margin = new System.Windows.Forms.Padding(0);
            this.ckb10.Name = "ckb10";
            this.ckb10.ShadowDecoration.Parent = this.ckb10;
            this.ckb10.Size = new System.Drawing.Size(87, 75);
            this.ckb10.TabIndex = 31;
            this.ckb10.Text = "siticoneCustomCheckBox2";
            this.ckb10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb10.UncheckedState.BorderRadius = 2;
            this.ckb10.UncheckedState.BorderThickness = 1;
            this.ckb10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb10.UncheckedState.Parent = this.ckb10;
            // 
            // ckb20
            // 
            this.ckb20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb20.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb20.CheckedState.BorderRadius = 2;
            this.ckb20.CheckedState.BorderThickness = 1;
            this.ckb20.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb20.CheckedState.Parent = this.ckb20;
            this.ckb20.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb20.ForeColor = System.Drawing.Color.Red;
            this.ckb20.Location = new System.Drawing.Point(261, 50);
            this.ckb20.Margin = new System.Windows.Forms.Padding(0);
            this.ckb20.Name = "ckb20";
            this.ckb20.ShadowDecoration.Parent = this.ckb20;
            this.ckb20.Size = new System.Drawing.Size(87, 75);
            this.ckb20.TabIndex = 32;
            this.ckb20.Text = "siticoneCustomCheckBox3";
            this.ckb20.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb20.UncheckedState.BorderRadius = 2;
            this.ckb20.UncheckedState.BorderThickness = 1;
            this.ckb20.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb20.UncheckedState.Parent = this.ckb20;
            // 
            // ckb30
            // 
            this.ckb30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb30.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb30.CheckedState.BorderRadius = 2;
            this.ckb30.CheckedState.BorderThickness = 1;
            this.ckb30.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb30.CheckedState.Parent = this.ckb30;
            this.ckb30.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb30.ForeColor = System.Drawing.Color.Red;
            this.ckb30.Location = new System.Drawing.Point(348, 50);
            this.ckb30.Margin = new System.Windows.Forms.Padding(0);
            this.ckb30.Name = "ckb30";
            this.ckb30.ShadowDecoration.Parent = this.ckb30;
            this.ckb30.Size = new System.Drawing.Size(87, 75);
            this.ckb30.TabIndex = 39;
            this.ckb30.Text = "siticoneCustomCheckBox10";
            this.ckb30.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb30.UncheckedState.BorderRadius = 2;
            this.ckb30.UncheckedState.BorderThickness = 1;
            this.ckb30.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb30.UncheckedState.Parent = this.ckb30;
            // 
            // ckb40
            // 
            this.ckb40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb40.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb40.CheckedState.BorderRadius = 2;
            this.ckb40.CheckedState.BorderThickness = 1;
            this.ckb40.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb40.CheckedState.Parent = this.ckb40;
            this.ckb40.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb40.ForeColor = System.Drawing.Color.Red;
            this.ckb40.Location = new System.Drawing.Point(435, 50);
            this.ckb40.Margin = new System.Windows.Forms.Padding(0);
            this.ckb40.Name = "ckb40";
            this.ckb40.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ckb40.ShadowDecoration.Parent = this.ckb40;
            this.ckb40.Size = new System.Drawing.Size(87, 75);
            this.ckb40.TabIndex = 36;
            this.ckb40.Text = "siticoneCustomCheckBox7";
            this.ckb40.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb40.UncheckedState.BorderRadius = 2;
            this.ckb40.UncheckedState.BorderThickness = 1;
            this.ckb40.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb40.UncheckedState.Parent = this.ckb40;
            // 
            // ckb50
            // 
            this.ckb50.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb50.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb50.CheckedState.BorderRadius = 2;
            this.ckb50.CheckedState.BorderThickness = 1;
            this.ckb50.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb50.CheckedState.Parent = this.ckb50;
            this.ckb50.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb50.ForeColor = System.Drawing.Color.Red;
            this.ckb50.Location = new System.Drawing.Point(522, 50);
            this.ckb50.Margin = new System.Windows.Forms.Padding(0);
            this.ckb50.Name = "ckb50";
            this.ckb50.ShadowDecoration.Parent = this.ckb50;
            this.ckb50.Size = new System.Drawing.Size(87, 75);
            this.ckb50.TabIndex = 35;
            this.ckb50.Text = "siticoneCustomCheckBox6";
            this.ckb50.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb50.UncheckedState.BorderRadius = 2;
            this.ckb50.UncheckedState.BorderThickness = 1;
            this.ckb50.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb50.UncheckedState.Parent = this.ckb50;
            // 
            // ckb60
            // 
            this.ckb60.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb60.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb60.CheckedState.BorderRadius = 2;
            this.ckb60.CheckedState.BorderThickness = 1;
            this.ckb60.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb60.CheckedState.Parent = this.ckb60;
            this.ckb60.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb60.ForeColor = System.Drawing.Color.Red;
            this.ckb60.Location = new System.Drawing.Point(609, 50);
            this.ckb60.Margin = new System.Windows.Forms.Padding(0);
            this.ckb60.Name = "ckb60";
            this.ckb60.ShadowDecoration.Parent = this.ckb60;
            this.ckb60.Size = new System.Drawing.Size(88, 75);
            this.ckb60.TabIndex = 37;
            this.ckb60.Text = "siticoneCustomCheckBox8";
            this.ckb60.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb60.UncheckedState.BorderRadius = 2;
            this.ckb60.UncheckedState.BorderThickness = 1;
            this.ckb60.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb60.UncheckedState.Parent = this.ckb60;
            // 
            // ckb01
            // 
            this.ckb01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb01.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb01.CheckedState.BorderRadius = 2;
            this.ckb01.CheckedState.BorderThickness = 1;
            this.ckb01.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb01.CheckedState.Parent = this.ckb01;
            this.ckb01.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb01.ForeColor = System.Drawing.Color.Red;
            this.ckb01.Location = new System.Drawing.Point(87, 125);
            this.ckb01.Margin = new System.Windows.Forms.Padding(0);
            this.ckb01.Name = "ckb01";
            this.ckb01.ShadowDecoration.Parent = this.ckb01;
            this.ckb01.Size = new System.Drawing.Size(87, 75);
            this.ckb01.TabIndex = 34;
            this.ckb01.Text = "siticoneCustomCheckBox5";
            this.ckb01.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb01.UncheckedState.BorderRadius = 2;
            this.ckb01.UncheckedState.BorderThickness = 1;
            this.ckb01.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb01.UncheckedState.Parent = this.ckb01;
            // 
            // ckb11
            // 
            this.ckb11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb11.CheckedState.BorderRadius = 2;
            this.ckb11.CheckedState.BorderThickness = 1;
            this.ckb11.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb11.CheckedState.Parent = this.ckb11;
            this.ckb11.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb11.ForeColor = System.Drawing.Color.Red;
            this.ckb11.Location = new System.Drawing.Point(174, 125);
            this.ckb11.Margin = new System.Windows.Forms.Padding(0);
            this.ckb11.Name = "ckb11";
            this.ckb11.ShadowDecoration.Parent = this.ckb11;
            this.ckb11.Size = new System.Drawing.Size(87, 75);
            this.ckb11.TabIndex = 38;
            this.ckb11.Text = "siticoneCustomCheckBox9";
            this.ckb11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb11.UncheckedState.BorderRadius = 2;
            this.ckb11.UncheckedState.BorderThickness = 1;
            this.ckb11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb11.UncheckedState.Parent = this.ckb11;
            // 
            // ckb21
            // 
            this.ckb21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb21.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb21.CheckedState.BorderRadius = 2;
            this.ckb21.CheckedState.BorderThickness = 1;
            this.ckb21.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb21.CheckedState.Parent = this.ckb21;
            this.ckb21.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb21.ForeColor = System.Drawing.Color.Red;
            this.ckb21.Location = new System.Drawing.Point(261, 125);
            this.ckb21.Margin = new System.Windows.Forms.Padding(0);
            this.ckb21.Name = "ckb21";
            this.ckb21.ShadowDecoration.Parent = this.ckb21;
            this.ckb21.Size = new System.Drawing.Size(87, 75);
            this.ckb21.TabIndex = 33;
            this.ckb21.Text = "siticoneCustomCheckBox4";
            this.ckb21.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb21.UncheckedState.BorderRadius = 2;
            this.ckb21.UncheckedState.BorderThickness = 1;
            this.ckb21.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb21.UncheckedState.Parent = this.ckb21;
            // 
            // ckb31
            // 
            this.ckb31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb31.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb31.CheckedState.BorderRadius = 2;
            this.ckb31.CheckedState.BorderThickness = 1;
            this.ckb31.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb31.CheckedState.Parent = this.ckb31;
            this.ckb31.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb31.ForeColor = System.Drawing.Color.Red;
            this.ckb31.Location = new System.Drawing.Point(348, 125);
            this.ckb31.Margin = new System.Windows.Forms.Padding(0);
            this.ckb31.Name = "ckb31";
            this.ckb31.ShadowDecoration.Parent = this.ckb31;
            this.ckb31.Size = new System.Drawing.Size(87, 75);
            this.ckb31.TabIndex = 42;
            this.ckb31.Text = "siticoneCustomCheckBox13";
            this.ckb31.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb31.UncheckedState.BorderRadius = 2;
            this.ckb31.UncheckedState.BorderThickness = 1;
            this.ckb31.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb31.UncheckedState.Parent = this.ckb31;
            // 
            // ckb41
            // 
            this.ckb41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb41.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb41.CheckedState.BorderRadius = 2;
            this.ckb41.CheckedState.BorderThickness = 1;
            this.ckb41.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb41.CheckedState.Parent = this.ckb41;
            this.ckb41.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb41.ForeColor = System.Drawing.Color.Red;
            this.ckb41.Location = new System.Drawing.Point(435, 125);
            this.ckb41.Margin = new System.Windows.Forms.Padding(0);
            this.ckb41.Name = "ckb41";
            this.ckb41.ShadowDecoration.Parent = this.ckb41;
            this.ckb41.Size = new System.Drawing.Size(87, 75);
            this.ckb41.TabIndex = 43;
            this.ckb41.Text = "siticoneCustomCheckBox14";
            this.ckb41.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb41.UncheckedState.BorderRadius = 2;
            this.ckb41.UncheckedState.BorderThickness = 1;
            this.ckb41.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb41.UncheckedState.Parent = this.ckb41;
            // 
            // ckb51
            // 
            this.ckb51.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb51.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb51.CheckedState.BorderRadius = 2;
            this.ckb51.CheckedState.BorderThickness = 1;
            this.ckb51.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb51.CheckedState.Parent = this.ckb51;
            this.ckb51.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb51.ForeColor = System.Drawing.Color.Red;
            this.ckb51.Location = new System.Drawing.Point(522, 125);
            this.ckb51.Margin = new System.Windows.Forms.Padding(0);
            this.ckb51.Name = "ckb51";
            this.ckb51.ShadowDecoration.Parent = this.ckb51;
            this.ckb51.Size = new System.Drawing.Size(87, 75);
            this.ckb51.TabIndex = 41;
            this.ckb51.Text = "siticoneCustomCheckBox12";
            this.ckb51.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb51.UncheckedState.BorderRadius = 2;
            this.ckb51.UncheckedState.BorderThickness = 1;
            this.ckb51.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb51.UncheckedState.Parent = this.ckb51;
            // 
            // ckb61
            // 
            this.ckb61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb61.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb61.CheckedState.BorderRadius = 2;
            this.ckb61.CheckedState.BorderThickness = 1;
            this.ckb61.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb61.CheckedState.Parent = this.ckb61;
            this.ckb61.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb61.ForeColor = System.Drawing.Color.Red;
            this.ckb61.Location = new System.Drawing.Point(609, 125);
            this.ckb61.Margin = new System.Windows.Forms.Padding(0);
            this.ckb61.Name = "ckb61";
            this.ckb61.ShadowDecoration.Parent = this.ckb61;
            this.ckb61.Size = new System.Drawing.Size(88, 75);
            this.ckb61.TabIndex = 44;
            this.ckb61.Text = "siticoneCustomCheckBox15";
            this.ckb61.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb61.UncheckedState.BorderRadius = 2;
            this.ckb61.UncheckedState.BorderThickness = 1;
            this.ckb61.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb61.UncheckedState.Parent = this.ckb61;
            // 
            // ckb62
            // 
            this.ckb62.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb62.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb62.CheckedState.BorderRadius = 2;
            this.ckb62.CheckedState.BorderThickness = 1;
            this.ckb62.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb62.CheckedState.Parent = this.ckb62;
            this.ckb62.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb62.ForeColor = System.Drawing.Color.Red;
            this.ckb62.Location = new System.Drawing.Point(609, 200);
            this.ckb62.Margin = new System.Windows.Forms.Padding(0);
            this.ckb62.Name = "ckb62";
            this.ckb62.ShadowDecoration.Parent = this.ckb62;
            this.ckb62.Size = new System.Drawing.Size(88, 78);
            this.ckb62.TabIndex = 47;
            this.ckb62.Text = "siticoneCustomCheckBox18";
            this.ckb62.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb62.UncheckedState.BorderRadius = 2;
            this.ckb62.UncheckedState.BorderThickness = 1;
            this.ckb62.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb62.UncheckedState.Parent = this.ckb62;
            // 
            // ckb52
            // 
            this.ckb52.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb52.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb52.CheckedState.BorderRadius = 2;
            this.ckb52.CheckedState.BorderThickness = 1;
            this.ckb52.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb52.CheckedState.Parent = this.ckb52;
            this.ckb52.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb52.ForeColor = System.Drawing.Color.Red;
            this.ckb52.Location = new System.Drawing.Point(522, 200);
            this.ckb52.Margin = new System.Windows.Forms.Padding(0);
            this.ckb52.Name = "ckb52";
            this.ckb52.ShadowDecoration.Parent = this.ckb52;
            this.ckb52.Size = new System.Drawing.Size(87, 78);
            this.ckb52.TabIndex = 40;
            this.ckb52.Text = "siticoneCustomCheckBox11";
            this.ckb52.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb52.UncheckedState.BorderRadius = 2;
            this.ckb52.UncheckedState.BorderThickness = 1;
            this.ckb52.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb52.UncheckedState.Parent = this.ckb52;
            // 
            // ckb42
            // 
            this.ckb42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb42.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb42.CheckedState.BorderRadius = 2;
            this.ckb42.CheckedState.BorderThickness = 1;
            this.ckb42.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb42.CheckedState.Parent = this.ckb42;
            this.ckb42.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb42.ForeColor = System.Drawing.Color.Red;
            this.ckb42.Location = new System.Drawing.Point(435, 200);
            this.ckb42.Margin = new System.Windows.Forms.Padding(0);
            this.ckb42.Name = "ckb42";
            this.ckb42.ShadowDecoration.Parent = this.ckb42;
            this.ckb42.Size = new System.Drawing.Size(87, 78);
            this.ckb42.TabIndex = 49;
            this.ckb42.Text = "siticoneCustomCheckBox20";
            this.ckb42.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb42.UncheckedState.BorderRadius = 2;
            this.ckb42.UncheckedState.BorderThickness = 1;
            this.ckb42.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb42.UncheckedState.Parent = this.ckb42;
            // 
            // ckb02
            // 
            this.ckb02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb02.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb02.CheckedState.BorderRadius = 2;
            this.ckb02.CheckedState.BorderThickness = 1;
            this.ckb02.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb02.CheckedState.Parent = this.ckb02;
            this.ckb02.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb02.ForeColor = System.Drawing.Color.Red;
            this.ckb02.Location = new System.Drawing.Point(87, 200);
            this.ckb02.Margin = new System.Windows.Forms.Padding(0);
            this.ckb02.Name = "ckb02";
            this.ckb02.ShadowDecoration.Parent = this.ckb02;
            this.ckb02.Size = new System.Drawing.Size(87, 78);
            this.ckb02.TabIndex = 46;
            this.ckb02.Text = "siticoneCustomCheckBox17";
            this.ckb02.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb02.UncheckedState.BorderRadius = 2;
            this.ckb02.UncheckedState.BorderThickness = 1;
            this.ckb02.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb02.UncheckedState.Parent = this.ckb02;
            // 
            // ckb12
            // 
            this.ckb12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb12.CheckedState.BorderRadius = 2;
            this.ckb12.CheckedState.BorderThickness = 1;
            this.ckb12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb12.CheckedState.Parent = this.ckb12;
            this.ckb12.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb12.ForeColor = System.Drawing.Color.Red;
            this.ckb12.Location = new System.Drawing.Point(174, 200);
            this.ckb12.Margin = new System.Windows.Forms.Padding(0);
            this.ckb12.Name = "ckb12";
            this.ckb12.ShadowDecoration.Parent = this.ckb12;
            this.ckb12.Size = new System.Drawing.Size(87, 78);
            this.ckb12.TabIndex = 45;
            this.ckb12.Text = "siticoneCustomCheckBox16";
            this.ckb12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb12.UncheckedState.BorderRadius = 2;
            this.ckb12.UncheckedState.BorderThickness = 1;
            this.ckb12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb12.UncheckedState.Parent = this.ckb12;
            // 
            // ckb22
            // 
            this.ckb22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb22.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb22.CheckedState.BorderRadius = 2;
            this.ckb22.CheckedState.BorderThickness = 1;
            this.ckb22.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb22.CheckedState.Parent = this.ckb22;
            this.ckb22.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb22.ForeColor = System.Drawing.Color.Red;
            this.ckb22.Location = new System.Drawing.Point(261, 200);
            this.ckb22.Margin = new System.Windows.Forms.Padding(0);
            this.ckb22.Name = "ckb22";
            this.ckb22.ShadowDecoration.Parent = this.ckb22;
            this.ckb22.Size = new System.Drawing.Size(87, 78);
            this.ckb22.TabIndex = 48;
            this.ckb22.Text = "siticoneCustomCheckBox19";
            this.ckb22.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb22.UncheckedState.BorderRadius = 2;
            this.ckb22.UncheckedState.BorderThickness = 1;
            this.ckb22.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb22.UncheckedState.Parent = this.ckb22;
            // 
            // ckb32
            // 
            this.ckb32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckb32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb32.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb32.CheckedState.BorderRadius = 2;
            this.ckb32.CheckedState.BorderThickness = 1;
            this.ckb32.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb32.CheckedState.Parent = this.ckb32;
            this.ckb32.CheckMarkColor = System.Drawing.Color.Red;
            this.ckb32.ForeColor = System.Drawing.Color.Red;
            this.ckb32.Location = new System.Drawing.Point(348, 200);
            this.ckb32.Margin = new System.Windows.Forms.Padding(0);
            this.ckb32.Name = "ckb32";
            this.ckb32.ShadowDecoration.Parent = this.ckb32;
            this.ckb32.Size = new System.Drawing.Size(87, 78);
            this.ckb32.TabIndex = 54;
            this.ckb32.Text = "siticoneCustomCheckBox21";
            this.ckb32.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ckb32.UncheckedState.BorderRadius = 2;
            this.ckb32.UncheckedState.BorderThickness = 1;
            this.ckb32.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ckb32.UncheckedState.Parent = this.ckb32;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoRoundedCorners = true;
            this.BtnSearch.BorderRadius = 17;
            this.BtnSearch.CheckedState.Parent = this.BtnSearch;
            this.BtnSearch.CustomImages.Parent = this.BtnSearch;
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.DisabledState.Parent = this.BtnSearch;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.HoverState.Parent = this.BtnSearch;
            this.BtnSearch.Location = new System.Drawing.Point(237, 15);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.ShadowDecoration.Parent = this.BtnSearch;
            this.BtnSearch.Size = new System.Drawing.Size(122, 36);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Clinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Clinic";
            this.Size = new System.Drawing.Size(1130, 670);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbRoom;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbPeriod;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbDepartment;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbDoctor;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox9;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tb7;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb00;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb10;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb20;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb30;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb40;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb50;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb60;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb01;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb11;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb21;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb31;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb41;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb51;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb61;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb62;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb52;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb42;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb02;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb12;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb22;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomCheckBox ckb32;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnSearch;
    }
}
