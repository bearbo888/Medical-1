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
    public partial class DoctorAddRating : UserControl
    {
        public static int doctorid { set; get; }

        MedicalEntities db = new MedicalEntities();
        //int DocIDrating = 1;    //ToDo撈醫生ID  要等於Complete傳來醫生ID 
        int docRatingType;                                       //參數.星數
        public DoctorAddRating()
        {

            InitializeComponent();
            
            MedicalEntities db = new MedicalEntities();
            var q = from d in db.Doctors
                    where d.DoctorID == doctorid
                    select d.DoctorName;

            this.lb_Rating.Text = "給" + q.FirstOrDefault() + "醫生建議與評價";
            cb_Rating.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Ratingtxt = txt_Ratingtxt.Text;
            docRatingType = Convert.ToInt32(cb_Rating.SelectedIndex+1);

            AddRatingtxt(doctorid, docRatingType, Ratingtxt);
        }   //按鈕.輸入醫師ID星數和評論

        private void AddRatingtxt(int i, int j, string k)
        {
            try 
            {
                var q = new RatingDoctor
                {
                    DoctorID = i,
                    RatingTypeID = j,
                    Rating = k
                };
                this.db.RatingDoctors.Add(q);
                db.SaveChanges();
                MessageBox.Show("謝謝您的建議");
                this.Controls.Clear();
                this.Controls.Add(new Complete());
                this.Controls.Find("Complete", false)[0].BringToFront();
            } 
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }

        }        //輸入結束後跳畫面

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Complete());
            this.Controls.Find("Complete", false)[0].BringToFront();
        } //回到上一頁
    }
}
