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
    public partial class Complete : UserControl
    {
        public Complete()
        {
            InitializeComponent();
        }
        public static string doctname { get; set; }
        public static string deptname { get; set; }
        public static string reservedate { get; set; }
        public static string clock { get; set; }
        public static string callCount { get; set; }
        public static string roomNO { get; set; }
        public static string patientNote { get; set; }
        public static string IDID { get; set; }

        MedicalEntities dbContext = new MedicalEntities();
        private void Complete_Load(object sender, EventArgs e)
        {
            label12.Text = deptname;
            label7.Text = doctname;
            label8.Text = reservedate;
            label9.Text = clock;
            label2.Text = callCount;
            label4.Text = patientNote;
            label15.Text = roomNO;
            //=====================
            if (IDID == null)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Location = new Point(140, 25);
               dataGridView1.Visible = true;
                this.panel1.Visible = false;
                //this.label16.Visible = true;
                dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                callDataGrid();
                IDID = null;   //避免再度預約時會有上次的ID
            }
            //=============================
       
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.Name = "預約取消";
            btn.Text = "預約取消";
            btn.UseColumnTextForButtonValue = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new ReserveMain());

            this.Controls.Find("ReserveMain", false)[0].BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string value = dataGridView1.Rows[e.RowIndex].Cells["姓名"].Value.ToString();
            //DateTime date = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["看診日期"].Value;
            //if (e.ColumnIndex == dataGridView1.Columns["詳細資料"].Index)
            //{
            //    ViewDocPatDetail(value, date);
            //}
            //================
            if (MainPage.memberid > 0)           
            {
                DateTime dt = new DateTime();
                dt = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["預約日期"].Value;
                var q = (from d in dbContext.Reserves
                         where d.ReserveDate == dt
                         select d).FirstOrDefault();
                this.dbContext.Reserves.Remove(q);
                this.dbContext.SaveChanges();
                callDataGrid();
            }
            

            //if (e.ColumnIndex == 0)
            //{
            //    this.Controls.Add(new UserControls.DoctorAddRating());
            //    this.Controls.Find("DoctorAddRating", false)[0].BringToFront();
            //}
            //DateTime dp = new DateTime();
            //dp = (DateTime)this.dataGridView1.CurrentRow.Cells[3].Value;
            //var qqq = (from gg in dbContext.Reserves.AsEnumerable()
            //           join dd in dbContext.Members on gg.MemberID equals dd.MemberID
            //           join cd in dbContext.ClinicDetails on gg.ClinicDetailID equals cd.ClinicDetailID
            //           join dm in dbContext.Departments on cd.DepartmentID equals dm.DepartmentID
            //           where dm.DeptName == deptname && gg.ReserveDate.Date == dp
            //           orderby gg.ReserveDate
            //           orderby gg.ReserveID
            //           group gg by new { gg.MemberID, gg.ReserveDate.Date, V = reserveCCCount(gg.ReserveDate) } into g  //依照日期分群
            //           select new
            //           {
            //               日期 = g.Key.Date,
            //               會員ID = g.Key.MemberID,
            //               時段 = g.Key.V,
            //               預約數 = g.Count()
            //           });
            //label16.Text = qqq.預約數+"";

        }
        private void callDataGrid()
        {
            var q = from n in dbContext.Reserves
                    join dd in dbContext.Members on n.MemberID equals dd.MemberID
                    join cc in dbContext.ClinicDetails on n.ClinicDetailID equals cc.ClinicDetailID
                    join ff in dbContext.Departments on cc.DepartmentID equals ff.DepartmentID
                    join dc in dbContext.Doctors on cc.DoctorID equals dc.DoctorID
                    where dd.IdentityID == IDID
                    orderby n.ReserveDate 
                    select new
                    {
                        科別 = ff.DeptName,
                        醫師 = dc.DoctorName,
                        預約日期 = n.ReserveDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private string reserveCCCount(DateTime reCount)
        {
            if (reCount.Hour >= 9 && reCount.Hour <= 12)
            {
                return "早";
            }
            else if (reCount.Hour >= 13 && reCount.Hour <= 16)   //24小時制
            {
                return "午";
            }
            else if (reCount.Hour >= 17 && reCount.Hour <= 20)
            {
                return "晚";
            }
            else   //有回傳值的必定要有else(抓到其他不滿足上述條件的)
            {
                return "其他";
            }
        }
    }
}
