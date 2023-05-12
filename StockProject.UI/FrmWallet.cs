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
    public partial class FrmWallet : Form
    {
        public FrmWallet()
        {
            InitializeComponent();
        }

        UserManager user = new UserManager();
        private void btnConfirmation_Click(object sender, EventArgs e)
        {
          
            int Id = Convert.ToInt32(lblId.Text);

            if (txtAdwallet.Text.Trim()!=null && txtAdwallet.Text.Trim()!="")
            {
                user.ChangeWallet(Id, decimal.Parse(txtWallet.Text.Replace(".", ",").Trim()), decimal.Parse(txtAdwallet.Text.Replace(".", ",").Trim()));

                MessageBox.Show("Cüzdana Ekleme Yapıldı");
                FrmShopping frm = new FrmShopping();
                frm.lbluserId.Text = lblId.Text;
                frm.lblTotal.Text = lblTotal.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boş Bırakılamaz");
            }

        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            FrmShopping frm = new FrmShopping();
            frm.lbluserId.Text = lblId.Text;
            frm.lblTotal.Text = lblTotal.Text;
            frm.Show();
            this.Hide();
        }
    }
}
