
namespace Medical.UserControls
{
    partial class Frm_Product_manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.btnAddprod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showpic = new System.Windows.Forms.DataGridViewButtonColumn();
            this.adjustprod = new System.Windows.Forms.DataGridViewButtonColumn();
            this.discontinued = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showpic,
            this.adjustprod,
            this.discontinued});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 663);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmbCate);
            this.splitContainer2.Panel1.Controls.Add(this.cmbBrand);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddprod);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(1123, 798);
            this.splitContainer2.SplitterDistance = 131;
            this.splitContainer2.TabIndex = 3;
            // 
            // cmbCate
            // 
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(111, 85);
            this.cmbCate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(249, 23);
            this.cmbCate.TabIndex = 5;
            this.cmbCate.SelectedIndexChanged += new System.EventHandler(this.cmbCate_SelectedIndexChanged);
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(111, 35);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(249, 23);
            this.cmbBrand.TabIndex = 4;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // btnAddprod
            // 
            this.btnAddprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddprod.Location = new System.Drawing.Point(833, 36);
            this.btnAddprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddprod.Name = "btnAddprod";
            this.btnAddprod.Size = new System.Drawing.Size(122, 49);
            this.btnAddprod.TabIndex = 3;
            this.btnAddprod.Text = "新增產品";
            this.btnAddprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddprod.UseVisualStyleBackColor = true;
            this.btnAddprod.Click += new System.EventHandler(this.btnAddprod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "產品種類 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "產品品牌 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(486, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "產品列表";
            // 
            // showpic
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.showpic.DefaultCellStyle = dataGridViewCellStyle1;
            this.showpic.HeaderText = "顯示圖片";
            this.showpic.MinimumWidth = 6;
            this.showpic.Name = "showpic";
            this.showpic.Text = "查看圖片";
            this.showpic.UseColumnTextForButtonValue = true;
            this.showpic.Width = 80;
            // 
            // adjustprod
            // 
            this.adjustprod.HeaderText = "";
            this.adjustprod.MinimumWidth = 6;
            this.adjustprod.Name = "adjustprod";
            this.adjustprod.Text = "修改產品";
            this.adjustprod.UseColumnTextForButtonValue = true;
            this.adjustprod.Width = 80;
            // 
            // discontinued
            // 
            this.discontinued.HeaderText = "";
            this.discontinued.MinimumWidth = 6;
            this.discontinued.Name = "discontinued";
            this.discontinued.Text = "下架";
            this.discontinued.UseColumnTextForButtonValue = true;
            this.discontinued.Width = 80;
            // 
            // Frm_Product_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "Frm_Product_manage";
            this.Size = new System.Drawing.Size(1123, 798);
            this.Load += new System.EventHandler(this.Frm_Product_manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Button btnAddprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn showpic;
        private System.Windows.Forms.DataGridViewButtonColumn adjustprod;
        private System.Windows.Forms.DataGridViewButtonColumn discontinued;
    }
}
