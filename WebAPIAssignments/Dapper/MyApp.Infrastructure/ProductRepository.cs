using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Core;

namespace MyApp.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        ProductEntities _db;

        public ProductRepository()
        {
            _db = new ProductEntities();    
        }
        public void Create(tbl_ProductMaster product)
        {
            _db.tbl_ProductMaster.Add(product);
            _db.SaveChanges();
        }

        public void Delete(int productId)
        {
            //tbl_ProductMaster product = _db.tbl_ProductMaster.Find(productId);
            var product = _db.tbl_ProductMaster.Find(productId);
            _db.tbl_ProductMaster.Remove(product);
            _db.SaveChanges();
        }

        public IEnumerable<tbl_ProductMaster> GetAllProduct()
        {
            return _db.tbl_ProductMaster;
        }

        public tbl_ProductMaster GetProductById(int productId)
        {
            var product = _db.tbl_ProductMaster.Find(productId);
            return product;
        }

        public void Update(tbl_ProductMaster product)
        {
            _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
