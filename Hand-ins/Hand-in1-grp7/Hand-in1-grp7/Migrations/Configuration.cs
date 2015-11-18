namespace Hand_in1_grp7.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Hand_in1_grp7.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Hand_in1_grp7.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hand_in1_grp7.Models.ApplicationDbContext context)
        {
            context.LoanInformation.AddOrUpdate(p => p.LoanId,
               new LoanInformation
               {
                   LoanDate = DateTime.Today,
                   ReturnDate = DateTime.Today.AddDays(1),
                   IsEmailSent = "yes",
                   ReservationDate = DateTime.Today.AddDays(-1),
                   OwnerId = "EtEllerAndetFirma",
                   ReservationId = "ErReserveret",
                   ComponentData = new Component
                   {
                       ComponentNumber = 1,
                       SerialNr = "123321",
                       AdminComment = "Virker Det?",
                       UserComment = "Ja Det gør det.",
                       ComponentInfo = new ComponentInformation
                       {
                           ComponentName = "Arduino",
                           ComponentInfo = "Noget mærkeligt",
                           DataSheet = "Min URL",
                           Image = "Skal ikke være en URL",
                           ManufacturerLink = "URL",
                           CategoryInfo = new Category { CategoryName = "Arduino" },
                       }
                   },
                   UserInfo = new UserInformation
                   {
                       StudentId = "MA90747",
                       CellNr = "50587609",
                       FullName = "Magnus Schou Abildgren",
                   },
               });
            //new Component
            //{
            //    ComponentNumber = 1,
            //    SerialNr = "123321",
            //    AdminComment = "Virker Det?",
            //    UserComment = "Ja Det gør det.",
            //    ComponentInfo = new ComponentInformation
            //    {
            //        ComponentName = "Arduino",
            //        ComponentInfo = "Noget mærkeligt",
            //        DataSheet = "Min URL",
            //        Image = "Skal ikke være en URL",
            //        ManufacturerLink = "URL",
            //        CategoryInfo = new Categories { CategoryName = "Arduino" },
            //    }

            //}
            //context.ComponentInformations.AddOrUpdate(p => p.ComponentName,
            //    new ComponentInformation
            //    {
            //        ComponentName = "Arduino",
            //        ComponentInfo = "Noget mærkeligt",
            //        DataSheet = "Min URL",
            //        Image = "Skal ikke være en URL",
            //        ManufacturerLink = "URL",
            //        CategoryId = new Categories { CategoryName="Arduino"},
            //    });
            //var category = new Categories
            //    {

            //        CategoryName = "Arduino",
            //    };



            //context.CategoryTable.AddOrUpdate(p => p.CategoryName, category);

            /*context.ComponentInformations.AddOrUpdate(p => p.ComponentName, 
                new ComponentInformation
                {
                    InfoId = 1,
                    ComponentName = "MK2",
                    ComponentInfo = "The very best of Arduino",
                    DataSheet = "MyURL",
                    Image = "ByteArrayToBe",
                    ManufacturerLink = "AnotherURL",
                    CategoryId = new Categories(),
                },
                new ComponentInformation
                {
                    InfoId = 2,
                    ComponentName = "MK3",
                    ComponentInfo = "The next best of Arduino",
                    DataSheet = "MyURL",
                    Image = "ByteArrayToBe",
                    ManufacturerLink = "AnotherURL",
                    CategoryId = 1,
                });

            context.Components.AddOrUpdate(p => p.ComponentNumber,
                new Component
                {
                    ComponentNumber = 1,
                    SerialNr = "123321",
                    AdminComment = "Virker Det?",
                    UserComment = "Ja Det gør det.",
                    InfoId = 1
                    
                },
                new Component
                {
                    ComponentNumber = 2,
                    SerialNr = "333321",
                    AdminComment = "Virker det stadig?",
                    UserComment = "Ja sandelig.",
                    InfoId = 2,
                }
                );*/
            /*context.ComponentInformations.AddOrUpdate(p => p.ComponentName,
                new ComponentInformation
                {
                    ComponentName = "Arduino",
                    ComponentInfo = "Noget mærkeligt",
                    DataSheet = "Min URL",
                    Image = "Skal ikke være en URL",
                    ManufacturerLink = "URL",
                    Category = 1,
                }); */
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
