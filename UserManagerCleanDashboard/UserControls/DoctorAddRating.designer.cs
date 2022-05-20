
namespace Medical.UserControls
{
    partial class DoctorAddRating
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Rating = new System.Windows.Forms.ComboBox();
            this.lb_Rating = new System.Windows.Forms.Label();
            this.txt_Ratingtxt = new System.Windows.Forms.TextBox();
            this.siticoneColorTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneColorTransition(this.components);
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.siticoneButton2);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.cb_Rating);
            this.panel1.Controls.Add(this.lb_Rating);
            this.panel1.Controls.Add(this.txt_Ratingtxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 764);
            this.panel1.TabIndex = 6;
            // 
            // cb_Rating
            // 
            this.cb_Rating.FormattingEnabled = true;
            this.cb_Rating.Items.AddRange(new object[] {
            "五顆星",
            "四顆星",
            "三顆星",
            "二顆星",
            "一顆星"});
            this.cb_Rating.Location = new System.Drawing.Point(32, 86);
            this.cb_Rating.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Rating.Name = "cb_Rating";
            this.cb_Rating.Size = new System.Drawing.Size(160, 23);
            this.cb_Rating.TabIndex = 5;
            // 
            // lb_Rating
            // 
            this.lb_Rating.AutoSize = true;
            this.lb_Rating.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Rating.Location = new System.Drawing.Point(28, 42);
            this.lb_Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Rating.Name = "lb_Rating";
            this.lb_Rating.Size = new System.Drawing.Size(110, 24);
            this.lb_Rating.TabIndex = 4;
            this.lb_Rating.Text = "提供建議";
            // 
            // txt_Ratingtxt
            // 
            this.txt_Ratingtxt.Location = new System.Drawing.Point(32, 128);
            this.txt_Ratingtxt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ratingtxt.Multiline = true;
            this.txt_Ratingtxt.Name = "txt_Ratingtxt";
            this.txt_Ratingtxt.Size = new System.Drawing.Size(733, 219);
            this.txt_Ratingtxt.TabIndex = 2;
            // 
            // siticoneColorTransition1
            // 
            this.siticoneColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            // 
            // siticoneButton1
            // 
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
            this.siticoneButton1.Location = new System.Drawing.Point(466, 375);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(127, 57);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "新增評論";
            this.siticoneButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siticoneButton2
            // 
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
            this.siticoneButton2.Location = new System.Drawing.Point(638, 375);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(127, 57);
            this.siticoneButton2.TabIndex = 7;
            this.siticoneButton2.Text = "取消";
            this.siticoneButton2.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // DoctorAddRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorAddRating";
            this.Size = new System.Drawing.Size(1483, 764);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Rating;
        private System.Windows.Forms.TextBox txt_Ratingtxt;
        private Siticone.Desktop.UI.WinForms.SiticoneColorTransition siticoneColorTransition1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.ComboBox cb_Rating;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}
