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
    public partial class CaseReview : UserControl
    {
        MedicalEntities medicalEntities = new MedicalEntities();
        public CaseReview()
        {
            InitializeComponent();                                         
            AddYearToCombo();            
            SelectCaseRecord();

        }
        int memID = MainPage.memberid;                                                                      //ToDo MemberID    
        private void AddYearToCombo()
        {
            var q = from r in medicalEntities.Reserves
                    join m in medicalEntities.Members on r.MemberID equals m.MemberID
                    where m.MemberID == memID
                    group r by r.ReserveDate.Year into g
                    select g.Key;
            foreach (int i in q)
                cb_Year.Items.Add(i);           

            
        }                                                   //方法.加入年選單

             
                
        private void SelectCaseRecord()  
        {
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join cd in medicalEntities.ClinicDetails on r.ClinicDetailID equals cd.ClinicDetailID
                    join d in medicalEntities.Departments on cd.DepartmentID equals d.DepartmentID
                    join dc in medicalEntities.DepartmentCategories on d.DeptCategoryID equals dc.DeptCategoryID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    join doc in medicalEntities.Doctors on t.DoctorID equals doc.DoctorID
                    
                    where m.MemberID == memID
                    orderby r.ReserveDate descending
                    select new
                    {
                        看診日期 = r.ReserveDate,
                        看診醫師 = doc.DoctorName,               
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right,
                        看診科目 = d.DeptName,
                        科目類別 = dc.DeptCategoryName,
                        症狀描述 = c.SyndromeDescription,
                    };
            //join m in medical.Members on c.MemberID equals m.MemberID
            //join a in medical.ArticleComments on m.MemberID equals a.MemberID
            //join d in medical.Doctors on a.DoctorID equals d.DoctorID
            //select new { c.CaseID, m.MemberName, d.DoctorName };
            dataGridView1.DataSource = q.ToList();
        }                                               //方法.查詢病歷      
        private void btnCaseRecord_Click(object sender, EventArgs e)
        {
            memID = 1;
            cb_Year.Items.Clear();
            cb_Month.Items.Clear();
            cb_Day.Items.Clear();
            SelectCaseRecord();
            AddYearToCombo();            
        }                    //Demo MemID=1
        private void cb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhereYear();
        }           //選單.年篩選病歷
        private void WhereYear()
        {
            int y = Convert.ToInt32(cb_Year.SelectedItem);
            cb_Month.Items.Clear();
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join cd in medicalEntities.ClinicDetails on r.ClinicDetailID equals cd.ClinicDetailID
                    join d in medicalEntities.Departments on cd.DepartmentID equals d.DepartmentID
                    join dc in medicalEntities.DepartmentCategories on d.DeptCategoryID equals dc.DeptCategoryID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    join doc in medicalEntities.Doctors on t.DoctorID equals doc.DoctorID
                    where m.MemberID == memID && r.ReserveDate.Year == y 
                    orderby r.ReserveDate descending
                    select new
                    {
                        看診日期 = r.ReserveDate,
                        看診醫師 = doc.DoctorName,                        
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right,
                        看診科目 = d.DeptName,
                        科目類別 = dc.DeptCategoryName,
                        症狀描述 = c.SyndromeDescription,
                    };
            this.dataGridView1.DataSource = q.ToList();
            var s = from r in medicalEntities.Reserves
                    join m in medicalEntities.Members on r.MemberID equals m.MemberID
                    where m.MemberID == memID && r.ReserveDate.Year == y
                    group r by r.ReserveDate.Month into g
                    select g.Key;
            foreach (int i in s)
                cb_Month.Items.Add(i);

        }                                                        //方法.年篩選病歷
        
        private void cb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhereMonth();
        }          //按鈕.年月篩選病例
        private void WhereMonth()
        {
            int y = Convert.ToInt32(cb_Year.SelectedItem);
            int mon = Convert.ToInt32(cb_Month.SelectedItem);
            cb_Day.Items.Clear();
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join cd in medicalEntities.ClinicDetails on r.ClinicDetailID equals cd.ClinicDetailID
                    join d in medicalEntities.Departments on cd.DepartmentID equals d.DepartmentID
                    join dc in medicalEntities.DepartmentCategories on d.DeptCategoryID equals dc.DeptCategoryID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    join doc in medicalEntities.Doctors on t.DoctorID equals doc.DoctorID
                    where m.MemberID == memID && r.ReserveDate.Year == y && r.ReserveDate.Month == mon
                    orderby r.ReserveDate descending
                    select new
                    {
                        看診日期 = r.ReserveDate,
                        看診醫師 = doc.DoctorName,                        
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right,
                        看診科目 = d.DeptName,
                        科目類別 = dc.DeptCategoryName,
                        症狀描述 = c.SyndromeDescription,
                    };
            this.dataGridView1.DataSource = q.ToList();
            var z = from r in medicalEntities.Reserves
                    join m in medicalEntities.Members on r.MemberID equals m.MemberID
                    where m.MemberID == memID && r.ReserveDate.Year == y && r.ReserveDate.Month == mon 
                    group r by r.ReserveDate.Day into g
                    select g.Key;
            foreach (int i in z)
                cb_Day.Items.Add(i);
        }                                                       //方法.年月篩選病例
        
        private void cb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhereDay();
        }            //選單.年月日篩選病歷
        
        private void WhereDay()
        {
            int y = Convert.ToInt32(cb_Year.SelectedItem);
            int mon = Convert.ToInt32(cb_Month.SelectedItem);
            int dy = Convert.ToInt32(cb_Day.SelectedItem);
            var q = from c in medicalEntities.CaseRecords
                    join m in medicalEntities.Members on c.MemberID equals m.MemberID
                    join rs in medicalEntities.Reserves on c.ReserveID equals rs.ReserveID
                    join td in medicalEntities.TreatmentDetails on c.TreatmentDetailID equals td.TreatmentDetailID
                    join r in medicalEntities.Reserves on c.ReserveID equals r.ReserveID
                    join cd in medicalEntities.ClinicDetails on r.ClinicDetailID equals cd.ClinicDetailID
                    join d in medicalEntities.Departments on cd.DepartmentID equals d.DepartmentID
                    join dc in medicalEntities.DepartmentCategories on d.DeptCategoryID equals dc.DeptCategoryID
                    join t in medicalEntities.Treatments on td.TreatmentDetailID equals t.TreatmentDetailID
                    join doc in medicalEntities.Doctors on t.DoctorID equals doc.DoctorID
                    where m.MemberID == memID && r.ReserveDate.Year == y && r.ReserveDate.Month == mon && r.ReserveDate.Day == dy
                    orderby r.ReserveDate descending
                    select new
                    {
                        看診日期 = r.ReserveDate,
                        看診醫師 = doc.DoctorName,                        
                        體重 = m.Weight,
                        左眼視力 = m.OS_Left,
                        右眼視力 = m.OD_Right,
                        看診科目 = d.DeptName,
                        科目類別 = dc.DeptCategoryName,
                        症狀描述 = c.SyndromeDescription,
                    };
            this.dataGridView1.DataSource = q.ToList();
        }                                                         //方法.年月日篩選病歷

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                var q = medicalEntities.Doctors.Where(x => x.Member.MemberName.Equals(name));
                DoctorAddRating.doctorid = q.FirstOrDefault().DoctorID;

                this.Controls.Add(new UserControls.DoctorAddRating());
                this.Controls.Find("DoctorAddRating", false)[0].BringToFront();
            }
        }
    }
}
