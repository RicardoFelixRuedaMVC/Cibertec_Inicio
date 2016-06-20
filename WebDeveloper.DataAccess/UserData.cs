using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
   public  class UserData:BaseDataAccess<User>
    {
        public User GetUser(int id)
        {

            using (var dbcontext = new WebContextDb())
                return dbcontext.User.FirstOrDefault(x => x.id == id);

        }
    }
}
