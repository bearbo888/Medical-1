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
    public partial class ProductComment : UserControl
    {
        public ProductComment()
        {
            InitializeComponent();
            LoadComboBox();
            LoadProductData();
        }

        public static int prodID  { get; set; }
        public static string prodName { get; set; }
        byte[] bytes;
        private void LoadProductData()
        {
            var q = from d in medicalContext.Products
                    from sd in d.ProductSpecifications
                     where d.ProductName == prodName
                    select new
                     {
                         name = d.ProductName,
                         image = sd.ProductImage
                     };
            foreach (var item in q)
            {
                label_name.Text = item.name;
                bytes = item.image;
                MemoryStream ms = new MemoryStream(bytes);
                try
                {
                    siticonePictureBox1.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        MedicalEntities medicalContext = new MedicalEntities();
        private void LoadComboBox()
        {
            var q = from r in medicalContext.RatingTypes
                    select r.RatingTypeName;
            
            siticoneComboBox1.DataSource = q.ToList();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string comment = txt_Comment.Text;

            DialogResult result = MessageBox.Show("確定送出評論嗎?", "確認!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Review review = new Review
                {
                    MemberID = MainPage.memberid,
                    ProductID = prodID,
                    RatingTypeID = int.Parse(siticoneComboBox1.Text),
                    CommentContent = comment,
                    CreateDate = DateTime.Now
                };

                medicalContext.Reviews.Add(review);
                medicalContext.SaveChanges();
                MessageBox.Show("新增評論成功");
                FrmProductView.prodname = label_name.Text;
                this.Controls.Clear();
                Controls.Add(new FrmProductView());
                Controls.Find("FrmProductView", false)[0].BringToFront();
            }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Controls.Add(new FrmOrderdetail());
            Controls.Find("FrmOrderdetail", false)[0].BringToFront();


        }
    }
}
