
namespace Medical.UserControls
{
    partial class ResetPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.lblVerify = new System.Windows.Forms.Label();
            this.txtVerify = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtId = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnEnter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblRa);
            this.panel1.Controls.Add(this.lblVerify);
            this.panel1.Controls.Add(this.txtVerify);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 677);
            this.panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 19;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(462, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(200, 41);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(410, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 22);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "密碼";
            this.lblPassword.Visible = false;
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRa.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRa.ForeColor = System.Drawing.Color.Black;
            this.lblRa.Location = new System.Drawing.Point(668, 218);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(2, 39);
            this.lblRa.TabIndex = 7;
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.ForeColor = System.Drawing.Color.Black;
            this.lblVerify.Location = new System.Drawing.Point(392, 226);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(64, 22);
            this.lblVerify.TabIndex = 6;
            this.lblVerify.Text = "驗證碼";
            // 
            // txtVerify
            // 
            this.txtVerify.AutoRoundedCorners = true;
            this.txtVerify.BorderRadius = 19;
            this.txtVerify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerify.DefaultText = "";
            this.txtVerify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerify.DisabledState.Parent = this.txtVerify;
            this.txtVerify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerify.FocusedState.Parent = this.txtVerify;
            this.txtVerify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVerify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerify.HoverState.Parent = this.txtVerify;
            this.txtVerify.Location = new System.Drawing.Point(462, 216);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.PasswordChar = '\0';
            this.txtVerify.PlaceholderText = "";
            this.txtVerify.SelectedText = "";
            this.txtVerify.ShadowDecoration.Parent = this.txtVerify;
            this.txtVerify.Size = new System.Drawing.Size(200, 41);
            this.txtVerify.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.AutoRoundedCorners = true;
            this.txtMail.BorderRadius = 19;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.Parent = this.txtMail;
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedState.Parent = this.txtMail;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.HoverState.Parent = this.txtMail;
            this.txtMail.Location = new System.Drawing.Point(462, 149);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(200, 41);
            this.txtMail.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.AutoRoundedCorners = true;
            this.txtId.BorderRadius = 19;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.Parent = this.txtId;
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.FocusedState.Parent = this.txtId;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.HoverState.Parent = this.txtId;
            this.txtId.Location = new System.Drawing.Point(462, 76);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.ShadowDecoration.Parent = this.txtId;
            this.txtId.Size = new System.Drawing.Size(200, 41);
            this.txtId.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.AutoRoundedCorners = true;
            this.btnEnter.BorderRadius = 23;
            this.btnEnter.CheckedState.Parent = this.btnEnter;
            this.btnEnter.CustomImages.Parent = this.btnEnter;
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.DisabledState.Parent = this.btnEnter;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.HoverState.Parent = this.btnEnter;
            this.btnEnter.Location = new System.Drawing.Point(478, 403);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.ShadowDecoration.Parent = this.btnEnter;
            this.btnEnter.Size = new System.Drawing.Size(127, 48);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "送出";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(398, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 22);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(410, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Name = "ResetPassword";
            this.Size = new System.Drawing.Size(1201, 677);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Label lblVerify;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtVerify;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtId;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEnter;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}
