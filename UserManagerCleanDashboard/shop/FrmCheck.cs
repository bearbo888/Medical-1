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
    public partial class FrmCheck : UserControl
    {
        public FrmCheck()
        {
            InitializeComponent();
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
                get;set;
            }
            public string Text
            {
                get;set;
            }
            public override string ToString()
            {
                return Text;
            }
        }
        ComboBoxItem cmbi;

       MedicalEntities dbContext = new MedicalEntities();
        
        int sum;
        private void FrmCheck_Load(object sender, EventArgs e)
        {
            
            txtAddress.Text = "台北市大安區";
            var q2 = from c in dbContext.Cities.AsEnumerable()
                     select c;
            foreach(var cData in q2)
            {
                cmbi = new ComboBoxItem(cData.CityID,cData.CityName);
                cmbAddress.Items.Add(cmbi);
            }

            var q = from p in dbContext.Products.AsEnumerable()
                    from SC in p.ShoppingCarts
                    from ps in p.ProductSpecifications
                    where SC.MemberID == MainPage.memberid
                    select new
                    {
                        照片 = ps.ProductImage,
                        產品名稱 = p.ProductName,
                        產品單價 = ps.UnitPrice,
                        數量 = SC.ProductAmount,
                        總價 = ps.UnitPrice * SC.ProductAmount,
                        購物車號 = SC.ShoppingCartID
                    };

            foreach (var a in q)
            {
                sum += a.總價;
            }
            lblSum.Text = sum.ToString();
            if (lblSum.Text == "0")
            {
                btnCheck.Enabled = false;
            }

            dataGridView1.DataSource = q.ToList();
            AdjustColumnOrder();
            LoadMemberDate();
            cmbAddress.SelectedIndex = 0;
            txtAddress.Text = "台北市大安區";
        }
        private void LoadMemberDate()
        {
            var q = from m in dbContext.Members
                    where m.MemberID == MainPage.memberid
                    select m;
            foreach (var Mem in q)
            {
                txtMemName.Text = Mem.MemberName;
                txtMemName2.Text = Mem.MemberName;
                txtMemPhone.Text = Mem.Phone;
                txtAddress.Text = Mem.Address;
            }
        }
        private void AdjustColumnOrder()
        {
            dataGridView1.Columns["購物車號"].Visible = false;
        }

        List<int> PID = new List<int>();
        List<int> PCount = new List<int>();
        List<int> shopCartID = new List<int>();
        List<int> StockNum = new List<int>();
        int oID;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if ((rbCVS.Checked != false || rbhome.Checked != false) && (rbCash.Checked != false || rbCredit.Checked != false))
            {
                using (MedicalEntities dbContextT = new MedicalEntities())
                {
                    var q = from s in dbContextT.ShoppingCarts
                            where s.MemberID == MainPage.memberid
                            select s;

                    foreach (var shopdata in q)
                    {
                        PID.Add(shopdata.ProductID);
                        PCount.Add(shopdata.ProductAmount);
                        shopCartID.Add(shopdata.ShoppingCartID);
                        StockNum.Add(shopdata.Product.Stock);
                    }
                    using (var transaction = dbContextT.Database.BeginTransaction())
                    {
                        try
                        {
                            Order o = new Order();
                            o.OrderID = oID;
                            o.MemberID = MainPage.memberid;
                            o.OrderDate = DateTime.Now;
                            o.CityID = CID;
                            o.ShipAddress = txtAddress.Text;
                            o.IsPaid = true;
                            o.OrderStateID = 1;
                            o.PayTypeID = paytypeNum;
                            o.ShipTypeID = shiptypeNum;
                            //int test = PID.Count;

                            dbContext.Orders.Add(o);
                            for (int i = 0; i <= PID.Count-1; i++)
                            {
                                OrderDetail od = new OrderDetail();
                                od.OrderID = oID;
                                od.ProductID = PID[i];
                                od.Quantity = PCount[i];
                                dbContext.OrderDetails.Add(od);

                                int pid = PID[i];
                                Product p = dbContext.Products.FirstOrDefault(x1 => x1.ProductID==pid);
                                p.ProductID = PID[i];
                                p.Stock = StockNum[i]-PCount[i];

                                int test = shopCartID[i];
                                ShoppingCart shopCar = dbContext.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartID == test);
                                dbContext.ShoppingCarts.Remove(shopCar);
                            }
                            dbContext.SaveChanges();
                            MessageBox.Show("交易成功");
                            Store.a.Text = "1";
                            btnCheck.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("交易失敗,請填寫正確資料");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇付款方式");
                return;
            }

        }
        int paytypeNum,shiptypeNum;
        int CID = 1;
        private void rbhome_CheckedChanged(object sender, EventArgs e)
        {
            shiptypeNum = 1;
        }

        private void rbCVS_CheckedChanged(object sender, EventArgs e)
        {
            shiptypeNum = 2;
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            paytypeNum = 1;
        }

        private void btnBackToShop_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Controls.Add(new FrmShopping());
            Controls.Find("FrmShopping", false)[0].BringToFront();
        }

        private void cmbAddress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CID = 1; //((ComboBoxItem)this.cmbAddress.SelectedItem).Value;  
        }

        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            paytypeNum = 2;
        }
    }
}
