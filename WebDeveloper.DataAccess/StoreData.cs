using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class StoreData:BaseDataAccess<Store>
    {
        public Store GetStore(int id)
        {

            using (var dbcontext = new WebContextDb())
                return dbcontext.Store.FirstOrDefault(x => x.id == id);

        }


    }
}
