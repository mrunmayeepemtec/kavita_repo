using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace MyApp.Core
{
    public interface IProductRepository
    {
        void Create(tbl_ProductMaster product);

        void Update(tbl_ProductMaster product);

        void Delete(int productId);

        IEnumerable<tbl_ProductMaster> GetAllProduct();

        tbl_ProductMaster GetProductById(int productId);
    }


}
