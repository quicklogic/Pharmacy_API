using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PharmacyAPI.Controllers
{
    
    public class UserInfoController : ApiController
    {
        Pharmacy db = new Pharmacy();

        [HttpGet]
         public IQueryable Get(string login)
        {
            return db.UsersInfoes.Where(p => p.login == login);
        }

        
    }
}