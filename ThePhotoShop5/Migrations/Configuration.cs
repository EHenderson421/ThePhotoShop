namespace ThePhotoShop5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ThePhotoShop5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ThePhotoShop5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ThePhotoShop5.Models.ApplicationDbContext context)
        {
            if (context.Owners.Any())
            {
                return;
            }

            else
            {

                var owner = new Owner[]
                {
                new Owner{UserId = "eric@thephotoshop.com"}
                };
                foreach (Owner o in owner)
                {
                    context.Owners.Add(o);
                }
                context.SaveChanges();
            }
        }
    }
}
