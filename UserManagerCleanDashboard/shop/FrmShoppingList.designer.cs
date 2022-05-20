
namespace Medical.UserControls
{
    partial class FrmShoppingList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ADD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reduce = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.ADD,
            this.reduce});
            this.dataGridView1.Location = new System.Drawing.Point(34, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(966, 448);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(422, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "購物車清單";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Medical.Product);
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::Medical.Properties.Resources.deleteIcon;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Width = 50;
            // 
            // ADD
            // 
            this.ADD.HeaderText = "";
            this.ADD.MinimumWidth = 6;
            this.ADD.Name = "ADD";
            this.ADD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ADD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ADD.Text = "+";
            this.ADD.UseColumnTextForButtonValue = true;
            this.ADD.Width = 50;
            // 
            // reduce
            // 
            this.reduce.HeaderText = "";
            this.reduce.MinimumWidth = 6;
            this.reduce.Name = "reduce";
            this.reduce.Text = "-";
            this.reduce.UseColumnTextForButtonValue = true;
            this.reduce.Width = 50;
            // 
            // FrmShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmShoppingList";
            this.Size = new System.Drawing.Size(1030, 654);
            this.Load += new System.EventHandler(this.FrmShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn ADD;
        private System.Windows.Forms.DataGridViewButtonColumn reduce;
    }
}
