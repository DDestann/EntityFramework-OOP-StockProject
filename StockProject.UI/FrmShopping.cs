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
    public partial class FrmShopping : Form
    {
        UserManager user = new UserManager();
        OrderManager order = new OrderManager();
        public FrmShopping()
        {
            InitializeComponent();
        }

        private void FrmShopping_Load(object sender, EventArgs e)
        {
            Getwallet();

        }

        private void Getwallet()
        {

            int Id = int.Parse(lbluserId.Text);
            user.GetUserWallet(Id);
            lblWallet.Text = user.wallet.ToString();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            order.ConfirmationOrder(int.Parse(lbluserId.Text),decimal.Parse(lblWallet.Text), decimal.Parse(lblTotal.Text));
            Getwallet();
           
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            FrmWallet frm = new FrmWallet();
            frm.lblId.Text = lbluserId.Text;
            frm.lblTotal.Text = lblTotal.Text;
            frm.txtWallet.Text = lblWallet.Text;
            frm.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder();
            frm.lblId.Text = lbluserId.Text;
            frm.lblTotal.Text = lblTotal.Text;
            frm.Show();
            this.Hide();
        }

        
    }
}
