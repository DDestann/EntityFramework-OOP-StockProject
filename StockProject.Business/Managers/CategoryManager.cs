using StockProject.Entity.Context;
using StockProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject.Business.Managers
{
    public class CategoryManager
    {
        MessagesManager msg = new MessagesManager();
        public void GetListCategory(ComboBox cmb)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    cmb.DataSource = db.Categories.ToList();
                    cmb.ValueMember = "CategoryId";
                    cmb.DisplayMember = "CategoryName";

                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }

        }

        public void AddCategory(string name)
        {

            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    Category category = new Category();
                    category.CategoryName = name;

                    db.Categories.Add(category);
                    db.SaveChanges();

                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }

        }
        public int DeleteCategory(int categoryId)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var deleteCategory = db.Categories.FirstOrDefault(Del => Del.CategoryId == categoryId);


                    db.Categories.Remove(deleteCategory);
                    db.SaveChanges();


                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }


            return categoryId;

        }


        public int UpdateCategory(int categoryId, string name)
        {
            try
            {
                using (StockProjectDbContext db = new StockProjectDbContext())
                {
                    var updatecategory = db.Categories.FirstOrDefault(x => x.CategoryId == categoryId);

                    updatecategory.CategoryId = categoryId;
                    updatecategory.CategoryName = name;
                    db.SaveChanges();


                }
            }
            catch (Exception msj)
            {

                MessageBox.Show("Hata Oluştu ", msj.Message);
            }

            return categoryId;

        }


    }
}
