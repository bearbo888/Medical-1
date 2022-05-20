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
    public partial class FrmOrderdetail : UserControl
    {
        public FrmOrderdetail()
        {
            InitializeComponent();
        }
        public static int oID { get; set; }
        MedicalEntities dbContext = new MedicalEntities();

        private void FrmOrderdetail_Load(object sender, EventArgs e)
        {

            var q = from p in dbContext.Products
                    from od in p.OrderDetails
                    from ps in p.ProductSpecifications
                    where od.Order.MemberID == MainPage.memberid && od.OrderID == oID
                    select new
                    {
                        產品圖 = ps.ProductImage, //2
                        產品名稱 = p.ProductName, //3
                        件數 = od.Quantity,//4
                        單價 = ps.UnitPrice,//5
                        金額 = od.Quantity * ps.UnitPrice, //6
                        ID = p.ProductID //7
                    };

            dataGridView1.DataSource = q.ToList();
            AdjustColumnOrder();
        }
        private void AdjustColumnOrder()
        {
            dataGridView1.Columns["buyagain"].DisplayIndex = 7;  // 0
            dataGridView1.Columns["productReview"].DisplayIndex = 6; //1
            dataGridView1.Columns["ID"].Visible = false;
            
        }
       // internal string prodname;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn  && e.ColumnIndex == 0)
            {
                FrmProductView.prodname = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                this.Controls.Clear();
                Controls.Add(new FrmProductView());
                Controls.Find("FrmProductView", false)[0].BringToFront();


            }
            else if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1)
            {
                


                ProductComment.prodName = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ProductComment.prodID = int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                this.Controls.Clear();
                Controls.Add(new ProductComment());
                Controls.Find("ProductComment", false)[0].BringToFront();

                
            }
        }
    }

}
