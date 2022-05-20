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
    public partial class DoctorTeam : UserControl
    {
        public DoctorTeam()
        {
            InitializeComponent();
            AddflowLayoutPanel();
            AddcomboBox_Department();
        }
        MedicalEntities medicalcontext = new MedicalEntities(); //建模型
        private void AddcomboBox_Dorctor()
        {
            var dorctor = from d in medicalcontext.Doctors
                          where d.Department.DeptName == this.comboBox_Department.Text
                          select d.DoctorName;
            this.comboBox_Dorctor.DataSource = dorctor.ToList();
        }

        private void AddcomboBox_Department()
        {
            var department = from d in medicalcontext.Departments
                             select d.DeptName;
            this.comboBox_Department.DataSource = department.ToList();
        }
        private void AddflowLayoutPanel()
        {
            var result = from p in medicalcontext.Doctors
                         select p;
            int b = result.Count();

            if (b > 0)
            {

                foreach (var a in result)
                {
                    

                    System.IO.MemoryStream ms = new System.IO.MemoryStream(a.Picture);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromStream(ms);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 200;
                    pictureBox.Height = 100;
                    pictureBox.Click += PictureBox_Click;
                    pictureBox.Tag = a.DoctorName;
                    pictureBox.Dock = DockStyle.Top;
                    Label label_name = new Label();
                    //Label_name.Dock =DockStyle.Bottom;
                    label_name.ForeColor = Color.Blue;
                    label_name.Location = new System.Drawing.Point(5, 101);
                    label_name.Width = 80;
                    label_name.Font= new System.Drawing.Font("Segoe UI", 15F);

                    Button button_Rating = new Button();
                    button_Rating.Text = "查看評分";
                    button_Rating.ForeColor = Color.Blue;
                    button_Rating.Tag = a.DoctorName;
                    button_Rating.Width = 100;
                    button_Rating.Click += Button_Rating_Click;
                    button_Rating.Location=new System.Drawing.Point(100, 101);
                    label_name.Text = a.DoctorName;// + "\n" + "學歷  " + a.Education;

                    Panel panel = new Panel();
                    panel.Width = 200;
                    panel.Height = 150;
                    panel.Controls.Add(label_name);
                    panel.Controls.Add(button_Rating);
                    panel.Controls.Add(pictureBox);
                    
                    
                    this.flowLayoutPanel_ALL_doctor.Controls.Add(panel);
                    

                }
            }
        }

        private void Button_Rating_Click(object sender, EventArgs e)
        {
            Button button =sender as Button;
            DoctorRating doctorRating = new DoctorRating(button.Tag);
            doctorRating.Show();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {          
            PictureBox box = sender as PictureBox;

            DoctorDetail dortor = new DoctorDetail(box.Tag);         
            this.panel1.Controls.Add(new UserControls.DoctorDetail(box.Tag));
            panel1.Controls.Find("DoctorDetail", false)[0].BringToFront();
        }

        private void AddcomboBox_TreatmentDetail()
        {
            this.comboBox_TreatmentDetail.DataSource = null; 
            var detail = from d in medicalcontext.TreatmentDetails
                         where d.Department.DeptName == this.comboBox_Department.Text
                         select d.TreatmentDetail1;
            this.comboBox_TreatmentDetail.DataSource = detail.ToList();

        }
        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddcomboBox_TreatmentDetail();
            AddcomboBox_Dorctor();
        }

        private void button_Dorctor_Click(object sender, EventArgs e)
        {
            var result = from d in medicalcontext.Doctors.AsEnumerable()
                         where d.DoctorName.Contains(this.textBox_dorctor.Text.ToUpper()) ||
                               d.DoctorName.Contains(this.textBox_dorctor.Text.ToLower())
                         select d;
            if (result.Count() == 0)
            {
                MessageBox.Show("查無此醫師");
            }
            else if (String.IsNullOrEmpty(this.textBox_dorctor.Text))
            {
                MessageBox.Show("請輸入要查詢的醫師");
            }
            else
            {
                // this.comboBox_dorctor1.DataSource = result.ToList();
                this.flowLayoutPanel_ALL_doctor.Controls.Clear();

                int b = result.Count();

                if (b > 0)
                {
                    foreach (var a in result)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(a.Picture);
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 200;
                        pictureBox.Height = 100;
                        pictureBox.Tag = a.DoctorName;
                        pictureBox.Click += PictureBox_Click;

                        Label label_name = new Label();
                        //Label_name.Dock =DockStyle.Bottom;
                        label_name.ForeColor = Color.Blue;
                        label_name.Text = a.DoctorName;// + "\n" + "學歷" + a.Education;
                        this.flowLayoutPanel_ALL_doctor.Controls.Add(pictureBox);
                        this.flowLayoutPanel_ALL_doctor.Controls.Add(label_name);

                    }
                }

            }

        }      
    }
}
