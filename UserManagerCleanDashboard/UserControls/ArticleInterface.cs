using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical.UserControls
{
    public partial class ArticleInterface : UserControl
    {
        public ArticleInterface()
        {
            InitializeComponent();
            LoadArticleData();

        }

        private void LoadNewsData()
        {
            var q = from n in medicalContext.News
                    select new
                    {
                        n.CreateDate,
                        n.NewsTitle,
                        
                    };
            dataG_News.DataSource = q.ToList();
        }

        MedicalEntities medicalContext = new MedicalEntities();
        private void LoadArticleData()
        {
            var q = from a in medicalContext.Articles
                    orderby a.CreateDate descending
                    select new
                    {
                        a.CreateDate,
                        a.Articeltitle

                    };
            
            dataG_News.DataSource = q.ToList();
        }


        
        private void btn_News_Click_1(object sender, EventArgs e)
        {
            btn_HospitalNews.FillColor = Color.FromArgb(255, 224, 192);
            
            btn_News.FillColor = Color.DarkCyan;
                LoadNewsData();
            
          


        }

        private void btn_HospitalNews_Click(object sender, EventArgs e)
        {
            btn_News.FillColor = Color.FromArgb(255, 224, 192);
            btn_HospitalNews.FillColor = Color.DarkCyan;
            LoadArticleData();
        }


        private void ChangeImage(Image img, int millisecondsTimeOut)
        {
            this.Invoke(new Action(() =>
            {
                pictureBox1.Image = img;
            })
                );
            Thread.Sleep(millisecondsTimeOut);
        }

        Thread th;


        private void ArticleInterface_Load_1(object sender, EventArgs e)
        {
            th = new Thread
               (
                   delegate ()
                   {
                       //3就是要迴圈輪數了
                       for (int i = 0; i < 60; i++)
                       {
                           //呼叫方法
                           //設定圖片的位置和顯示時間（1000 為1秒）
                           ChangeImage(Image.FromFile("111.jpg"), 1000);
                           ChangeImage(Image.FromFile("222.jpg"), 1000);

                           //ChangeImage(Image.FromFile(), 1000);
                           //ChangeImage(Image.FromFile(@"C:\Users\User\Desktop\新增資料夾\222.jpg"), 1000);

                       }
                   }
               );
            th.IsBackground = true;
            th.Start();
        }

        private void dataG_News_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string adtitle = dataG_News.Rows[e.RowIndex].Cells[1].Value.ToString();//標題、疾病名

           // int value = (int)dataG_News.Rows[e.RowIndex].Cells[0].Value;//AdminID

            if (e.ColumnIndex >= 0)
            {
                this.Controls.Clear();
                this.Controls.Add(new UserControls.Article_FrontShow(adtitle));
                this.Controls.Find("Article_FrontShow", false)[0].BringToFront();

            }
        }
 
        private void ArticleInterface_Leave(object sender, EventArgs e)
        {
            th.Abort();//結束執行緒
            
        }
    }
}
