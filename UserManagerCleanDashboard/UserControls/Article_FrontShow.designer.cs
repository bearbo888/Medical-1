
namespace Medical.UserControls
{
    partial class Article_FrontShow
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
            this.lab_content = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel_article_frontshow = new System.Windows.Forms.Panel();
            this.txt_frontDoctorName = new System.Windows.Forms.TextBox();
            this.txt_frontcontent = new System.Windows.Forms.TextBox();
            this.txt_fronttitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.panel_article_frontshow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_content
            // 
            this.lab_content.AutoSize = true;
            this.lab_content.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_content.Location = new System.Drawing.Point(56, 168);
            this.lab_content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_content.Name = "lab_content";
            this.lab_content.Size = new System.Drawing.Size(80, 31);
            this.lab_content.TabIndex = 30;
            this.lab_content.Text = "內文 : ";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_title.Location = new System.Drawing.Point(12, 90);
            this.lab_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(128, 31);
            this.lab_title.TabIndex = 29;
            this.lab_title.Text = "文章標題 : ";
            // 
            // panel_article_frontshow
            // 
            this.panel_article_frontshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_article_frontshow.Controls.Add(this.txt_frontDoctorName);
            this.panel_article_frontshow.Controls.Add(this.txt_frontcontent);
            this.panel_article_frontshow.Controls.Add(this.txt_fronttitle);
            this.panel_article_frontshow.Controls.Add(this.label1);
            this.panel_article_frontshow.Controls.Add(this.button1);
            this.panel_article_frontshow.Controls.Add(this.lab_title);
            this.panel_article_frontshow.Controls.Add(this.lab_content);
            this.panel_article_frontshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_article_frontshow.Location = new System.Drawing.Point(0, 0);
            this.panel_article_frontshow.Name = "panel_article_frontshow";
            this.panel_article_frontshow.Size = new System.Drawing.Size(986, 598);
            this.panel_article_frontshow.TabIndex = 33;
            // 
            // txt_frontDoctorName
            // 
            this.txt_frontDoctorName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_frontDoctorName.Location = new System.Drawing.Point(148, 27);
            this.txt_frontDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_frontDoctorName.Multiline = true;
            this.txt_frontDoctorName.Name = "txt_frontDoctorName";
            this.txt_frontDoctorName.ReadOnly = true;
            this.txt_frontDoctorName.Size = new System.Drawing.Size(308, 39);
            this.txt_frontDoctorName.TabIndex = 39;
            // 
            // txt_frontcontent
            // 
            this.txt_frontcontent.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_frontcontent.Location = new System.Drawing.Point(144, 168);
            this.txt_frontcontent.Margin = new System.Windows.Forms.Padding(4);
            this.txt_frontcontent.Multiline = true;
            this.txt_frontcontent.Name = "txt_frontcontent";
            this.txt_frontcontent.ReadOnly = true;
            this.txt_frontcontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_frontcontent.Size = new System.Drawing.Size(650, 302);
            this.txt_frontcontent.TabIndex = 37;
            // 
            // txt_fronttitle
            // 
            this.txt_fronttitle.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_fronttitle.Location = new System.Drawing.Point(148, 94);
            this.txt_fronttitle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fronttitle.Multiline = true;
            this.txt_fronttitle.Name = "txt_fronttitle";
            this.txt_fronttitle.ReadOnly = true;
            this.txt_fronttitle.Size = new System.Drawing.Size(308, 39);
            this.txt_fronttitle.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "醫生 : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(655, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 65);
            this.button1.TabIndex = 35;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Article_FrontShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Controls.Add(this.panel_article_frontshow);
            this.Name = "Article_FrontShow";
            this.Size = new System.Drawing.Size(986, 598);
            this.panel_article_frontshow.ResumeLayout(false);
            this.panel_article_frontshow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lab_content;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Panel panel_article_frontshow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txt_frontDoctorName;
        internal System.Windows.Forms.TextBox txt_frontcontent;
        internal System.Windows.Forms.TextBox txt_fronttitle;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
    }
}
