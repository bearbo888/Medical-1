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
    
    public partial class DoctorMaintain : UserControl
    {
        public DoctorMaintain()
        {
            InitializeComponent();
        }


        MedicalEntities medicalcontext = new MedicalEntities(); //建模型

        private void 醫生列表_Load(object sender, EventArgs e)
        {
            var result_dorctor = from d in medicalcontext.Doctors
                                 select new
                                 {
                                     醫師編號 = d.DoctorID,
                                     會員編號 = d.MemberID,
                                     醫師姓名 = d.DoctorName,
                                     醫師職稱 = d.JobTitle,
                                     醫師履歷 = d.Education,
                                     醫師專長 = d.Department.DeptName,
                                     醫師照片 = d.Picture

                                 };
            this.siticoneDataGridView1.DataSource = result_dorctor.ToList();
        }

        private void dataGridView1_Dorctor_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {                     
            if (e.ColumnIndex == 0)
            {
                string a = this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師姓名"].Value.ToString();
                string b = this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師職稱"].Value.ToString();
                string c = this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師履歷"].Value.ToString();
                string d = this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師專長"].Value.ToString();
                byte[] bytes = (byte[])this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師照片"].Value;
                int f = (int)this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師編號"].Value;

                DorctorCRUD cRUD =new DorctorCRUD(a, b, c, d, bytes, f);
           
                //this.Controls.Clear();
                this.Controls.Add(new UserControls.DorctorCRUD(a, b, c, d, bytes, f));
                this.Controls.Find("DorctorCRUD", false)[0].BringToFront();

            }
            if (e.ColumnIndex == 1)
            {
                int id = (int)this.siticoneDataGridView1.Rows[e.RowIndex].Cells["醫師編號"].Value;

                //string name = this.dataGridView_Dorctor.Rows[e.RowIndex].Cells["醫師姓名"].Value.ToString();
                var delete = (from d in medicalcontext.Doctors
                              where d.DoctorID == id
                              select d).FirstOrDefault();
                if (delete == null) return;



                DialogResult result = MessageBox.Show("確定要刪除?", "刪除醫師資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //this.medicalcontext.Doctor.Remove(delete);
                    //this.medicalcontext.Doctor.Remove(delete);
                    //this.medicalcontext.SaveChanges();

                    this.siticoneDataGridView1.DataSource = null;
                    var Doctor = from d in medicalcontext.Doctors
                                 select new
                                 {
                                     醫師編號 = d.DoctorID,
                                     會員編號 = d.MemberID,
                                     醫師姓名 = d.DoctorName,
                                     醫師職稱 = d.JobTitle,
                                     醫師履歷 = d.Education,
                                     醫師專長 = d.Department.DeptName,
                                     醫師照片 = d.Picture

                                 };
                    this.siticoneDataGridView1.DataSource = Doctor.ToList();
                    MessageBox.Show("刪除成功");
                }
            }

         

        }

        private void button_AddDorctor_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            this.panel1.Controls.Add(new UserControls.DorctorCRUD());                    
            panel1.Controls.Find("DorctorCRUD", false)[0].BringToFront();

        }

      
    }
}
