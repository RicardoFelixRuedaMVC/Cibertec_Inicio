using Microsoft.Owin;
using Owin;
using LightInject;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new ServiceContainer();
            container.Register<IDataAccess<Client>, ClientData>();
           // container.RegisterAssembly(A)


            container.RegisterControllers();
            container.EnableMvc();

            //ConfigureAuth(app);
        }
    }
}
