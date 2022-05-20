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
    public partial class Article_User : UserControl
    {
        public Article_User()
        {
            InitializeComponent();

            LoadAdTitle();
            LoadAdTitleToComboBox();
            LoadDoctorNameToComboBox();
            LoadDateToComboBox();
            SetDropDownWidth(cmb_adtitle);

        }

        private void LoadDateToComboBox()
        {
            var q = from a in medicalContext.Articles
                    group a by a.CreateDate.Value.Year into g
                    orderby g.Key
                    select g.Key;
            foreach (var item in q.Distinct())
            {
                cmb_year.Items.Add(item);
            }
        }

        private void LoadDoctorNameToComboBox()
        {
            var q = from a in medicalContext.Articles
                    select a.Doctor.DoctorName;
            foreach (var item in q.Distinct())
            {
                cmb_doctor.Items.Add(item);

            }
        }

        private void LoadAdTitleToComboBox()
        {
            var q = from a in medicalContext.Articles
                    select a.Articeltitle;
            foreach (var item in q)
            {
                cmb_adtitle.Items.Add(item);
            }
        }

        MedicalEntities medicalContext = new MedicalEntities();
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

            dataG_show.DataSource = q.ToList();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string word = txt_disease.Text.Trim();

            var q = from a in medicalContext.Articles
                    where a.Articeltitle.Contains(word)
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };

            dataG_show.DataSource = q.ToList();
        }



        private void btn_refill_Click(object sender, EventArgs e)
        {
            LoadAdTitle();
        }

        private void dataG_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string adtitle = dataG_show.Rows[e.RowIndex].Cells[1].Value.ToString();//標題、疾病名

                // int value = (int)dataG_show.Rows[e.RowIndex].Cells[0].Value;//AdminID

                if (e.RowIndex >= 0)
                {
                    this.Controls.Clear();
                    this.Controls.Add(new UserControls.Article_FrontShow(adtitle));
                    this.Controls.Find("Article_FrontShow", false)[0].BringToFront();

                }
            }
        }

        private void SetDropDownWidth(ComboBox myCombo)
        {
            int maxSize = 0;
            System.Drawing.Graphics g = CreateGraphics();

            for (int i = 0; i < myCombo.Items.Count; i++)
            {
                myCombo.SelectedIndex = i;
                SizeF size = g.MeasureString(myCombo.Text, myCombo.Font);

                if (maxSize < (int)size.Width)
                {
                    maxSize = (int)size.Width;
                }
            }

            //if (myCombo.Width < maxSize)
            //{
            //    myCombo.Width = maxSize+100;
            //}


            myCombo.DropDownWidth = myCombo.Width;
            if (myCombo.DropDownWidth < maxSize)
            {
                myCombo.DropDownWidth = maxSize;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            //this.panel_all.Controls.Clear();
            //panel_all.Controls.Add(new UserControls.Article_BackCRUD());
            //panel_all.Controls.Find("Article_BackCRUD", false)[0].BringToFront();
        }
        private void Read_RefreshDataGridView()
        {

            LoadAdTitle();
        }





        private void btn_backrefill_Click(object sender, EventArgs e)
        {
            LoadAdTitle();
        }

        private void cmb_adtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from a in medicalContext.Articles
                    where a.Articeltitle == cmb_adtitle.Text
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };

            dataG_show.DataSource = q.ToList();

        }

        private void cmb_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from a in medicalContext.Articles
                    where a.Doctor.DoctorName == cmb_doctor.Text
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };

            dataG_show.DataSource = q.ToList();
        }

        

        private void cmb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from a in medicalContext.Articles
                    where a.CreateDate.Value.Year == (int)cmb_year.SelectedItem
                    select new
                    {
                        篇數 = a.ArticleID,
                        疾病名 = a.Articeltitle,
                        醫生 = a.Doctor.DoctorName,
                        日期 = a.CreateDate
                    };
            dataG_show.DataSource = q.ToList();
        }
    }
}
