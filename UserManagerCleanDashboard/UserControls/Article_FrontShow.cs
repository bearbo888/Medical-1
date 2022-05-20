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
    public partial class Article_FrontShow : UserControl
    {
        public Article_FrontShow()
        {
            InitializeComponent();
        }


        MedicalEntities medicalContext = new MedicalEntities();
        public Article_FrontShow(string adtitle)
        {
            InitializeComponent();


            var q1 = from a in medicalContext.Articles
                     where a.Articeltitle.Equals(adtitle)
                     select a.Articeltitle;


            foreach (var title in q1)
            {
                txt_fronttitle.Text = title.FirstOrDefault().ToString();
            }

            var q2 = from a in medicalContext.Articles
                     where a.Articeltitle == adtitle
                     select a.ArticleContent;

            foreach (var title in q2)
            {
                txt_frontcontent.Text = title;
            }
            var q3 = from a in medicalContext.Articles
                     where a.Articeltitle == adtitle
                     select a.Doctor.DoctorName;
            foreach (var title in q3)
            {
                txt_frontDoctorName.Text = title;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel_article_frontshow.Controls.Clear();
            panel_article_frontshow.Controls.Add(new UserControls.Article_User());
            panel_article_frontshow.Controls.Find("Article_User", false)[0].BringToFront();
        }


    }
}
