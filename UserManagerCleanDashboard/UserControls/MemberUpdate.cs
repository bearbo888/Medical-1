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
    public partial class MemberUpdate : UserControl
    {
        public MemberUpdate()
        {
            InitializeComponent();
            LoadCombox();
            MemberLord();
        }

        int id = MainPage.memberid;
        private void MemberLord()
        {
            var q = from p in this.medicalContext.Members
                    where p.MemberID == id
                    select p;

            foreach(var i in q)
            {
                txtIdentityID.Text = i.IdentityID;
                txtPassword.Text = i.Password;
                txtName.Text = i.MemberName;
                dtpBirthday.Value = i.BirthDay.Value;
                ComboUitil.SetItemValue(cmbGender, i.GenderID.ToString());
                txtBloodtype.Text = i.BloodType;
                txtWeight.Text = i.Weight.ToString();
                txtEmail.Text = i.Email;
                txtPhone.Text = i.Phone;
                ComboUitil.SetItemValue(cmbCity, i.CityID.ToString());
                txtAddress.Text = i.Address;
            }
        }

        
        MedicalEntities medicalContext = new MedicalEntities();
        private void LoadCombox()
        {
            var q = this.medicalContext.Cities.OrderBy(p => p.CityID);
            foreach (var i in q)
            {
                this.cmbCity.Items.Add(new ComboBoxItem(i.CityID.ToString(), i.CityName));
            }
            var d = this.medicalContext.Genders.OrderBy(o => o.GenderID);
            foreach (var i in d)
            {
                this.cmbGender.Items.Add(new ComboBoxItem(i.GenderID.ToString(), i.Gender1));
            }
            this.txtIdentityID.Enabled = false;

        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            string CityValue = ComboUitil.GetItem(cmbCity).Value;
            string GenderValue = ComboUitil.GetItem(cmbGender).Value;

            var product = (from p in this.medicalContext.Members
                           where p.IdentityID.Equals(txtIdentityID.Text.Trim())
                           // where p.IdentityID == txtIdentityID.Text
                           select p).FirstOrDefault();

            product.MemberName = this.txtName.Text;
            product.Password = this.txtPassword.Text;
            product.MemberName = this.txtName.Text;
            product.BirthDay = this.dtpBirthday.Value;
            product.GenderID = int.Parse(GenderValue);
            product.BloodType = this.txtBloodtype.Text;
            product.Weight = int.Parse(this.txtWeight.Text);
            product.Email = this.txtEmail.Text;
            product.Phone = this.txtPhone.Text;
            product.CityID = int.Parse(CityValue);
            product.Address = this.txtAddress.Text;

            medicalContext.SaveChanges();

            MessageBox.Show("更新成功! 請重新登入~");
            //this.Controls.Clear();
            panel1.Controls.Add(new Logon());
            panel1.Controls.Find("Logon", false)[0].BringToFront();
        }
        public class ComboBoxItem
        {
            public ComboBoxItem(string value, string text)
            {
                Value = value;
                Text = text;
            }
            public string Value
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

        public class ComboUitil
        {
            public static ComboBoxItem GetItem(ComboBox cbo)
            {
                ComboBoxItem item = new ComboBoxItem("", "");

                if (cbo.SelectedIndex > -1)
                {
                    item = cbo.Items[cbo.SelectedIndex] as ComboBoxItem;
                }
                return item;
            }

            public static void SetItemValue(ComboBox cbo, string value)
            {
                var selectesObject = cbo.Items.Cast<ComboBoxItem>().SingleOrDefault(i => i.Value.Equals(value));
                if (selectesObject != null)
                {
                    cbo.SelectedIndex = cbo.FindStringExact(selectesObject.Text.ToString());
                }
                else
                {
                    cbo.SelectedIndex = -1;
                }
            }
        }
    }
}
