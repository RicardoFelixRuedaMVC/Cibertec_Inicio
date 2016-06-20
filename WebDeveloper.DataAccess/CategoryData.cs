using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CategoryData: BaseDataAccess<Category>
    {
        public Category GetCategory(int id)
        {

            using (var dbcontext = new WebContextDb())
                return dbcontext.Category.FirstOrDefault(x => x.id == id);

        }


    }
}
