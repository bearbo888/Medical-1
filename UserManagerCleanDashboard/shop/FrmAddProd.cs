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
    public partial class FrmAddProd : UserControl
    {
        public FrmAddProd()
        {
            InitializeComponent();
        }

        ComboBoxItem cmbCateItem;
        ComboBoxItem cmbBrandItem;

        private void FrmAddProd_Load(object sender, EventArgs e)
        {
            MedicalEntities dc = new MedicalEntities();
            var q = from pc in dc.ProductCategories.AsEnumerable()
                    select pc;
            foreach(var Cate in q)
            {
                cmbCateItem = new ComboBoxItem(Cate.ProductCategoryID, Cate.ProductCategoryName);
                cmbCate.Items.Add(cmbCateItem);
            }

            var q2 = from pb in dc.ProductBrands.AsEnumerable()
                     select pb;
            
            foreach(var Brand in q2)
            {
                cmbBrandItem = new ComboBoxItem(Brand.ProductBrandID, Brand.ProductBrandName);
                cmbBrand.Items.Add(cmbBrandItem);
            }
        }
        int Shelfvalue;
        int stockvalue;
        int prodID;
        string filename = null;
        byte[] bytes = null;

        private void btnADD_Click(object sender, EventArgs e)
        {
            MedicalEntities dc = new MedicalEntities();

            string value = numericUpDownStock.Value.ToString();
            if (int.TryParse(value, out stockvalue) && int.TryParse(txtShelfDate.Text, out Shelfvalue))
            {
                if (picboxProduct.Image == null)
                {
                    MessageBox.Show("請選擇照片");
                    return;
                }
                else
                {
                    Product newprod = new Product
                    {
                        ProductID = prodID,
                        ProductCategoryID = CID,
                        ProductBrandID = BID,
                        ProductName = txtProdName.Text,
                        discontinued = false,
                        Stock = (int)numericUpDownStock.Value,
                        Shelfdate = int.Parse(txtShelfDate.Text)
                    };
                    ProductSpecification newprodSepc = new ProductSpecification
                    {
                        ProductID = prodID,
                        UnitPrice = int.Parse(txtUnitPrice.Text),
                        ProductImage = bytes,
                        ProductColor = txtColor.Text,
                        ProductAppearance = rtxtApperance.Text,
                        ProductMaterial = cmbMaterial.Text
                    };
                    if (newprod != null && newprodSepc != null)
                    {
                        dc.Products.Add(newprod);
                        dc.ProductSpecifications.Add(newprodSepc);
                        try
                        {
                            dc.SaveChanges();
                            MessageBox.Show("新增產品成功");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("新增產品失敗");
                        }
                    }
                    else
                    {
                        MessageBox.Show("失敗");
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的數值");
                return;
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
        int CID=1, BID=1;
        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BID = ((ComboBoxItem)this.cmbBrand.SelectedItem).Value;
        }

        private void btnBackToPreviusPage_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Controls.Add(new Frm_Product_manage());
            Controls.Find("Frm_Product_manage", false)[0].BringToFront();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtProdName.Text = "Demo001";
            cmbBrand.SelectedIndex = 0;
            cmbCate.SelectedIndex = 0;
            txtUnitPrice.Text = "9999";
            numericUpDownStock.Value = 6;
            txtShelfDate.Text = "100";
            txtColor.Text = "見聞色";
            cmbMaterial.SelectedIndex = 0;
            rtxtApperance.Text = "Demo001很好用";
        }

        private void cmbCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CID = ((ComboBoxItem)this.cmbCate.SelectedItem).Value;

        }
    }
}
