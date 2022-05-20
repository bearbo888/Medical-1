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
using static Medical.UserControls.FrmCheck;

namespace Medical.UserControls
{
    public partial class FrmUpdateProd : UserControl
    {
        public FrmUpdateProd()
        {
            InitializeComponent();
        }

        ComboBoxItem cmbCateItem;
        ComboBoxItem cmbBrandItem;

        public static int prodID { get; set; }
        byte[] bytes = null;
        
        private void FrmUpdateProd_Load(object sender, EventArgs e)
        {
            MedicalEntities dc = new MedicalEntities();
            var q = from pc in dc.ProductCategories.AsEnumerable()
                    select pc;
            foreach (var Cate in q)
            {
                cmbCateItem = new ComboBoxItem(Cate.ProductCategoryID, Cate.ProductCategoryName);
                cmbCate.Items.Add(cmbCateItem);
                
            }

            var q2 = from pb in dc.ProductBrands.AsEnumerable()
                     select pb;

            foreach (var Brand in q2)
            {
                cmbBrandItem = new ComboBoxItem(Brand.ProductBrandID, Brand.ProductBrandName);
                cmbBrand.Items.Add(cmbBrandItem);
            }
            LoadData();
            comboBox1.SelectedIndex = 0;
        }

        private void LoadData()
        {
            MedicalEntities dc = new MedicalEntities();

            var q = from p in dc.Products
                    from ps in p.ProductSpecifications
                    where p.ProductID == prodID
                    select new
                    {
                        p.ProductName,
                        p.ProductCategory.ProductCategoryName,
                        p.ProductBrand.ProductBrandName,
                        ps.UnitPrice,
                        ps.ProductColor,
                        ps.ProductMaterial,
                        ps.ProductAppearance,
                        p.Shelfdate,
                        ps.ProductImage,
                        p.Stock,
                        p.ProductBrandID,
                        p.ProductCategoryID
                    };

            foreach (var prod in q)
            {
                txtProdName.Text = prod.ProductName;
                cmbBrand.Text = prod.ProductBrandName;
                cmbCate.Text = prod.ProductCategoryName;
                txtUnitPrice.Text = prod.UnitPrice.ToString();
                numericUpDownStock.Value = prod.Stock;
                txtShelfDate.Text = prod.Shelfdate.ToString();
                txtColor.Text = prod.ProductColor;
                cmbMaterial.Text = prod.ProductMaterial;
                rtxtApperance.Text = prod.ProductAppearance;
                BID = prod.ProductBrandID;
                CID = prod.ProductCategoryID;

                bytes = prod.ProductImage;
                MemoryStream ms = new MemoryStream(bytes);
                picboxProduct.Image = Image.FromStream(ms);
            }

        }
        int BrandID;
        int CateID;
        string filename = null;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MedicalEntities dc = new MedicalEntities();
            try
            {
                var prodcut = dc.Products.FirstOrDefault(x => x.ProductID == prodID);
                var productSpec = dc.ProductSpecifications.FirstOrDefault(x1 => x1.ProductID == prodID);
                if (prodcut != null && productSpec != null)
                {
                    prodcut.ProductCategoryID = CID;
                    prodcut.ProductBrandID = BID;
                    prodcut.ProductName = txtProdName.Text;
                    prodcut.Stock = (int)numericUpDownStock.Value;
                    prodcut.discontinued = YesNO;
                    prodcut.Shelfdate = int.Parse(txtShelfDate.Text);

                    productSpec.UnitPrice = int.Parse(txtUnitPrice.Text);
                    productSpec.ProductColor = txtColor.Text;
                    productSpec.ProductAppearance = rtxtApperance.Text;
                    productSpec.ProductMaterial = cmbMaterial.Text;
                    productSpec.ProductImage = bytes;
                    try
                    {
                        dc.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }


                    MessageBox.Show("修改成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picboxProduct.Image = Image.FromFile(this.openFileDialog1.FileName);
                filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                picboxProduct.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();
                lblPath.Text = filename.ToString();
            }
        }
        int CID, BID;

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BID = ((ComboBoxItem)this.cmbBrand.SelectedItem).Value;
        }

        private void cmbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBackToPreviousPage_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Controls.Add(new Frm_Product_manage());
            Controls.Find("Frm_Product_manage", false)[0].BringToFront();
        }
        bool YesNO;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                YesNO = false; // 上下
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                YesNO = true;
            }
        }

        private void cmbCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CID = ((ComboBoxItem)this.cmbCate.SelectedItem).Value;
        }
    }
}
