using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical.UserControls
{
    public partial class Clinic : UserControl
    {
        public Clinic()
        {
            InitializeComponent();
            LoadData();
            loadCombox();
        }
        MedicalEntities medicalContext = new MedicalEntities();

        string i;
        int start = 0;
        int end = 0;
        CultureInfo ci = new CultureInfo("zh-tw");

        private void loadCombox()
        {
            var q = medicalContext.Doctors;

            foreach (var i in q)
            {
                this.cmbDoctor.Items.Add(new ComboBoxItem(i.DoctorID, i.DoctorName));
            }

            //var q2 = medicalContext.Periods;

            //foreach (var i in q2)
            //{
            //    this.cmbPeriod.Items.Add(new ComboBoxItem(i.PeriodID, i.PeriodDetail));
            //}

            //var q3 = medicalContext.ClinicRooms;

            //foreach (var i in q3)
            //{
            //    this.cmbRoom.Items.Add(new ComboBoxItem(i.RoomID, i.RoomName));
            //}
        }

        void LoadData()
        {
            DateTime now = DateTime.Now;
            string DWShortName = ci.DateTimeFormat.GetShortestDayName(DateTime.Today.DayOfWeek);
            string DWName = ci.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);

            i = now.DayOfWeek.ToString();
            int num = (int)now.DayOfWeek;

            start = now.AddDays(0 - num).Day;
            end = now.AddDays(6 - num).Day;
           
            tb7.Text = $"{now.Month}/{now.AddDays(0 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(0 - num).DayOfWeek)})";
            tb1.Text = $"{now.Month}/{now.AddDays(1 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(1 - num).DayOfWeek)})";
            tb2.Text = $"{now.Month}/{now.AddDays(2 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(2 - num).DayOfWeek)})";
            tb3.Text = $"{now.Month}/{now.AddDays(3 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(3 - num).DayOfWeek)})";
            tb4.Text = $"{now.Month}/{now.AddDays(4 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(4 - num).DayOfWeek)})";
            tb5.Text = $"{now.Month}/{now.AddDays(5 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(5 - num).DayOfWeek)})";
            tb6.Text = $"{now.Month}/{now.AddDays(6 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(6 - num).DayOfWeek)})";
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

        public enum dw
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime now = e.Start;

            i = now.DayOfWeek.ToString();
            int num = (int)now.DayOfWeek;

            start = now.AddDays(0 - num).Day;
            end = now.AddDays(6 - num).Day;

            tb7.Text = $"{now.Month}/{now.AddDays(0 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(0 - num).DayOfWeek)})";
            tb1.Text = $"{now.Month}/{now.AddDays(1 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(1 - num).DayOfWeek)})";
            tb2.Text = $"{now.Month}/{now.AddDays(2 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(2 - num).DayOfWeek)})";
            tb3.Text = $"{now.Month}/{now.AddDays(3 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(3 - num).DayOfWeek)})";
            tb4.Text = $"{now.Month}/{now.AddDays(4 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(4 - num).DayOfWeek)})";
            tb5.Text = $"{now.Month}/{now.AddDays(5 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(5 - num).DayOfWeek)})";
            tb6.Text = $"{now.Month}/{now.AddDays(6 - num).Day}({ci.DateTimeFormat.GetShortestDayName(now.AddDays(6 - num).DayOfWeek)})";

            if(cmbDoctor.SelectedItem != null)
            {
                reset();

                int DoctorID = (int)((ComboBoxItem)cmbDoctor.SelectedItem).Value;

                var qry = from q in medicalContext.ClinicDetails.AsEnumerable() where q.DoctorID.Equals(DoctorID) select q;

                if (qry.Count() > 0)
                {
                    qry = qry.Where(x => x.ClinicDate.Value.Day > start && x.ClinicDate.Value.Day < end).OrderBy(x => x.ClinicDate);

                    foreach (var i in qry)
                    {
                        switch (i.ClinicDate.Value.DayOfWeek.ToString())
                        {
                            case "Monday":
                                if (i.PeriodID == 1) { ckb10.Checked = true; }
                                if (i.PeriodID == 2) { ckb11.Checked = true; }
                                if (i.PeriodID == 3) { ckb12.Checked = true; }
                                break;
                            case "Tuesday":
                                if (i.PeriodID == 1) { ckb20.Checked = true; }
                                if (i.PeriodID == 2) { ckb21.Checked = true; }
                                if (i.PeriodID == 3) { ckb22.Checked = true; }
                                break;
                            case "Wednesday":
                                if (i.PeriodID == 1) { ckb30.Checked = true; }
                                if (i.PeriodID == 2) { ckb31.Checked = true; }
                                if (i.PeriodID == 3) { ckb32.Checked = true; }
                                break;
                            case "Thursday":
                                if (i.PeriodID == 1) { ckb40.Checked = true; }
                                if (i.PeriodID == 2) { ckb41.Checked = true; }
                                if (i.PeriodID == 3) { ckb42.Checked = true; }
                                break;
                            case "Friday":
                                if (i.PeriodID == 1) { ckb50.Checked = true; }
                                if (i.PeriodID == 2) { ckb51.Checked = true; }
                                if (i.PeriodID == 3) { ckb52.Checked = true; }
                                break;
                        }
                    }
                }
            }

        }


        internal void UISwitch(int PeriodID)
        {
            
        }

        void reset()
        {
            //平日
            ckb10.Checked = ckb11.Checked = ckb12.Checked = ckb20.Checked = ckb21.Checked = ckb22.Checked = false;
            ckb30.Checked = ckb31.Checked = ckb32.Checked = ckb40.Checked = ckb41.Checked = ckb42.Checked = false;
            ckb50.Checked = ckb51.Checked = ckb52.Checked = false;
            //假日
            ckb00.Checked = ckb01.Checked = ckb02.Checked = ckb60.Checked = ckb61.Checked = ckb62.Checked = false;


            //ckb10.Enabled = ckb11.Enabled = ckb12.Enabled = ckb20.Enabled = ckb21.Enabled = ckb22.Enabled = false;
            //ckb30.Enabled = ckb31.Enabled = ckb32.Enabled = ckb40.Enabled = ckb41.Enabled = ckb42.Enabled = false;
            //ckb50.Enabled = ckb51.Enabled = ckb52.Enabled = false;
            ////假日
            //ckb00.Enabled = ckb01.Enabled = ckb02.Enabled = ckb60.Enabled = ckb61.Enabled = ckb62.Enabled = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            reset();

            int DoctorID = (int)((ComboBoxItem)cmbDoctor.SelectedItem).Value;

            var qry = from q in medicalContext.ClinicDetails.AsEnumerable() where q.DoctorID.Equals(DoctorID) select q;

            if (qry.Count() > 0)
            {
                qry = qry.Where(x => x.ClinicDate.Value.Day > start && x.ClinicDate.Value.Day < end);//.OrderBy(x=>x.ClinicDate);

                foreach(var i in qry)
                {
                    switch (i.ClinicDate.Value.DayOfWeek.ToString())
                    {
                        case "Monday":
                            if (i.PeriodID == 1) { ckb10.Checked = true; }
                            if (i.PeriodID == 2) { ckb11.Checked = true; }
                            if (i.PeriodID == 3) { ckb12.Checked = true; }
                            break;
                        case "Tuesday":
                            if (i.PeriodID == 1) { ckb20.Checked = true; }
                            if (i.PeriodID == 2) { ckb21.Checked = true; }
                            if (i.PeriodID == 3) { ckb22.Checked = true; }
                            break;
                        case "Wednesday":
                            if (i.PeriodID == 1) { ckb30.Checked = true; }
                            if (i.PeriodID == 2) { ckb31.Checked = true; }
                            if (i.PeriodID == 3) { ckb32.Checked = true; }
                            break;
                        case "Thursday":
                            if (i.PeriodID == 1) { ckb40.Checked = true; }
                            if (i.PeriodID == 2) { ckb41.Checked = true; }
                            if (i.PeriodID == 3) { ckb42.Checked = true; }
                            break;
                        case "Friday":
                            if (i.PeriodID == 1) { ckb50.Checked = true; }
                            if (i.PeriodID == 2) { ckb51.Checked = true; }
                            if (i.PeriodID == 3) { ckb52.Checked = true; }
                            break;
                    }
                }
            }

        }
    }
}
