using StockProject.Business.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject.UI
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        OrderManager ordermanager = new OrderManager();
        ProductManager productmanager = new ProductManager();
        CategoryManager categorymanager = new CategoryManager();
        MessagesManager msg = new MessagesManager();
    
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            GetcategoryList();
            GetproductList();
        }
     
        private void GetproductList()
        {
            productmanager.GetListProduct(DtlShopping);
        }

        private void GetcategoryList()
        {
            categorymanager.GetListCategory(DrpCategory);
        }

        private void DrpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            productmanager.Source(DrpCategory, DtlShopping);
        }

       

        private void btnShowShopping_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder();
            frm.lblId.Text = lblId.Text;
            frm.ShowDialog();
            this.Hide();
        }

        private void BtnAddShopping_Click(object sender, EventArgs e)
        {
             int productId = int.Parse(DtlShopping.CurrentRow.Cells["ProductId"].Value.ToString());
            decimal Total = decimal.Parse(DtlShopping.CurrentRow.Cells["Price"].Value.ToString());
            

            ordermanager.OrderAdd(productId, int.Parse(lblId.Text), int.Parse(txtCount.Text), 1,Total);
        }
    }
}
