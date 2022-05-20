using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using Medical.UserControls;

namespace Medical
{
    public partial class MainPage:Form
    {

        bool silderEXpand;
        public static int memberid { get; set;}
        public static int role { get; set; }
        public static int doctorid { get; set; }

        public static bool hasAuth { get; set ; }
        public MainPage()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
            new SiticoneDragControl(TopHeader);
            new SiticoneDragControl(DragPanel);

            // add controls
            PanelSlider.Controls.Add(new ArticleInterface());
            PanelSlider.Controls.Add(new Logon());
            PanelSlider.Controls.Add(new Notifications());
            PanelSlider.Controls.Add(new FrmShoppingList());
            PanelSlider.Controls.Add(new MemberCenter_Admin());
            PanelSlider.Controls.Add(new MemberCenter_User());
            PanelSlider.Controls.Add(new UserControls.ReserveMain());
            PanelSlider.Controls.Add(new Clinic());
            PanelSlider.Controls.Add(new UserControls.Treatment());
            PanelSlider.Controls.Add(new DoctorTeam());
            PanelSlider.Controls.Add(new MyDoctor());
            PanelSlider.Controls.Add(new Store());
            PanelSlider.Controls.Add(new Info());
            PanelSlider.Controls.Add(new UserControls.Article_User());
            PanelSlider.Controls.Add(new DoctorMaintain());
            PanelSlider.Controls.Add(new Dashboard());           
            PanelSlider.Controls.Add(new ArticleInterface());
            PanelSlider.Controls.Add(new Complete());
            PanelSlider.Controls.Add(new Admin());
            

        }

        internal void UISwitch(string ui, bool isSideNav)
        {
            switch (ui)
            {
                case "Dashboard":
                    PanelSlider.Controls.Find("Dashboard", false)[0].BringToFront();
                    break;
                case "Logon":
                    PanelSlider.Controls.Find("Logon", false)[0].BringToFront();
                    break;
                case "Notifications":
                    PanelSlider.Controls.Find("Notifications", false)[0].BringToFront();
                    break;
                case "FrmShoppingList":
                    PanelSlider.Controls.Find("FrmShoppingList", false)[0].BringToFront();
                    break;
                case "MemberCenter":
                    PanelSlider.Controls.Find("MemberCenter", false)[0].BringToFront();
                    break;
                case "ReserveMain":
                    PanelSlider.Controls.Find("ReserveMain", false)[0].BringToFront();
                    break;
                case "Clinic":
                    PanelSlider.Controls.Find("Clinic", false)[0].BringToFront();
                    break;
                case "Treatment":
                    PanelSlider.Controls.Find("Treatment", false)[0].BringToFront();
                    break;
                case "DoctorTeam":
                    PanelSlider.Controls.Find("DoctorTeam", false)[0].BringToFront();
                    break;
                case "Store":
                    PanelSlider.Controls.Find("Store", false)[0].BringToFront();
                    break;
                case "MyDoctor":
                    PanelSlider.Controls.Find("MyDoctor", false)[0].BringToFront();
                    break;
                case "Info":
                    PanelSlider.Controls.Find("Info", false)[0].BringToFront();
                    break;
                case "Article":
                    PanelSlider.Controls.Find("Article_User", false)[0].BringToFront();
                    break;
                case "DoctorMaintain":
                    PanelSlider.Controls.Find("DoctorMaintain", false)[0].BringToFront();
                    break;
                case "MemberCenter_User":
                    PanelSlider.Controls.Find("MemberCenter_User", false)[0].BringToFront();
                    break;
                case "Back":
                    PanelSlider.Controls.Find("Back", false)[0].BringToFront();
                    break;
                case "ArticleInterface":
                    PanelSlider.Controls.Find("ArticleInterface", false)[0].BringToFront();
                    break;
                case "Complete":
                    PanelSlider.Controls.Find("Complete", false)[0].BringToFront();
                    break;
                case "Admin":
                    PanelSlider.Controls.Find("Admin", false)[0].BringToFront();
                    break;


            }

            switch (isSideNav)
            {
                case true:
                    foreach (SiticoneButton button in DragPanel.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
                default:
                    foreach (SiticoneButton button in SideNavButtonContainer.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (silderEXpand)
            {
                if(SideNav.Width == SideNav.MinimumSize.Width)
                {
                    silderEXpand = false;
                    timer1.Stop();
                }
                else
                {
                    SideNav.Width -= 10;
                    PanelSlider.Width += 10;
                }
            }
            else
            {
                if (SideNav.Width == SideNav.MaximumSize.Width)
                {
                    silderEXpand = true;
                    timer1.Stop();
                }
                else
                {
                    PanelSlider.Width -= 10;
                    SideNav.Width += 10;
                }
            }
        }
        private void silder_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            //UISwitch("Dashboard", true);
            timer1.Start();
        }


        public void on_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new MyDoctor());
            if (int.Parse(lbRole.Text)==2)
            {
                UISwitch("MyDoctor", true);
            }
        }


