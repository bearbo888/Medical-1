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
    public partial class FrmShoppingList : UserControl
    {
        public FrmShoppingList()
        {
            InitializeComponent();
        }

        MedicalEntities dbContext = new MedicalEntities();

        private void FrmShoppingList_Load(object sender, EventArgs e)
        {
            loadData();
        }
        List<int> Ppriec = new List<int>();
        List<string> Pname = new List<string>();
        List<int> PCount = new List<int>();
        int sum = 0;
        private void loadData()
        {
            sum = 0;
            var q = from p in dbContext.Products.AsEnumerable()
                    from sl in p.ShoppingCarts
                    from ps in p.ProductSpecifications
                    where sl.MemberID == MainPage.memberid
                    group sl by new { sl.MemberID, p.ProductName, ps.ProductImage, ps.UnitPrice, sl.ProductAmount, sl.ShoppingCartID ,p.Stock} into g
                    select new
                    {
                        產品圖片 = g.Key.ProductImage,//3
                        產品名稱 = g.Key.ProductName,//4
                        產品單價 = g.Key.UnitPrice,//5
                        數量 = g.Key.ProductAmount,//6
                        庫存 = g.Key.Stock,//7
                        金額 = g.Key.UnitPrice * g.Key.ProductAmount,//8
                        購物車號 = g.Key.ShoppingCartID//9
                    };

            foreach(var a in q)
            {
                Ppriec.Add(a.產品單價);
                Pname.Add(a.產品名稱);
                PCount.Add(a.數量);
            }

            dataGridView1.DataSource = q.ToList();
            AdjustColumnOrder();

        }
        private void AdjustColumnOrder()
        {

            dataGridView1.Columns["delete"].DisplayIndex = 9; 
            dataGridView1.Columns["reduce"].DisplayIndex = 5;
            dataGridView1.Columns["ADD"].DisplayIndex =4;
            dataGridView1.Columns["購物車號"].Visible = false;
        }
        int cartID;
        private void deleteCart()
        {

            var shopCar = dbContext.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartID == cartID);
            if (shopCar != null)
            {
                dbContext.ShoppingCarts.Remove(shopCar);
                dbContext.SaveChanges();
                MessageBox.Show("成功");
            }
            else
            {
                MessageBox.Show("失敗");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                cartID = (int)dataGridView1.CurrentRow.Cells[9].Value;

                DialogResult dialogResult = MessageBox.Show("確定要刪除嗎?", "將此筆資料從購物車刪除", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteCart();
                    loadData();
                    Store.a.Text = "1";
                }
                else return;
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                int afteradd = (int)dataGridView1.CurrentRow.Cells[6].Value+1;
                int stocknum= (int)dataGridView1.CurrentRow.Cells[7].Value;
                if (afteradd > stocknum)
                {
                    MessageBox.Show("數量不可大於庫存");
                    return;
                }
                else
                {
                    int cartID = (int)dataGridView1.CurrentRow.Cells[9].Value;
                    var shopcart = dbContext.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartID == cartID);
                    if (shopcart != null)
                    {
                        shopcart.ProductAmount = afteradd;
                        dbContext.SaveChanges();
                        loadData();
                        Store.a.Text = "1";
                    }
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int afteradd = (int)dataGridView1.CurrentRow.Cells[6].Value - 1;

                if(afteradd < 1)
                {
                    MessageBox.Show("數量不可小於1");
                    return;
                }
                else
                {
                    int cartID = (int)dataGridView1.CurrentRow.Cells[9].Value;
                    var shopcart = dbContext.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartID == cartID);
                    if (shopcart != null)
                    {
                        shopcart.ProductAmount = afteradd;
                        dbContext.SaveChanges();
                        loadData();
                        Store.a.Text = "1";
                    }
                }
            }
            else 
            {
            
            }
        }
    }
}
