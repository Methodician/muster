using muster.Models;

namespace muster.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<muster.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(muster.Models.ApplicationDbContext context)
        {
            context.Camps.AddOrUpdate(
                p => p.Name,
                new Camp
                {Id = 1, Name = "Sun", Mustering = false, Musters = {}},
                new Camp
                {Id = 2, Name = "Moon", Mustering = false, Musters = {}},
                new Camp
                {Id = 3, Name = "Earth", Mustering = true, Musters = {}},
                new Camp
                {Id = 4, Name = "Potato", Mustering = false, Musters = {}},
                new Camp
                {Id = 5, Name = "Carrot", Mustering = false, Musters = {}},
                new Camp
                {Id = 6, Name = "Turnip", Mustering = true, Musters = {}},
                new Camp
                {Id = 7, Name = "Banana", Mustering = false, Musters = {}},
                new Camp
                {Id = 8, Name = "Orange", Mustering = false, Musters = {}},
                new Camp
                {Id = 9, Name = "Apple", Mustering = false, Musters = {}}
                );
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
        }
    }
}
