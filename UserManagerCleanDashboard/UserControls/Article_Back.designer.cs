
namespace Medical.UserControls
{
    partial class Article_Back
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
            this.lab_title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_backDoctor = new System.Windows.Forms.Label();
            this.label_backShowDoctor = new System.Windows.Forms.Label();
            this.txt_Search = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cmb_backDoctor = new Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox();
            this.dataG_showdata = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.txt_backShowDoctorName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txt_title = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txt_content = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btn_modify = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.btn_delete = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.btn_create = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.btn_backsearch = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.btn_backrefill = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.panel_Back = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_showdata)).BeginInit();
            this.panel_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(23, 266);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(74, 21);
            this.lab_title.TabIndex = 37;
            this.lab_title.Text = "文章標題";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "關鍵字查詢";
            // 
            // label_backDoctor
            // 
            this.label_backDoctor.AutoSize = true;
            this.label_backDoctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backDoctor.Location = new System.Drawing.Point(23, 57);
            this.label_backDoctor.Name = "label_backDoctor";
            this.label_backDoctor.Size = new System.Drawing.Size(42, 21);
            this.label_backDoctor.TabIndex = 50;
            this.label_backDoctor.Text = "醫生";
            // 
            // label_backShowDoctor
            // 
            this.label_backShowDoctor.AutoSize = true;
            this.label_backShowDoctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backShowDoctor.Location = new System.Drawing.Point(23, 234);
            this.label_backShowDoctor.Name = "label_backShowDoctor";
            this.label_backShowDoctor.Size = new System.Drawing.Size(42, 21);
            this.label_backShowDoctor.TabIndex = 51;
            this.label_backShowDoctor.Text = "醫生";
            // 
            // txt_Search
            // 
            this.txt_Search.AutoRoundedCorners = true;
            this.txt_Search.BorderRadius = 9;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.Parent = this.txt_Search;
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.FocusedState.Parent = this.txt_Search;
            this.txt_Search.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.HoverState.Parent = this.txt_Search;
            this.txt_Search.Location = new System.Drawing.Point(120, 20);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(200, 21);
            this.txt_Search.TabIndex = 53;
            // 
            // cmb_backDoctor
            // 
            this.cmb_backDoctor.BackColor = System.Drawing.Color.Transparent;
            this.cmb_backDoctor.BorderRadius = 17;
            this.cmb_backDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_backDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_backDoctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_backDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_backDoctor.FocusedState.Parent = this.cmb_backDoctor;
            this.cmb_backDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_backDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_backDoctor.HoverState.Parent = this.cmb_backDoctor;
            this.cmb_backDoctor.ItemHeight = 30;
            this.cmb_backDoctor.ItemsAppearance.Parent = this.cmb_backDoctor;
            this.cmb_backDoctor.Location = new System.Drawing.Point(120, 47);
            this.cmb_backDoctor.Name = "cmb_backDoctor";
            this.cmb_backDoctor.ShadowDecoration.Parent = this.cmb_backDoctor;
            this.cmb_backDoctor.Size = new System.Drawing.Size(200, 36);
            this.cmb_backDoctor.TabIndex = 54;
            this.cmb_backDoctor.SelectedIndexChanged += new System.EventHandler(this.cmb_backDoctor_SelectedIndexChanged);
            // 
            // dataG_showdata
            // 
            this.dataG_showdata.AllowUserToAddRows = false;
            this.dataG_showdata.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataG_showdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataG_showdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataG_showdata.BackgroundColor = System.Drawing.Color.White;
            this.dataG_showdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataG_showdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataG_showdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataG_showdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataG_showdata.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataG_showdata.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataG_showdata.EnableHeadersVisualStyles = false;
            this.dataG_showdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataG_showdata.Location = new System.Drawing.Point(27, 89);
            this.dataG_showdata.Name = "dataG_showdata";
            this.dataG_showdata.ReadOnly = true;
            this.dataG_showdata.RowHeadersVisible = false;
            this.dataG_showdata.RowHeadersWidth = 51;
            this.dataG_showdata.RowTemplate.Height = 24;
            this.dataG_showdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataG_showdata.Size = new System.Drawing.Size(472, 127);
            this.dataG_showdata.TabIndex = 55;
            this.dataG_showdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataG_showdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataG_showdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataG_showdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataG_showdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataG_showdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataG_showdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataG_showdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataG_showdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataG_showdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataG_showdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataG_showdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataG_showdata.ThemeStyle.HeaderStyle.Height = 20;
            this.dataG_showdata.ThemeStyle.ReadOnly = true;
            this.dataG_showdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataG_showdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataG_showdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataG_showdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataG_showdata.ThemeStyle.RowsStyle.Height = 24;
            this.dataG_showdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataG_showdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataG_showdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataG_showdata_CellClick);
            // 
            // txt_backShowDoctorName
            // 
            this.txt_backShowDoctorName.AutoRoundedCorners = true;
            this.txt_backShowDoctorName.BorderRadius = 9;
            this.txt_backShowDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_backShowDoctorName.DefaultText = "";
            this.txt_backShowDoctorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_backShowDoctorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_backShowDoctorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_backShowDoctorName.DisabledState.Parent = this.txt_backShowDoctorName;
            this.txt_backShowDoctorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_backShowDoctorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_backShowDoctorName.FocusedState.Parent = this.txt_backShowDoctorName;
            this.txt_backShowDoctorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_backShowDoctorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_backShowDoctorName.HoverState.Parent = this.txt_backShowDoctorName;
            this.txt_backShowDoctorName.Location = new System.Drawing.Point(120, 234);
            this.txt_backShowDoctorName.Name = "txt_backShowDoctorName";
            this.txt_backShowDoctorName.PasswordChar = '\0';
            this.txt_backShowDoctorName.PlaceholderText = "";
            this.txt_backShowDoctorName.ReadOnly = true;
            this.txt_backShowDoctorName.SelectedText = "";
            this.txt_backShowDoctorName.ShadowDecoration.Parent = this.txt_backShowDoctorName;
            this.txt_backShowDoctorName.Size = new System.Drawing.Size(200, 21);
            this.txt_backShowDoctorName.TabIndex = 56;
            // 
            // txt_title
            // 
            this.txt_title.AutoRoundedCorners = true;
            this.txt_title.BorderRadius = 9;
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.DefaultText = "";
            this.txt_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_title.DisabledState.Parent = this.txt_title;
            this.txt_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_title.FocusedState.Parent = this.txt_title;
            this.txt_title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_title.HoverState.Parent = this.txt_title;
            this.txt_title.Location = new System.Drawing.Point(120, 266);
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.PlaceholderText = "";
            this.txt_title.SelectedText = "";
            this.txt_title.ShadowDecoration.Parent = this.txt_title;
            this.txt_title.Size = new System.Drawing.Size(200, 21);
            this.txt_title.TabIndex = 57;
            // 
            // txt_content
            // 
            this.txt_content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_content.DefaultText = "";
            this.txt_content.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_content.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_content.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_content.DisabledState.Parent = this.txt_content;
            this.txt_content.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_content.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_content.FocusedState.Parent = this.txt_content;
            this.txt_content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_content.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_content.HoverState.Parent = this.txt_content;
            this.txt_content.Location = new System.Drawing.Point(27, 293);
            this.txt_content.Name = "txt_content";
            this.txt_content.PasswordChar = '\0';
            this.txt_content.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_content.PlaceholderText = "內文";
            this.txt_content.SelectedText = "";
            this.txt_content.ShadowDecoration.Parent = this.txt_content;
            this.txt_content.Size = new System.Drawing.Size(472, 199);
            this.txt_content.TabIndex = 58;
            this.txt_content.TextChanged += new System.EventHandler(this.txt_content_TextChanged);
            // 
            // btn_modify
            // 
            this.btn_modify.BorderRadius = 19;
            this.btn_modify.CheckedState.Parent = this.btn_modify;
            this.btn_modify.CustomImages.Parent = this.btn_modify;
            this.btn_modify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modify.DisabledState.Parent = this.btn_modify;
            this.btn_modify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.HoverState.Parent = this.btn_modify;
            this.btn_modify.Location = new System.Drawing.Point(505, 340);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.ShadowDecoration.Parent = this.btn_modify;
            this.btn_modify.Size = new System.Drawing.Size(144, 41);
            this.btn_modify.TabIndex = 59;
            this.btn_modify.Text = "修改";
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BorderRadius = 19;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.DisabledState.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(505, 387);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(144, 41);
            this.btn_delete.TabIndex = 60;
            this.btn_delete.Text = "刪除";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.BorderRadius = 19;
            this.btn_create.CheckedState.Parent = this.btn_create;
            this.btn_create.CustomImages.Parent = this.btn_create;
            this.btn_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_create.DisabledState.Parent = this.btn_create;
            this.btn_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.HoverState.Parent = this.btn_create;
            this.btn_create.Location = new System.Drawing.Point(505, 293);
            this.btn_create.Name = "btn_create";
            this.btn_create.ShadowDecoration.Parent = this.btn_create;
            this.btn_create.Size = new System.Drawing.Size(144, 41);
            this.btn_create.TabIndex = 61;
            this.btn_create.Text = "新增";
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_backsearch
            // 
            this.btn_backsearch.BorderRadius = 17;
            this.btn_backsearch.CheckedState.Parent = this.btn_backsearch;
            this.btn_backsearch.CustomImages.Parent = this.btn_backsearch;
            this.btn_backsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_backsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_backsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_backsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_backsearch.DisabledState.Parent = this.btn_backsearch;
            this.btn_backsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_backsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backsearch.ForeColor = System.Drawing.Color.White;
            this.btn_backsearch.HoverState.Parent = this.btn_backsearch;
            this.btn_backsearch.Location = new System.Drawing.Point(339, 20);
            this.btn_backsearch.Name = "btn_backsearch";
            this.btn_backsearch.ShadowDecoration.Parent = this.btn_backsearch;
            this.btn_backsearch.Size = new System.Drawing.Size(61, 36);
            this.btn_backsearch.TabIndex = 62;
            this.btn_backsearch.Text = "搜索";
            this.btn_backsearch.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_backrefill
            // 
            this.btn_backrefill.BorderRadius = 17;
            this.btn_backrefill.CheckedState.Parent = this.btn_backrefill;
            this.btn_backrefill.CustomImages.Parent = this.btn_backrefill;
            this.btn_backrefill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_backrefill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_backrefill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_backrefill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_backrefill.DisabledState.Parent = this.btn_backrefill;
            this.btn_backrefill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_backrefill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backrefill.ForeColor = System.Drawing.Color.White;
            this.btn_backrefill.HoverState.Parent = this.btn_backrefill;
            this.btn_backrefill.Location = new System.Drawing.Point(414, 20);
            this.btn_backrefill.Name = "btn_backrefill";
            this.btn_backrefill.ShadowDecoration.Parent = this.btn_backrefill;
            this.btn_backrefill.Size = new System.Drawing.Size(85, 36);
            this.btn_backrefill.TabIndex = 63;
            this.btn_backrefill.Text = "全搜索";
            this.btn_backrefill.Click += new System.EventHandler(this.btn_backrefill_Click);
            // 
            // panel_Back
            // 
            this.panel_Back.Controls.Add(this.btn_backrefill);
            this.panel_Back.Controls.Add(this.btn_backsearch);
            this.panel_Back.Controls.Add(this.btn_create);
            this.panel_Back.Controls.Add(this.btn_delete);
            this.panel_Back.Controls.Add(this.btn_modify);
            this.panel_Back.Controls.Add(this.txt_content);
            this.panel_Back.Controls.Add(this.txt_title);
            this.panel_Back.Controls.Add(this.txt_backShowDoctorName);
            this.panel_Back.Controls.Add(this.dataG_showdata);
            this.panel_Back.Controls.Add(this.cmb_backDoctor);
            this.panel_Back.Controls.Add(this.txt_Search);
            this.panel_Back.Controls.Add(this.label_backShowDoctor);
            this.panel_Back.Controls.Add(this.label_backDoctor);
            this.panel_Back.Controls.Add(this.label3);
            this.panel_Back.Controls.Add(this.lab_title);
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(953, 569);
            this.panel_Back.TabIndex = 49;
            // 
            // Article_Back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel_Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Article_Back";
            this.Size = new System.Drawing.Size(953, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dataG_showdata)).EndInit();
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_backDoctor;
        private System.Windows.Forms.Label label_backShowDoctor;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_Search;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedComboBox cmb_backDoctor;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataG_showdata;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_backShowDoctorName;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_title;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_content;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton btn_modify;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton btn_delete;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton btn_create;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton btn_backsearch;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton btn_backrefill;
        private System.Windows.Forms.Panel panel_Back;
    }
}
