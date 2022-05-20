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
using System.Windows.Forms;

namespace Medical.UserControls
{
    public partial class FrmShopping : UserControl
    {
        public FrmShopping()
        {
            InitializeComponent();
        }

        MedicalEntities dbContext = new MedicalEntities();
        PictureBox pictureBox = null;
        internal Panel panel;
        internal Label ProductNames;
        internal Label unitprice;
        internal string BrandName;
        internal string stock;
        internal string description;
        internal string categoryName;
        internal string ProductIDs;
        List<string> Brn = new List<string>();
        List<string> Cat = new List<string>();
        private void FrmShopping_Load(object sender, EventArgs e)
        {
            addTopProduct();

            var q = from pc in dbContext.ProductCategories
                    select pc;
            int i = 0;
            foreach (var c in q)
            {
                i++;
                Button btnCate = new Button();
                btnCate.Text = c.ProductCategoryName;
                btnCate.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                btnCate.Width = panelCate.Width;
                btnCate.Height = 35;
                btnCate.Top = btnCate.Height * i;
                btnCate.Click += BtnCate_Click;
                panelCate.Controls.Add(btnCate);
            }
            var q2 = from pb in dbContext.ProductBrands
                     select pb;
            int i2 = 0;
            foreach (var b in q2)
            {
                i2++;
                Button btnBrand = new Button();
                btnBrand.Text = b.ProductBrandName;
                btnBrand.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                btnBrand.Width = panelCate.Width;
                btnBrand.Height = 35;
                btnBrand.Top = btnBrand.Height * i2;
                btnBrand.Click += BtnBrand_Click;
                panelbrand.Controls.Add(btnBrand);
            }
        }

        private void BtnCate_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Button Categorybutton = sender as Button;
            if (Categorybutton != null)
            {
                string Category = Categorybutton.Text;
                ShowCategoryImage(Category);
            }
        }

        private void ShowCategoryImage(string category)
        {
            var q = from pc in dbContext.ProductCategories.AsEnumerable()
                    from p in pc.Products
                    from ps in p.ProductSpecifications
                    where pc.ProductCategoryName == $"{category}" && p.discontinued ==false
                    select new { p.ProductName, ps.ProductImage, ps.UnitPrice, pc.ProductCategoryName, p.ProductBrand.ProductBrandName, ps.ProductColor, p.Stock, p.ProductID, p.ProductCategoryID, p.ProductBrandID };

            foreach (var group in q)
            {
                FrmProductView.prodname = group.ProductName;

                SiticoneButton btnBrandIcon = new SiticoneButton();
                btnBrandIcon.AutoRoundedCorners = true;
                btnBrandIcon.FillColor = Color.Gray;  
                btnBrandIcon.Width = 70;
                btnBrandIcon.Height = 20;

                SiticoneButton btnCateIcon = new SiticoneButton();
                btnCateIcon.AutoRoundedCorners = true;
                btnCateIcon.FillColor = Color.Gray;
                btnCateIcon.Width = 70;
                btnCateIcon.Height = 20;
                FlowLayoutPanel panel = new FlowLayoutPanel();


                pictureBox = new PictureBox();
                ProductNames = new Label();
                unitprice = new Label();
                pictureBox.Name = group.ProductName;
                BrandName = group.ProductBrandName;
                categoryName = group.ProductCategoryName;
                stock = group.Stock.ToString();
                description = group.ProductColor;
                ProductIDs = group.ProductID.ToString();

                Brn.Add(group.ProductBrandName);
                Cat.Add(group.ProductCategoryName);
                btnBrandIcon.Text = group.ProductBrandName;
                btnCateIcon.Text = group.ProductCategoryName;
                btnBrandIcon.Click += Btn_Click;
                btnCateIcon.Click += Btn_Click;
                btnBrandIcon.ForeColor = Color.White;
                btnCateIcon.ForeColor = Color.White;

                byte[] bytes = group.ProductImage;
                MemoryStream ms = new MemoryStream(bytes);
                ProductNames.Text = group.ProductName;
                unitprice.Text = "$" + group.UnitPrice.ToString();

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(ProductNames);
                panel.Controls.Add(unitprice);
                panel.Controls.Add(btnBrandIcon);
                panel.Controls.Add(btnCateIcon);
                btnCateIcon.Top = 220;
                btnBrandIcon.Top = 220;

                ProductNames.Top = 180;
                ProductNames.Width = 180;
                ProductNames.TextAlign = ContentAlignment.MiddleCenter;

                unitprice.Top = 200;
                unitprice.Width = 180;
                unitprice.TextAlign = ContentAlignment.MiddleCenter;

                flowLayoutPanel1.Controls.Add(panel);

                pictureBox.Image = Image.FromStream(ms);


                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 180;
                pictureBox.Height = 160;
                pictureBox.Padding = new Padding(4, 4, 4, 4);
                pictureBox.Click += toCart_Click;

                panel.Width = 180;
                panel.Height = 250;
            }
        }

