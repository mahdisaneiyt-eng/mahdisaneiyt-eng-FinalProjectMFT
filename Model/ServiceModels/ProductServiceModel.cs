using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {
        #region [- SelectAll() -]
        public List<Product> SelectAll()
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var products = context.Product.ToList();
                    return products;
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion

        #region [- Insert(Product product) -]
        public void Insert(Product product)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    context.Product.Add(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion

        #region [- Update(Product product) -]
        public void Update(Product product)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    context.Product.Update(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion

        #region [- Delete(int id) -]
        public void Delete(int id)
        {
            using (var context = new ProjectDbContext())
            {
                try
                {
                    var product = context.Product.Find(id);
                    if (product != null)
                    {
                        context.Product.Remove(product);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally { }
            }
        }
        #endregion
    }
}
