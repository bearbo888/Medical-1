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
    
    public partial class ReserveConfirm : UserControl
    {
        //private static string _name;
        //public static string name {
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public static string doctname { get; set; }
        public static string deptname { get; set; }
        public static string reservedate { get; set; }
        public static string clock { get; set; }

        public ReserveConfirm()
        {
            InitializeComponent();
        }
        
        private void TreatmentItem_Load(object sender, EventArgs e)
        {
            label12.Text = deptname;
            label7.Text = doctname;
            label8.Text = reservedate;
            label9.Text = clock;
            patientCount();
            label11.Text = k.ToString();
        }
        private void patientCount()   //要再分類科別
        {
            var qqq = from gg in dbC.Reserves.AsEnumerable()
                      join cd in dbC.ClinicDetails on gg.ClinicDetailID equals cd.ClinicDetailID
                      join dm in dbC.Departments on cd.DepartmentID equals dm.DepartmentID
                      where dm.DeptName == deptname
                      group gg by new { gg.ReserveDate.Date, V = reserveCCCount(gg.ReserveDate) } into g  //依照日期分群
                      select new
                      {
                          日期 = g.Key.Date,
                          時段 = g.Key.V,
                          預約數 = g.Count()
                      };
            DateTime h = Convert.ToDateTime(reservedate+" "+clock);   //傳入日期則沒有時間,btn傳來的時間沒有日期
            string bb = reserveCCCount(h);
            var ooo = (from j in qqq
                       where j.日期 == Convert.ToDateTime(label8.Text)&&j.時段==bb   //抓早中晚
                       select j).FirstOrDefault();
            
            //k = ooo.預約數;
            //a = ooo.日期.ToString();
            if(ooo == null)
            {
                k = 0;
            }
            else
            {
                k = ooo.預約數;
            }
        }
        int k ;
        //string a = "";
        MedicalEntities dbC = new MedicalEntities();

        private void button1_Click_1(object sender, EventArgs e)
        {
            //======================================================
            //======================================================
            //======================================================
            //var qqq = from gg in dbC.Reserves 
            //          //where gg.ReserveDate.Hour>=9&&gg.ReserveDate.Hour<=12
            //          group gg by reserveCCCount() into g

            //var qqq = from gg in dbC.Reserves.AsEnumerable()
            //          group gg by new { gg.ReserveDate.Date, V = reserveCCCount(gg.ReserveDate) } into g  //依照日期分群
            //          select new
            //          {
            //              日期 = g.Key.Date,
            //              時段 = g.Key.V,
            //              預約數 = g.Count()
            //          };
            //var ooo = (from j in qqq
            //           where j.日期.ToString() == label8.Text
            //           select j).FirstOrDefault();
            patientCount();
            if (k + 1 > 6)
            {
                MessageBox.Show("預約已額滿");
            }
            else
            {
                this.label11.Text = k.ToString();

                //======================================================
                //===================================此為使用limitNum(燈號)限制人數
                var clinicCount = (from di in dbC.ClinicDetails      //目前只用在Complete.callCount   給Complete表單亮燈號
                                   join a in dbC.Doctors on di.DoctorID equals a.DoctorID
                                   join n in dbC.Departments on a.DepartmentID equals n.DepartmentID
                                   where a.DoctorName == this.label7.Text && n.DeptName == label12.Text
                                   select di).FirstOrDefault();
                //////if (clinicCount.LimitNum + 1 > 6)
                //////{
                //////    MessageBox.Show("預約已額滿");
                //////}
                //////else
                //////{
                //////    if(clinicCount.LimitNum==null)
                //////    {
                //////        clinicCount.LimitNum = 0;
                //////    }
                //////    clinicCount.LimitNum++;
                //////    this.dbC.SaveChanges();
                //TODO 如果limitCount要跟StateID綁的話
                //Complete.callCount = (from n in dbC.Reserves
                //                      where n.MemberID == 4 && n.StateID == 2  //TODO   MemberID  為流水號，要由登入系統抓到? //針對預約狀態為?的(未看診)       
                //                      select n.ReserveID).FirstOrDefault().ToString();      //TODO 無法用LastOrDefault() 抓到新增的那筆???

                //==============================================
                var reserveValues = (from di in dbC.ClinicDetails
                                     join a in dbC.Doctors on di.DoctorID equals a.DoctorID
                                     join n in dbC.Departments on a.DepartmentID equals n.DepartmentID
                                     join r in dbC.ClinicRooms on di.RoomID equals r.RoomID
                                     where a.DoctorName == this.label7.Text && n.DeptName == label12.Text
                                     select di).FirstOrDefault();

                Reserve reserve = new Reserve
                {
                    MemberID = 4,    //TODO   MemberID  為流水號，要由登入系統抓到?
                    StateID = 2,           //TODO 應為未預約
                    ClinicDetailID = reserveValues.ClinicDetailID,
                    //ReserveDate = r_1.monthCalendar1.SelectionStart.Date,    //TODO 設定格式 抓到小時
                    ReserveDate = Convert.ToDateTime($"{label8.Text} {label9.Text}"),
                    //TODO 無法呼叫前一個表單的日期，目前使用字串輸入
                    //轉型別 Convert.ToDateTime(string)   --string格式有要求，必須是yyyy-MM-dd hh:mm:ss
                    Remark_Patient = textBox1.Text,
                    SourceID = 1    //網路預約
                };
                this.dbC.Reserves.Add(reserve);
                this.dbC.SaveChanges();   //查看資料表
                                          //=============================================

                Complete.doctname = this.label12.Text;
                Complete.deptname = this.label7.Text;
                Complete.reservedate = this.label8.Text;
                Complete.clock = this.label9.Text;
                Complete.patientNote = textBox1.Text;
                Complete.callCount = (k+1).ToString();

                Complete.roomNO = reserveValues.ClinicRoom.RoomName;
                

                MessageBox.Show("預約成功!?");
                //cpt.Show();
                this.Controls.Add(new Complete());

                this.Controls.Find("Complete", false)[0].BringToFront();
                //===========================================

            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new ReserveMain());

            this.Controls.Find("ReserveMain", false)[0].BringToFront();
        }
    }
}