using StockProject.Entity.Context;
using StockProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject.Business.Managers
{
    public class OrderManager
    {

        public decimal Total = 0;
       
        public void GetListOrder(DataGridView dt, string userId)
        {


            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var query = from item in db.Orders
                                join item2 in db.Products
                                on item.ProductId equals item2.ProductId
                                where (item.UserId.ToString() == userId & item.Okey == 1)

                                select new
                                {
                                    item.OrderId,
                                    item2.ProductId,
                                    item2.ProductName,
                                    item.Count,
                                    item2.Price,
                                    item.Total
                                };



                    if (query != null)
                    {


                        dt.DataSource = query.ToList();
                        dt.Columns[1].Visible = false;
                        if (dt.Rows.Count > 0)
                        {
                            Total = query.Sum(x => x.Total);
                        }

                    }

                }
            }
            catch (Exception msj)
            {
                MessageBox.Show("Hata Oluştu :" + msj.Message);
            }
        }

        public void OrderAdd(int productId, int userId, int count, int okey, decimal total)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    
                    Order order = new Order();
                    order.ProductId = productId;
                    order.UserId = userId;
                    order.Count = count;
                    order.Okey = okey;
                    order.Total = total * count;



                    var control = db.Orders.FirstOrDefault(x => x.ProductId == productId & x.Okey==1);
                    var control2 = db.Products.Where(x=> x.ProductId==productId);
                    if (control2.FirstOrDefault().StockCount>0)
                    {
                        if (control == null)
                        {
                            db.Orders.Add(order);
                            db.SaveChanges();
                            var query = db.Products.FirstOrDefault(x => x.ProductId == productId);
                            query.StockCount = query.StockCount - count;
                            db.SaveChanges();

                            MessageBox.Show("Siparişiniz Eklendi");

                        }
                        else
                        {
                            MessageBox.Show("Siparişiniz Mevcut");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün Stokta Kalmadı");
                    }

                    

                }
            }
            catch (Exception msj)
            {
                MessageBox.Show("Hata Oluştu :" + msj.Message);
            }
        }

        public void CountChange(int productId, int userId, int count, decimal price)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var query = db.Orders.FirstOrDefault(x => x.ProductId == productId & x.UserId == userId);
                    var query2 = db.Products.Where(x=>x.ProductId==productId);

                    if (query2.FirstOrDefault().StockCount >0 )
                    {
                        query2.FirstOrDefault().StockCount = (query2.FirstOrDefault().StockCount + query.Count) - count;

                        if (userId > 0 && productId > 0 && count > 0 )
                        {
                            query.Count = count;
                            query.Total = price * count;

                            db.SaveChanges();

                            MessageBox.Show("Count Değiştirildi");
                        }
                        else
                        {
                            MessageBox.Show("Count Alanı Boş Bırakılamaz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("istediğiniz miktarda Stokta bulunmuyor Not: stok adedi '0' Olduğundan dolayı ürünü Sildikten sonra Farklı bir Adet Girişi Yapabilirsiniz ");
                    }

                    

                }
            }
            catch (Exception msj)
            {
                MessageBox.Show("Hata Oluştu :" + msj.Message);
            }
        }

        public int DeleteOrder(int orderId , int productId)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {

                    var query = db.Orders.FirstOrDefault(x => x.OrderId == orderId);
                    var query2 = db.Products.FirstOrDefault(x=>x.ProductId==query.ProductId);
                    query2.StockCount = query2.StockCount + query.Count;
                    db.Orders.Remove(query);
                    db.SaveChanges();




                }
                
                
            }
            catch (Exception msj)
            {
                MessageBox.Show("Hata Oluştu :" + msj.Message);
            }

            return orderId;
        }

        public void ConfirmationOrder(int userId,decimal wallet,decimal total)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {

                    var query = db.Orders.Where(item => item.UserId == userId & item.Okey == 1 );
                    var query2 = db.Users.FirstOrDefault(x=> x.UserId==userId & x.UserId==query.FirstOrDefault().UserId);



                    if (query != null && query.Count() > 0 )
                    {
                        if (wallet> total || wallet>=total)
                        {
                            query2.Wallet = wallet - total;


                            for (int i = 0; i < query.Count() + 1; i++)
                            {
                                i = query.FirstOrDefault().Okey = 0;
                                db.SaveChanges();
                            }

                            MessageBox.Show("Ödemeniz Alındı");

                        }
                        else
                        {
                            MessageBox.Show("Yetersiz Bakiye ");
                        }
                    }
                    else
                    {

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
