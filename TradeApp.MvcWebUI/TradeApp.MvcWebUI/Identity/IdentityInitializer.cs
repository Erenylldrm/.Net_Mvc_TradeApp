using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TradeApp.MvcWebUI.Entity;

namespace TradeApp.MvcWebUI.Identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>
    {
     

        protected override void Seed(IdentityDataContext context)
        {
          
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name="admin",Description="admin rolü"};
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "erenyildirim"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);


                var user = new ApplicationUser() { Name="eren",Surname="yildirim",UserName="erenyildirim",Email="erenyildirim@gmail.com"};


                manager.Create(user, "123456789");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "fatmayildirim"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "fatma", Surname = "yildirim", UserName = "fatmayildirim", Email = "fatmayildirim@gmail.com" };


                manager.Create(user, "123456789");
            
                manager.AddToRole(user.Id, "user");
            }



            base.Seed(context);
        }

    }
}