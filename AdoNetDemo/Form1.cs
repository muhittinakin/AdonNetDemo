using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
                {
                Name = TxtName.Text,
                UnitPrice = Convert.ToDecimal(TxtUnitPrize.Text),
                StockAmount=Convert.ToInt32(TxtUnitPrize.Text)

            });

            LoadProducts();
            MessageBox.Show("Ürün Eklendi.");

        }

       

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            TxtUnitPrizeUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
          TxtStockAmountUpdate.Text= dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {

                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = TxtNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(TxtUnitPrizeUpdate.Text),
                StockAmount =Convert.ToInt32(TxtStockAmountUpdate.Text)
            };
           
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!!");
    }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted");
        }
    }
}
