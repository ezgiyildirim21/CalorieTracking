namespace Calori.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false, maxLength: 256),
                        Calorie = c.Decimal(nullable: false, precision: 5, scale: 2),
                        ImagePath = c.String(nullable: false),
                        Porsion = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 5, scale: 2),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.FoodId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealId = c.Int(nullable: false, identity: true),
                        MealName = c.Int(nullable: false),
                        MealDate = c.DateTime(nullable: false),
                        TotalMealCalories = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MealId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Surname = c.String(nullable: false, maxLength: 256),
                        Email = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                        BirthDate = c.DateTime(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Height = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MealFoods",
                c => new
                    {
                        Meal_MealId = c.Int(nullable: false),
                        Food_FoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Meal_MealId, t.Food_FoodId })
                .ForeignKey("dbo.Meals", t => t.Meal_MealId, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.Food_FoodId, cascadeDelete: true)
                .Index(t => t.Meal_MealId)
                .Index(t => t.Food_FoodId);
            
            CreateTable(
                "dbo.UserMeals",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Meal_MealId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Meal_MealId })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_MealId, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Meal_MealId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMeals", "Meal_MealId", "dbo.Meals");
            DropForeignKey("dbo.UserMeals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.MealFoods", "Food_FoodId", "dbo.Foods");
            DropForeignKey("dbo.MealFoods", "Meal_MealId", "dbo.Meals");
            DropForeignKey("dbo.Foods", "CategoryId", "dbo.Categories");
            DropIndex("dbo.UserMeals", new[] { "Meal_MealId" });
            DropIndex("dbo.UserMeals", new[] { "User_Id" });
            DropIndex("dbo.MealFoods", new[] { "Food_FoodId" });
            DropIndex("dbo.MealFoods", new[] { "Meal_MealId" });
            DropIndex("dbo.Foods", new[] { "CategoryId" });
            DropTable("dbo.UserMeals");
            DropTable("dbo.MealFoods");
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
