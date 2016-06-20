using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    class WebDeveloperInitializer:DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name="Jose", LastName="Perez"},
                new Client {Name="Maria", LastName="Perez"},
                new Client {Name="Jesus", LastName="Perez"},
                new Client {Name="Juan", LastName="Perez"},
                new Client {Name="Pedro", LastName="Perez"}
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {Code="Z001",  Name="Zapatitos para bb azul", DateExpired=Convert.ToDateTime("12-06-2018 00:00:00")},
                new Product {Code="Z002",  Name="Zapatitos para bb Rojo", DateExpired=Convert.ToDateTime("12-06-2018 00:00:00")},

                
            };

            products.ForEach(c => context.Product.Add(c));
            context.SaveChanges();

            var Categorys = new List<Category>
            {
                new Category {NameCategory="Zapatitos"},
                new Category {NameCategory="Chompas"},
                new Category {NameCategory="Gorros"}
               
            };

            Categorys.ForEach(c => context.Category.Add(c));
            context.SaveChanges();

            var Stores = new List<Store>
            {
                new Store {Code="S001",Name="San borja"}

            };

            Stores.ForEach(c => context.Store.Add(c));
            context.SaveChanges();



        }
    }
}
