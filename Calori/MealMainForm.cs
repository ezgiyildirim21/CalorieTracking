using Calori.Data;
using Calori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calori
{
    public partial class MealMainForm : Form
    {
        private readonly AppDbContext db;
        private readonly User user;

        public MealMainForm(AppDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            SelectMealForm selectMealForm = new SelectMealForm(db, user);
            selectMealForm.ShowDialog();
            UpdateFoods();
        }

        private void UpdateFoods()
        { 
            if (mcMealDate.SelectionRange.Start < DateTime.Now)
            {
                dgvMeals.Rows.Clear();
                if (user.Meals.Count > 0)
                {
                    List<Meal> totalMeal = user.Meals
                        .Where(x => x.MealDate.Date == mcMealDate.SelectionRange.Start)
                        .ToList();

                    Dictionary<Meal, List<Food>> mealFoodList = new Dictionary<Meal, List<Food>>();
                    foreach (var meal in totalMeal)
                    {
                        mealFoodList.Add(meal, meal.Foods);
                    }
                    dgvMeals.Columns[dgvMeals.Columns.Count - 1].Visible = false;
                    foreach (var meal in mealFoodList)
                    {
                        foreach (var food in meal.Value)
                        {
                            dgvMeals.Rows
                                .Add(food.FoodName, food.Calorie, food.Amount, food.Porsion, meal.Key.MealName, food.FoodId);
                        }
                    }
                }
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm(db, user);
            statisticForm.ShowDialog();
        }

        private void mcMealDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateFoods();
        }
    }
}