        private void BtnLogon_Click(object sender, EventArgs e)
        {
            if (MainPage.hasAuth == false)
            {
                this.PanelSlider.Controls.Clear();
                PanelSlider.Controls.Add(new Logon());
                UISwitch("Logon", true);
            }
            else if (MainPage.hasAuth == true)
            {
                if (MainPage.role == 1)
                {
                    this.PanelSlider.Controls.Clear();
                    PanelSlider.Controls.Add(new MemberCenter_User());
                    UISwitch("MemberCenter_User", true);
                }
                else if (MainPage.role == 2)
                {
                    this.PanelSlider.Controls.Clear();
                    PanelSlider.Controls.Add(new MyDoctor());
                    UISwitch("MyDoctor", true);
                }
                else if (MainPage.role == 3)
                {
                    this.PanelSlider.Controls.Clear();
                    PanelSlider.Controls.Add(new Admin());
                    UISwitch("Admin", true);
                }

            }
           
        }

        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new Notifications());          
            UISwitch("Notifications", true);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            if (MainPage.memberid > 0)
            {
                this.PanelSlider.Controls.Clear();
                PanelSlider.Controls.Add(new FrmShoppingList());

                UISwitch("FrmShoppingList", true);
            }
            else
            {
                MessageBox.Show("請先登入");
                this.PanelSlider.Controls.Clear();
                this.PanelSlider.Controls.Add(new Logon());
                this.PanelSlider.Controls.Find("Logon", false)[0].BringToFront();
            }
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {         
                this.PanelSlider.Controls.Clear();
                PanelSlider.Controls.Add(new MemberCenter_Admin());
                UISwitch("MemberCenter_Admin", true);                    
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new UserControls.ReserveMain());
            UISwitch("ReserveMain", false);
        }
        private void BtnClinic_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new Clinic());
            UISwitch("Clinic", false);
        }

        private void BtnTreatment_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new UserControls.Treatment());
            UISwitch("Treatment", false);
        }

        private void BtnDoctorTeam_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();       
            PanelSlider.Controls.Add(new DoctorTeam());
            UISwitch("DoctorTeam", false);
        }

        public void BtnMyDoctor_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new MyDoctor());
            UISwitch("MyDoctor", false);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new Store());
            UISwitch("Store", false);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new Info());
            UISwitch("Info", false);
        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
           
            PanelSlider.Controls.Add(new UserControls.Article_User());
            UISwitch("Article_User", false);
        }

        private void Btn_DoctorMaintain_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new DoctorMaintain());
            UISwitch("DoctorMaintain", false);
        }

        private void Btn_User_MemberCenter_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            PanelSlider.Controls.Add(new MemberCenter_User());
            UISwitch("MemberCenter_User", false);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (MainPage.memberid > 0)
            {
                DialogResult result = MessageBox.Show("確定要登出?", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MainPage.memberid = 0;
                    MainPage.role = 0;
                    MainPage.doctorid = 0;
                    MainPage.hasAuth = false;
                    this.PanelSlider.Controls.Clear();
                    this.PanelSlider.Controls.Add(new ArticleInterface());
                    this.PanelSlider.Controls.Find("ArticleInterface", false)[0].BringToFront();
                }
            }
            else
            {
                MessageBox.Show("尚未登入");
                this.PanelSlider.Controls.Clear();
                this.PanelSlider.Controls.Add(new Logon());
                this.PanelSlider.Controls.Find("Logon", false)[0].BringToFront();
            }
            
        }

       

        private void siticoneButton_Home_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            this.PanelSlider.Controls.Add(new ArticleInterface());
            this.PanelSlider.Controls.Find("ArticleInterface", false)[0].BringToFront();
        }
      
        private void siticoneButton_Admin_Click(object sender, EventArgs e)
        {
            this.PanelSlider.Controls.Clear();
            this.PanelSlider.Controls.Add(new Admin());
            this.PanelSlider.Controls.Find("Admin", false)[0].BringToFront();
        }
    }
}
