
namespace Medical.UserControls
{
    partial class DoctorRating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneDataGridView_Rating = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneButton_all = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton_five = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton_four = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton_three = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton_two = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButton_one = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label_RatingTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(256, 398);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton1.TabIndex = 17;
            this.siticoneButton1.Text = "退出評論";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneDataGridView_Rating
            // 
            this.siticoneDataGridView_Rating.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView_Rating.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.siticoneDataGridView_Rating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siticoneDataGridView_Rating.BackgroundColor = System.Drawing.Color.White;
            this.siticoneDataGridView_Rating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneDataGridView_Rating.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView_Rating.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView_Rating.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.siticoneDataGridView_Rating.ColumnHeadersHeight = 20;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView_Rating.DefaultCellStyle = dataGridViewCellStyle6;
            this.siticoneDataGridView_Rating.EnableHeadersVisualStyles = false;
            this.siticoneDataGridView_Rating.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView_Rating.Location = new System.Drawing.Point(103, 166);
            this.siticoneDataGridView_Rating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneDataGridView_Rating.Name = "siticoneDataGridView_Rating";
            this.siticoneDataGridView_Rating.RowHeadersVisible = false;
            this.siticoneDataGridView_Rating.RowHeadersWidth = 51;
            this.siticoneDataGridView_Rating.RowTemplate.Height = 27;
            this.siticoneDataGridView_Rating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siticoneDataGridView_Rating.Size = new System.Drawing.Size(452, 214);
            this.siticoneDataGridView_Rating.TabIndex = 16;
            this.siticoneDataGridView_Rating.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView_Rating.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView_Rating.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView_Rating.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView_Rating.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView_Rating.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView_Rating.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView_Rating.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView_Rating.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView_Rating.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView_Rating.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.siticoneDataGridView_Rating.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView_Rating.ThemeStyle.HeaderStyle.Height = 20;
            this.siticoneDataGridView_Rating.ThemeStyle.ReadOnly = false;
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.Height = 27;
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.siticoneDataGridView_Rating.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticoneButton_all
            // 
            this.siticoneButton_all.CheckedState.Parent = this.siticoneButton_all;
            this.siticoneButton_all.CustomImages.Parent = this.siticoneButton_all;
            this.siticoneButton_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_all.DisabledState.Parent = this.siticoneButton_all;
            this.siticoneButton_all.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton_all.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_all.HoverState.Parent = this.siticoneButton_all;
            this.siticoneButton_all.Location = new System.Drawing.Point(419, 99);
            this.siticoneButton_all.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton_all.Name = "siticoneButton_all";
            this.siticoneButton_all.ShadowDecoration.Parent = this.siticoneButton_all;
            this.siticoneButton_all.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton_all.TabIndex = 15;
            this.siticoneButton_all.Text = "所有評論";
            this.siticoneButton_all.Click += new System.EventHandler(this.siticoneButton_all_Click);
            // 
            // siticoneButton_five
            // 
            this.siticoneButton_five.CheckedState.Parent = this.siticoneButton_five;
            this.siticoneButton_five.CustomImages.Parent = this.siticoneButton_five;
            this.siticoneButton_five.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_five.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_five.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_five.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_five.DisabledState.Parent = this.siticoneButton_five;
            this.siticoneButton_five.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton_five.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_five.HoverState.Parent = this.siticoneButton_five;
            this.siticoneButton_five.Location = new System.Drawing.Point(266, 99);
            this.siticoneButton_five.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton_five.Name = "siticoneButton_five";
            this.siticoneButton_five.ShadowDecoration.Parent = this.siticoneButton_five;
            this.siticoneButton_five.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton_five.TabIndex = 14;
            this.siticoneButton_five.Text = "一顆星";
            this.siticoneButton_five.Click += new System.EventHandler(this.siticoneButton_one_Click);
            // 
            // siticoneButton_four
            // 
            this.siticoneButton_four.CheckedState.Parent = this.siticoneButton_four;
            this.siticoneButton_four.CustomImages.Parent = this.siticoneButton_four;
            this.siticoneButton_four.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_four.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_four.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_four.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_four.DisabledState.Parent = this.siticoneButton_four;
            this.siticoneButton_four.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton_four.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_four.HoverState.Parent = this.siticoneButton_four;
            this.siticoneButton_four.Location = new System.Drawing.Point(100, 99);
            this.siticoneButton_four.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton_four.Name = "siticoneButton_four";
            this.siticoneButton_four.ShadowDecoration.Parent = this.siticoneButton_four;
            this.siticoneButton_four.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton_four.TabIndex = 13;
            this.siticoneButton_four.Text = "二顆星";
            this.siticoneButton_four.Click += new System.EventHandler(this.siticoneButton_two_Click);
            // 
            // siticoneButton_three
            // 
            this.siticoneButton_three.CheckedState.Parent = this.siticoneButton_three;
            this.siticoneButton_three.CustomImages.Parent = this.siticoneButton_three;
            this.siticoneButton_three.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_three.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_three.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_three.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_three.DisabledState.Parent = this.siticoneButton_three;
            this.siticoneButton_three.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton_three.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_three.HoverState.Parent = this.siticoneButton_three;
            this.siticoneButton_three.Location = new System.Drawing.Point(419, 46);
            this.siticoneButton_three.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton_three.Name = "siticoneButton_three";
            this.siticoneButton_three.ShadowDecoration.Parent = this.siticoneButton_three;
            this.siticoneButton_three.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton_three.TabIndex = 12;
            this.siticoneButton_three.Text = "三顆星";
            this.siticoneButton_three.CheckedChanged += new System.EventHandler(this.siticoneButton_three_Click);
            // 
            // siticoneButton_two
            // 
            this.siticoneButton_two.CheckedState.Parent = this.siticoneButton_two;
            this.siticoneButton_two.CustomImages.Parent = this.siticoneButton_two;
            this.siticoneButton_two.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_two.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_two.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_two.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_two.DisabledState.Parent = this.siticoneButton_two;
            this.siticoneButton_two.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton_two.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_two.HoverState.Parent = this.siticoneButton_two;
            this.siticoneButton_two.Location = new System.Drawing.Point(266, 46);
            this.siticoneButton_two.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton_two.Name = "siticoneButton_two";
            this.siticoneButton_two.ShadowDecoration.Parent = this.siticoneButton_two;
            this.siticoneButton_two.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton_two.TabIndex = 11;
            this.siticoneButton_two.Text = "四顆星";
            this.siticoneButton_two.Click += new System.EventHandler(this.siticoneButton_three_Click);
            // 
            // siticoneButton_one
            // 
            this.siticoneButton_one.CheckedState.Parent = this.siticoneButton_one;
            this.siticoneButton_one.CustomImages.Parent = this.siticoneButton_one;
            this.siticoneButton_one.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_one.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton_one.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton_one.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton_one.DisabledState.Parent = this.siticoneButton_one;
            this.siticoneButton_one.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton_one.ForeColor = System.Drawing.Color.White;
            this.siticoneButton_one.HoverState.Parent = this.siticoneButton_one;
            this.siticoneButton_one.Location = new System.Drawing.Point(100, 46);
            this.siticoneButton_one.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneButton_one.Name = "siticoneButton_one";
            this.siticoneButton_one.ShadowDecoration.Parent = this.siticoneButton_one;
            this.siticoneButton_one.Size = new System.Drawing.Size(126, 38);
            this.siticoneButton_one.TabIndex = 10;
            this.siticoneButton_one.Text = "五顆星";
            this.siticoneButton_one.Click += new System.EventHandler(this.siticoneButton_five_Click);
            // 
            // label_RatingTitle
            // 
            this.label_RatingTitle.AutoSize = true;
            this.label_RatingTitle.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_RatingTitle.Location = new System.Drawing.Point(263, 14);
            this.label_RatingTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RatingTitle.Name = "label_RatingTitle";
            this.label_RatingTitle.Size = new System.Drawing.Size(59, 19);
            this.label_RatingTitle.TabIndex = 9;
            this.label_RatingTitle.Text = "label1";
            // 
            // DoctorRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneDataGridView_Rating);
            this.Controls.Add(this.siticoneButton_all);
            this.Controls.Add(this.siticoneButton_five);
            this.Controls.Add(this.siticoneButton_four);
            this.Controls.Add(this.siticoneButton_three);
            this.Controls.Add(this.siticoneButton_two);
            this.Controls.Add(this.siticoneButton_one);
            this.Controls.Add(this.label_RatingTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoctorRating";
            this.Text = "醫生評論";
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView_Rating;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_all;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_five;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_four;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_three;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_two;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton_one;
        private System.Windows.Forms.Label label_RatingTitle;
    }
}