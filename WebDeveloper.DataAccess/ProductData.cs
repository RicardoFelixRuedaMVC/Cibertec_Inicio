
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
using System;
namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public Product GetProduct(int id)
        {

            using (var dbcontext = new WebContextDb())
                return dbcontext.Product.FirstOrDefault(x => x.id == id);

        }

        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {id=1,Description="Cristal",Price=3.0,DateCreation=DateTime.Now },
                new Product {id=1,Description="Pilsen",Price=3.0,DateCreation=DateTime.Now },
                new Product {id=1,Description="Pilsen",Price=0.0,DateCreation=null }
            };



        }
    }

    
}
