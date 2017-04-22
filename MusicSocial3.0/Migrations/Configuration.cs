namespace MusicSocial3.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MusicSocial3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MusicSocial3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        bool AddUserAndRole(MusicSocial3.Models.ApplicationDbContext contexts)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(contexts));
            ir = rm.Create(new IdentityRole("Developer"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(contexts));
            var user = new ApplicationUser()
            {
                UserName = "user1@contoso.com",
            };
            ir = um.Create(user, "P_assw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "Developer");
            return ir.Succeeded;
        }

        protected override void Seed(MusicSocial3.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Roles.AddOrUpdate( p => p.Name,
            //    new IdentityRole { Name = "Admin" },
            //    new IdentityRole { Name = "Developer" },
            //    new IdentityRole { Name = "member"}

            //    );
            bool AddUserAndRole(MusicSocial3.Models.ApplicationDbContext contexts)
            {
                IdentityResult ir;
                var rm = new RoleManager<IdentityRole>
                    (new RoleStore<IdentityRole>(context));
                ir = rm.Create(new IdentityRole("Developer"));
                var um = new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(context));
                var user = new ApplicationUser()
                {
                    UserName = "user1@contoso.com",
                };
                ir = um.Create(user, "P_assw0rd1");
                if (ir.Succeeded == false)
                    return ir.Succeeded;
                ir = um.AddToRole(user.Id, "Developer");
                return ir.Succeeded;
            }



        }
    }
}
