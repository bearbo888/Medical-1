using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical.UserControls
{
    public partial class FrmProductView : UserControl
    {
        public FrmProductView()
        {
            InitializeComponent();
        }

        
        MedicalEntities dbContext = new MedicalEntities();
        byte[] bytes = null;
        int memberID = 1;
        int productID;
        int count = 1;
        public static string prodname { get; set; }
        private void FrmProductView_Load(object sender, EventArgs e)
        {
            

            cmbCount.SelectedIndex = 0;

         

            var q = from p in dbContext.Products
                    from ps in p.ProductSpecifications
                    where p.ProductName == prodname
                    select new
                    {
                        p.ProductName,
                        p.ProductCategory.ProductCategoryName,
                        p.ProductBrand.ProductBrandName,
                        ps.UnitPrice,
                        ps.ProductImage,
                        p.Stock,
                        ps.ProductColor,
                        p.ProductID
                    };
            foreach (var pv in q)
            {
                lblProductName.Text = pv.ProductName;
                lblProductPrice.Text = pv.UnitPrice.ToString();
                lblBrand.Text = pv.ProductBrandName;
                lblCate.Text = pv.ProductCategoryName;
                lblStock.Text = pv.Stock.ToString();
                lblDescription.Text = pv.ProductColor;
                productID = pv.ProductID;
                bytes = pv.ProductImage;
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox1.Image = Image.FromStream(ms);
            }

            if (lblStock.Text == "0")
            {
                btnBuyNow.Enabled = false;
                btnAddtoCart.Enabled = false;
                cmbCount.Visible = false;
                lblOut.Visible = true;
            }
            ShowReview();
        }
        int before;
        int after;
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            MedicalEntities dc = new MedicalEntities();

            var c = (dc.ShoppingCarts.Where(p => p.Product.ProductName == lblProductName.Text && p.MemberID == MainPage.memberid)).FirstOrDefault();
            if (c !=null)
            {
                int before = c.ProductAmount;
                int after  = before + int.Parse(cmbCount.Text);

                if (after > int.Parse(lblStock.Text))
                {
                    MessageBox.Show("購買數量不可大於庫存");
                    return;
                }
                else
                {
                    c.ProductAmount = after;
                    dc.SaveChanges();
                    MessageBox.Show("成功加入購物車");
                    Store.a.Text= "1";
                }
            }
            else
            {
                ShoppingCart shopcart = new ShoppingCart
                {
                    MemberID = MainPage.memberid,
                    ProductID = productID,
                    ProductAmount = count
                };

                dc.ShoppingCarts.Add(shopcart);
                dc.SaveChanges();
                MessageBox.Show("成功加入購物車");
                Store.a.Text = "1";
            }

        }

        private void cmbCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = int.Parse(cmbCount.Text);
            if (count > int.Parse(lblStock.Text))
            {
                MessageBox.Show("庫存不足");
                cmbCount.Text = "1";
            }
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            MedicalEntities dc = new MedicalEntities();

            var c = (dc.ShoppingCarts.Where(p => p.Product.ProductName == lblProductName.Text && p.MemberID == MainPage.memberid)).FirstOrDefault();
            if (c != null)
            {
                int before = c.ProductAmount;
                int after = before + int.Parse(cmbCount.Text);

                if (after > int.Parse(lblStock.Text))
                {
                    MessageBox.Show("購買數量不可大於庫存");
                    return;
                }
                else
                {
                    c.ProductAmount = after;
                    dc.SaveChanges();     
                    Store.a.Text = "1";
                    this.Controls.Clear();

                    Controls.Add(new FrmCheck());
                    Controls.Find("FrmCheck", false)[0].BringToFront();
                }
            }
            else
            {
                ShoppingCart shopcart = new ShoppingCart
                {
                    MemberID = MainPage.memberid,
                    ProductID = productID,
                    ProductAmount = count
                };

                dc.ShoppingCarts.Add(shopcart);
                dc.SaveChanges();
                Store.a.Text = "1";
                this.Controls.Clear();

                Controls.Add(new FrmCheck());
                Controls.Find("FrmCheck", false)[0].BringToFront();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Controls.Add(new FrmShopping());
            Controls.Find("FrmShopping", false)[0].BringToFront();
        }
        int Count=0;
        private void ShowReview()
        {
            MedicalEntities dc = new MedicalEntities();
            var q = from r in dc.Reviews
                    where r.Product.ProductName == lblProductName.Text
                    select new { r.RatingType.RatingTypeName, r.Member.MemberName, r.CreateDate, r.CommentContent };
            
            foreach (var a in q)
            {
                FlowLayoutPanel flow = new FlowLayoutPanel();
                Label Rate = new Label();
                Label RateContent = new Label();
                SiticoneRatingStar ratingStar = new SiticoneRatingStar();
                flow.Width = flowReviewPanel.Width;
                flow.Height = 100;
                flow.BackColor = Color.AliceBlue;

                char lastname = (a.MemberName).FirstOrDefault();

                ratingStar.Value =float.Parse(a.RatingTypeName);
                Rate.Text = a.RatingTypeName + "  " + lastname + " 先生/小姐  " + a.CreateDate;
                Rate.Width = flow.Width;
                RateContent.Text = a.CommentContent;
                flow.Controls.Add(ratingStar);
                flow.Controls.Add(Rate);
                flow.Controls.Add(RateContent);
                flowReviewPanel.Controls.Add(flow);
                count++;
               
            }

            lblShowRcount.Text = "共" + (count - 1) + "項 評論";


        }
    }
}
