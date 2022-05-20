
namespace Medical.UserControls
{
    partial class Article_BackCRUD
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
            this.txt_backtitle = new System.Windows.Forms.TextBox();
            this.txt_backcontent = new System.Windows.Forms.TextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lab_content = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel_BackCRUD = new System.Windows.Forms.Panel();
            this.cmb_chooseDcotor = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label_backCRUD_Doctor = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_BackCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_backtitle
            // 
            this.txt_backtitle.Location = new System.Drawing.Point(147, 99);
            this.txt_backtitle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_backtitle.Multiline = true;
            this.txt_backtitle.Name = "txt_backtitle";
            this.txt_backtitle.Size = new System.Drawing.Size(308, 39);
            this.txt_backtitle.TabIndex = 20;
            // 
            // txt_backcontent
            // 
            this.txt_backcontent.Location = new System.Drawing.Point(143, 173);
            this.txt_backcontent.Margin = new System.Windows.Forms.Padding(4);
            this.txt_backcontent.Multiline = true;
            this.txt_backcontent.Name = "txt_backcontent";
            this.txt_backcontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_backcontent.Size = new System.Drawing.Size(628, 302);
            this.txt_backcontent.TabIndex = 19;
            // 
            // btn_return
            // 
            this.btn_return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_return.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_return.Location = new System.Drawing.Point(543, 492);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(94, 42);
            this.btn_return.TabIndex = 18;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(329, 492);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 42);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OK.Location = new System.Drawing.Point(143, 492);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(153, 42);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "確定新增";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lab_content
            // 
            this.lab_content.AutoSize = true;
            this.lab_content.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_content.Location = new System.Drawing.Point(55, 164);
            this.lab_content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_content.Name = "lab_content";
            this.lab_content.Size = new System.Drawing.Size(63, 24);
            this.lab_content.TabIndex = 15;
            this.lab_content.Text = "內文 : ";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_title.Location = new System.Drawing.Point(11, 90);
            this.lab_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(101, 24);
            this.lab_title.TabIndex = 14;
            this.lab_title.Text = "文章標題 : ";
            // 
            // panel_BackCRUD
            // 
            this.panel_BackCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_BackCRUD.Controls.Add(this.treeView1);
            this.panel_BackCRUD.Controls.Add(this.cmb_chooseDcotor);
            this.panel_BackCRUD.Controls.Add(this.label_backCRUD_Doctor);
            this.panel_BackCRUD.Controls.Add(this.txt_backcontent);
            this.panel_BackCRUD.Controls.Add(this.txt_backtitle);
            this.panel_BackCRUD.Controls.Add(this.lab_title);
            this.panel_BackCRUD.Controls.Add(this.lab_content);
            this.panel_BackCRUD.Controls.Add(this.btn_return);
            this.panel_BackCRUD.Controls.Add(this.btn_OK);
            this.panel_BackCRUD.Controls.Add(this.btn_cancel);
            this.panel_BackCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BackCRUD.Location = new System.Drawing.Point(0, 0);
            this.panel_BackCRUD.Name = "panel_BackCRUD";
            this.panel_BackCRUD.Size = new System.Drawing.Size(913, 663);
            this.panel_BackCRUD.TabIndex = 21;
            // 
            // cmb_chooseDcotor
            // 
            this.cmb_chooseDcotor.BackColor = System.Drawing.Color.Transparent;
            this.cmb_chooseDcotor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_chooseDcotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chooseDcotor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_chooseDcotor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_chooseDcotor.FocusedState.Parent = this.cmb_chooseDcotor;
            this.cmb_chooseDcotor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_chooseDcotor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_chooseDcotor.HoverState.Parent = this.cmb_chooseDcotor;
            this.cmb_chooseDcotor.ItemHeight = 30;
            this.cmb_chooseDcotor.ItemsAppearance.Parent = this.cmb_chooseDcotor;
            this.cmb_chooseDcotor.Location = new System.Drawing.Point(147, 27);
            this.cmb_chooseDcotor.Name = "cmb_chooseDcotor";
            this.cmb_chooseDcotor.ShadowDecoration.Parent = this.cmb_chooseDcotor;
            this.cmb_chooseDcotor.Size = new System.Drawing.Size(223, 36);
            this.cmb_chooseDcotor.TabIndex = 25;
            // 
            // label_backCRUD_Doctor
            // 
            this.label_backCRUD_Doctor.AutoSize = true;
            this.label_backCRUD_Doctor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_backCRUD_Doctor.Location = new System.Drawing.Point(60, 32);
            this.label_backCRUD_Doctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_backCRUD_Doctor.Name = "label_backCRUD_Doctor";
            this.label_backCRUD_Doctor.Size = new System.Drawing.Size(58, 24);
            this.label_backCRUD_Doctor.TabIndex = 21;
            this.label_backCRUD_Doctor.Text = "醫生 :";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(473, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(298, 163);
            this.treeView1.TabIndex = 56;
            // 
            // Article_BackCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Controls.Add(this.panel_BackCRUD);
            this.Name = "Article_BackCRUD";
            this.Size = new System.Drawing.Size(913, 663);
            this.panel_BackCRUD.ResumeLayout(false);
            this.panel_BackCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txt_backtitle;
        internal System.Windows.Forms.TextBox txt_backcontent;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lab_content;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Panel panel_BackCRUD;
        private System.Windows.Forms.Label label_backCRUD_Doctor;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmb_chooseDcotor;
        private System.Windows.Forms.TreeView treeView1;
    }
}
