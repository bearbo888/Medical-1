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
    public partial class MemberCenter_Admin : UserControl
    {
        
        public MemberCenter_Admin()
        {
            InitializeComponent();
            lodCmb();
            datalod();
            Addmember();

        }

        private void Addmember()
        {
            if (MainPage.hasAuth == true)
            {
                var result = (from m in medicalContext.Members
                              where m.MemberID == MainPage.memberid
                              select m).FirstOrDefault();
                this.txtIdentityID.Text = result.IdentityID;
                this.txtName.Text = result.MemberName;
                this.txtPassword.Text = result.Password;
                this.dtpBirthday.Value = result.BirthDay.Value;
                this.cmbGender.Text = result.Gender.ToString();
                this.cmbBloodType.Text = result.BloodType;
                this.txtWeight.Text = result.Weight.ToString();
                this.txtEmail.Text = result.Email;
                this.txtPhone.Text = result.Phone;
                this.cmbCity.Text = result.City.ToString();
                this.txtAddress.Text = result.Address;
            }      
       }

        MedicalEntities medicalContext = new MedicalEntities();
        int MemID = 0;

        private void lodCmb()
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new Member_ADD());
            this.panel1.Controls.Find("Member_ADD", false)[0].BringToFront();
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {

            string CityValue = ComboUitil.GetItem(cmbCity).Value;
            string GenderValue = ComboUitil.GetItem(cmbGender).Value;

            var q = (from m in this.medicalContext.Members
                     where m.IdentityID == this.txtIdentityID.Text
                     select m).FirstOrDefault();
            if (this.txtName.Text != "")
            {
                q.MemberName = this.txtName.Text;
                q.Password = this.txtPassword.Text;
                q.BirthDay = this.dtpBirthday.Value;
                q.GenderID = int.Parse(GenderValue); 
                q.BloodType = this.cmbBloodType.Text;
                q.Weight = int.Parse(this.txtWeight.Text);
                q.Email = this.txtEmail.Text;
                q.Phone = this.txtPhone.Text;
                q.CityID = int.Parse(CityValue);
                q.Address = this.txtAddress.Text;
                medicalContext.SaveChanges();

                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("請輸入完整資料");               
            }

            

            datalod();
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MemID = (int)this.siticoneDataGridView2.CurrentRow.Cells[0].Value;
            MemberLod();
        }
        private void MemberLod()
        {
            var q = from p in this.medicalContext.Members
                    where p.MemberID == MemID
                    select p;

            foreach (var i in q)
            {
                txtIdentityID.Text = i.IdentityID;
                txtPassword.Text = i.Password;
                txtName.Text = i.MemberName;
                dtpBirthday.Value = i.BirthDay.Value;
                ComboUitil.SetItemValue(cmbGender, i.GenderID.ToString());
                cmbBloodType.Text = i.BloodType;
                txtWeight.Text = i.Weight.ToString();
                txtEmail.Text = i.Email;
                txtPhone.Text = i.Phone;
                ComboUitil.SetItemValue(cmbCity, i.CityID.ToString());
                txtAddress.Text = i.Address;
            }
        }
        private void datalod()
        {
            var q = from p in this.medicalContext.Members
                    select new
                    {
                        會員ID = p.MemberID,
                        會員帳號 = p.IdentityID,
                        會員密碼 = p.Password,
                        會員姓名 = p.MemberName,
                        會員生日 = p.BirthDay,
                        會員性別 = p.GenderID,
                        會員血型 = p.BloodType,
                        會員體重 = p.Weight,
                        會員IC_Card = p.IC_Card_No,
                        會員Email = p.Email,
                        會員電話 = p.Phone,
                        會員右眼視力 = p.OD_Right,
                        會員左眼視力 = p.OS_Left,
                        會員權限 = p.Role,
                        會員地區 = p.CityID,
                        會員地址 = p.Address
                    };

            this.siticoneDataGridView2.DataSource = q.ToList();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            var q = (from p in this.medicalContext.Members
                     where p.MemberID == MemID
                     select p).FirstOrDefault();
            DialogResult result = MessageBox.Show("確定要刪除?", "刪除會員資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.medicalContext.Members.Remove(q);
                this.medicalContext.SaveChanges();

                this.txtIdentityID.Text = "";
                this.txtName.Text = "";
                this.txtPassword.Text = "";
                this.txtName.Text = "";
                this.dtpBirthday.Value = DateTime.Now;
                this.cmbGender.Text = "";
                this.cmbBloodType.Text = "";
                this.txtWeight.Text = "";
                this.txtEmail.Text = "";
                this.txtPhone.Text = "";
                this.cmbCity.Text = "";
                this.txtAddress.Text = "";
                MessageBox.Show("刪除成功");
            }
            datalod();
            
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
