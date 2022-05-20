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
   
    public partial class MyDoctor_DoctorWork : UserControl
    {
        public static int clinicid { get; set; }

        int number = 1;
        int doctorID = MainPage.doctorid;
        public MyDoctor_DoctorWork()
        {
            InitializeComponent();
        }
       
        private void DoctorWork_Load(object sender, EventArgs e)
        {
            PatientList();
            LoadPatient();
            LoadRecord();
        }


        public void PatientList()
        {
            MedicalEntities medicalContext = new MedicalEntities();
            var qry = from q in medicalContext.ClinicDetails
                      where q.DoctorID == doctorID && q.ClinicDetailID == clinicid
                      select q.ClinicDetailID;

            if (qry.Count() > 0)
            {
                int id = qry.First();
                var qry2 = from q in medicalContext.Members
                           from c in q.Reserves
                           where c.ClinicDetailID.Equals(id)
                           orderby c.ReserveDate ascending
                           select q;

                gvPatinet.Columns.Add("Column", "候診順序");
                gvPatinet.Columns.Add("Column2", "");
                gvPatinet.Columns.Add("Column3", "");

                foreach (var i in qry2)
                {
                    gvPatinet.Rows.Add(number, i.MemberName, "候診中");
                    number++;
                }
            }
        }

        private void gvPatinet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                value = (int)gvPatinet.Rows[e.RowIndex].Cells[0].Value;
                name = (string)gvPatinet.Rows[e.RowIndex].Cells[1].Value;
                index = gvPatinet.Rows[e.RowIndex].Cells[0].RowIndex;
            }

            LoadPatient();
            LoadRecord();
        }

        int value=0; string name; int index = 0;

        private void 過號候補ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvPatinet.Rows.Add(value, name,"過號候補");
            gvPatinet.Rows[index].Cells[2].Style.ForeColor = Color.Blue;
            gvPatinet.Rows.RemoveAt(index);
            gvPatinet.Refresh();
        }

        int click = 0;

        private void BtnNext_Click(object sender, EventArgs e)
        {
            tbDiagnosticRecord.Enabled = BtnSave.Enabled = true;

            if (click == 0)
            {
                gvPatinet.Rows[index].Cells[2].Style.SelectionForeColor = Color.Red;
                gvPatinet.Rows[index].Cells[2].Value = "看診中";
                click++; 
            }
            else
            {
                if (gvPatinet.Rows[index].Cells[2].Value.ToString() != "未到")
                {
                    if (!String.IsNullOrEmpty(tbDiagnosticRecord.Text))
                    {
                        gvPatinet.Rows[index].Cells[2].Value = "完成看診";
                        gvPatinet.Rows[index].Cells[2].Style.ForeColor = Color.Purple;

                        gvPatinet.Rows[index].Selected = false;

                        if (index < gvPatinet.Rows.Count - 1)
                        {
                            gvPatinet.Rows[index + 1].Cells[2].Style.SelectionForeColor = Color.Red;
                            gvPatinet.Rows[index + 1].Cells[2].Value = "看診中";
                            gvPatinet.Rows[index + 1].Selected = true;
                            index++;
                        }
                        else
                        {
                            MessageBox.Show("今日看診已完成");
                            BtnNext.Enabled = BtnSave.Enabled = tbDiagnosticRecord.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("未填寫病患症狀描述");
                    }
                }
                else
                {
                    gvPatinet.Rows[index].Selected = false;
                    gvPatinet.Rows[index + 1].Selected = true;
                    gvPatinet.Rows[index + 1].Cells[2].Value = "看診中";
                    gvPatinet.Rows[index + 1].Cells[2].Style.SelectionForeColor = Color.Red;
                    index++;
                }
            }

            //叫下一個號碼
            MedicalEntities medicalContext = new MedicalEntities();
            var q = medicalContext.ClinicDetails.Where(x => x.ClinicDetailID.Equals(clinicid)).FirstOrDefault();
            q.LimitNum = index+1;
            medicalContext.SaveChanges();

            gvPatinet.Refresh();

            this.gvRecord.DataSource = null;
            LoadRecord();
            tbDiagnosticRecord.Text = "";
        }


        public void LoadPatient()
        {
            this.gvPatinet.DataSource = null;

            MedicalEntities medicalContext = new MedicalEntities();
            DateTime now = DateTime.Now;
            var qry = from q in medicalContext.Reserves
                      where q.ClinicDetailID == clinicid                    
                      select q;

            if (qry.Count() > 0)
            {
                if (index > 0)
                {
                    qry = qry.Where(x => x.Member.MemberName.Equals(name.Trim()));
                    DateTime birthDay = (DateTime)qry.FirstOrDefault().Member.BirthDay;
                    string age = Convert.ToDouble((now.Year - birthDay.Year) + (Math.Abs(now.Month - birthDay.Month) / 12)).ToString("0.0");
                    lbPatient.Text = $"病患：{qry.FirstOrDefault().Member.MemberName}/{qry.FirstOrDefault().Member.Gender.Gender1}/{ age }";
                }
                else
                {
                    qry = qry.OrderBy(x => x.ReserveDate);
                    DateTime birthDay = (DateTime)qry.FirstOrDefault().Member.BirthDay;
                    string age = Convert.ToDouble((now.Year - birthDay.Year) + (Math.Abs(now.Month - birthDay.Month) / 12)).ToString("0.0");
                    lbPatient.Text = $"病患：{qry.FirstOrDefault().Member.MemberName}/{qry.FirstOrDefault().Member.Gender.Gender1}/{ age }";
                }
            } 
            
        }

        public void LoadRecord()
        {
            this.gvRecord.DataSource = null;

            MedicalEntities medicalContext = new MedicalEntities();
            var qry = from q in medicalContext.Reserves
                      where q.ClinicDetailID == clinicid
                      select q;

            if (qry.Count() > 0)
            {
                if (index > 0)
                {
                    var q2 = from q in medicalContext.CaseRecords.AsEnumerable()
                             where q.Member.MemberName == name
                             select new { 日期 = q.Reserve.ReserveDate.ToString("yyyy-MM-dd"), 科別 = q.Reserve.ClinicDetail.Department.DeptName, 診斷 = q.SyndromeDescription };
                    gvRecord.DataSource = q2.ToList();
                }
                else
                {
                    name = gvPatinet.Rows[0].Cells[1].Value.ToString();

                    var q2 = from q in medicalContext.CaseRecords.AsEnumerable()
                             where q.Member.MemberName.Equals(name.Trim())
                             select new { 日期 = q.Reserve.ReserveDate.ToString("yyyy-MM-dd"), 科別 = q.Reserve.ClinicDetail.Department.DeptName, 診斷 = q.SyndromeDescription };
                    gvRecord.DataSource = q2.ToList();
                }
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                name = gvPatinet.Rows[0].Cells[1].Value.ToString();
            }

            MedicalEntities medicalContext = new MedicalEntities();
            var qry = from q in medicalContext.Reserves
                      where q.ClinicDetailID == clinicid && q.Member.MemberName.Equals(name.Trim())
                      select new { MemberID = q.MemberID, ReserveID = q.ReserveID };

            if (qry.Count() > 0)
            {
                int MemberID = qry.FirstOrDefault().MemberID;
                int ReserveID = qry.FirstOrDefault().ReserveID;


                if (!String.IsNullOrEmpty(tbDiagnosticRecord.Text))
                {
                    CaseRecord record = new CaseRecord
                    {
                        MemberID = MemberID,
                        ReserveID = ReserveID,
                        SyndromeDescription = tbDiagnosticRecord.Text
                    };

                    medicalContext.CaseRecords.Add(record);
                    medicalContext.SaveChanges();
                    MessageBox.Show("儲存成功");
                }
                else
                {
                    MessageBox.Show("未填寫病患症狀描述");
                }
            }
            tbDiagnosticRecord.Enabled = BtnSave.Enabled = false;
        }

        private void BtnBackMyClinic_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new MyDoctor_MyClinic());
            this.Controls.Find("MyDoctor_MyClinic", false)[0].BringToFront();
        }

        private void 未到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvPatinet.Rows[index].Cells[2].Value = "未到";
            gvPatinet.Rows[index].Cells[2].Style.ForeColor = Color.Green;
            gvPatinet.Refresh();
        }
    }
}
