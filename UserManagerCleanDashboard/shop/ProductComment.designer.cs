
namespace Medical.UserControls
{
    partial class ProductComment
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
            this.components = new System.ComponentModel.Container();
            this.label_name = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneComboBox1 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_return = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btn_add = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label_Star = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.txt_Comment = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = false;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(446, 79);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(148, 37);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "產品名稱";
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.FocusedState.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.HoverState.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.ItemsAppearance.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Location = new System.Drawing.Point(671, 210);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.ShadowDecoration.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Size = new System.Drawing.Size(141, 36);
            this.siticoneComboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_return);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label_Star);
            this.panel1.Controls.Add(this.siticonePictureBox1);
            this.panel1.Controls.Add(this.txt_Comment);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.siticoneComboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 656);
            this.panel1.TabIndex = 3;
            // 
            // btn_return
            // 
            this.btn_return.CheckedState.Parent = this.btn_return;
            this.btn_return.CustomImages.Parent = this.btn_return;
            this.btn_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_return.DisabledState.Parent = this.btn_return;
            this.btn_return.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.HoverState.Parent = this.btn_return;
            this.btn_return.Location = new System.Drawing.Point(792, 542);
            this.btn_return.Name = "btn_return";
            this.btn_return.ShadowDecoration.Parent = this.btn_return;
            this.btn_return.Size = new System.Drawing.Size(191, 62);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "返回";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_add
            // 
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.DisabledState.Parent = this.btn_add;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(410, 542);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(191, 62);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "送出";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label_Star
            // 
            this.label_Star.AutoSize = false;
            this.label_Star.BackColor = System.Drawing.Color.Transparent;
            this.label_Star.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Star.Location = new System.Drawing.Point(446, 210);
            this.label_Star.Name = "label_Star";
            this.label_Star.Size = new System.Drawing.Size(198, 37);
            this.label_Star.TabIndex = 5;
            this.label_Star.Text = "評價(星星)→";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(76, 79);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(253, 203);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 4;
            this.siticonePictureBox1.TabStop = false;
            // 
            // txt_Comment
            // 
            this.txt_Comment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Comment.DefaultText = "";
            this.txt_Comment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Comment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Comment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Comment.DisabledState.Parent = this.txt_Comment;
            this.txt_Comment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Comment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Comment.FocusedState.Parent = this.txt_Comment;
            this.txt_Comment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Comment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Comment.HoverState.Parent = this.txt_Comment;
            this.txt_Comment.Location = new System.Drawing.Point(410, 290);
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.PasswordChar = '\0';
            this.txt_Comment.PlaceholderText = "";
            this.txt_Comment.SelectedText = "";
            this.txt_Comment.ShadowDecoration.Parent = this.txt_Comment;
            this.txt_Comment.Size = new System.Drawing.Size(573, 229);
            this.txt_Comment.TabIndex = 3;
            // 
            // ProductComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Name = "ProductComment";
            this.Size = new System.Drawing.Size(1138, 656);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_name;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_Star;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_Comment;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_return;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_add;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
