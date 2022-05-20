
namespace Medical.UserControls
{
    partial class FrmCheck
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMemPhone = new System.Windows.Forms.TextBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMemName2 = new System.Windows.Forms.TextBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbhome = new System.Windows.Forms.RadioButton();
            this.rbCVS = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(51, 61);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(923, 421);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(923, 124);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtMemPhone);
            this.panel2.Controls.Add(this.cmbAddress);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtMemName2);
            this.panel2.Controls.Add(this.txtMemName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 193);
            this.panel2.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCheck.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(771, 130);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(129, 42);
            this.btnCheck.TabIndex = 24;
            this.btnCheck.Text = "結帳";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "繼續購物";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBackToShop_Click);
            // 
            // txtMemPhone
            // 
            this.txtMemPhone.Location = new System.Drawing.Point(253, 57);
            this.txtMemPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemPhone.Name = "txtMemPhone";
            this.txtMemPhone.Size = new System.Drawing.Size(147, 25);
            this.txtMemPhone.TabIndex = 23;
            // 
            // cmbAddress
            // 
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(460, 59);
            this.cmbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(108, 23);
            this.cmbAddress.TabIndex = 22;
            this.cmbAddress.SelectionChangeCommitted += new System.EventHandler(this.cmbAddress_SelectionChangeCommitted);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(631, 57);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(261, 25);
            this.txtAddress.TabIndex = 21;
            // 
            // txtMemName2
            // 
            this.txtMemName2.Location = new System.Drawing.Point(17, 143);
            this.txtMemName2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemName2.Name = "txtMemName2";
            this.txtMemName2.Size = new System.Drawing.Size(183, 25);
            this.txtMemName2.TabIndex = 20;
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(17, 57);
            this.txtMemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.ReadOnly = true;
            this.txtMemName.Size = new System.Drawing.Size(183, 25);
            this.txtMemName.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "配送地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "連絡電話";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "收件人";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "購買人";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblSum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 100);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCash);
            this.groupBox2.Controls.Add(this.rbCredit);
            this.groupBox2.Location = new System.Drawing.Point(355, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(277, 38);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(44, 12);
            this.rbCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(58, 19);
            this.rbCash.TabIndex = 9;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "現金";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(125, 12);
            this.rbCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(73, 19);
            this.rbCredit.TabIndex = 10;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "信用卡";
            this.rbCredit.UseVisualStyleBackColor = true;
            this.rbCredit.CheckedChanged += new System.EventHandler(this.rbCredit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbhome);
            this.groupBox1.Controls.Add(this.rbCVS);
            this.groupBox1.Location = new System.Drawing.Point(60, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 38);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rbhome
            // 
            this.rbhome.AutoSize = true;
            this.rbhome.Location = new System.Drawing.Point(29, 12);
            this.rbhome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbhome.Name = "rbhome";
            this.rbhome.Size = new System.Drawing.Size(58, 19);
            this.rbhome.TabIndex = 9;
            this.rbhome.TabStop = true;
            this.rbhome.Text = "宅配";
            this.rbhome.UseVisualStyleBackColor = true;
            this.rbhome.CheckedChanged += new System.EventHandler(this.rbhome_CheckedChanged);
            // 
            // rbCVS
            // 
            this.rbCVS.AutoSize = true;
            this.rbCVS.Location = new System.Drawing.Point(123, 12);
            this.rbCVS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCVS.Name = "rbCVS";
            this.rbCVS.Size = new System.Drawing.Size(88, 19);
            this.rbCVS.TabIndex = 10;
            this.rbCVS.TabStop = true;
            this.rbCVS.Text = "超商取貨";
            this.rbCVS.UseVisualStyleBackColor = true;
            this.rbCVS.CheckedChanged += new System.EventHandler(this.rbCVS_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(770, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "NT$";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSum.ForeColor = System.Drawing.Color.Red;
            this.lblSum.Location = new System.Drawing.Point(809, 35);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(82, 24);
            this.lblSum.TabIndex = 7;
            this.lblSum.Text = "總金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(685, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "總金額 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "付款方式 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "配送方式 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(443, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "結帳";
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmCheck";
            this.Size = new System.Drawing.Size(1043, 583);
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMemPhone;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMemName2;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbhome;
        private System.Windows.Forms.RadioButton rbCVS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
