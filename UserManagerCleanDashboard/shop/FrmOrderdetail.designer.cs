
namespace Medical.UserControls
{
    partial class FrmOrderdetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbacktoorder = new System.Windows.Forms.Button();
            this.buyagain = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productReview = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyagain,
            this.productReview});
            this.dataGridView1.Location = new System.Drawing.Point(39, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(843, 614);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(378, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "訂單明細";
            // 
            // btnbacktoorder
            // 
            this.btnbacktoorder.Location = new System.Drawing.Point(410, 720);
            this.btnbacktoorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbacktoorder.Name = "btnbacktoorder";
            this.btnbacktoorder.Size = new System.Drawing.Size(101, 49);
            this.btnbacktoorder.TabIndex = 10;
            this.btnbacktoorder.Text = "返回訂單";
            this.btnbacktoorder.UseVisualStyleBackColor = true;
            // 
            // buyagain
            // 
            this.buyagain.HeaderText = "";
            this.buyagain.MinimumWidth = 6;
            this.buyagain.Name = "buyagain";
            this.buyagain.Text = "再次購買";
            this.buyagain.UseColumnTextForButtonValue = true;
            this.buyagain.Width = 125;
            // 
            // productReview
            // 
            this.productReview.HeaderText = "產品評論";
            this.productReview.MinimumWidth = 6;
            this.productReview.Name = "productReview";
            this.productReview.Text = "新增評論";
            this.productReview.UseColumnTextForButtonValue = true;
            // 
            // FrmOrderdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbacktoorder);
            this.Name = "FrmOrderdetail";
            this.Size = new System.Drawing.Size(911, 692);
            this.Load += new System.EventHandler(this.FrmOrderdetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbacktoorder;
        private System.Windows.Forms.DataGridViewButtonColumn buyagain;
        private System.Windows.Forms.DataGridViewButtonColumn productReview;
    }
}
