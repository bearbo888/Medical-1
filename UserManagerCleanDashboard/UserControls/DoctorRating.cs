using Siticone.Desktop.UI.WinForms;
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
    public partial class DoctorRating : Form
    {
        public DoctorRating()
        {
            InitializeComponent();                     
        }
        public DoctorRating(object NAME)
        {
            InitializeComponent();
            AllRating(NAME);
            Addtitle(NAME);
                               
        }
        private void AllRating(object A)
        {
            var result = from r in medicalContext.RatingDoctors
                         where r.Doctor.DoctorName == A.ToString()
                         orderby r.RatingType.RatingTypeName descending
                         select new
                         {
                             所有評分 = r.RatingType.RatingTypeName,
                             評論 = r.Rating
                         };
            this.siticoneDataGridView_Rating.DataSource = result.ToList();
        }

        private  void Addtitle(object name)
        {
            var result1 = (from r in medicalContext.RatingDoctors
                           where r.Doctor.DoctorName==name.ToString()
                           select r).Count();


            this.label_RatingTitle.Text = name.ToString();// + "醫生共有" + result1 + "則評論";
        }

        MedicalEntities medicalContext = new MedicalEntities();
        private void siticoneButton_one_Click(object sender, EventArgs e)
        {
            //SiticoneRatingStar ratingStar;

            //Panel panel = new Panel();
            //panel.Width = 200;
            //panel.Height = 300;

           
            //panel.Controls.Add(ratingStar);

            var result = from r in medicalContext.RatingDoctors
                         where r.RatingType.RatingTypeName =="1" && 
                               r.Doctor.DoctorName== this.label_RatingTitle.Text
                         select new
                         {
                            
                             所有評分 = r.RatingType.RatingTypeName,
                             評論 = r.Rating
                         };
            this.siticoneDataGridView_Rating.DataSource = result.ToList();

        }

        private void siticoneButton_two_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton_three_Click(object sender, EventArgs e)
        {
            var result = from r in medicalContext.RatingDoctors
                         where r.RatingType.RatingTypeName == "3" && r.Doctor.DoctorName == this.label_RatingTitle.Text
                         select new
                         {
                             所有評分 = r.RatingType.RatingTypeName,
                             評論 = r.Rating
                         };
            this.siticoneDataGridView_Rating.DataSource = result.ToList();
        }

        private void siticoneButton_four_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton_five_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton_all_Click(object sender, EventArgs e)
        {
            var result = from r in medicalContext.RatingDoctors
                         where r.Doctor.DoctorName == this.label_RatingTitle.Text
                         orderby r.RatingType.RatingTypeName descending
                         select new
                         {
                             所有評分 = r.RatingType.RatingTypeName,
                             評論 = r.Rating
                         };
            this.siticoneDataGridView_Rating.DataSource = result.ToList();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
