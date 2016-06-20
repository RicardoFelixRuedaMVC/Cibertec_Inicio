using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb:DbContext
    {
        public WebContextDb():base("name=WebDeveloperConnectionString")
        {
            Database.SetInitializer(new WebDeveloperInitializer());
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       
    }
}
