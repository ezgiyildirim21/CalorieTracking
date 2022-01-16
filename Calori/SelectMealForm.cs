using Calori.Data;
using Calori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calori
{
    public partial class SelectMealForm : Form
    {
        private readonly AppDbContext db;
        private readonly User user;
        Meal meal;

        public SelectMealForm(AppDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            LoadMeals();
        }

        private void LoadMeals()
        {
            cboSelectMeal.Items.Clear();
            cboSelectMeal.DataSource = Enum.GetNames(typeof(MealType)).ToArray();
        }

        private void btnSelectAdd_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now.Date;

            if (cboSelectMeal.SelectedIndex == 0)   // Breakfast
            {
                meal = db.Meals.FirstOrDefault(x => x.MealName == MealType.Breakfast && DbFunctions.TruncateTime(x.MealDate) == dateTime && x.Users.Any(k => k.Id == user.Id));
                if (meal == null)
                {
                    meal = new Meal()
                    {
                        MealName = MealType.Breakfast,
                        MealDate = DateTime.Now 
                    };
                    user.Meals.Add(meal);
                }
                db.SaveChanges();
                MealForm mealForm = new MealForm(db, user,meal);
                mealForm.ShowDialog();
            }
            else if (cboSelectMeal.SelectedIndex == 1)
            {
                meal = db.Meals.FirstOrDefault(x => x.MealName == MealType.Lunch && DbFunctions.TruncateTime(x.MealDate) == dateTime && x.Users.Any(k => k.Id == user.Id));
                if (meal == null)
                {
                    meal = new Meal()
                    {
                        MealName = MealType.Lunch,
                        MealDate = DateTime.Now
                    };
                }
                db.SaveChanges();
                MealForm mealForm = new MealForm(db, user, meal);
                mealForm.ShowDialog();
            }
            else if (cboSelectMeal.SelectedIndex == 2)
            {
                meal = db.Meals.FirstOrDefault(x => x.MealName == MealType.Snack && DbFunctions.TruncateTime(x.MealDate) == dateTime && x.Users.Any(k => k.Id == user.Id));
                if (meal == null)
                {
                    meal = new Meal()
                    {
                        MealName = MealType.Snack,
                        MealDate = DateTime.Now
                    };
                }
                db.SaveChanges();
                MealForm mealForm = new MealForm(db, user, meal);
                mealForm.ShowDialog();
            }
            else if (cboSelectMeal.SelectedIndex == 3)
            {
                meal = db.Meals.FirstOrDefault(x => x.MealName == MealType.Dinner && DbFunctions.TruncateTime(x.MealDate) == dateTime && x.Users.Any(k => k.Id == user.Id));
                if (meal == null)
                {
                    meal = new Meal()
                    {
                        MealName = MealType.Dinner,
                        MealDate = DateTime.Now
                    };
                }
                db.SaveChanges();
                MealForm mealForm = new MealForm(db, user, meal);
                mealForm.ShowDialog();
            }
        }
    }
}
