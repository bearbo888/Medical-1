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
    public partial class DoctorDetail : UserControl
    {
        public DoctorDetail()
        {
            InitializeComponent();

            AddComboBox(); //新增 comboBOX
            Addtreeview();//新增 treeview
            //MessageBox.Show(xxx.ToString());
            //comboBox_Doctor.Text = xxx.ToString();

        }
        public DoctorDetail(object dorctor)
        {
            InitializeComponent();
            AddComboBox(); //新增 comboBOX
            Addtreeview();//新增 treeview
            comboBox_Doctor.Text = dorctor.ToString();

        }
        public static string xxx
        {
            set;get;
            
        }

        MedicalEntities medicalcontext = new MedicalEntities(); //建模型
        private void Addtreeview()
        {

            treeView_Doctor.Nodes.Clear();
            var result = from d in medicalcontext.Doctors
                         select d.DoctorName;
            foreach (var n in result)
            {
                TreeNode node = this.treeView_Doctor.Nodes.Add(n);
            }
        }
        private void AddComboBox()
        {
            comboBox_Doctor.SelectedItem = 0;
            var result = from d in medicalcontext.Doctors
                         select d.DoctorName;
            comboBox_Doctor.DataSource = result.ToList();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //醫生姓名
            this.label_name.Text = this.comboBox_Doctor.Text + "醫師";
            //=====================================================================
            //醫生學歷
            var education = from n in medicalcontext.Doctors
                            where n.DoctorName == this.comboBox_Doctor.Text
                            select n.Education;
            label_Education.Text = education.Single();
            //=====================================================================
            //醫生診療項目
            var Department = from n in medicalcontext.Doctors.AsEnumerable()
                             where n.DoctorName == this.comboBox_Doctor.Text
                             group n by n.Department.DeptName into g
                             select new { g.Key };
            label_Department.Text = Department.ElementAt(0).Key.ToString();
            //=====================================================================
            //醫生項目TreatmentDetail

            var detail = from n in medicalcontext.Treatments.AsEnumerable()
                         where n.Doctor.DoctorName == this.comboBox_Doctor.Text
                         group n by n.TreatmentDetail.TreatmentDetail1 into g
                         select new { g.Key };

            //this.dataGridView1.DataSource = detail.ToList();

            //this.label_TreatmentDetail.Text = detail.ElementAt(0).Key.ToString();
            this.label_TreatmentDetail.Text = "";
            foreach (var d in detail)
            {
                this.label_TreatmentDetail.Text += d.Key + "\n";
            }
            //=====================================================================
            //醫生照片   
            this.pictureBox_Dorctor.Image = null;
            var picture = from n in medicalcontext.Doctors.AsEnumerable()
                          where n.DoctorName == this.comboBox_Doctor.Text && n.Picture != null
                          select n.Picture;
            int a = picture.Count();
            if (a > 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(picture.FirstOrDefault());
                this.pictureBox_Dorctor.Image = Image.FromStream(ms);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            //    //醫生姓名
            //    this.label_name.Text = this.treeView_Doctor.SelectedNode.Text + "醫師";
            //    //this.label_name.Text = this.treeView_Doctor.SelectedNode + "醫師";
            //    //=====================================================================
            //    //醫生學歷
            //    var education = from n in medicalcontext.Doctors
            //                    where n.DoctorName == this.treeView_Doctor.SelectedNode.Text
            //                    select n.Education;
            //    label_Education.Text = education.Single();
            //    //=====================================================================
            //    //醫生診療科別
            //    var Department = from n in medicalcontext.Doctors.AsEnumerable()
            //                     where n.DoctorName == this.treeView_Doctor.SelectedNode.Text
            //                     group n by n.Department.DeptName into g
            //                     select new { g.Key };

            //    label_Department.Text = Department.ElementAt(0).Key.ToString();
            //    //=====================================================================
            //    //醫生項目TreatmentDetail

            //    var detail = from n in medicalcontext.Treatments.AsEnumerable()
            //                 where n.Doctor.DoctorName == this.treeView_Doctor.SelectedNode.Text
            //                 group n by n.TreatmentDetail.TreatmentDetail1 into g
            //                 select new { g.Key };

            //    //this.dataGridView1.DataSource = detail.ToList();

            //    //this.label_TreatmentDetail.Text = detail.ElementAt(0).Key.ToString();
            //    this.label_TreatmentDetail.Text = "";
            //    foreach (var d in detail)
            //    {
            //        this.label_TreatmentDetail.Text += d.Key + "\n";
            //    }



            //    //=====================================================================
            //    //醫生照片                                                               
            //    this.pictureBox_Dorctor.Image = null;
            //    var picture = from n in medicalcontext.Doctors.AsEnumerable()
            //                  where n.DoctorName == this.treeView_Doctor.SelectedNode.Text && n.Picture != null
            //                  select n.Picture;
            //    int a = picture.Count();
            //    if (a > 0)
            //    {
            //        System.IO.MemoryStream ms = new System.IO.MemoryStream(picture.FirstOrDefault());
            //        this.pictureBox_Dorctor.Image = Image.FromStream(ms);
            //    }
            }

            private void siticoneButton1_goback_Click(object sender, EventArgs e)
            {
                this.Controls.Clear();
                this.Controls.Add(new UserControls.DoctorTeam());
                this.Controls.Find("DoctorTeam", false)[0].BringToFront();
            }

            private void treeView_Doctor_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
            {
            string name = e.Node.Text;
            this.comboBox_Doctor.Text = name;
            //醫生姓名
            this.label_name.Text = e.Node.Text + "醫師";

            //=====================================================================
            //醫生學歷
            var education = from n in medicalcontext.Doctors
                                where n.DoctorName.Equals(name)
                                select n.Education;

                label_Education.Text = education.Single();
                //=====================================================================
                //醫生診療科別
                var Department = from n in medicalcontext.Doctors.AsEnumerable()
                                 where n.DoctorName.Equals(name)
                                 group n by n.Department.DeptName into g
                                 select new { g.Key };

                label_Department.Text = Department.ElementAt(0).Key.ToString();
                //=====================================================================
                //醫生項目TreatmentDetail

                var detail = from n in medicalcontext.Treatments.AsEnumerable()
                             where n.Doctor.DoctorName.Equals(name)
                             group n by n.TreatmentDetail.TreatmentDetail1 into g
                             select new { g.Key };

                //this.dataGridView1.DataSource = detail.ToList();

                //this.label_TreatmentDetail.Text = detail.ElementAt(0).Key.ToString();
                this.label_TreatmentDetail.Text = "";
                foreach (var d in detail)
                {
                    this.label_TreatmentDetail.Text += d.Key + "\n";
                }



                //=====================================================================
                //醫生照片                                                               
                this.pictureBox_Dorctor.Image = null;
                var picture = from n in medicalcontext.Doctors.AsEnumerable()
                              where n.DoctorName.Equals(name) && n.Picture != null
                              select n.Picture;
                int a = picture.Count();
                if (a > 0)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(picture.FirstOrDefault());
                    this.pictureBox_Dorctor.Image = Image.FromStream(ms);
                }
            }
    }
}
