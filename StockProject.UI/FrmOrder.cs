using StockProject.Business.Managers;
using StockProject.Entity.Context;
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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        OrderManager ordermanager = new OrderManager();
       
        private void FrmOrder_Load(object sender, EventArgs e)
        {
        
             Getlist();
           

        }
       
        private void Getlist()
        {
           
            ordermanager.GetListOrder(DtlShopping, lblId.Text);

            if (ordermanager.Total>0 && DtlShopping.Rows.Count>0)
            {
                lblTotal.Text = ordermanager.Total.ToString();
                
            }
            else
            {
                lblTotal.Text = "0";
            }
            
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.lblId.Text = lblId.Text;
            frm.Show();
            this.Hide();
        }

        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            

            FrmShopping frm = new FrmShopping();
            frm.lbluserId.Text= lblId.Text;
            frm.lblTotal.Text = lblTotal.Text;
            
            frm.Show();
            this.Hide();
        }

        private void btnCountChange_Click(object sender, EventArgs e)
        {
            if (DtlShopping.Rows.Count>0)
            {
                int productId = int.Parse(DtlShopping.CurrentRow.Cells["ProductId"].Value.ToString());
                int Count = int.Parse(DtlShopping.CurrentRow.Cells["Count"].Value.ToString());
                decimal Price = decimal.Parse(DtlShopping.CurrentRow.Cells["Price"].Value.ToString());

                FrmChangeCount frm = new FrmChangeCount();
                frm.lblprocId.Text = productId.ToString();
                frm.lblId.Text = lblId.Text;
                frm.txtCount.Text = Count.ToString();
                frm.lblPrice.Text = Price.ToString();

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ürün Yok");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtlShopping.Rows.Count == 0)
            {
                FrmOrder frm = new FrmOrder();
                frm.Show();
                this.Hide();
            }
            if (DtlShopping.Rows.Count != 0)
            {
                lblorderId.Text = DtlShopping.CurrentRow.Cells["OrderId"].Value.ToString();
                lblproductId.Text = DtlShopping.CurrentRow.Cells["ProductId"].Value.ToString();
                ordermanager.DeleteOrder(Convert.ToInt32(lblorderId.Text) , Convert.ToInt32(lblproductId.Text));
                MessageBox.Show("Ürün Silindi");
                Getlist();
            }


              
            
           
          
        }
    }
}
