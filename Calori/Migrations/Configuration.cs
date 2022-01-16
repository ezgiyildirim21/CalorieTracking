namespace Calori.Migrations
{
    using Calori.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Calori.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Calori.Data.AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User()
                {
                    Name = "admin",
                    Surname = "admin",
                    Email = "admin@gmail.com",
                    Password = "admin",
                    BirthDate = DateTime.Now,
                    Gender = Gender.Male
                });
            }
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category()
                {
                    CategoryName = "Soups",
                    CategoryId = 1
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Meat Dishes",
                    CategoryId = 2
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Olive Oils",
                    CategoryId = 3
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Pastries",
                    CategoryId = 4
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Pilafs",
                    CategoryId = 5
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Pastas",
                    CategoryId = 6
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Desserts",
                    CategoryId = 7
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Sea Products",
                    CategoryId = 8
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Breakfasts",
                    CategoryId = 9
                });

                context.Categories.Add(new Category()
                {
                    CategoryName = "Beverages",
                    CategoryId = 10
                });
                context.Categories.Add(new Category()
                {
                    CategoryName = "Salads-Appetizers",
                    CategoryId = 11
                });

            }
            if (!context.Foods.Any())
            {
                context.Foods.Add(new Food()
                {
                    FoodName = "Lentil Soup",
                    Calorie = 55.9m,
                    Porsion = Porsions.gram,
                    Amount = 100.0m,
                    CategoryId = 1,
                    ImagePath = "https://im.haberturk.com/2020/10/27/ver1603801237/2849815_810x458.jpg"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Iskender Kebab",
                    Calorie = 755,
                    Porsion = Porsions.gram,
                    Amount = 500.0m,
                    CategoryId = 2,
                    ImagePath = "https://i.lezzet.com.tr/images-xxlarge-recipe/ev-yapimi-iskender-33bd7089-fa36-4398-95f8-02c6463ea27c.jpg"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Green Beans",
                    Calorie = 31.3m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 3,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStMenUBoO4a74qtfbV_TtNd9TiYHs6GGMQFg&usqp=CAU"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Olive Pastry",
                    Calorie = 384m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 4,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9cU-MBuXHvc52RvViBIDdxUWBhNTxvV2_9g&usqp=CAU"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Bulgur Pilaf",
                    Calorie = 114m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 5,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbB__RXAnjMPenJOXQDD21u-sSuO9yNFSgYQ&usqp=CAU"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Fettucini Alfredo",
                    Calorie = 312m,
                    Porsion = Porsions.gram,
                    Amount = 150m,
                    CategoryId = 6,
                    ImagePath = "https://cdn.yemek.com/mnresize/940/940/uploads/2014/09/fettucini-alfredo-yemekcom.jpg"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Pistachio Baklava",
                    Calorie = 329m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 7,
                    ImagePath = "https://haciismailoglu.com.tr/wp-content/uploads/2020/09/fistiklibaklava-1.jpg"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Baked Salmon",
                    Calorie = 171m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 8,
                    ImagePath = "https://www.jessicagavin.com/wp-content/uploads/2019/01/baked-salmon-8-1200.jpg"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Egg",
                    Calorie = 155.1m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 9,
                    ImagePath = "https://food.unl.edu/newsletters/images/hard-cooked-eggs_0.jpg"
                });
                context.Foods.Add(new Food()
                {
                    FoodName = "Coca-Cola",
                    Calorie = 38m,
                    Porsion = Porsions.millilitre,
                    Amount = 100m,
                    CategoryId = 10,
                    ImagePath = "https://www.gulyurt.com.tr/yuklemeler/2021/01/60ba5836e4754_coca-cola330.jpg"
                });

                context.Foods.Add(new Food()
                {
                    FoodName = "Caesar Salad",
                    Calorie = 65m,
                    Porsion = Porsions.gram,
                    Amount = 100m,
                    CategoryId = 11,
                    ImagePath = "https://ykv.s3.eu-central-1.amazonaws.com/img/tarif/mgt/tavuklu-sezar-salata.jpg"
                });
            }
        }
    }
}
