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
    public partial class Schedule : UserControl
    {
        public Schedule()
        {
            InitializeComponent();
            loadCombox();
            Loadgv();
        }

        MedicalEntities medicalContext = new MedicalEntities();

        private void Loadgv()
        {
            var qry = from q in medicalContext.ClinicDetails.AsEnumerable()
                      select new 
            { 
                診間編號 = q.ClinicDetailID,
                醫生 = q.Doctor.DoctorName,
                科別 = q.Department.DeptName,
                時段 = q.Period.PeriodDetail,
                q.Online,
                診間 = q.ClinicRoom.RoomName,
                日期 = ((DateTime)q.ClinicDate).ToString("yyyy-MM-dd") 
            };

            gvSchedule.DataSource = qry.ToList();
        }

        

        private void loadCombox()
        {
            var q = medicalContext.Doctors;

            foreach (var i in q)
            {
                this.cmbDoctor.Items.Add(new ComboBoxItem(i.DoctorID, i.DoctorName));
            }

            var q2 = medicalContext.Periods;

            foreach (var i in q2)
            {
                this.cmbPeriod.Items.Add(new ComboBoxItem(i.PeriodID, i.PeriodDetail));
            }

            var q3 = medicalContext.ClinicRooms;

            foreach (var i in q3)
            {
                this.cmbRoom.Items.Add(new ComboBoxItem(i.RoomID, i.RoomName));
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbDepartment.Items.Clear();

            var q = from p in this.medicalContext.Doctors
                    where p.DoctorName.Equals(cmbDoctor.Text)
                    select p.Department;

            foreach (var i in q)
            {
                this.cmbDepartment.Items.Add(new ComboBoxItem(i.DepartmentID, i.DeptName));
                this.cmbDepartment.Text = i.DeptName;
            }


        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string DoctorID = ((ComboBoxItem)cmbDoctor.SelectedItem).Value.ToString();
            string DepartmentID = ((ComboBoxItem)cmbDepartment.SelectedItem).Value.ToString();
            string PeriodID = ((ComboBoxItem)cmbPeriod.SelectedItem).Value.ToString();
            string RoomID = ((ComboBoxItem)cmbRoom.SelectedItem).Value.ToString();

            ClinicDetail clinic = new ClinicDetail
            {
                DoctorID = int.Parse(DoctorID),
                DepartmentID = int.Parse(DepartmentID),
                PeriodID = int.Parse(PeriodID),
                RoomID = int.Parse(RoomID),
                ClinicDate = DateTimePicker1.Value,
                Online = 0,
                LimitNum = 1
            };

            medicalContext.ClinicDetails.Add(clinic);
            medicalContext.SaveChanges();

            Loadgv();
        }

    }
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
