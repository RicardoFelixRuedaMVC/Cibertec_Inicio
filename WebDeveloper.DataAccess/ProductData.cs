
using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
    public class ProductData: BaseDataAccess<Product>
    {
        public Product GetProduct(int id)
        {

            using (var dbcontext = new WebContextDb())
                return dbcontext.Product.FirstOrDefault(x => x.id == id);

        }
    }
}
