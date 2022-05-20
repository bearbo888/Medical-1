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
    public partial class MyDoctor_MyClinic : UserControl
    {
        int doctorID = MainPage.doctorid;
        public MyDoctor_MyClinic()
        {
            InitializeComponent();
        }

        private void MyDoctor_Platform_Load(object sender, EventArgs e)
        {
            gv.DataSource = null;



            string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

            MedicalEntities medicalContext = new MedicalEntities();
            var qry = from q in medicalContext.ClinicDetails.AsEnumerable()
                      where q.DoctorID == doctorID
                      select new
                      {
                          門診編號 = q.ClinicDetailID,
                          日期 = ((DateTime)q.ClinicDate).ToString("yyyy-MM-dd"),
                          星期 = Day[Convert.ToInt32(((DateTime)q.ClinicDate).DayOfWeek)].ToString(),
                          時段 = q.Period.PeriodDetail,
                          門診 = q.Department.DeptName,
                          診間 = q.ClinicRoom.RoomName,
                          掛號人數 = (from X in medicalContext.Reserves where X.ClinicDetailID.Equals(q.ClinicDetailID) select X).Count()
                      };


            if (qry.Count()>0)
            {

                gv.DataSource = qry.ToList();
            }

            DataGridViewLinkColumn column = new DataGridViewLinkColumn(); 
            column.Name = "功能"; 
            column.UseColumnTextForLinkValue = true;
            column.Text = "進入工作區"; 
            column.LinkBehavior = LinkBehavior.HoverUnderline; 
            column.TrackVisitedState = true; 
            gv.Columns.Add(column);

        }

        //CellContentClick事件處理器
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
            DataGridView dgv = (DataGridView)sender; 
            if (dgv.Columns[e.ColumnIndex].Name == "功能")
            {
                // MessageBox.Show(dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                DataGridViewLinkCell cell = (DataGridViewLinkCell)dgv[e.ColumnIndex, e.RowIndex]; 
                cell.LinkVisited = true;

                MyDoctor_DoctorWork.clinicid = (int)dgv.Rows[e.RowIndex].Cells[1].Value; 

                this.Controls.Clear();
                this.Controls.Add(new MyDoctor_DoctorWork());
                this.Controls.Find("MyDoctor_DoctorWork", false)[0].BringToFront();
            } 
        }


    }
}
