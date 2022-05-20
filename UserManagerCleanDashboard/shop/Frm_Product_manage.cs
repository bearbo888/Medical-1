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
    public partial class Frm_Product_manage : UserControl
    {
        public Frm_Product_manage()
        {
            InitializeComponent();
        }

        private void Frm_Product_manage_Load(object sender, EventArgs e)
        {
            FillCateAndBrand();
            UpdateAllDGV();
            AdjustColumnOrder();
        }
        string brand;
        string Cate;

        private void UpdateAllDGV()
        {
            MedicalEntities dbcontext = new MedicalEntities();
            var q = from p in dbcontext.Products
                    from ps in p.ProductSpecifications
                    select new
                    {
                        產品名稱 = p.ProductName,  //3
                        品牌 = p.ProductBrand.ProductBrandName, //4
                        種類 = p.ProductCategory.ProductCategoryName, //5
                        單價 = ps.UnitPrice,  //6
                        庫存 = p.Stock,  //7
                        顏色 = ps.ProductColor,  //8
                        ID = p.ProductID, //9
                        已下架 = p.discontinued //10
                    };
            dataGridView1.DataSource = q.ToList();
        }
        private void UpdateDGVByBrand(string bybrand)
        {
            MedicalEntities dbcontext = new MedicalEntities();
            var q = from p in dbcontext.Products
                    from ps in p.ProductSpecifications
                    where p.ProductBrand.ProductBrandName == brand
                    select new
                    {
                        產品名稱 = p.ProductName,
                        品牌 = p.ProductBrand.ProductBrandName,
                        種類 = p.ProductCategory.ProductCategoryName,
                        單價 = ps.UnitPrice,
                        庫存 = p.Stock,
                        顏色 = ps.ProductColor,
                        ID = p.ProductID,
                        已下架 = p.discontinued
                    };
            dataGridView1.DataSource = q.ToList();
        }
        private void UpdateDGVByCate(string byCate)
        {
            MedicalEntities dbcontext = new MedicalEntities();
            var q = from p in dbcontext.Products
                    from ps in p.ProductSpecifications
                    where p.ProductCategory.ProductCategoryName == Cate
                    select new
                    {
                        產品名稱 = p.ProductName,
                        品牌 = p.ProductBrand.ProductBrandName,
                        種類 = p.ProductCategory.ProductCategoryName,
                        單價 = ps.UnitPrice,
                        庫存 = p.Stock,
                        顏色 = ps.ProductColor,
                        ID = p.ProductID,
                        已下架 = p.discontinued //10
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void FillCateAndBrand()
        {
            MedicalEntities dbcontext = new MedicalEntities();
            var q = from pc in dbcontext.ProductCategories
                    select pc.ProductCategoryName;
            foreach (string Cate in q)
            {
                cmbCate.Items.Add(Cate);

            }

            var q2 = from pb in dbcontext.ProductBrands
                     select pb.ProductBrandName;

            foreach (string Brand in q2)
            {
                cmbBrand.Items.Add(Brand);
            }
        }
        private void AdjustColumnOrder()
        {
            dataGridView1.Columns["discontinued"].DisplayIndex = 10;
            dataGridView1.Columns["adjustprod"].DisplayIndex = 9; 
            dataGridView1.Columns["showpic"].DisplayIndex = 8;
            dataGridView1.Columns["ID"].Visible = false;
        }
        internal int ProdID = 0;

        private void btnAddprod_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FrmAddProd f = new FrmAddProd();
            Controls.Add(new FrmAddProd());
            Controls.Find("FrmAddProd", false)[0].BringToFront();

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            brand = cmbBrand.SelectedItem.ToString();
            UpdateDGVByBrand(brand);
        }

        private void cmbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cate = cmbCate.SelectedItem.ToString();
            UpdateDGVByCate(Cate);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicalEntities dbcontext = new MedicalEntities();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ProdID = (int)dataGridView1.CurrentRow.Cells[9].Value; 
                FrmUpdateProd.prodID = (int)dataGridView1.CurrentRow.Cells[9].Value;  
                if (e.ColumnIndex == 0)
                {
                    string prodName = dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
                    Form pictures = new Form();
                    pictures.Show();
                    pictures.BackgroundImageLayout = ImageLayout.Stretch;
                    var q = from ps in dbcontext.ProductSpecifications
                            where ps.Product.ProductName == prodName
                            select ps.ProductImage;

                    foreach (var pic in q)
                    {
                        byte[] bytes = pic;
                        MemoryStream ms = new MemoryStream(bytes);
                        pictures.BackgroundImage = Image.FromStream(ms);
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    this.Controls.Clear();
                    Controls.Add(new FrmUpdateProd());
                    Controls.Find("FrmUpdateProd", false)[0].BringToFront();
                }
                else if (e.ColumnIndex == 2) // 下架
                {
                    DialogResult dialogResult = MessageBox.Show("確定要將此產品下架嗎?", "將此產品下架", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string Pname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        var c = (dbcontext.Products.Where(p => p.ProductName == Pname)).FirstOrDefault();
                        c.discontinued = true;
                        dbcontext.SaveChanges();
                        MessageBox.Show("下架成功");
                    }
                    else return;
                }

            }
        }
    }
}
