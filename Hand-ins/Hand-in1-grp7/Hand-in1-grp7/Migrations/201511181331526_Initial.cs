namespace Hand_in1_grp7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ComponentInformations",
                c => new
                    {
                        InfoId = c.Int(nullable: false, identity: true),
                        ComponentName = c.String(),
                        ComponentInfo = c.String(),
                        DataSheet = c.String(),
                        Image = c.String(),
                        ManufacturerLink = c.String(),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InfoId)
                .ForeignKey("dbo.Categories", t => t.Category, cascadeDelete: true)
                .Index(t => t.Category);
            
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        ComponentId = c.Int(nullable: false, identity: true),
                        ComponentNumber = c.Int(nullable: false),
                        SerialNr = c.String(),
                        AdminComment = c.String(),
                        UserComment = c.String(),
                        ComponentInfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComponentId)
                .ForeignKey("dbo.ComponentInformations", t => t.ComponentInfoId, cascadeDelete: true)
                .Index(t => t.ComponentInfoId);
            
            CreateTable(
                "dbo.LoanInformations",
                c => new
                    {
                        LoanId = c.Int(nullable: false, identity: true),
                        ComponentNr = c.Int(nullable: false),
                        LoanDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        IsEmailSent = c.String(),
                        ReservationDate = c.DateTime(nullable: false),
                        OwnerId = c.String(),
                        ReservationId = c.String(),
                        StudentId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LoanId)
                .ForeignKey("dbo.Components", t => t.ComponentNr, cascadeDelete: true)
                .ForeignKey("dbo.UserInformations", t => t.StudentId)
                .Index(t => t.ComponentNr)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.UserInformations",
                c => new
                    {
                        StudentId = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        CellNr = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.LoanInformations", "StudentId", "dbo.UserInformations");
            DropForeignKey("dbo.LoanInformations", "ComponentNr", "dbo.Components");
            DropForeignKey("dbo.Components", "ComponentInfoId", "dbo.ComponentInformations");
            DropForeignKey("dbo.ComponentInformations", "Category", "dbo.Categories");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.LoanInformations", new[] { "StudentId" });
            DropIndex("dbo.LoanInformations", new[] { "ComponentNr" });
            DropIndex("dbo.Components", new[] { "ComponentInfoId" });
            DropIndex("dbo.ComponentInformations", new[] { "Category" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.UserInformations");
            DropTable("dbo.LoanInformations");
            DropTable("dbo.Components");
            DropTable("dbo.ComponentInformations");
            DropTable("dbo.Categories");
        }
    }
}
