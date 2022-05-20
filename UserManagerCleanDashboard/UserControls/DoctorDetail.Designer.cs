
namespace Medical.UserControls
{
    partial class DoctorDetail
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
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView_Doctor = new System.Windows.Forms.TreeView();
            this.siticoneButton1_goback = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label_TreatmentDetail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Department = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Education = new System.Windows.Forms.Label();
            this.label_學歷 = new System.Windows.Forms.Label();
            this.pictureBox_Dorctor = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dorctor)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Location = new System.Drawing.Point(457, 13);
            this.comboBox_Doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(171, 35);
            this.comboBox_Doctor.TabIndex = 0;
            this.comboBox_Doctor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Doctor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 586);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView_Doctor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.siticoneButton1_goback);
            this.splitContainer2.Panel2.Controls.Add(this.label_TreatmentDetail);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label_Department);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.label_Education);
            this.splitContainer2.Panel2.Controls.Add(this.label_學歷);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox_Dorctor);
            this.splitContainer2.Panel2.Controls.Add(this.label_name);
            this.splitContainer2.Size = new System.Drawing.Size(1207, 531);
            this.splitContainer2.SplitterDistance = 244;
            this.splitContainer2.TabIndex = 1;
            // 
            // treeView_Doctor
            // 
            this.treeView_Doctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Doctor.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.treeView_Doctor.Location = new System.Drawing.Point(0, 0);
            this.treeView_Doctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Doctor.Name = "treeView_Doctor";
            this.treeView_Doctor.Size = new System.Drawing.Size(244, 531);
            this.treeView_Doctor.TabIndex = 0;
            this.treeView_Doctor.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Doctor_NodeMouseClick);
            this.treeView_Doctor.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // siticoneButton1_goback
            // 
            this.siticoneButton1_goback.CheckedState.Parent = this.siticoneButton1_goback;
            this.siticoneButton1_goback.CustomImages.Parent = this.siticoneButton1_goback;
            this.siticoneButton1_goback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1_goback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1_goback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1_goback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1_goback.DisabledState.Parent = this.siticoneButton1_goback;
            this.siticoneButton1_goback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1_goback.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1_goback.HoverState.Parent = this.siticoneButton1_goback;
            this.siticoneButton1_goback.Location = new System.Drawing.Point(384, 21);
            this.siticoneButton1_goback.Name = "siticoneButton1_goback";
            this.siticoneButton1_goback.ShadowDecoration.Parent = this.siticoneButton1_goback;
            this.siticoneButton1_goback.Size = new System.Drawing.Size(159, 50);
            this.siticoneButton1_goback.TabIndex = 8;
            this.siticoneButton1_goback.Text = "上一頁";
            this.siticoneButton1_goback.Click += new System.EventHandler(this.siticoneButton1_goback_Click);
            // 
            // label_TreatmentDetail
            // 
            this.label_TreatmentDetail.AutoSize = true;
            this.label_TreatmentDetail.Location = new System.Drawing.Point(263, 280);
            this.label_TreatmentDetail.Name = "label_TreatmentDetail";
            this.label_TreatmentDetail.Size = new System.Drawing.Size(82, 28);
            this.label_TreatmentDetail.TabIndex = 7;
            this.label_TreatmentDetail.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(252, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "診療項目";
            // 
            // label_Department
            // 
            this.label_Department.AutoSize = true;
            this.label_Department.Location = new System.Drawing.Point(281, 146);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(216, 28);
            this.label_Department.TabIndex = 5;
            this.label_Department.Text = "label_Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(270, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "診療科別";
            // 
            // label_Education
            // 
            this.label_Education.AutoSize = true;
            this.label_Education.Location = new System.Drawing.Point(31, 275);
            this.label_Education.Name = "label_Education";
            this.label_Education.Size = new System.Drawing.Size(82, 28);
            this.label_Education.TabIndex = 3;
            this.label_Education.Text = "label2";
            // 
            // label_學歷
            // 
            this.label_學歷.AutoSize = true;
            this.label_學歷.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label_學歷.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_學歷.Location = new System.Drawing.Point(27, 226);
            this.label_學歷.Name = "label_學歷";
            this.label_學歷.Size = new System.Drawing.Size(70, 28);
            this.label_學歷.TabIndex = 2;
            this.label_學歷.Text = "學歷";
            // 
            // pictureBox_Dorctor
            // 
            this.pictureBox_Dorctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Dorctor.Location = new System.Drawing.Point(25, 58);
            this.pictureBox_Dorctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Dorctor.Name = "pictureBox_Dorctor";
            this.pictureBox_Dorctor.Size = new System.Drawing.Size(215, 143);
            this.pictureBox_Dorctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Dorctor.TabIndex = 1;
            this.pictureBox_Dorctor.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label_name.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(27, 21);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(70, 28);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DoctorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "DoctorDetail";
            this.Size = new System.Drawing.Size(1207, 586);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dorctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Doctor;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView_Doctor;
        private System.Windows.Forms.Label label_TreatmentDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Education;
        private System.Windows.Forms.Label label_學歷;
        private System.Windows.Forms.PictureBox pictureBox_Dorctor;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1_goback;
    }
}
