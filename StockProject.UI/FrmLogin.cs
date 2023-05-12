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
    public partial class FrmLogin : Form
    {
        MessagesManager msg = new MessagesManager();
        UserManager usermanager = new UserManager();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var UserControl = usermanager.UserLogin(txtMail.Text, txtPassword.Text);

            if (usermanager!=null && usermanager.userId > 0)
            {
                if (txtMail.Text.Trim() != null && txtMail.Text.Trim() != "" && txtPassword.Text.Trim() != null && txtPassword.Text.Trim() != "")
                {

                    MessageBox.Show(msg.Successful("Kullanıcı ", " Girişi"));

                    

                    FrmProduct frm = new FrmProduct();
                    frm.lblId.Text = usermanager.userId.ToString();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg.NullBox());
                }
            }
        }
    }
}
