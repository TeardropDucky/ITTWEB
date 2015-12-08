namespace HandIn2_FoodProcessor.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HandIn2_FoodProcessor.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HandIn2_FoodProcessor.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HandIn2_FoodProcessor.Models.ApplicationDbContext context)
        {
            context.Consumables.AddOrUpdate(p => p.ConsumableName, new Consumables
            {
                ConsumableName = "Oksekød",
                ProteinPer100Gram = 20,
            },
            new Consumables 
            {
                ConsumableName = "Svinekød",
                ProteinPer100Gram = 20,
            },
            new Consumables 
            {
                ConsumableName = "Kylling",
                ProteinPer100Gram = 20,
            },
            new Consumables 
            {
                ConsumableName = "Æg",
                ProteinPer100Gram = 12.6,
            },
            new Consumables 
            {
                ConsumableName = "Minimælk",
                ProteinPer100Gram = 3.5,
            },
            new Consumables 
            {
                ConsumableName = "Havregryn",
                ProteinPer100Gram = 13.3,
            },
            new Consumables 
            {
                ConsumableName = "Rugbrød",
                ProteinPer100Gram = 6.2,
            },
            new Consumables 
            {
                ConsumableName = "Grønne bønner",
                ProteinPer100Gram = 2,
            },
            new Consumables 
            {
                ConsumableName = "Kartoffel",
                ProteinPer100Gram = 1.9,
            }
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
