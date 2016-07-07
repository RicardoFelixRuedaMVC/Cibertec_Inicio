using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

namespace WebDeveloper
{
    public partial class Startup
    {
        public class startup
        {
            public void ConfigureAuth(IAppBuilder app)
            {
                app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AuthenticationType=DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath=new Microsoft.Owin.PathString("/Account/Login")

                });
            }


        }

    }
}
