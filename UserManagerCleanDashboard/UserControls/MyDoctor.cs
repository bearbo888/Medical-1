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
    public partial class MyDoctor : UserControl
    {
        public MyDoctor()
        {
            InitializeComponent();
            PanelSlider.Controls.Add(new MyDoctor_MyClinic());
            PanelSlider.Controls.Add(new MyDoctor_DoctorWork());
            PanelSlider.Controls.Add(new MyPatientView());

        }

        private void UISwitch(string ui, bool isSideNav)
        {
            switch (ui)
            {
                case "MyDoctor_MyClinic":
                    PanelSlider.Controls.Find("MyDoctor_MyClinic", false)[0].BringToFront();
                    break;
                case "MyDoctor_DoctorWork":
                    PanelSlider.Controls.Find("MyDoctor_DoctorWork", false)[0].BringToFront();
                    break;
                case "MyPatientView":
                    PanelSlider.Controls.Find("MyPatientView", false)[0].BringToFront();
                    break;
            }
        }

        private void BtnClinic_Click(object sender, EventArgs e)
        {
            UISwitch("MyDoctor_MyClinic", false);
        }

        private void BtnWork_Click(object sender, EventArgs e)
        {
            UISwitch("MyDoctor_DoctorWork", false);
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            UISwitch("MyPatientView", false);
        }
    }
}
