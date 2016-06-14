using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
    public class ClientData
    {
        public List<Client> GetFakeData()
        {
            return new List<Client>
        {
            new Client {id=1,Name="Juan", LastName="Perez" },
            new Client {id=2,Name="Raul", LastName="Ruidiaz" }
        };


        }
        public List<Client> GetList()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Clients.ToList();

            }
        }
    }
}
