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
    public partial class ReserveMain : UserControl
    {
        public ReserveMain()
        {
            InitializeComponent();
        }
        MedicalEntities dbContex = new MedicalEntities();

        private void ReservationMain_Load(object sender, EventArgs e)
        {
            var s = from dp in dbContex.Departments
                    select dp.DeptName;

            this.comboBox1.DataSource = s.ToList();

            //===============
            Button[] btn = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12 };
            //button放入陣列中，物件名要是Button才可使用button屬性
            //btn[0] = button1;
            //再把他們加入EventHandler中
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Click += new EventHandler(mybtn_Click);
            }

        }

        Button clockBtn = new Button();
        private void mybtn_Click(object sender, EventArgs e)
        {
            clockBtn = (Button)sender;

            //t_2.label9.Text = b.Text;
            ReserveConfirm.clock = clockBtn.Text;

        }
        //List<object> btnList = new List<object>();   //把btn加入list方便管理
        //private void BtnAddList()  //把btn加入list方便管理
        //{
        //    btnList.Add(this.button1);
        //TODO 把每個button分配datetime Hours
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q2 = from n in dbContex.Doctors
                     where n.DepartmentID == this.comboBox1.SelectedIndex + 1
                     select n.DoctorName;
            this.comboBox2.DataSource = q2.ToList();
        }
   //TreatmentItem t_2 = new TreatmentItem();
        private void button13_Click(object sender, EventArgs e)
        {
            ReserveConfirm.doctname = this.comboBox2.SelectedItem.ToString();
            ReserveConfirm.deptname = this.comboBox1.SelectedItem.ToString();
            ReserveConfirm.reservedate = this.monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");

            //t_2.str = this.comboBox2.SelectedItem.ToString();
            //t_2.label7.Text = this.comboBox2.SelectedItem.ToString();   //Modifiers設為public
            //t_2.label8.Text = this.monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");
            //t_2.label12.Text = this.comboBox1.SelectedItem.ToString();

            if (DateTime.Now.Hour > int.Parse(ReserveConfirm.clock.Substring(0,2)) || clockBtn.Text == "")
            {
                MessageBox.Show("請選取正確時間");
            }
            else
            {
                //t_2.FormClosing += T_FormClosing;  //for 繼承Form表單

                //t_2.Show();
                //表單2_關閉會發生例外，所以要將表單隱藏
                //https://social.msdn.microsoft.com/Forums/zh-TW/87104588-1ed5-4d4f-93bd-a2a0c0732a32/22914203093529927770?forum=233
                //https://dotblogs.com.tw/v6610688/2014/05/06/close_form_cannot_access_a_disposed_object
                this.Controls.Clear();
                this.Controls.Add(new ReserveConfirm());    //加入Control

                this.Controls.Find("ReserveConfirm", false)[0].BringToFront();
            }

        }


        //private void T_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true; //關閉視窗時取消
        //    t_2.Hide(); //隱藏式窗,下次再show出
        //}

        private void button14_Click(object sender, EventArgs e)
        {
            //ReserveSearch reserveSearch = new ReserveSearch();
            //reserveSearch.Show();
            this.Controls.Add(new ReserveSearch());

            this.Controls.Find("ReserveSearch", false)[0].BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //ClinicProgress clinicProgress = new ClinicProgress();
            //clinicProgress.Show();
            this.Controls.Add(new ClinicProgress());

            this.Controls.Find("ClinicProgress", false)[0].BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            var picture = from n in dbContex.Doctors.AsEnumerable()
                          where n.DoctorName == this.comboBox2.Text && n.Picture != null
                          select n.Picture;
            int a = picture.Count();
            if (a > 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(picture.FirstOrDefault());
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}

