
namespace Medical.UserControls
{
    partial class FrmAddProd
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
            this.btnAddPic = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShelfDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtApperance = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picboxProduct = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(0, 12);
            this.btnAddPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(77, 39);
            this.btnAddPic.TabIndex = 9;
            this.btnAddPic.Text = "選擇照片";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(207, 115);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(133, 25);
            this.txtColor.TabIndex = 22;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "Hard",
            "Soft"});
            this.cmbMaterial.Location = new System.Drawing.Point(207, 184);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(104, 23);
            this.cmbMaterial.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cmbMaterial);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtShelfDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rtxtApperance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.picboxProduct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDemo);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.numericUpDownStock);
            this.panel1.Controls.Add(this.cmbCate);
            this.panel1.Controls.Add(this.cmbBrand);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.txtProdName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(106, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 493);
            this.panel1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "產品顏色:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "產品材質:";
            // 
            // txtShelfDate
            // 
            this.txtShelfDate.Location = new System.Drawing.Point(29, 398);
            this.txtShelfDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShelfDate.Name = "txtShelfDate";
            this.txtShelfDate.Size = new System.Drawing.Size(187, 25);
            this.txtShelfDate.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "保存期限:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "產品圖片:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "外觀描述:";
            // 
            // rtxtApperance
            // 
            this.rtxtApperance.Location = new System.Drawing.Point(374, 366);
            this.rtxtApperance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtApperance.Name = "rtxtApperance";
            this.rtxtApperance.Size = new System.Drawing.Size(343, 84);
            this.rtxtApperance.TabIndex = 6;
            this.rtxtApperance.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "庫存量:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "單價:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "種類:";
            // 
            // picboxProduct
            // 
            this.picboxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxProduct.Location = new System.Drawing.Point(374, 36);
            this.picboxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxProduct.Name = "picboxProduct";
            this.picboxProduct.Size = new System.Drawing.Size(322, 225);
            this.picboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxProduct.TabIndex = 12;
            this.picboxProduct.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "品牌:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.btnAddPic);
            this.groupBox1.Location = new System.Drawing.Point(433, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(284, 58);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Location = new System.Drawing.Point(80, 14);
            this.lblPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(204, 37);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "檔案名稱";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(245, 308);
            this.btnDemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(83, 38);
            this.btnDemo.TabIndex = 8;
            this.btnDemo.Text = "測試";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(245, 256);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(83, 38);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "新增產品";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(29, 326);
            this.numericUpDownStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownStock.TabIndex = 5;
            // 
            // cmbCate
            // 
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(29, 184);
            this.cmbCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(140, 23);
            this.cmbCate.TabIndex = 4;
            this.cmbCate.SelectionChangeCommitted += new System.EventHandler(this.cmbCate_SelectionChangeCommitted);
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(29, 115);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(104, 23);
            this.cmbBrand.TabIndex = 3;
            this.cmbBrand.SelectionChangeCommitted += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(29, 256);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(153, 25);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(29, 49);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(243, 25);
            this.txtProdName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "產品名稱:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 388);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "返回(需調整位置)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBackToPreviusPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(410, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "新增產品";
            // 
            // productBrandBindingSource
            // 
            this.productBrandBindingSource.DataMember = "ProductBrand";
            // 
            // FrmAddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddProd";
            this.Size = new System.Drawing.Size(1440, 823);
            this.Load += new System.EventHandler(this.FrmAddProd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBrandBindingSource;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.BindingSource medicalDataSetBindingSource;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShelfDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtApperance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picboxProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
