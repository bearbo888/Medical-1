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
    public partial class ReserveSearch : UserControl
    {
        public ReserveSearch()
        {
            InitializeComponent();
        }
        MedicalEntities dbC = new MedicalEntities();

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "c124865897";
            this.dateTimePicker1.Value = Convert.ToDateTime("1996/12/08");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var q = (from n in dbC.Members   //TODO 從Member4的身分證測試
                     where n.IdentityID == textBox1.Text && n.BirthDay == dateTimePicker1.Value
                     select n.MemberID).FirstOrDefault();

            //Complete cpt = new Complete();   //秀出資訊到complete表單
            var g = from s in dbC.Reserves   //瘋狂JOIN
                    where s.MemberID == q  //&&s.StateID == 2    //TODO 等決定好stateID幾號再來設
                    join d in dbC.ClinicDetails on s.ClinicDetailID equals d.ClinicDetailID
                    join p in dbC.Departments on d.DepartmentID equals p.DepartmentID
                    join c in dbC.Doctors on d.DoctorID equals c.DoctorID
                    join r in dbC.ClinicRooms on d.RoomID equals r.RoomID
                    join m in dbC.Members on s.MemberID equals m.MemberID
                    select new
                    {
                        s.Remark_Patient,
                        s.ReserveDate,
                        c.DoctorName,
                        //s.MemberID,
                        m.IdentityID,
                        p.DeptName,
                        r.RoomName,
                        s.ReserveID
                    };
            foreach (var kk in g)
            {
                Complete.deptname = $"{kk.DeptName}";
                Complete.doctname = $"{kk.DoctorName}";
                Complete.reservedate = $"{kk.ReserveDate.ToString("yyyy/MM/dd")}";
                Complete.clock = $"{kk.ReserveDate.ToString("hh:mm")}";
                Complete.patientNote = $"{kk.Remark_Patient}";
                Complete.roomNO = $"{kk.RoomName}";
                //================================
                ////////////Complete.callCount = $"{kk.ReserveID}";    
                //////////////TODO 要改掉
                //=================================
                Complete.IDID = $"{kk.IdentityID}";
            }

            //cpt.label2.Text = (from n in dbC.Reserves
            //                   where n.MemberID == q && n.StateID == 2  //TODO   MemberID  為流水號，要由登入系統抓到? //針對預約狀態為?的(未看診)       
            //                   select n.ReserveID).FirstOrDefault().ToString();      //TODO 無法用LastOrDefault() 抓到新增的那筆???
         
            
            this.Controls.Add(new Complete());

            this.Controls.Find("Complete", false)[0].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new ReserveMain());

            this.Controls.Find("ReserveMain", false)[0].BringToFront();
        }
    }
}