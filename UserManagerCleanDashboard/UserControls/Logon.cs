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
    
    public partial class Logon : UserControl
    {
       
        public static int memberid { get; set; }

        public Logon()
        {
            InitializeComponent();
        }


        MedicalEntities medicalContext = new MedicalEntities();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            
            var qry = medicalContext.Members.Where(x => x.IdentityID.Equals(txtName.Text.Trim()) && x.Password.Equals(txtPw.Text.Trim()));

            if (qry.Count() > 0)
            {
                MainPage.memberid = qry.First().MemberID;
                MainPage.role = (int)qry.First().Role;              
               
                if (MainPage.role == 2)
                {
                    MainPage.doctorid = medicalContext.Doctors.Where(x => x.MemberID == MainPage.memberid).Select(x => x.DoctorID).FirstOrDefault();

                    this.Controls.Clear();
                    this.Controls.Add(new MyDoctor());
                    this.Controls.Find("MyDoctor", false)[0].BringToFront();
                    MessageBox.Show("登入成功~" + "醫生歡迎回來!");
                    MainPage.hasAuth = true;
                }
                if (MainPage.role == 3)
                {                  
                    this.Controls.Clear();
                    this.Controls.Add(new Admin());
                    this.Controls.Find("Admin", false)[0].BringToFront();
                    MessageBox.Show("登入成功~" + "漢斯眼科歡迎回來!");
                    MainPage.hasAuth = true;
                }              
                if (MainPage.role == 1)
                {
                    this.Controls.Clear();
                    this.Controls.Add(new ArticleInterface());
                    this.Controls.Find("ArticleInterface", false)[0].BringToFront();
                    MessageBox.Show("登入成功~" + "歡迎回來!");
                    MainPage.hasAuth = true;
                }                                           
            }
           else
            {
                MessageBox.Show("登入失敗~請輸入正確資料");
            }                    
        }

        private void siticoneButton_Register_Click(object sender, EventArgs e)
        {
            siticonePanel2.Controls.Clear();
            siticonePanel2.Controls.Add(new Member_ADD());
            this.siticonePanel2.Controls.Find("Member_ADD", false)[0].BringToFront();
            
        }

        private void siticoneButton_ResetPassword_Click(object sender, EventArgs e)
        {
            siticonePanel2.Controls.Clear();
            siticonePanel2.Controls.Add(new ResetPassword());
            this.siticonePanel2.Controls.Find("ResetPassword", false)[0].BringToFront();
        }

        private void siticoneButton_demo_Click(object sender, EventArgs e)
        {
            //柯文哲
            txtName.Text = "a124865899";
            txtPw.Text = "851208";
        }

       
        private void siticoneButton_demo1_Click(object sender, EventArgs e)
        {
            //王世堅
            txtName.Text = "c124865897";
            txtPw.Text = "851208";
        }

        private void siticoneButton_demo3_Click(object sender, EventArgs e)
        {
            txtName.Text = "AAA";
            txtPw.Text = "AAA";
        }
    }
}
