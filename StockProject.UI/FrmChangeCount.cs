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
    
    public partial class FrmChangeCount : Form
    {

        OrderManager ordermanager = new OrderManager();
        public FrmChangeCount()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ordermanager.CountChange(int.Parse(lblprocId.Text), int.Parse(lblId.Text), int.Parse(txtCount.Text),decimal.Parse(lblPrice.Text.Replace(".",",")));
            

            FrmOrder frm = new FrmOrder();
            frm.lblId.Text = lblId.Text;
           
            frm.Show();
            this.Hide();
        }
    }
}
