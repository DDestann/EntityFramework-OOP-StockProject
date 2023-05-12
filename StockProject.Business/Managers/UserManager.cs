using StockProject.Entity.Context;
using StockProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockProject.Business.Managers
{
    public class UserManager
    {
        MessagesManager msg = new MessagesManager();
        User user = new User();
         public int userId = 0;
        public decimal wallet = 0;
      //  public decimal addwallet = 0;
        public void GetListUser(DataGridView dt)
        {

            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    dt.DataSource = db.Users.ToList();
                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu : ", msj.Message);
            }
        }


        public void UserAdd(string name, string surname, string mail, string password, string address,int check)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {

                   
                    user.UserName = name;
                    user.UserSurname = surname;
                    user.Email = mail;
                    user.Password = password;
                    user.Choices = check;
                    user.Address = address;
                    
                    var control = db.Users.Where(x => x.Email == mail).FirstOrDefault();
                    if (control == null)
                    {
                        db.Users.Add(user);
                        db.SaveChanges();
                       // MessageBox.Show(msg.Successful("Kullanıcı", "Ekleme"));
                    }
                    else
                    {
                        MessageBox.Show(msg.ControlMail());
                    }



                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu : ", msj.Message);
            }


        }

        public bool UserLogin(string mail, string password)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {


                    var choicecontrol = db.Users.Where(x => x.Email == mail & x.Choices == 1).FirstOrDefault();



                    if (choicecontrol != null)
                    {
                        var controll = db.Users.Where(x => x.Email == mail & x.Password == password).FirstOrDefault();
                        if (controll != null)
                        {
                            userId = controll.UserId;
                           // wallet = controll.Wallet;
                            /*Kullanici Yonlendirilecek (Yapılacak)*/
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(msg.Incorrect());
                        }
                    }
                    else
                    {
                        MessageBox.Show(msg.CheckControl());
                    }



                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu : " + msj.Message);
            }

            return false;

        }


        public void GetUserWallet(int userId)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    
                   var query = db.Users.FirstOrDefault(x => x.UserId == userId);
                    
                    wallet = Convert.ToDecimal(query.Wallet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void ChangeWallet(int userId ,decimal wallett ,decimal addwallet)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var query = db.Users.Where(x => x.UserId == userId).FirstOrDefault();

                    if (query.UserId==userId && wallett>0 && addwallet>0)
                    {

                        query.Wallet= wallett + addwallet;
                        

                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("wallet Alanı Boş Bırakılamaz");
                    }

                }
            }
            catch (Exception msj)
            {
                MessageBox.Show("Hata Oluştu :" + msj.Message);
            }
        }
    }

}

