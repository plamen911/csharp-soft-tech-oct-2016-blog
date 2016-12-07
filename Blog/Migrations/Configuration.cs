namespace Blog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Blog.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<Blog.Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BlogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            if (!context.Roles.Any())
            {
                this.CreateRole(context, "Admin");
                this.CreateRole(context, "User");
            }

            if (!context.Users.Any())
            {
                this.CreateUser(context, "plamen@lynxlake.org", "Plamen Markov", "1");
                this.SetRoleToUser(context, "plamen@lynxlake.org", "Admin");
            }
        }

        private void SetRoleToUser(BlogDbContext context, string email, string role)
        {
            // Create user manager
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            // Get the user from the db by his email
            var user = context.Users.Where(u => u.Email == email).First();

            // Add the role to the user
            var result = userManager.AddToRole(user.Id, role);

            // Validate result
            if (!result.Succeeded)
            {
                throw new Exception(string.Join(";", result.Errors));
            }
        }

        private void CreateRole(BlogDbContext context, string v)
        {
            throw new NotImplementedException();
        }

        private void CreateUser(BlogDbContext context, string email, string fullName, string password)
        {
            // Create user manager
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            // Ser user manager password validator
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireDigit = false,
                RequireLowercase = false,
                RequireNonLetterOrDigit = false,
                RequireUppercase = false,
            };

            // Create user object
            var admin = new ApplicationUser
            {
                UserName = email,
                FullName = fullName,
                Email = email,
            };

            // Create user
            var result = userManager.Create(admin, password);

            // Validate result
            if (!result.Succeeded)
            {
                throw new Exception(string.Join(";", result.Errors));
            }
        }
    }
}
