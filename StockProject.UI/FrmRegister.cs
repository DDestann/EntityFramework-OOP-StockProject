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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        UserManager usermanager = new UserManager();
        MessagesManager msg = new MessagesManager();
        

        private void btnNewCreate_Click(object sender, EventArgs e)
        {
            if (
                txtName.Text.Trim() != null && txtName.Text.Trim() != ""
                && txtSurname.Text.Trim() != null && txtSurname.Text.Trim() != "" &&
                txtMail.Text.Trim() != null && txtMail.Text.Trim() != "" &&
                txtPassword.Text.Trim() != null && txtPassword.Text.Trim() != "" &&
                txtPasswordAgain.Text.Trim() != null && txtPasswordAgain.Text.Trim() != "" &&
                txtAddress.Text.Trim() != null && txtAddress.Text.Trim()!=""
               // txtWallet.Text.Trim().Replace(".", ",") != null && txtWallet.Text.Trim().Replace(".", ",") != ""

               

               )
            {
                if (txtPassword.Text.Trim() == txtPasswordAgain.Text.Trim())
                {
                    usermanager.UserAdd(txtName.Text, txtSurname.Text, txtMail.Text, txtPassword.Text,txtAddress.Text,1);
                    MessageBox.Show(msg.Successful("Kullanıcı","Ekleme") + " Login Sayfasına Yönlendirilecaksiniz");

                    FrmLogin frm = new FrmLogin();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg.PasswordControl());

                }

            }
            else
            {
                MessageBox.Show(msg.NullBox());
            }
        }
    }
}
