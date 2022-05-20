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
    public partial class Article_BackCRUD : UserControl
    {
        public Article_BackCRUD()
        {
            InitializeComponent();
            ComboBoxToName();
            LoadDoctorNameToTreeView();
        }

        private void LoadDoctorNameToTreeView()
        {
            var q = from d in medicalContext.Doctors
                    select new
                    {
                        編號 = d.DoctorID,
                        醫生 = d.DoctorName
                    };
            foreach (var item in q)
            {
                treeView1.Nodes.Add(item.ToString());
            }
        }

        private void ComboBoxToName()
        {
            var q = from d in medicalContext.Doctors

                    select d.DoctorID;

            foreach (var item in q)
            {
                cmb_chooseDcotor.Items.Add(item);
            }
        }

        MedicalEntities medicalContext = new MedicalEntities();
        public Article_BackCRUD(string adtitle)
        {
            InitializeComponent();
            var q1 = from m in medicalContext.Articles
                     where m.Articeltitle == adtitle
                     select m.Articeltitle;
            foreach (var title in q1)
            {
                txt_backtitle.Text = title;
            }
            var q2 = from m in medicalContext.Articles
                     where m.Articeltitle == adtitle
                     select m.ArticleContent;
            foreach (var title in q2)
            {
                txt_backcontent.Text = title;
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.panel_BackCRUD.Controls.Clear();
            panel_BackCRUD.Controls.Add(new UserControls.Article_Back());
            panel_BackCRUD.Controls.Find("Article_Back", false)[0].BringToFront();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.panel_BackCRUD.Controls.Clear();
            panel_BackCRUD.Controls.Add(new UserControls.Article_Back());
            panel_BackCRUD.Controls.Find("Article_Back", false)[0].BringToFront();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            Article a = new Article
            {
                DoctorID = (int)cmb_chooseDcotor.SelectedItem,
                Articeltitle = txt_backtitle.Text,
                ArticleContent = txt_backcontent.Text,
                CreateDate = DateTime.Today
            };

            medicalContext.Articles.Add(a);
            medicalContext.SaveChanges();

            MessageBox.Show("新增完成");
            this.panel_BackCRUD.Controls.Clear();
            panel_BackCRUD.Controls.Add(new UserControls.Article_Back());
            panel_BackCRUD.Controls.Find("Article_Back", false)[0].BringToFront();

        }
        
    }

}
