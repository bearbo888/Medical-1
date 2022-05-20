
namespace Medical.UserControls
{
    partial class FrmProductView
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnBuyNow = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbCount = new System.Windows.Forms.ComboBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCate = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowReviewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblShowRcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(980, 1084);
            this.splitContainer1.SplitterDistance = 484;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.btnBack);
            this.splitContainer2.Panel2.Controls.Add(this.btnBuyNow);
            this.splitContainer2.Panel2.Controls.Add(this.lblOut);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer2.Panel2.Controls.Add(this.cmbCount);
            this.splitContainer2.Panel2.Controls.Add(this.btnAddtoCart);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.lblStock);
            this.splitContainer2.Panel2.Controls.Add(this.lblCate);
            this.splitContainer2.Panel2.Controls.Add(this.lblBrand);
            this.splitContainer2.Panel2.Controls.Add(this.lblProductPrice);
            this.splitContainer2.Panel2.Controls.Add(this.lblProductName);
            this.splitContainer2.Size = new System.Drawing.Size(980, 484);
            this.splitContainer2.SplitterDistance = 397;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoRoundedCorners = true;
            this.btnBack.BorderRadius = 15;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(419, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(128, 32);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "返回商品首頁";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.AutoRoundedCorners = true;
            this.btnBuyNow.BorderRadius = 15;
            this.btnBuyNow.CheckedState.Parent = this.btnBuyNow;
            this.btnBuyNow.CustomImages.Parent = this.btnBuyNow;
            this.btnBuyNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuyNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuyNow.DisabledState.Parent = this.btnBuyNow;
            this.btnBuyNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuyNow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuyNow.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.HoverState.Parent = this.btnBuyNow;
            this.btnBuyNow.Location = new System.Drawing.Point(282, 430);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.ShadowDecoration.Parent = this.btnBuyNow;
            this.btnBuyNow.Size = new System.Drawing.Size(117, 32);
            this.btnBuyNow.TabIndex = 45;
            this.btnBuyNow.Text = "立即購買";
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // lblOut
            // 
            this.lblOut.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOut.ForeColor = System.Drawing.Color.Red;
            this.lblOut.Location = new System.Drawing.Point(150, 415);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(70, 23);
            this.lblOut.TabIndex = 44;
            this.lblOut.Text = "待補貨";
            this.lblOut.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "產品描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "庫存 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "產品類別 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "產品品牌 :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(161, 322);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(59, 15);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "unknown";
            // 
            // cmbCount
            // 
            this.cmbCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCount.FormattingEnabled = true;
            this.cmbCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCount.Location = new System.Drawing.Point(143, 416);
            this.cmbCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCount.Name = "cmbCount";
            this.cmbCount.Size = new System.Drawing.Size(84, 23);
            this.cmbCount.TabIndex = 37;
            this.cmbCount.SelectedIndexChanged += new System.EventHandler(this.cmbCount_SelectedIndexChanged);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddtoCart.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.Location = new System.Drawing.Point(282, 392);
            this.btnAddtoCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(117, 33);
            this.btnAddtoCart.TabIndex = 36;
            this.btnAddtoCart.Text = "加入購物車";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "數量 :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(161, 279);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(28, 15);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "100";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(161, 232);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(59, 15);
            this.lblCate.TabIndex = 33;
            this.lblCate.Text = "unknown";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(161, 186);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(59, 15);
            this.lblBrand.TabIndex = 32;
            this.lblBrand.Text = "unknown";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductPrice.Location = new System.Drawing.Point(80, 141);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(89, 20);
            this.lblProductPrice.TabIndex = 31;
            this.lblProductPrice.Text = "產品單價";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductName.Location = new System.Drawing.Point(80, 55);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(147, 33);
            this.lblProductName.TabIndex = 30;
            this.lblProductName.Text = "產品名稱";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.flowReviewPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 595);
            this.panel1.TabIndex = 0;
            // 
            // flowReviewPanel
            // 
            this.flowReviewPanel.BackColor = System.Drawing.Color.White;
            this.flowReviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowReviewPanel.Location = new System.Drawing.Point(0, 58);
            this.flowReviewPanel.Name = "flowReviewPanel";
            this.flowReviewPanel.Size = new System.Drawing.Size(980, 537);
            this.flowReviewPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.lblShowRcount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 58);
            this.panel2.TabIndex = 0;
            // 
            // lblShowRcount
            // 
            this.lblShowRcount.AutoSize = true;
            this.lblShowRcount.Location = new System.Drawing.Point(30, 21);
            this.lblShowRcount.Name = "lblShowRcount";
            this.lblShowRcount.Size = new System.Drawing.Size(78, 15);
            this.lblShowRcount.TabIndex = 0;
            this.lblShowRcount.Text = "共x項 評論";
            // 
            // FrmProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductView";
            this.Size = new System.Drawing.Size(980, 1084);
            this.Load += new System.EventHandler(this.FrmProductView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbCount;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblOut;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBuyNow;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblShowRcount;
        private System.Windows.Forms.FlowLayoutPanel flowReviewPanel;
    }
}
