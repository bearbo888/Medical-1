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
    public partial class MyDoctor_PatientView : UserControl
    {
        public MyDoctor_PatientView()
        {
            InitializeComponent();                        
            AdditemtoCombo();
            IdentityRole();
            cb_Mypatient.SelectedIndex = 0;
        }
        int memID = MainPage.memberid; //ToDo MemberID
        int role = MainPage.role;//inPage.role; //ToDo Role
        int docID = MainPage.doctorid;//inPage.doctorid; //ToDo DocID 
        private void IdentityRole()
        {
            if (role == 1)
            {
                btn_DocID1.Visible = true;                
                btn_PatientDetail.Visible = true;
                cb_Mypatient.Visible = true;
                cb_Year.Visible = true;
                cb_Month.Visible = true;
                this.txt_KeyWrod.Visible = true;
                lbKeyword.Visible = true;
                lbyear.Visible = true;
                lbmonth.Visible = true;
            }
            if (role == 2)
            {
                btn_DocID1.Visible = false;                
                btn_PatientDetail.Visible = false;
                cb_Mypatient.Visible = false;
                cb_Year.Visible = false;
                cb_Month.Visible = false;
                this.txt_KeyWrod.Visible = false;
                lbKeyword.Visible = false;
                lbyear.Visible = false;
                lbmonth.Visible = false;
            }
        }
        //識別權限
        private void AdditemtoCombo()
        {
            int d = DateTime.Now.Date.Year;
            this.cb_Month.Items.Clear();
            this.cb_Mypatient.Items.Clear();
            this.cb_Year.Items.Clear();
            this.cb_Day.Items.Clear();
            this.cb_Mypatient.Items.Add("全部病患");
            var q = (from m in medicalEntities.Members
                    join r in medicalEntities.Reserves on m.MemberID equals r.MemberID
                    join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    where t.DoctorID == docID
                    select m.MemberName).Distinct();
            foreach (string item in q)
                this.cb_Mypatient.Items.Add(item);
            var s = (from r in medicalEntities.Reserves
                    join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    where t.DoctorID == docID
                    group r by r.ReserveDate.Year into g
                    select g.Key).Distinct();
            foreach (int i in s)
                this.cb_Year.Items.Add(i);
            var tz = (from r in medicalEntities.Reserves
                     join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                     join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                     join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID
                     where t.DoctorID == docID
                     group r by r.ReserveDate.Month into g
                    select g.Key).Distinct();
            foreach (int i in tz)
                this.cb_Month.Items.Add(i);
            var tzz = (from r in medicalEntities.Reserves
                     join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                     join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                     join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID
                     where t.DoctorID == docID
                     group r by r.ReserveDate.Day into g
                     select g.Key).Distinct();
            foreach (int i in tzz)
                this.cb_Day.Items.Add(i);

        }
        MedicalEntities medicalEntities = new MedicalEntities(); 
        private void button1_Click(object sender, EventArgs e)
        {
            MyPatient();
        }
        /*Deemo DocID=1*/
        private void MyPatient()
        {
            cb_Mypatient.SelectedIndex = 0;
            docID = 1;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            var q = (from m in medicalEntities.Members
                    join r in medicalEntities.Reserves on m.MemberID equals r.MemberID
                    join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    where t.DoctorID == docID                    
                    select new 
                    {
                        患者姓名 = m.MemberName
                    }).Distinct();
            this.dataGridView1.DataSource = q.ToList();
            AdditemtoCombo();
        }
        /*我的病患*/
        private void ViewDocPat(string e, DateTime k)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            string memN = /*"黃子涵";*/ this.txt_KeyWrod.Text; /*醫生登入後可以看到病患病歷*/
            var q = from m in medicalEntities.Members
                    join r in medicalEntities.Reserves on m.MemberID equals r.MemberID
                    join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID                    
                    where m.MemberName.Contains(e) && t.DoctorID == docID && r.ReserveDate == k
                    select new
                    {                        
                        姓名 =  m.MemberName,
                        診斷紀錄 =  c.DiagnosticRecord,
                        症狀描述 = c.SyndromeDescription,
                        看診細節 = td.TreatmentDetail1
                    };
            dataGridView1.DataSource = q.ToList();
        }
        /*看診細節*/        
        private void ViewPatientDetail()
        {
            //選取病患 顯示病患詳細資料(病歷 生理等)
            dataGridView1.DataSource=null;
            dataGridView1.Columns.Clear();
            int d = DateTime.Now.Date.Year;
            string memN = txt_KeyWrod.Text;
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    where m.MemberName.Contains(memN) && t.DoctorID == docID
                    orderby r.ReserveDate descending
                    select new
                    {
                        病歷號 = c.CaseID,
                        看診日期 = r.ReserveDate,
                        姓名 = m.MemberName,
                        症狀描述 = c.SyndromeDescription,                        
                        年齡 = (d - m.BirthDay.Value.Year),
                        血型 = m.BloodType,
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right

                    };
            
            dataGridView1.DataSource = q.ToList();
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(dgvBtn);
            dgvBtn.Name = "詳細資料";
            dgvBtn.Text = "點開資料";
            dgvBtn.UseColumnTextForButtonValue = true;            
        }       
        /*看診訊息*/

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ViewDocPat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewPatientDetail();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            int d = DateTime.Now.Date.Year;
            if (this.cb_Mypatient.SelectedItem.ToString() == "全部病患")
            {
                var z = from c in medicalEntities.CaseRecords
                        join m in medicalEntities.Members on c.MemberID equals m.MemberID
                        join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                        join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                        join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                        join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                        where t.DoctorID == docID
                        orderby r.ReserveDate descending
                        select new
                        {
                            病歷號 = c.CaseID,                            
                            看診日期 = r.ReserveDate,
                            姓名 = m.MemberName,
                            症狀描述 = c.SyndromeDescription,
                            年齡 = (d - m.BirthDay.Value.Year),
                            血型 = m.BloodType,
                            體重 = m.Weight,
                            左眼視力 = m.OS_Left,
                            右眼視力 = m.OD_Right
                            
                        };
                dataGridView1.DataSource = z.ToList();
                DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(dgvBtn);
                dgvBtn.Name = "詳細資料";
                dgvBtn.Text = "點開資料";
                dgvBtn.UseColumnTextForButtonValue = true;

            }
            else
            {
                var q = from c in medicalEntities.CaseRecords
                        join m in medicalEntities.Members on c.MemberID equals m.MemberID
                        join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                        join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                        join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                        where m.MemberName == this.cb_Mypatient.SelectedItem.ToString()
                        orderby r.ReserveDate descending
                        select new
                        {
                            病歷號 = c.CaseID,
                            症狀描述 = c.SyndromeDescription,
                            看診日期 = r.ReserveDate,
                            姓名 = m.MemberName,
                            年齡 = (d - m.BirthDay.Value.Year),
                            血型 = m.BloodType,
                            體重 = m.Weight,
                            左眼視力 = m.OS_Left,
                            右眼視力 = m.OD_Right,
                            
                        };                
                dataGridView1.DataSource = q.ToList();
                DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(dgvBtn);
                dgvBtn.Name = "詳細資料";
                dgvBtn.Text = "點開資料";
                dgvBtn.UseColumnTextForButtonValue = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            int selectYear = Convert.ToInt32(this.cb_Year.SelectedItem);
            int d = DateTime.Now.Date.Year;
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID
                    where r.ReserveDate.Year == selectYear && t.DoctorID == docID
                    orderby r.ReserveDate descending
                    select new
                    {
                        病歷號 = c.CaseID,
                        看診日期 = r.ReserveDate,
                        姓名 = m.MemberName,
                        症狀描述 = c.SyndromeDescription,
                        年齡 = (d - m.BirthDay.Value.Year),
                        血型 = m.BloodType,
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right,                        
                    };
            dataGridView1.DataSource = q.ToList();
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(dgvBtn);
            dgvBtn.Name = "詳細資料";
            dgvBtn.Text = "點開資料";
            dgvBtn.UseColumnTextForButtonValue = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            int selectYear = Convert.ToInt32(this.cb_Year.SelectedItem);
            int selectMonth = Convert.ToInt32(cb_Month.SelectedItem);
            int d = DateTime.Now.Date.Year;
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID                    
                    where r.ReserveDate.Year == selectYear && r.ReserveDate.Month == selectMonth && t.DoctorID == docID
                    orderby r.ReserveDate descending
                    select new
                    {
                        病歷號 = c.CaseID,
                        看診日期 = r.ReserveDate,
                        姓名 = m.MemberName,
                        症狀描述 = c.SyndromeDescription,
                        年齡 = (d - m.BirthDay.Value.Year),
                        血型 = m.BloodType,
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right                        
                    };
            dataGridView1.DataSource = q.ToList();
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(dgvBtn);
            dgvBtn.Name = "詳細資料";
            dgvBtn.Text = "點開資料";
            dgvBtn.UseColumnTextForButtonValue = true;
        }

        private void btn_role_Click(object sender, EventArgs e)
        {
           
        }

        private void cb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            int selectYear = Convert.ToInt32(this.cb_Year.SelectedItem);
            int selectMonth = Convert.ToInt32(cb_Month.SelectedItem);
            int selectDay = Convert.ToInt32(cb_Day.SelectedItem);
            int d = DateTime.Now.Date.Year;
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentID
                    where r.ReserveDate.Year == selectYear && r.ReserveDate.Month == selectMonth && t.DoctorID == docID && r.ReserveDate.Day == selectDay
                    orderby r.ReserveDate descending
                    select new
                    {
                        病歷號 = c.CaseID,
                        看診日期 = r.ReserveDate,
                        姓名 = m.MemberName,
                        症狀描述 = c.SyndromeDescription,
                        年齡 = (d - m.BirthDay.Value.Year),
                        血型 = m.BloodType,
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right
                    };
            dataGridView1.DataSource = q.ToList();
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(dgvBtn);
            dgvBtn.Name = "詳細資料";
            dgvBtn.Text = "點開資料";
            dgvBtn.UseColumnTextForButtonValue = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells["姓名"].Value.ToString();
            DateTime date = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["看診日期"].Value;
            if (e.ColumnIndex == dataGridView1.Columns["詳細資料"].Index)
            {
                ViewDocPat(value,date);                
            }            
        }

        private void btnDocID2_Click(object sender, EventArgs e)
        {
            cb_Mypatient.SelectedIndex = 0;
            docID = 2;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            var q = (from m in medicalEntities.Members
                     join r in medicalEntities.Reserves on m.MemberID equals r.MemberID
                     join c in medicalEntities.CaseRecords on r.ReserveID equals c.ReserveID
                     join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                     join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                     where t.DoctorID == docID
                     select new
                     {
                         患者姓名 = m.MemberName
                     }).Distinct();
            this.dataGridView1.DataSource = q.ToList();
            AdditemtoCombo();
        }
    }
}
