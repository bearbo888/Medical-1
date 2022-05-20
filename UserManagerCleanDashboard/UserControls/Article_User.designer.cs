
namespace Medical.UserControls
{
    partial class Article_User
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
            this.cmb_doctor = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refill = new System.Windows.Forms.Button();
            this.cmb_adtitle = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_searchComboBox = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label_searchName = new System.Windows.Forms.Label();
            this.txt_disease = new System.Windows.Forms.TextBox();
            this.label_searchdatail = new System.Windows.Forms.Label();
            this.dataG_show = new System.Windows.Forms.DataGridView();
            this.label_year = new System.Windows.Forms.Label();
            this.cmb_year = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_show)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_doctor
            // 
            this.cmb_doctor.BackColor = System.Drawing.Color.Transparent;
            this.cmb_doctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_doctor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_doctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_doctor.FocusedState.Parent = this.cmb_doctor;
            this.cmb_doctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_doctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_doctor.HoverState.Parent = this.cmb_doctor;
            this.cmb_doctor.ItemHeight = 30;
            this.cmb_doctor.ItemsAppearance.Parent = this.cmb_doctor;
            this.cmb_doctor.Location = new System.Drawing.Point(198, 128);
            this.cmb_doctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_doctor.Name = "cmb_doctor";
            this.cmb_doctor.ShadowDecoration.Parent = this.cmb_doctor;
            this.cmb_doctor.Size = new System.Drawing.Size(101, 36);
            this.cmb_doctor.TabIndex = 46;
            this.cmb_doctor.SelectedIndexChanged += new System.EventHandler(this.cmb_doctor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(433, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "疾病";
            // 
            // btn_refill
            // 
            this.btn_refill.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_refill.Location = new System.Drawing.Point(394, 14);
            this.btn_refill.Name = "btn_refill";
            this.btn_refill.Size = new System.Drawing.Size(83, 28);
            this.btn_refill.TabIndex = 43;
            this.btn_refill.Text = "全搜索";
            this.btn_refill.UseVisualStyleBackColor = true;
            this.btn_refill.Click += new System.EventHandler(this.btn_refill_Click);
            // 
            // cmb_adtitle
            // 
            this.cmb_adtitle.BackColor = System.Drawing.Color.Transparent;
            this.cmb_adtitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_adtitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_adtitle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_adtitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_adtitle.FocusedState.Parent = this.cmb_adtitle;
            this.cmb_adtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_adtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_adtitle.HoverState.Parent = this.cmb_adtitle;
            this.cmb_adtitle.ItemHeight = 30;
            this.cmb_adtitle.ItemsAppearance.Font = new System.Drawing.Font("PMingLiU", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_adtitle.ItemsAppearance.Parent = this.cmb_adtitle;
            this.cmb_adtitle.Location = new System.Drawing.Point(199, 48);
            this.cmb_adtitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_adtitle.MaxDropDownItems = 10;
            this.cmb_adtitle.Name = "cmb_adtitle";
            this.cmb_adtitle.ShadowDecoration.Parent = this.cmb_adtitle;
            this.cmb_adtitle.Size = new System.Drawing.Size(100, 36);
            this.cmb_adtitle.TabIndex = 49;
            this.cmb_adtitle.SelectedIndexChanged += new System.EventHandler(this.cmb_adtitle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(107, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "醫生";
            // 
            // label_searchComboBox
            // 
            this.label_searchComboBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_searchComboBox.Location = new System.Drawing.Point(103, 56);
            this.label_searchComboBox.Name = "label_searchComboBox";
            this.label_searchComboBox.Size = new System.Drawing.Size(94, 18);
            this.label_searchComboBox.TabIndex = 44;
            this.label_searchComboBox.Text = "下拉式查詢 : ";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search.Location = new System.Drawing.Point(315, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 29);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label_searchName
            // 
            this.label_searchName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_searchName.Location = new System.Drawing.Point(103, 18);
            this.label_searchName.Name = "label_searchName";
            this.label_searchName.Size = new System.Drawing.Size(94, 27);
            this.label_searchName.TabIndex = 42;
            this.label_searchName.Text = "關鍵字查詢 : ";
            // 
            // txt_disease
            // 
            this.txt_disease.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_disease.Location = new System.Drawing.Point(199, 14);
            this.txt_disease.Name = "txt_disease";
            this.txt_disease.Size = new System.Drawing.Size(100, 29);
            this.txt_disease.TabIndex = 40;
            // 
            // label_searchdatail
            // 
            this.label_searchdatail.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_searchdatail.Location = new System.Drawing.Point(107, 177);
            this.label_searchdatail.Name = "label_searchdatail";
            this.label_searchdatail.Size = new System.Drawing.Size(73, 20);
            this.label_searchdatail.TabIndex = 47;
            this.label_searchdatail.Text = "項目";
            // 
            // dataG_show
            // 
            this.dataG_show.AllowUserToAddRows = false;
            this.dataG_show.AllowUserToDeleteRows = false;
            this.dataG_show.AllowUserToResizeColumns = false;
            this.dataG_show.AllowUserToResizeRows = false;
            this.dataG_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataG_show.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataG_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_show.Location = new System.Drawing.Point(109, 200);
            this.dataG_show.Name = "dataG_show";
            this.dataG_show.RowHeadersWidth = 51;
            this.dataG_show.RowTemplate.Height = 24;
            this.dataG_show.Size = new System.Drawing.Size(542, 247);
            this.dataG_show.TabIndex = 45;
            this.dataG_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataG_show_CellClick);
            // 
            // label_year
            // 
            this.label_year.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_year.Location = new System.Drawing.Point(107, 94);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(44, 18);
            this.label_year.TabIndex = 52;
            this.label_year.Text = "年份";
            // 
            // cmb_year
            // 
            this.cmb_year.BackColor = System.Drawing.Color.Transparent;
            this.cmb_year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_year.FocusedState.Parent = this.cmb_year;
            this.cmb_year.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_year.HoverState.Parent = this.cmb_year;
            this.cmb_year.ItemHeight = 30;
            this.cmb_year.ItemsAppearance.Parent = this.cmb_year;
            this.cmb_year.Location = new System.Drawing.Point(199, 88);
            this.cmb_year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.ShadowDecoration.Parent = this.cmb_year;
            this.cmb_year.Size = new System.Drawing.Size(100, 36);
            this.cmb_year.TabIndex = 51;
            this.cmb_year.SelectedIndexChanged += new System.EventHandler(this.cmb_year_SelectedIndexChanged);
            // 
            // Article_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_doctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_refill);
            this.Controls.Add(this.cmb_adtitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_searchComboBox);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label_searchName);
            this.Controls.Add(this.txt_disease);
            this.Controls.Add(this.label_searchdatail);
            this.Controls.Add(this.dataG_show);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Article_User";
            this.Size = new System.Drawing.Size(895, 633);
            ((System.ComponentModel.ISupportInitialize)(this.dataG_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmb_doctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refill;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmb_adtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_searchComboBox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label_searchName;
        private System.Windows.Forms.TextBox txt_disease;
        private System.Windows.Forms.Label label_searchdatail;
        private System.Windows.Forms.DataGridView dataG_show;
        private System.Windows.Forms.Label label_year;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmb_year;
    }
}
