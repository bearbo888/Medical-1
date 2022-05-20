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
    public partial class ClinicProgress : UserControl
    {
        public ClinicProgress()
        {
            InitializeComponent();
        }
        MedicalEntities dbContex = new MedicalEntities();
        private void ClinicProgress_Load_1(object sender, EventArgs e)
        {
            LoadCombox();
            LoadDoctor2();
        }
        private void LoadCombox()
        {
            this.comboBox1.Text = "請選擇科別";
            this.comboBox1.Items.Add(new ComboBoxItem(0, "請選擇科別"));

            //////var s = from dp in dbContex.Doctors
            //////        select new
            //////        {
            //////            DeptName = dp.Department.DeptName,
            //////            Deptid = dp.DepartmentID,
            //////            MyDoc = dp.DoctorName,
            //////            DocID = dp.DoctorID
            //////        };
            var ss =
                (from dp in dbContex.ClinicDetails
                select dp.Department.DeptName).Distinct();
                           
                       
                       //.Distinct().OrderBy(o => o.RoomID);

           // var s = ss.OrderBy(o=>o.RoomID);


            foreach (var item in ss)
                this.comboBox1.Items.Add(item);
            //foreach (var i in s)
            //{
            //    this.comboBox1.Items.Add(new ComboBoxItem(i.DeptName));
            //}
            //var t = from dp in dbContex.ClinicDetails
            //         orderby dp.DepartmentID
            //        select new
            //        {
            //            Deptid = dp.DepartmentID,
            //            DeptName = dp.Department.DeptName,
            //             DocID = dp.DoctorID,
            //             MyDoc = dp.Doctor.DoctorName
            //        };

            //foreach (var i in t)
            //{
            //    this.comboBox2.Items.Add(new ComboBoxItem((int)i.DocID, i.MyDoc));
            //}

            this.comboBox2.Items.Add(new ComboBoxItem(0, "全部醫師"));
            this.comboBox2.Text = "全部醫師";
        }

        private void LoadDoctor2()
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            //=======================================panel位置
            this.panel1.Location = new Point(50, 50);
            this.panel2.Location = new System.Drawing.Point(380, 50);
            //this.panel2.Size = new System.Drawing.Size(245, 138);
            this.panel3.Location = new System.Drawing.Point(715, 50);
            this.panel4.Location = new Point(50, 290);
            this.panel5.Location = new Point(380, 290);

            Label[] deptArray = { label3, label6, label9, label12, label19 };//科別名
            Label[] docArray = { label4, label7, label10, label13, label20 };//醫師名
            Label[] roomArray = { label5, label8, label11, label14, label21 };//診間
            Label[] CurrentNum = { label15, label16, label17, label18, label22 };//叫號
            DateTime dt = new DateTime();
            dt = this.dateTimePicker1.Value.Date;
            //dt = Convert.ToDateTime("2022/05/13");
            int w = 0;
            var qry = from q in dbContex.ClinicDetails

                      where q.ClinicDate.Value.Equals(dt)

                      select q;

            foreach (var q in qry)
            {
                deptArray[w].Text = q.Department.DeptName;                        //科別名
                docArray[w].Text = q.Doctor.DoctorName;                               //醫師名
                roomArray[w].Text = "診間 : " + q.ClinicRoom.RoomName;  //診間
                CurrentNum[w].Text = q.LimitNum + "";                                    //叫號
                w++;
            }
        }



        //private void LoadDoctor123()
        //{
        //    panel1.Visible = true;
        //    panel2.Visible = true;
        //    panel3.Visible = true;
        //    panel4.Visible = true;
        //    panel5.Visible = true;
        //    //=======================================panel位置
        //    this.panel1.Location = new Point(50, 50);
        //    this.panel2.Location = new System.Drawing.Point(380, 50);
        //    //this.panel2.Size = new System.Drawing.Size(245, 138);
        //    this.panel3.Location = new System.Drawing.Point(715, 50);
        //    this.panel4.Location = new Point(50, 290);
        //    this.panel5.Location = new Point(380, 290);
        //    //======================= //科別名
        //    Label[] deptArray = { label3, label6, label9, label12,label19 };

        //    string DoctorID = ((ComboBoxItem)comboBox2.SelectedItem).Value.ToString();

        //    for (int i = 0; i < deptArray.Length; i++)
        //    {
        //        var q1 = from d1 in dbContex.Doctors
        //                 join cc in dbContex.Departments on d1.DepartmentID equals cc.DepartmentID
        //                 where d1.DoctorID == int.Parse(DoctorID)
        //                 select new
        //                 {
        //                     cc.DeptName
        //                 };
        //        foreach (var k1 in q1)
        //        {
        //            //label3.Text = k1.DoctorName;
        //            deptArray[i].Text = k1.DeptName;
        //        }
        //    }
        //    //=======================
        //    Label[] docArray = { label4, label7, label10, label13,label20 };    //醫師名
        //    for (int i = 0; i < docArray.Length; i++)
        //    {
        //        var q2 = from d1 in dbContex.Doctors
        //                 where d1.DoctorID == i + 1
        //                 select new
        //                 {
        //                     d1.DoctorName
        //                 };
        //        foreach (var k2 in q2)
        //        {
        //            //label3.Text = k1.DoctorName;
        //            docArray[i].Text = k2.DoctorName;
        //        }
        //    }
        //    //MessageBox.Show(docArray[0] +"."+ docArray[1] +"."+ docArray[2]);
        //    //=============================//診間
        //    Label[] roomArray = { label5, label8, label11, label14, label21 };
        //    for (int i = 0; i < roomArray.Length; i++)
        //    {
        //        var q3 = from d1 in dbContex.Doctors
        //                 join cc in dbContex.ClinicDetails on d1.DoctorID equals cc.DoctorID
        //                 join gg in dbContex.ClinicRooms on cc.RoomID equals gg.RoomID
        //                 where d1.DoctorID == i + 1
        //                 select new
        //                 {
        //                     gg.RoomName
        //                 };
        //        foreach (var k3 in q3)
        //        {
        //            //label3.Text = k1.DoctorName;
        //            roomArray[i].Text = "診間 : " + k3.RoomName;
        //        }
        //    }
        //    //==============================  //叫號
        //    Label[] CurrentNum = { label15, label16, label17, label18 ,label22};
        //    for (int i = 0; i < CurrentNum.Length; i++)
        //    {
        //        DateTime dt = new DateTime();
        //        dt = this.dateTimePicker1.Value.Date;
        //        //dt = Convert.ToDateTime("2022/05/13");
        //        var q4 = from d1 in dbContex.Doctors
        //                 join cc in dbContex.ClinicDetails on d1.DoctorID equals cc.DoctorID
        //                 join gg in dbContex.ClinicRooms on cc.RoomID equals gg.RoomID
        //                 where d1.DoctorID == i + 1&&  cc.ClinicDate.Value==dt      //今天
        //                 select new
        //                 {
        //                    cc.LimitNum
        //                 };

        //        foreach(var k4 in q4)
        //        {

        //            CurrentNum[i].Text = k4.LimitNum+"";

        //        }
        //    }
        //}

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            this.comboBox2.Items.Add(new ComboBoxItem(0, "全部醫師"));

            //////////var q1 = from n in dbContex.Doctors
            //////////         where n.DepartmentID == this.comboBox1.SelectedIndex
            //////////         select n;
            ////////////this.comboBox2.DataSource = q1.ToList();   //TODO 顯示全部醫師

            //////////foreach (var i in q1)
            //////////{
            //////////    this.comboBox2.Items.Add(new ComboBoxItem(i.DoctorID, i.DoctorName));
            //////////}

            //this.comboBox2.Items.AddRange(q1.ToArray());   //使用AddRange搭配ToArray轉成陣列
            //this.comboBox2.Text = q1.ToString();
            string deptS = this.comboBox1.SelectedItem.ToString();
            var q1 = (from n in dbContex.Doctors
                     join j in dbContex.Departments on n.DepartmentID equals j.DepartmentID
                     join cd in dbContex.ClinicDetails on j.DepartmentID equals cd.DepartmentID
                     where j.DeptName == deptS
                     orderby j.DepartmentID
                     select n.DoctorName).Distinct();
            this.comboBox2.Items.Clear();
            this.comboBox2.Items.AddRange(q1.ToArray());   //使用AddRange搭配ToArray轉成陣列


            //var q2 = (from n in dbContex.Doctors
            //          where n.DepartmentID == this.comboBox1.SelectedIndex
            //          select new
            //          { n.DoctorName }).FirstOrDefault();
            //if (q2 != null)                //避免index為0時DeptID為0的null例外
            //{
            //    this.comboBox2.Text = q2.DoctorName;
            //}

            //=======================================


            if (comboBox1.Text == "請選擇科別")
            {
                LoadDoctor2();
            }
            else
            {
                //var qq = (from d in dbContex.Departments
                //          where d.DepartmentID == this.comboBox1.SelectedIndex
                //          select new
                //          {
                //              d.DepartmentID
                //          }).FirstOrDefault();
                if (this.comboBox1.SelectedIndex == 1)
                {
                    panel1.Visible = true;
                    this.panel1.Location = new System.Drawing.Point(50, 50);    //移至panel1的位子
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                }
                else if (this.comboBox1.SelectedIndex == 2)
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    this.panel2.Location = new System.Drawing.Point(50, 50);    //移至panel1的位子
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                }
                else if (this.comboBox1.SelectedIndex == 3)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = false;
                    this.panel3.Location = new System.Drawing.Point(50, 50);
                    this.panel4.Location = new System.Drawing.Point(380, 50);
                }
                else if (this.comboBox1.SelectedIndex == 4)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    this.panel5.Location = new System.Drawing.Point(50, 50);
                    panel5.Visible = true;
                    //this.panel5.Location = new System.Drawing.Point(380, 50);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var q1 = from n in dbContex.Doctors
                     orderby n.DoctorID
                     select n.DoctorName;
            String[] dtname = q1.ToArray();          //醫師名陣列
            //MessageBox.Show(dtname[0] + "." + dtname[1] + "." + dtname[2] + "." + dtname[3]);   //TestArray
            if (comboBox2.Text == dtname[0])
            {
                panel1.Visible = true;
                this.panel1.Location = new System.Drawing.Point(50, 50);    //移至panel1的位子
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
            }
            else if (comboBox2.Text == dtname[1])
            {
                panel1.Visible = false;
                panel2.Visible = true;
                this.panel2.Location = new System.Drawing.Point(50, 50);    //移至panel1的位子
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
            }
            else if (comboBox2.Text == dtname[2])
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                this.panel3.Location = new System.Drawing.Point(50, 50);
            }
            else if (comboBox2.Text == dtname[3])
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
                this.panel4.Location = new System.Drawing.Point(50, 50);
                panel5.Visible = false;
            }
            else if (comboBox2.Text == dtname[4])
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                this.panel5.Location = new System.Drawing.Point(50, 50);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new ReserveMain());

            this.Controls.Find("ReserveMain", false)[0].BringToFront();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDoctor2();
        }


        //private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)    //Border顏色
        //{
        //    ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.BurlyWood, ButtonBorderStyle.Solid);
        //}


        public class ComboBoxItem
        {
            public ComboBoxItem(int value, string text)
            {
                Value = value;
                Text = text;
            }
            public int Value
            {
                get;
                set;
            }
            public string Text
            {
                get;
                set;
            }
            public override string ToString()
            {
                return Text;
            }
        }
    }
}