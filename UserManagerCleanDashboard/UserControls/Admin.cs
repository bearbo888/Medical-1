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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            AdminPanel.Controls.Add(new Schedule());
            AdminPanel.Controls.Add(new DoctorMaintain());
            AdminPanel.Controls.Add(new DorctorCRUD());
            AdminPanel.Controls.Add(new Frm_Product_manage());
           // AdminPanel.Controls.Add(new Article_Back());
            AdminPanel.Controls.Add(new Article_BackCRUD());
            AdminPanel.Controls.Add(new MemberCenter_Admin());
            AdminPanel.Controls.Add(new Dashboard());
        }

        private void BtnClinic_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(new Schedule());
            AdminPanel.Controls.Find("Schedule", false)[0].BringToFront();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(new DoctorMaintain());
            AdminPanel.Controls.Find("DoctorMaintain", false)[0].BringToFront();
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(new Frm_Product_manage());
            AdminPanel.Controls.Find("Frm_Product_manage", false)[0].BringToFront();
        }

        private void BtnArtcle_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(new Article_Back());
            AdminPanel.Controls.Find("Article_Back", false)[0].BringToFront();
        }

        private void BtnMember_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(new MemberCenter_Admin());
            AdminPanel.Controls.Find("MemberCenter_Admin", false)[0].BringToFront();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(new Dashboard());
            AdminPanel.Controls.Find("Dashboard", false)[0].BringToFront();
        }
    }
}
