
namespace Medical.UserControls
{
    partial class MyDoctor
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
            this.Header = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbDoctorID = new System.Windows.Forms.Label();
            this.BtnPatient = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnClinic = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Header.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Header.Controls.Add(this.siticoneButton1);
            this.Header.Controls.Add(this.lbDoctorID);
            this.Header.Controls.Add(this.BtnPatient);
            this.Header.Controls.Add(this.BtnClinic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.ShadowDecoration.Parent = this.Header;
            this.Header.Size = new System.Drawing.Size(1138, 52);
            this.Header.TabIndex = 1;
            // 
            // lbDoctorID
            // 
            this.lbDoctorID.AutoSize = true;
            this.lbDoctorID.Location = new System.Drawing.Point(980, 16);
            this.lbDoctorID.Name = "lbDoctorID";
            this.lbDoctorID.Size = new System.Drawing.Size(65, 19);
            this.lbDoctorID.TabIndex = 5;
            this.lbDoctorID.Text = "DoctorID";
            this.lbDoctorID.Visible = false;
            // 
            // BtnPatient
            // 
            this.BtnPatient.Animated = true;
            this.BtnPatient.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPatient.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnPatient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnPatient.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnPatient.CheckedState.Parent = this.BtnPatient;
            this.BtnPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPatient.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnPatient.CustomImages.Parent = this.BtnPatient;
            this.BtnPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPatient.DisabledState.Parent = this.BtnPatient;
            this.BtnPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.ForeColor = System.Drawing.Color.DimGray;
            this.BtnPatient.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnPatient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnPatient.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnPatient.HoverState.Parent = this.BtnPatient;
            this.BtnPatient.Location = new System.Drawing.Point(172, 2);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.PressedColor = System.Drawing.Color.White;
            this.BtnPatient.ShadowDecoration.Parent = this.BtnPatient;
            this.BtnPatient.Size = new System.Drawing.Size(154, 47);
            this.BtnPatient.TabIndex = 4;
            this.BtnPatient.Text = "我的病患";
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnClinic
            // 
            this.BtnClinic.Animated = true;
            this.BtnClinic.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnClinic.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnClinic.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnClinic.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnClinic.CheckedState.Parent = this.BtnClinic;
            this.BtnClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClinic.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnClinic.CustomImages.Parent = this.BtnClinic;
            this.BtnClinic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClinic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClinic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClinic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClinic.DisabledState.Parent = this.BtnClinic;
            this.BtnClinic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnClinic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClinic.ForeColor = System.Drawing.Color.DimGray;
            this.BtnClinic.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnClinic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnClinic.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnClinic.HoverState.Parent = this.BtnClinic;
            this.BtnClinic.Location = new System.Drawing.Point(12, 2);
            this.BtnClinic.Name = "BtnClinic";
            this.BtnClinic.PressedColor = System.Drawing.Color.White;
            this.BtnClinic.ShadowDecoration.Parent = this.BtnClinic;
            this.BtnClinic.Size = new System.Drawing.Size(154, 47);
            this.BtnClinic.TabIndex = 2;
            this.BtnClinic.Text = "我的門診";
            this.BtnClinic.Click += new System.EventHandler(this.BtnClinic_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.PanelSlider);
            this.siticonePanel1.Controls.Add(this.Header);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1138, 656);
            this.siticonePanel1.TabIndex = 2;
            // 
            // PanelSlider
            // 
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSlider.Location = new System.Drawing.Point(0, 52);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(1138, 604);
            this.PanelSlider.TabIndex = 2;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.DimGray;
            this.siticoneButton1.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.siticoneButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(332, 2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.White;
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(154, 47);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "醫生工作區";
            this.siticoneButton1.Visible = false;
            // 
            // MyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.siticonePanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyDoctor";
            this.Size = new System.Drawing.Size(1138, 656);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel Header;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelSlider;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnPatient;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnClinic;
        internal System.Windows.Forms.Label lbDoctorID;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}
