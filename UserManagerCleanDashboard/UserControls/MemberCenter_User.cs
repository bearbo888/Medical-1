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
    public partial class MemberCenter_User : UserControl
    {
        public MemberCenter_User()
        {
            InitializeComponent();
            
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            if (MainPage.memberid > 0)
            {
                this.Controls.Clear();
                this.Controls.Add(new MemberUpdate());
                this.Controls.Find("MemberUpdate", false)[0].BringToFront();
            }
            else
            {
                MessageBox.Show("請先登入帳號");
                this.Controls.Clear();
                this.Controls.Add(new Logon());
                this.Controls.Find("Logon", false)[0].BringToFront();
            }
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (MainPage.memberid > 0)
            {
                this.Controls.Clear();
                this.Controls.Add(new CaseReview());
                this.Controls.Find("CaseReview", false)[0].BringToFront();
            }
            else
            {
                MessageBox.Show("請先登入帳號");
                this.Controls.Clear();
                this.Controls.Add(new Logon());
                this.Controls.Find("Logon", false)[0].BringToFront();
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("確定要登出?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MainPage.memberid = 0;
                MainPage.role = 0;
                MainPage.doctorid = 0;
                MainPage.hasAuth = false;
                this.Controls.Clear();
                this.Controls.Add(new Logon());
                this.Controls.Find("Logon", false)[0].BringToFront();
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (MainPage.memberid > 0)
            {
                this.Controls.Clear();
                this.Controls.Add(new FrmOrderdetail());
                this.Controls.Find("FrmOrderdetail", false)[0].BringToFront();
            }
            else
            {
                MessageBox.Show("請先登入帳號");
                this.Controls.Clear();
                this.Controls.Add(new Logon());
                this.Controls.Find("Logon", false)[0].BringToFront();
            }
        }
    }
}
