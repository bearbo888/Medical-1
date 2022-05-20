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
    public partial class ResetPassword : UserControl
    {
        public ResetPassword()
        {
            InitializeComponent();
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                ra += random.Next(0, 9);
            }
            lblRa.Text = ra.ToString();
        }
        MedicalEntities medicalContext = new MedicalEntities();

        string ra = "";
        bool cl = true;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string verify = this.txtVerify.Text;
            string id = txtId.Text;
            string email = txtMail.Text;

            

            if (cl == true)
            {
                if (verify != ra)
                {
                    MessageBox.Show("驗證碼錯誤");
                }
                else
                {
                    var q = from p in this.medicalContext.Members
                            where p.IdentityID == id && p.Email == email
                            select p;

                    if (q.Any())
                    {
                        this.txtId.Enabled = true;
                        this.lblEmail.Visible = false;
                        this.txtMail.Visible = false;
                        this.lblPassword.Visible = true;
                        this.txtPassword.Visible = true;
                        this.lblVerify.Visible = false;
                        this.txtVerify.Visible = false;
                        this.lblRa.Visible = false;

                        cl = !cl ;
                    }
                    else
                    {
                        MessageBox.Show("輸入資料有誤");
                    }
                }
            }
            else
            {
                var pd = (from ad in this.medicalContext.Members
                          where ad.IdentityID == id
                          select ad).FirstOrDefault();

                pd.Password = this.txtPassword.Text;

                this.medicalContext.SaveChanges();
                MessageBox.Show("修改成功");

                panel1.Controls.Clear();
                panel1.Controls.Add(new Logon());
                panel1.Controls.Find("Logon", false)[0].BringToFront();
            }


        }
    }
}
