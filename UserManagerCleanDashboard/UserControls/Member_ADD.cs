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
    public partial class Member_ADD : UserControl
    {
        public Member_ADD()
        {
            InitializeComponent();
            LoadCmbox();
            this.btnAdd.Enabled = false;
        }

        //string id = "";
        MedicalEntities medicalContext = new MedicalEntities();

        private void LoadCmbox()
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
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var q = from p in this.medicalContext.Members
                    where p.IdentityID == this.txtIdentityID.Text
                    select p;

            if (q.ToList().Count == 0)
            {
                MessageBox.Show("此帳號可以使用");
                this.btnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("此帳號使用過，請重新輸入");
                this.txtIdentityID.Text = "";
                this.txtIdentityID.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CityValue = ComboUitil.GetItem(cmbCity).Value;
            string GenderValue = ComboUitil.GetItem(cmbGender).Value;

            try
            {
                if (string.IsNullOrEmpty(this.txtIdentityID.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtIdentityID.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPassword.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.cmbGender.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cmbGender.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtBloodtype.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBloodtype.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtWeight.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtWeight.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtEmail.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtPhone.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPhone.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.cmbCity.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cmbCity.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtAddress.Text))
                {
                    MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtAddress.Focus();
                    return;
                }
                else
                {
                    Member member = new Member
                    {
                        IdentityID = this.txtIdentityID.Text,
                        Password = this.txtPassword.Text,
                        MemberName = this.txtName.Text,
                        BirthDay = this.dtpBirthday.Value,
                        GenderID = int.Parse(GenderValue),
                        BloodType = this.txtBloodtype.Text,
                        Weight = int.Parse(this.txtWeight.Text),
                        Email = this.txtEmail.Text,
                        Phone = this.txtPhone.Text,
                        CityID = int.Parse(CityValue),
                        Address = this.txtAddress.Text,
                        Role = 1
                    };
                    this.medicalContext.Members.Add(member);
                    this.medicalContext.SaveChanges();
                    MessageBox.Show("註冊成功");

                    //panel1.Controls.Clear();
                    panel1.Controls.Add(new Logon());
                    panel1.Controls.Find("Logon", false)[0].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = "as123";
            
            this.dtpBirthday.Value = new DateTime(2008, 5, 1, 8, 30, 52);
            this.cmbGender.SelectedIndex = 1;
            this.txtBloodtype.Text = "A";
            this.txtWeight.Text = "60";
            this.txtEmail.Text = "LLL@gmail.com";
            this.txtPhone.Text = "0900888888";
            this.cmbCity.SelectedIndex = 0;
            this.txtAddress.Text = "大安區復興南路一段390號2樓";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
            }
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
        }
    }
}
