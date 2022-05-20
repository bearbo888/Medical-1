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
    public partial class DorctorCRUD : UserControl
    {
        public DorctorCRUD()
        {
            InitializeComponent();
            AddcomboBox_Departemt();           
            AddcomboBox_MemberName();
            comboBox_DorctorJobTitle.SelectedIndex = 0;
            this.button_update.Enabled = false;
        }     
        public DorctorCRUD(string a, string b, string c, string d, byte[] bytes, int f)
        {
            InitializeComponent();
            AddcomboBox_Departemt();          
            AddcomboBox_MemberName();
            this.comboBox_MemberName.Text = a;
            this.comboBox_DorctorJobTitle.Text = b;
            this.textBox_Education.Text = c;
            this.comboBox_Departemt.Text = d;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            //byte[] aa = { 1, 2 };
            this.pictureBox_DorctorPicture.Image = Image.FromStream(ms);
            //this.pictureBox_DorctorPicture.Image = Image.FromFile(aa
            this.label_ID.Text = f.ToString();
            this.button_SaveChange.Enabled = false;                  
        }
        MedicalEntities medicalcontext = new MedicalEntities(); //建模型
        private void AddcomboBox_MemberName()
        {
            this.comboBox_MemberName.SelectedIndex = 0;
            var result = from m in medicalcontext.Members.AsEnumerable()
                         //where m.Role == 1
                         select m.MemberName;
            this.comboBox_MemberName.DataSource = result.ToList();
        }      
        private void AddcomboBox_Departemt()
        {
            comboBox_Departemt.SelectedItem = 0;
            var result = from d in medicalcontext.Departments
                         select d.DeptName;
            comboBox_Departemt.DataSource = result.ToList();
        }      
        private void button_borwse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF "; //前面是呈現文字   ( | )  後 是檔案類別
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox_DorctorPicture.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void button_SaveChange_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBox_DorctorPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            var dept = from d in medicalcontext.Departments.AsEnumerable()
                       where d.DeptName == this.comboBox_Departemt.Text
                       group d by d.DepartmentID into g
                       select new { g.Key }.Key;
            var member = (from m in medicalcontext.Members.AsEnumerable()
                          where m.MemberName == this.comboBox_MemberName.Text
                          select m).FirstOrDefault();
            //group m by m.MemberID into g
            //select new { g.Key }.Key;
            //新增醫師資料
            Doctor doctor = new Doctor
            {
                DoctorName = this.comboBox_MemberName.Text,
                JobTitle = this.comboBox_DorctorJobTitle.Text,
                Education = this.textBox_Education.Text,
                DepartmentID = dept.ElementAt(0),
                MemberID = member.MemberID,
                Picture = bytes              
            };
           
            this.medicalcontext.Doctors.Add(doctor);               
            this.medicalcontext.SaveChanges();
//更新醫師會員權限
            var me = (from m in medicalcontext.Members.AsEnumerable()
                      where m.MemberID == member.MemberID
                      select m).FirstOrDefault();
            if (me == null) return;
            me.Role=2;         
            
            this.medicalcontext.SaveChanges();
            MessageBox.Show("新增醫師資料成功");
        }

        private void button_Demo_Click(object sender, EventArgs e)
        {          
            this.textBox_Education.Text = "博士";
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //update
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBox_DorctorPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            var update = (from d in medicalcontext.Doctors.AsEnumerable()
                          where d.DoctorID == Convert.ToInt32(this.label_ID.Text)
                          select d).FirstOrDefault();
            var dept = from d in medicalcontext.Departments.AsEnumerable()
                       where d.DeptName == this.comboBox_Departemt.Text
                       group d by d.DepartmentID into g
                       select new { g.Key }.Key;


            update.DoctorName = this.comboBox_MemberName.Text;
            update.JobTitle = this.comboBox_DorctorJobTitle.Text;
            update.Education = this.textBox_Education.Text;
            update.Picture = bytes;
            update.DepartmentID = dept.FirstOrDefault();
            if (update == null) return; //exit method

           

            this.medicalcontext.SaveChanges();
            MessageBox.Show("修改成功");

        }

        private void button_Goback_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControls.DoctorMaintain());
            this.Controls.Find("DoctorMaintain", false)[0].BringToFront();
        }

       
    }
}
