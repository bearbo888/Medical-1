
namespace Medical.UserControls
{
    partial class Treatment
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
            this.siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneHtmlLabel8
            // 
            this.siticoneHtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.siticoneHtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel8.Location = new System.Drawing.Point(321, 213);
            this.siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            this.siticoneHtmlLabel8.Size = new System.Drawing.Size(307, 91);
            this.siticoneHtmlLabel8.TabIndex = 18;
            this.siticoneHtmlLabel8.Text = "Treatment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneHtmlLabel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 508);
            this.panel1.TabIndex = 19;
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Treatment";
            this.Size = new System.Drawing.Size(905, 508);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private System.Windows.Forms.Panel panel1;
    }
}
