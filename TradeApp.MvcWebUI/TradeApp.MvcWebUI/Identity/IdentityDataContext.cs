using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TradeApp.MvcWebUI.Entity;

namespace TradeApp.MvcWebUI.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {


        public IdentityDataContext() : base("dataConnection")
        {

        }


    }
}