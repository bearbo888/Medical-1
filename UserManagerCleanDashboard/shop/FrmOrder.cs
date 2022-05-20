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
    public partial class FrmOrder : UserControl
    {
        public FrmOrder()
        {
            InitializeComponent();
        }
        MedicalEntities dbContext = new MedicalEntities();
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            var q = (from o in dbContext.Orders.AsEnumerable()
                    from od in o.OrderDetails
                    where od.Order.MemberID == MainPage.memberid
                     group od by new { o.OrderID, o.OrderDate, o.Orderstate.OrderState1, o.Paytype.PayType1, o.ShipType.ShipType1 } into g
                    select new
                    {
                        訂單編號 = g.Key.OrderID,
                        購買日期 = g.Key.OrderDate,
                        取貨方式 = g.Key.ShipType1,
                        訂單狀態 = g.Key.OrderState1,
                        付款狀態 = g.Key.PayType1,
                    }).OrderByDescending(a=>a.訂單編號);
            dataGridView1.DataSource = q.ToList();
            AdjustColumnOrder();
        }
        private void AdjustColumnOrder()
        {
            dataGridView1.Columns["Orderdt"].DisplayIndex = 5;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                FrmOrderdetail.oID = (int)dataGridView1.CurrentRow.Cells[1].Value;

                this.Controls.Clear();
                Controls.Add(new FrmOrderdetail());
                Controls.Find("FrmOrderdetail", false)[0].BringToFront();
            }
            else return;
        }
    }
}
