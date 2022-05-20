using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical.UserControls
{
    public partial class Article_Back : UserControl
    {
        MedicalEntities medicalContext = new MedicalEntities();
        public Article_Back()
        {
            InitializeComponent();
            //設定按字型來縮放控制元件
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //設定字型大小為12px
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            LoadAdTitle();
            LoadDoctorNameToComboBox();
        }

        private void LoadDoctorNameToComboBox()
        {
            var q = from a in medicalContext.Doctors
                    select a.DoctorName;
            foreach (var item in q.Distinct())
            {
                cmb_backDoctor.Items.Add(item);
            }
        }

        private void LoadAdTitle()
        {
            var q = from a in medicalContext.Articles
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };
            dataG_showdata.DataSource = q.ToList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string word = txt_Search.Text;

            var q = from a in medicalContext.Articles
                    where a.Articeltitle.Contains(word)
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };
            dataG_showdata.DataSource = q.ToList();
        }

        private void btn_refill_Click(object sender, EventArgs e)
        {
            LoadAdTitle();
        }

        private void dataG_showdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string adtitle = dataG_showdata.Rows[e.RowIndex].Cells[1].Value.ToString();//標題、疾病名
            string doctorName = dataG_showdata.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (e.RowIndex >= 0)
            {
                txt_title.Text = adtitle;
                txt_backShowDoctorName.Text = doctorName;
                var q = from a in medicalContext.Articles
                        where a.Articeltitle == adtitle
                        select a.ArticleContent;
                foreach (var c in q)
                {
                    txt_content.Text = c;
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControls.Article_BackCRUD());
            this.Controls.Find("Article_BackCRUD", false)[0].BringToFront();
        }
        private void Read_RefreshDataGridView()
        {
            dataG_showdata.DataSource = null;
            LoadAdTitle();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var q = (from b in this.medicalContext.Articles
                     where b.Articeltitle == txt_title.Text
                     select b).FirstOrDefault();

            DialogResult result = MessageBox.Show("確定永久刪除此資料嗎?", "警告!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                medicalContext.Articles.Remove(q);
                medicalContext.SaveChanges();
                Read_RefreshDataGridView();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            var q = (from a in this.medicalContext.Articles
                     where a.Doctor.DoctorName == txt_backShowDoctorName.Text
                     select a).FirstOrDefault();
            if (q == null) return;
            DialogResult result = MessageBox.Show("確定修改此資料嗎?", "警告!!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                q.Articeltitle = txt_title.Text;
                q.ArticleContent = txt_content.Text;
                q.Doctor.DoctorName = txt_backShowDoctorName.Text;
                medicalContext.SaveChanges();
                Read_RefreshDataGridView();
            }
        }

        private void btn_backrefill_Click(object sender, EventArgs e)
        {
            LoadAdTitle();
        }

        private void cmb_backDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from a in medicalContext.Articles
                    where a.Doctor.DoctorName == cmb_backDoctor.Text
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };

            dataG_showdata.DataSource = q.ToList();
        }

        private void txt_content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
