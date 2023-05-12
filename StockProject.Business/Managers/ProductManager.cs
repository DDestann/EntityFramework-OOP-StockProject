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
    public class ProductManager
    {

        public void Source(ComboBox cmb, DataGridView dt)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var query = from item in db.Products
                                join item2 in db.Categories
                                on item.CategoryId equals item2.CategoryId
                                where item2.CategoryName.Contains(cmb.Text)
                                select new
                                {
                                    item.ProductId,
                                    item2.CategoryName,
                                    item.ProductName,
                                    item.Price,
                                    item.StockCount
                                };

                    dt.DataSource = query.ToList();
                    dt.Columns[0].HeaderText = "Number";
                    dt.Columns[1].HeaderText = "Categories";
                    dt.Columns[2].HeaderText = "Products";

                }
            }
            catch (Exception msj)
            {
                MessageBox.Show("Hata Oluştu :" + msj.Message);
            }

        }
        public void GetListProduct(DataGridView dt)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var query = from item in db.Products
                                join item2 in db.Categories
                                on item.CategoryId equals item2.CategoryId

                                select new
                                {
                                    item.ProductId,
                                    item2.CategoryName,
                                    item.ProductName,
                                    item.Price,
                                    item.StockCount
                                };
                    dt.DataSource = query.ToList();
                    dt.Columns[0].HeaderText = "Number";
                    dt.Columns[1].HeaderText = "Categories";
                    dt.Columns[2].HeaderText = "Products";

                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }


        }
        public void AddProduct(int categoryId, string name, decimal price, int stockcount, int productId)
        {

            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    Product product = new Product();

                    product.CategoryId = categoryId;
                    product.ProductName = name;
                    product.Price = price;
                    product.StockCount = stockcount;



                    db.Products.Add(product);
                    db.SaveChanges();

                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }

        }
        public int DeleteProduct(int productyId)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var deleteProduct = db.Products.FirstOrDefault(Del => Del.ProductId == productyId);


                    db.Products.Remove(deleteProduct);
                    db.SaveChanges();


                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }

            return productyId;

        }
        public int UpdateProduct(int productId, int categoryId, string name, decimal price, int stockcount)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var UpdateProducts = db.Products.FirstOrDefault(x => x.ProductId == productId);

                    UpdateProducts.CategoryId = categoryId;
                    UpdateProducts.ProductName = name;
                    UpdateProducts.Price = price;
                    UpdateProducts.StockCount = stockcount;


                    db.SaveChanges();


                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }

            return productId;

        }


    }
}
