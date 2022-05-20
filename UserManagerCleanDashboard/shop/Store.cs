using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Medical.UserControls
{
    public partial class Store : UserControl
    {
        public Store()
        {
            InitializeComponent();
        }

       public static Label a { get; set; }

        int sum = 0;
        int count = 0;
        private void Store_Load(object sender, EventArgs e)
        {
            a = new Label();
            a.Text = "0";
            a.TextChanged += A_TextChanged;

            addTopProduct();
            MedicalEntities dbContext = new MedicalEntities();
            sum = 0;


            var q2 = (dbContext.Members.Where(p => p.MemberID == MainPage.memberid)).FirstOrDefault();
            if (q2 != null)
            {
                toolStripMenuItem1.Text = "您好 " + q2.MemberName ;
            }
            renewBtnCheckIcon();
        }

        private void A_TextChanged(object sender, EventArgs e)
        {
            if (a.Text == "1")
            {
                renewBtnCheckIcon();
                a.Text = "0";
            }
            else
            {
                return;
            }
            
        }

        private void toCart_Click(object sender, EventArgs e)
        {
            FrmProductView.prodname = ((PictureBox)sender).Name;
            this.Controls.Clear();

            Controls.Add(new FrmProductView());
            Controls.Find("FrmProductView", false)[0].BringToFront();

        }


        private void UISwitch(string ui, bool isSideNav)
        {
            switch (ui)
            {
                case "FrmShopping":
                    Shoppingpanel.Controls.Add(new FrmShopping());
                    Shoppingpanel.Controls.Find("FrmShopping", false)[0].BringToFront();
                    break;
                case "FrmShoppingList":
                    Shoppingpanel.Controls.Add(new FrmShoppingList());
                    Shoppingpanel.Controls.Find("FrmShoppingList", false)[0].BringToFront();
                    break;
                case "Frm_Product_manage":
                    Shoppingpanel.Controls.Add(new Frm_Product_manage());
                    Shoppingpanel.Controls.Find("Frm_Product_manage", false)[0].BringToFront();
                    break;
                case "FrmOrder":
                    Shoppingpanel.Controls.Add(new FrmOrder());
                    Shoppingpanel.Controls.Find("FrmOrder", false)[0].BringToFront();
                    break;
                case "FrmCheck":
                    Shoppingpanel.Controls.Add(new FrmCheck());
                    Shoppingpanel.Controls.Find("FrmCheck", false)[0].BringToFront();
                    break;
            }
        }

        private void btnOrderQ_Click(object sender, EventArgs e)
        {
            Shoppingpanel.Controls.Clear();
            UISwitch("FrmOrder", false);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Shoppingpanel.Controls.Clear();
            UISwitch("FrmCheck", false);
        }
        byte[] bytes;

        private void addTopProduct()
        {
            MedicalEntities dbcontext = new MedicalEntities();
            var q = (from od in dbcontext.OrderDetails
                     from ps in dbcontext.ProductSpecifications
                     group od by new { od.Product, od.Product.ProductName } into g
                     select new
                     {
                         Name = g.Key.ProductName,
                         count = g.Count()

                     }).OrderByDescending(a => a.count).Take(5);

            var q2 = from p in q
                     from ps in dbcontext.ProductSpecifications
                     where p.Name == ps.Product.ProductName
                     select new { ps.ProductImage, p.Name};

            foreach (var a in q2)
            {
                Panel panel = new Panel();
                PictureBox pb = new PictureBox();

                bytes = a.ProductImage;
                MemoryStream ms = new MemoryStream(bytes);
                pb.Image = Image.FromStream(ms);
                pb.Name = a.Name;
                pb.Width = 220;
                pb.Height = 160;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Click += toCart_Click;

                panel.BackColor = Color.WhiteSmoke;
                panel.Controls.Add(pb);

                panel.Width = 220;
                panel.Height = 163;
                flowLayoutPanel1.Controls.Add(panel);

            }
        }
        public  void renewBtnCheckIcon()
        {
            sum = 0;
            count = 0;
            MedicalEntities dbContext = new MedicalEntities();
            var q = from p in dbContext.Products.AsEnumerable()
                    from sl in p.ShoppingCarts
                    from ps in p.ProductSpecifications
                    where sl.MemberID == MainPage.memberid
                    group sl by new { sl.MemberID, p.ProductName, ps.UnitPrice, sl.ProductAmount, sl.ShoppingCartID, p.Stock } into g
                    select new
                    {
                        名稱 = g.Key.ProductName,
                        金額 = g.Key.UnitPrice * g.Key.ProductAmount,
                    };
            foreach (var a in q)
            {
                sum = sum + a.金額;
                count++;
            }

            if(sum == 0)
            {
                btnShow.ForeColor = Color.Gray;
                btnShow.Text = "尚未加入商品到購物車";
                return;
            }
            else
            {
                btnShow.ForeColor = Color.Red;
                btnShow.Text = "$" + sum.ToString() + " (" + count + ")" + "\n" + "結帳";
            }

            

        }


        private void btnShopping1_Click(object sender, EventArgs e)
        {
            Shoppingpanel.Controls.Clear();
            UISwitch("FrmShopping", false);
        }

        private void btnShoppingList2_Click(object sender, EventArgs e)
        {
            Shoppingpanel.Controls.Clear();
            UISwitch("FrmShoppingList", false);
        }

        private void btnCheckIcon_Click(object sender, EventArgs e)
        {
            Shoppingpanel.Controls.Clear();
            UISwitch("FrmCheck", false);
        }

        private void 我的購物車ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Shoppingpanel.Controls.Clear();
            UISwitch("FrmShoppingList", false);
        }

        private void 我的訂單紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shoppingpanel.Controls.Clear();
            UISwitch("FrmOrder", false);
        }

        private void btnfrontPage_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Store());
            Controls.Find("Store", false)[0].BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string old = label1.Text;
            string newest = label1.Text.Substring(0,1);
            old = old.Substring(1, old.Length - 1) + newest;
            label1.Text = old;
        }
    }
}