        private void BtnBrand_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Button brandbutton = sender as Button;
            if (brandbutton != null)
            {
                string Brand = brandbutton.Text;
                ShowBrandImage(Brand);
            }
        }
       
        private void ShowBrandImage(string brand)
        { 
            var q = from pb in dbContext.ProductBrands.AsEnumerable()
                    from p in pb.Products
                    from ps in p.ProductSpecifications
                    where pb.ProductBrandName == $"{ brand }"&& p.discontinued==false
                    select new { p.ProductName, ps.ProductImage, ps.UnitPrice, p.ProductCategory.ProductCategoryName, p.ProductBrand.ProductBrandName, ps.ProductColor, p.Stock, p.ProductID, p.ProductCategoryID, p.ProductBrandID };


            foreach (var group in q)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();


                SiticoneButton btnBrandIcon = new SiticoneButton();
                btnBrandIcon.AutoRoundedCorners = true;
                btnBrandIcon.FillColor = Color.Gray;

             //   Button btnBrandIcon = new Button();
                btnBrandIcon.Width = 70;
                btnBrandIcon.Height = 20;

                //Button btnCateIcon = new Button();
                SiticoneButton btnCateIcon = new SiticoneButton();
                btnCateIcon.AutoRoundedCorners = true;
                btnCateIcon.FillColor = Color.Gray;
                btnCateIcon.Width = 70;
                btnCateIcon.Height = 20;

                

                //panel = new Panel();
                pictureBox = new PictureBox();
                ProductNames = new Label();
                unitprice = new Label();
                pictureBox.Name = group.ProductName;
                BrandName = group.ProductBrandName;
                categoryName = group.ProductCategoryName;
                stock = group.Stock.ToString();
                description = group.ProductColor;
                ProductIDs = group.ProductID.ToString();


                byte[] bytes = group.ProductImage;
                MemoryStream ms = new MemoryStream(bytes);
                ProductNames.Text = group.ProductName;
                unitprice.Text = "$" + group.UnitPrice.ToString();


                Brn.Add(group.ProductBrandName);
                Cat.Add(group.ProductCategoryName);
                btnBrandIcon.Text = group.ProductBrandName;
                btnBrandIcon.Tag = group.ProductBrandID;
                btnCateIcon.Text = group.ProductCategoryName;
                btnCateIcon.Tag = group.ProductCategoryID;
                //btnBrandIcon.BackColor = Color.Gray;

                btnBrandIcon.Click += Btn_Click;
                btnCateIcon.Click += Btn_Click;
                btnBrandIcon.ForeColor = Color.White;
               // btnCateIcon.BackColor = Color.Gray;
                btnCateIcon.ForeColor = Color.White;



                panel.Controls.Add(pictureBox);
                panel.Controls.Add(ProductNames);
                panel.Controls.Add(unitprice);
                panel.Controls.Add(btnBrandIcon);
                panel.Controls.Add(btnCateIcon);
                btnCateIcon.Top = 220;
                btnBrandIcon.Top = 220;

                ProductNames.Top = 180;
                ProductNames.Width = 180;
                ProductNames.TextAlign = ContentAlignment.MiddleCenter;

                unitprice.Top = 200;
                unitprice.Width = 180;
                unitprice.TextAlign = ContentAlignment.MiddleCenter;

                flowLayoutPanel1.Controls.Add(panel);

                pictureBox.Image = Image.FromStream(ms);


                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 180;
                pictureBox.Height = 160;
                pictureBox.Padding = new Padding(4, 4, 4, 4);
                pictureBox.Click += toCart_Click;

                panel.Width = 180;
                panel.Height = 250;
            }
        }
        private void toCart_Click(object sender, EventArgs e)
        {
            FrmProductView.prodname = ((PictureBox)sender).Name;
            this.Controls.Clear();

            Controls.Add(new FrmProductView());
            Controls.Find("FrmProductView", false)[0].BringToFront();

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (Brn.Any(q => Brn.Contains(((SiticoneButton)sender).Text)))
            {
                flowLayoutPanel1.Controls.Clear();
                ShowBrandImage(((SiticoneButton)sender).Text);
            }
            else if (Cat.Any(q2 => Cat.Contains(((SiticoneButton)sender).Text)))
            {
                flowLayoutPanel1.Controls.Clear();
                ShowCategoryImage(((SiticoneButton)sender).Text);
            }
            else
            {
                return;
            }
        }
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

                     }).OrderByDescending(a => a.count).Take(8);

            var q2 = from p in q
                     from ps in dbcontext.ProductSpecifications
                     where p.Name == ps.Product.ProductName &&ps.Product.discontinued == false
                     select new { ps.ProductImage, p.Name,ps.Product.ProductBrand.ProductBrandName,ps.Product.ProductCategory.ProductCategoryName,ps.Product
                     .Stock,ps.ProductColor,ps.ProductID,ps.UnitPrice};

            foreach (var group in q2)
            {
                FrmProductView.prodname = group.Name;

                SiticoneButton btnBrandIcon = new SiticoneButton();
                btnBrandIcon.AutoRoundedCorners = true;
                btnBrandIcon.FillColor = Color.Gray;
                btnBrandIcon.Width = 70;
                btnBrandIcon.Height = 20;

                SiticoneButton btnCateIcon = new SiticoneButton();
                btnCateIcon.AutoRoundedCorners = true;
                btnCateIcon.FillColor = Color.Gray;
                btnCateIcon.Width = 70;
                btnCateIcon.Height = 20;
                FlowLayoutPanel panel = new FlowLayoutPanel();


                pictureBox = new PictureBox();
                ProductNames = new Label();
                unitprice = new Label();
                pictureBox.Name = group.Name;
                BrandName = group.ProductBrandName;
                categoryName = group.ProductCategoryName;
                stock = group.Stock.ToString();
                description = group.ProductColor;
                ProductIDs = group.ProductID.ToString();

                Brn.Add(group.ProductBrandName);
                Cat.Add(group.ProductCategoryName);
                btnBrandIcon.Text = group.ProductBrandName;
                btnCateIcon.Text = group.ProductCategoryName;
                btnBrandIcon.Click += Btn_Click;
                btnCateIcon.Click += Btn_Click;
                btnBrandIcon.ForeColor = Color.White;
                btnCateIcon.ForeColor = Color.White;

                byte[] bytes = group.ProductImage;
                MemoryStream ms = new MemoryStream(bytes);
                ProductNames.Text = group.Name;
                unitprice.Text = "$" + group.UnitPrice.ToString();

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(ProductNames);
                panel.Controls.Add(unitprice);
                panel.Controls.Add(btnBrandIcon);
                panel.Controls.Add(btnCateIcon);
                btnCateIcon.Top = 220;
                btnBrandIcon.Top = 220;

                ProductNames.Top = 180;
                ProductNames.Width = 180;
                ProductNames.TextAlign = ContentAlignment.MiddleCenter;

                unitprice.Top = 200;
                unitprice.Width = 180;
                unitprice.TextAlign = ContentAlignment.MiddleCenter;

                flowLayoutPanel1.Controls.Add(panel);

                pictureBox.Image = Image.FromStream(ms);


                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 180;
                pictureBox.Height = 160;
                pictureBox.Padding = new Padding(4, 4, 4, 4);
                pictureBox.Click += toCart_Click;

                panel.Width = 180;
                panel.Height = 250;

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            MedicalEntities dbContext = new MedicalEntities();
            if (e.KeyCode == Keys.Enter && txtSearch.Text != null)
            {
                flowLayoutPanel1.Controls.Clear();
                string search = txtSearch.Text;
                var q = from p in dbContext.Products
                        from ps in p.ProductSpecifications
                        where (p.ProductName.Contains(search) || p.ProductBrand.ProductBrandName.Contains(search) || p.ProductCategory.ProductCategoryName.Contains(search))&&p.discontinued == false
                        select new { p.ProductName, p.ProductBrand.ProductBrandName, p.ProductCategory.ProductCategoryName, ps.ProductImage, p.Stock, ps.UnitPrice, ps.ProductID };
                if (q != null)
                {
                    foreach (var group in q)
                    {
                        if (group != null)
                        {
                            FrmProductView.prodname = group.ProductName;

                            SiticoneButton btnBrandIcon = new SiticoneButton();
                            btnBrandIcon.AutoRoundedCorners = true;
                            btnBrandIcon.FillColor = Color.Gray;
                            btnBrandIcon.Width = 70;
                            btnBrandIcon.Height = 20;

                            SiticoneButton btnCateIcon = new SiticoneButton();
                            btnCateIcon.AutoRoundedCorners = true;
                            btnCateIcon.FillColor = Color.Gray;
                            btnCateIcon.Width = 70;
                            btnCateIcon.Height = 20;
                            FlowLayoutPanel panel = new FlowLayoutPanel();


                            pictureBox = new PictureBox();
                            ProductNames = new Label();
                            unitprice = new Label();
                            pictureBox.Name = group.ProductName;
                            string BrandName = group.ProductBrandName;
                            string categoryName = group.ProductCategoryName;
                            string stock = group.Stock.ToString();
                            string ProductIDs = group.ProductID.ToString();

                            Brn.Add(group.ProductBrandName);
                            Cat.Add(group.ProductCategoryName);
                            btnBrandIcon.Text = group.ProductBrandName;
                            btnCateIcon.Text = group.ProductCategoryName;
                            btnBrandIcon.Click += Btn_Click;
                            btnCateIcon.Click += Btn_Click;
                            btnBrandIcon.ForeColor = Color.White;
                            btnCateIcon.ForeColor = Color.White;

                            byte[] bytes = group.ProductImage;
                            MemoryStream ms = new MemoryStream(bytes);
                            ProductNames.Text = group.ProductBrandName;
                            unitprice.Text = "$" + group.UnitPrice.ToString();

                            panel.Controls.Add(pictureBox);
                            panel.Controls.Add(ProductNames);
                            panel.Controls.Add(unitprice);
                            panel.Controls.Add(btnBrandIcon);
                            panel.Controls.Add(btnCateIcon);
                            btnCateIcon.Top = 220;
                            btnBrandIcon.Top = 220;

                            ProductNames.Top = 180;
                            ProductNames.Width = 180;
                            ProductNames.TextAlign = ContentAlignment.MiddleCenter;

                            unitprice.Top = 200;
                            unitprice.Width = 180;
                            unitprice.TextAlign = ContentAlignment.MiddleCenter;

                            flowLayoutPanel1.Controls.Add(panel);

                            pictureBox.Image = Image.FromStream(ms);


                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Width = 180;
                            pictureBox.Height = 160;
                            pictureBox.Padding = new Padding(4, 4, 4, 4);
                            pictureBox.Click += toCart_Click;

                            panel.Width = 180;
                            panel.Height = 250;
                            flowLayoutPanel1.Controls.Add(panel);
                        }
                        else
                        {
                            Controls.Add(new FrmShopping());
                            Controls.Find("FrmShopping", false)[0].BringToFront();
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
