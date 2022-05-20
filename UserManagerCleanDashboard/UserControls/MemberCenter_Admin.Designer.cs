
namespace Medical.UserControls
{
    partial class MemberCenter_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRevise = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDelet = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtIdentityID = new System.Windows.Forms.TextBox();
            this.btnAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneDataGridView2 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRevise
            // 
            this.btnRevise.AutoRoundedCorners = true;
            this.btnRevise.BorderRadius = 16;
            this.btnRevise.CheckedState.Parent = this.btnRevise;
            this.btnRevise.CustomImages.Parent = this.btnRevise;
            this.btnRevise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevise.DisabledState.Parent = this.btnRevise;
            this.btnRevise.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRevise.ForeColor = System.Drawing.Color.White;
            this.btnRevise.HoverState.Parent = this.btnRevise;
            this.btnRevise.Location = new System.Drawing.Point(132, 495);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.ShadowDecoration.Parent = this.btnRevise;
            this.btnRevise.Size = new System.Drawing.Size(96, 34);
            this.btnRevise.TabIndex = 137;
            this.btnRevise.Text = "修改";
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.AutoRoundedCorners = true;
            this.btnDelet.BorderRadius = 16;
            this.btnDelet.CheckedState.Parent = this.btnDelet;
            this.btnDelet.CustomImages.Parent = this.btnDelet;
            this.btnDelet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelet.DisabledState.Parent = this.btnDelet;
            this.btnDelet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.HoverState.Parent = this.btnDelet;
            this.btnDelet.Location = new System.Drawing.Point(243, 495);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.ShadowDecoration.Parent = this.btnDelet;
            this.btnDelet.Size = new System.Drawing.Size(96, 34);
            this.btnDelet.TabIndex = 136;
            this.btnDelet.Text = "刪除";
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(96, 220);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(160, 31);
            this.cmbGender.TabIndex = 133;
            // 
            // txtIdentityID
            // 
            this.txtIdentityID.Location = new System.Drawing.Point(96, 84);
            this.txtIdentityID.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentityID.Name = "txtIdentityID";
            this.txtIdentityID.Size = new System.Drawing.Size(132, 30);
            this.txtIdentityID.TabIndex = 112;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 16;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(15, 495);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(96, 34);
            this.btnAdd.TabIndex = 134;
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 30);
            this.txtPassword.TabIndex = 113;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 152);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 30);
            this.txtName.TabIndex = 114;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(96, 392);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(160, 31);
            this.cmbCity.TabIndex = 132;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(96, 186);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(160, 30);
            this.dtpBirthday.TabIndex = 131;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(96, 290);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 30);
            this.txtWeight.TabIndex = 116;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(22, 431);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 22);
            this.label15.TabIndex = 130;
            this.label15.Text = "地區";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 324);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 30);
            this.txtEmail.TabIndex = 117;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(22, 395);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 22);
            this.label14.TabIndex = 129;
            this.label14.Text = "CityID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(96, 358);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 30);
            this.txtPhone.TabIndex = 118;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 364);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 128;
            this.label10.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 427);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 30);
            this.txtAddress.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 127;
            this.label9.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 120;
            this.label1.Text = "帳號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 126;
            this.label7.Text = "體重";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 121;
            this.label2.Text = "密碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 125;
            this.label6.Text = "血型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 122;
            this.label3.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 124;
            this.label5.Text = "性別";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 123;
            this.label4.Text = "生日";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBloodType);
            this.panel1.Controls.Add(this.siticoneDataGridView2);
            this.panel1.Controls.Add(this.btnRevise);
            this.panel1.Controls.Add(this.btnDelet);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.txtIdentityID);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cmbCity);
            this.panel1.Controls.Add(this.dtpBirthday);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 698);
            this.panel1.TabIndex = 113;
            // 
            // siticoneDataGridView2
            // 
            this.siticoneDataGridView2.AllowDrop = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.siticoneDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.siticoneDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.siticoneDataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.siticoneDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.siticoneDataGridView2.ColumnHeadersHeight = 27;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.siticoneDataGridView2.EnableHeadersVisualStyles = false;
            this.siticoneDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView2.Location = new System.Drawing.Point(345, 68);
            this.siticoneDataGridView2.Name = "siticoneDataGridView2";
            this.siticoneDataGridView2.RowHeadersVisible = false;
            this.siticoneDataGridView2.RowHeadersWidth = 51;
            this.siticoneDataGridView2.RowTemplate.Height = 27;
            this.siticoneDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siticoneDataGridView2.Size = new System.Drawing.Size(691, 415);
            this.siticoneDataGridView2.TabIndex = 138;
            this.siticoneDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView2.ThemeStyle.HeaderStyle.Height = 27;
            this.siticoneDataGridView2.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.Height = 27;
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siticoneDataGridView1_CellClick);
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cmbBloodType.Location = new System.Drawing.Point(96, 255);
            this.cmbBloodType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(160, 31);
            this.cmbBloodType.TabIndex = 140;
            // 
            // MemberCenter_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberCenter_Admin";
            this.Size = new System.Drawing.Size(1277, 698);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton btnRevise;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelet;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtIdentityID;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView2;
        private System.Windows.Forms.ComboBox cmbBloodType;
    }
}
