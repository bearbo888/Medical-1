
namespace Medical.UserControls
{
    partial class DorctorCRUD
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
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.comboBox_MemberName = new System.Windows.Forms.ComboBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Demo = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_SaveChange = new System.Windows.Forms.Button();
            this.pictureBox_DorctorPicture = new System.Windows.Forms.PictureBox();
            this.button_borwse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Departemt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Education = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_DorctorJobTitle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Goback = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DorctorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneHtmlLabel2);
            this.panel1.Controls.Add(this.siticoneHtmlLabel1);
            this.panel1.Controls.Add(this.comboBox_MemberName);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.button_Demo);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_SaveChange);
            this.panel1.Controls.Add(this.pictureBox_DorctorPicture);
            this.panel1.Controls.Add(this.button_borwse);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox_Departemt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Education);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_DorctorJobTitle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_Goback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 689);
            this.panel1.TabIndex = 0;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.AutoSize = false;
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(13, 43);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(142, 29);
            this.siticoneHtmlLabel2.TabIndex = 58;
            this.siticoneHtmlLabel2.Text = "新增醫生";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(13, 9);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(103, 28);
            this.siticoneHtmlLabel1.TabIndex = 57;
            this.siticoneHtmlLabel1.Text = "醫生維護";
            // 
            // comboBox_MemberName
            // 
            this.comboBox_MemberName.FormattingEnabled = true;
            this.comboBox_MemberName.Items.AddRange(new object[] {
            "院長",
            "主治醫師",
            "一般醫師",
            "實習醫師"});
            this.comboBox_MemberName.Location = new System.Drawing.Point(121, 144);
            this.comboBox_MemberName.Name = "comboBox_MemberName";
            this.comboBox_MemberName.Size = new System.Drawing.Size(250, 23);
            this.comboBox_MemberName.TabIndex = 56;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(272, 91);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(41, 15);
            this.label_ID.TabIndex = 55;
            this.label_ID.Text = "label9";
            this.label_ID.Visible = false;
            // 
            // button_Demo
            // 
            this.button_Demo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button_Demo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Demo.Location = new System.Drawing.Point(720, 76);
            this.button_Demo.Name = "button_Demo";
            this.button_Demo.Size = new System.Drawing.Size(156, 110);
            this.button_Demo.TabIndex = 53;
            this.button_Demo.Text = "Demo";
            this.button_Demo.UseVisualStyleBackColor = false;
            this.button_Demo.Click += new System.EventHandler(this.button_Demo_Click);
            // 
            // button_update
            // 
            this.button_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_update.Location = new System.Drawing.Point(530, 371);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(106, 36);
            this.button_update.TabIndex = 54;
            this.button_update.Text = "修改";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_SaveChange
            // 
            this.button_SaveChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_SaveChange.Location = new System.Drawing.Point(418, 371);
            this.button_SaveChange.Name = "button_SaveChange";
            this.button_SaveChange.Size = new System.Drawing.Size(106, 36);
            this.button_SaveChange.TabIndex = 52;
            this.button_SaveChange.Text = "新增";
            this.button_SaveChange.UseVisualStyleBackColor = true;
            this.button_SaveChange.Click += new System.EventHandler(this.button_SaveChange_Click);
            // 
            // pictureBox_DorctorPicture
            // 
            this.pictureBox_DorctorPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_DorctorPicture.Location = new System.Drawing.Point(418, 249);
            this.pictureBox_DorctorPicture.Name = "pictureBox_DorctorPicture";
            this.pictureBox_DorctorPicture.Size = new System.Drawing.Size(240, 116);
            this.pictureBox_DorctorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_DorctorPicture.TabIndex = 51;
            this.pictureBox_DorctorPicture.TabStop = false;
            // 
            // button_borwse
            // 
            this.button_borwse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_borwse.Location = new System.Drawing.Point(418, 206);
            this.button_borwse.Name = "button_borwse";
            this.button_borwse.Size = new System.Drawing.Size(106, 36);
            this.button_borwse.TabIndex = 50;
            this.button_borwse.Text = "選擇檔案";
            this.button_borwse.UseVisualStyleBackColor = true;
            this.button_borwse.Click += new System.EventHandler(this.button_borwse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(412, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 49;
            this.label8.Text = "個人相片";
            // 
            // comboBox_Departemt
            // 
            this.comboBox_Departemt.FormattingEnabled = true;
            this.comboBox_Departemt.Location = new System.Drawing.Point(121, 342);
            this.comboBox_Departemt.Name = "comboBox_Departemt";
            this.comboBox_Departemt.Size = new System.Drawing.Size(250, 23);
            this.comboBox_Departemt.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(115, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 45;
            this.label6.Text = "醫學專長";
            // 
            // textBox_Education
            // 
            this.textBox_Education.Location = new System.Drawing.Point(121, 266);
            this.textBox_Education.Name = "textBox_Education";
            this.textBox_Education.Size = new System.Drawing.Size(250, 25);
            this.textBox_Education.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(115, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "學歷";
            // 
            // comboBox_DorctorJobTitle
            // 
            this.comboBox_DorctorJobTitle.FormattingEnabled = true;
            this.comboBox_DorctorJobTitle.Items.AddRange(new object[] {
            "院長",
            "主治醫師",
            "一般醫師",
            "實習醫師"});
            this.comboBox_DorctorJobTitle.Location = new System.Drawing.Point(121, 206);
            this.comboBox_DorctorJobTitle.Name = "comboBox_DorctorJobTitle";
            this.comboBox_DorctorJobTitle.Size = new System.Drawing.Size(250, 23);
            this.comboBox_DorctorJobTitle.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(115, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 41;
            this.label4.Text = "職位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(115, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "醫師姓名";
            // 
            // button_Goback
            // 
            this.button_Goback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Goback.Location = new System.Drawing.Point(747, 21);
            this.button_Goback.Name = "button_Goback";
            this.button_Goback.Size = new System.Drawing.Size(129, 40);
            this.button_Goback.TabIndex = 38;
            this.button_Goback.Text = "返回上一頁";
            this.button_Goback.UseVisualStyleBackColor = true;
            this.button_Goback.Click += new System.EventHandler(this.button_Goback_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DorctorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "DorctorCRUD";
            this.Size = new System.Drawing.Size(1148, 689);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DorctorPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Demo;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_SaveChange;
        private System.Windows.Forms.PictureBox pictureBox_DorctorPicture;
        private System.Windows.Forms.Button button_borwse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Departemt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Education;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_DorctorJobTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Goback;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_MemberName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.Label label_ID;
    }
}
