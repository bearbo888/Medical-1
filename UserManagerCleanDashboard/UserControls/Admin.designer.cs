
namespace Medical.UserControls
{
    partial class Admin
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.BtnDashboard = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.BtnSchedule = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.BtnMember = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.BtnDoctor = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.BtnArtcle = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.BtnShop = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.AdminPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.BtnDashboard);
            this.siticonePanel1.Controls.Add(this.BtnSchedule);
            this.siticonePanel1.Controls.Add(this.BtnMember);
            this.siticonePanel1.Controls.Add(this.BtnDoctor);
            this.siticonePanel1.Controls.Add(this.BtnArtcle);
            this.siticonePanel1.Controls.Add(this.BtnShop);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1107, 50);
            this.siticonePanel1.TabIndex = 0;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BorderRadius = 21;
            this.BtnDashboard.CheckedState.Parent = this.BtnDashboard;
            this.BtnDashboard.CustomImages.Parent = this.BtnDashboard;
            this.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDashboard.DisabledState.Parent = this.BtnDashboard;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.HoverState.Parent = this.BtnDashboard;
            this.BtnDashboard.Location = new System.Drawing.Point(680, 2);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.ShadowDecoration.Parent = this.BtnDashboard;
            this.BtnDashboard.Size = new System.Drawing.Size(124, 45);
            this.BtnDashboard.TabIndex = 6;
            this.BtnDashboard.Text = "報表分析";
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.BorderRadius = 21;
            this.BtnSchedule.CheckedState.Parent = this.BtnSchedule;
            this.BtnSchedule.CustomImages.Parent = this.BtnSchedule;
            this.BtnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSchedule.DisabledState.Parent = this.BtnSchedule;
            this.BtnSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnSchedule.HoverState.Parent = this.BtnSchedule;
            this.BtnSchedule.Location = new System.Drawing.Point(2, 2);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.ShadowDecoration.Parent = this.BtnSchedule;
            this.BtnSchedule.Size = new System.Drawing.Size(124, 45);
            this.BtnSchedule.TabIndex = 0;
            this.BtnSchedule.Text = "門診維護";
            this.BtnSchedule.Click += new System.EventHandler(this.BtnClinic_Click);
            // 
            // BtnMember
            // 
            this.BtnMember.BorderRadius = 21;
            this.BtnMember.CheckedState.Parent = this.BtnMember;
            this.BtnMember.CustomImages.Parent = this.BtnMember;
            this.BtnMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMember.DisabledState.Parent = this.BtnMember;
            this.BtnMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMember.ForeColor = System.Drawing.Color.White;
            this.BtnMember.HoverState.Parent = this.BtnMember;
            this.BtnMember.Location = new System.Drawing.Point(545, 2);
            this.BtnMember.Name = "BtnMember";
            this.BtnMember.ShadowDecoration.Parent = this.BtnMember;
            this.BtnMember.Size = new System.Drawing.Size(124, 45);
            this.BtnMember.TabIndex = 5;
            this.BtnMember.Text = "會員維護";
            this.BtnMember.Click += new System.EventHandler(this.BtnMember_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BorderRadius = 21;
            this.BtnDoctor.CheckedState.Parent = this.BtnDoctor;
            this.BtnDoctor.CustomImages.Parent = this.BtnDoctor;
            this.BtnDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDoctor.DisabledState.Parent = this.BtnDoctor;
            this.BtnDoctor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.ForeColor = System.Drawing.Color.White;
            this.BtnDoctor.HoverState.Parent = this.BtnDoctor;
            this.BtnDoctor.Location = new System.Drawing.Point(137, 2);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.ShadowDecoration.Parent = this.BtnDoctor;
            this.BtnDoctor.Size = new System.Drawing.Size(124, 45);
            this.BtnDoctor.TabIndex = 1;
            this.BtnDoctor.Text = "醫生維護";
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnArtcle
            // 
            this.BtnArtcle.BorderRadius = 21;
            this.BtnArtcle.CheckedState.Parent = this.BtnArtcle;
            this.BtnArtcle.CustomImages.Parent = this.BtnArtcle;
            this.BtnArtcle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnArtcle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnArtcle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnArtcle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnArtcle.DisabledState.Parent = this.BtnArtcle;
            this.BtnArtcle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArtcle.ForeColor = System.Drawing.Color.White;
            this.BtnArtcle.HoverState.Parent = this.BtnArtcle;
            this.BtnArtcle.Location = new System.Drawing.Point(407, 2);
            this.BtnArtcle.Name = "BtnArtcle";
            this.BtnArtcle.ShadowDecoration.Parent = this.BtnArtcle;
            this.BtnArtcle.Size = new System.Drawing.Size(124, 45);
            this.BtnArtcle.TabIndex = 3;
            this.BtnArtcle.Text = "文章維護";
            this.BtnArtcle.Click += new System.EventHandler(this.BtnArtcle_Click);
            // 
            // BtnShop
            // 
            this.BtnShop.BorderRadius = 21;
            this.BtnShop.CheckedState.Parent = this.BtnShop;
            this.BtnShop.CustomImages.Parent = this.BtnShop;
            this.BtnShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShop.DisabledState.Parent = this.BtnShop;
            this.BtnShop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShop.ForeColor = System.Drawing.Color.White;
            this.BtnShop.HoverState.Parent = this.BtnShop;
            this.BtnShop.Location = new System.Drawing.Point(272, 2);
            this.BtnShop.Name = "BtnShop";
            this.BtnShop.ShadowDecoration.Parent = this.BtnShop;
            this.BtnShop.Size = new System.Drawing.Size(124, 45);
            this.BtnShop.TabIndex = 1;
            this.BtnShop.Text = "商城維護";
            this.BtnShop.Click += new System.EventHandler(this.BtnShop_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanel.Location = new System.Drawing.Point(0, 50);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.ShadowDecoration.Parent = this.AdminPanel;
            this.AdminPanel.Size = new System.Drawing.Size(1107, 606);
            this.AdminPanel.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.siticonePanel1);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(1107, 656);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton BtnDashboard;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton BtnMember;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton BtnArtcle;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton BtnShop;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton BtnDoctor;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton BtnSchedule;
        private Siticone.Desktop.UI.WinForms.SiticonePanel AdminPanel;
    }
}
