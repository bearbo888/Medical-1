
namespace Medical.UserControls
{
    partial class MemberCenter_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberCenter_User));
            this.btn_MemberUpdate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MemberUpdate
            // 
            this.btn_MemberUpdate.AutoRoundedCorners = true;
            this.btn_MemberUpdate.BorderRadius = 18;
            this.btn_MemberUpdate.CheckedState.Parent = this.btn_MemberUpdate;
            this.btn_MemberUpdate.CustomImages.Parent = this.btn_MemberUpdate;
            this.btn_MemberUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_MemberUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_MemberUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_MemberUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_MemberUpdate.DisabledState.Parent = this.btn_MemberUpdate;
            this.btn_MemberUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_MemberUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_MemberUpdate.HoverState.Parent = this.btn_MemberUpdate;
            this.btn_MemberUpdate.Location = new System.Drawing.Point(164, 27);
            this.btn_MemberUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_MemberUpdate.Name = "btn_MemberUpdate";
            this.btn_MemberUpdate.ShadowDecoration.Parent = this.btn_MemberUpdate;
            this.btn_MemberUpdate.Size = new System.Drawing.Size(96, 38);
            this.btn_MemberUpdate.TabIndex = 86;
            this.btn_MemberUpdate.Text = "修改會員資料";
            this.btn_MemberUpdate.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneCirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.siticoneButton3);
            this.panel1.Controls.Add(this.siticoneButton2);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.btn_MemberUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 525);
            this.panel1.TabIndex = 87;
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox1.Image")));
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(274, 86);
            this.siticoneCirclePictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(224, 225);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.siticoneCirclePictureBox1.TabIndex = 91;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(309, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 90;
            this.label1.Text = "歡迎漢斯眼科";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.AutoRoundedCorners = true;
            this.siticoneButton3.BorderRadius = 18;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton3.DisabledState.Parent = this.siticoneButton3;
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoverState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(501, 27);
            this.siticoneButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(96, 38);
            this.siticoneButton3.TabIndex = 89;
            this.siticoneButton3.Text = "登出";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.AutoRoundedCorners = true;
            this.siticoneButton2.BorderRadius = 18;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(382, 27);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(96, 38);
            this.siticoneButton2.TabIndex = 88;
            this.siticoneButton2.Text = "我的訂單";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderRadius = 18;
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
            this.siticoneButton1.Location = new System.Drawing.Point(274, 27);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(96, 38);
            this.siticoneButton1.TabIndex = 87;
            this.siticoneButton1.Text = "我的歷史病歷";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // MemberCenter_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberCenter_User";
            this.Size = new System.Drawing.Size(854, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_MemberUpdate;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
