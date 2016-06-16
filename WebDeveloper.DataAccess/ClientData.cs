﻿using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
    public class ClientData:BaseDataAccess<Client>
    {
        public Client GetClient(int id)
        {

            using (var dbcontext = new WebContextDb())
                return dbcontext.Clients.FirstOrDefault(x => x.id == id);
            
        }
    }
}
