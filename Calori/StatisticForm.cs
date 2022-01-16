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
    public partial class StatisticForm : Form
    {
        private readonly AppDbContext db;
        private readonly User user;

        public StatisticForm(AppDbContext db, User user)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            GetDailyReport();
            GetMeals();
        }
        private void GetDailyReport()
        {
            decimal breakfastTotalCalorie = 0, lunchTotalCalorie = 0, snackTotalCalorie = 0, dinnerTotalCalorie = 0;

            Meal breakfast = user.Meals.FirstOrDefault(x => x.MealName == MealType.Breakfast && x.MealDate.Date == DateTime.Now.Date);
            if (breakfast != null)
            {
                breakfastTotalCalorie = breakfast.Foods.Sum(x => x.Calorie * x.Amount);
                lblBreakfast.Text = $"{breakfastTotalCalorie} kcal";
            }

            Meal lunch = user.Meals.FirstOrDefault(x => x.MealName == MealType.Lunch && x.MealDate.Date == DateTime.Now.Date);
            if (lunch != null)
            {
                lunchTotalCalorie = lunch.Foods.Sum(x => x.Calorie * x.Amount);
                lblLunch.Text = $"{lunchTotalCalorie} kcal";
            }

            Meal snack = user.Meals.FirstOrDefault(x => x.MealName == MealType.Snack && x.MealDate.Date == DateTime.Now.Date);
            if (snack != null)
            {
                snackTotalCalorie = snack.Foods.Sum(x => x.Calorie * x.Amount);
                lblSnack.Text = $"{snackTotalCalorie} kcal";
            }

            Meal dinner = user.Meals.FirstOrDefault(x => x.MealName == MealType.Dinner && x.MealDate.Date == DateTime.Now.Date);
            if (dinner != null)
            {
                dinnerTotalCalorie = dinner.Foods.Sum(x => x.Calorie * x.Amount);
                lblDinner.Text = $"{dinnerTotalCalorie} kcal";
            }

            decimal totalCalorie = breakfastTotalCalorie + lunchTotalCalorie + snackTotalCalorie + dinnerTotalCalorie;
            lblTotalCalories.Text = $"{totalCalorie} kcal";
        }
        private void GetMeals()
        {
            cboMeals.Items.Clear();
            cboMeals.DataSource = Enum.GetNames(typeof(MealType)).ToArray();
        }

        private void cboMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> foods = new List<Food>();
            List<Meal> meals = new List<Meal>();
            if (cboMeals.SelectedIndex == 0)
            {
                meals = db.Meals
                .Where(x => x.MealName == MealType.Breakfast)
                .ToList();
            }
            else if (cboMeals.SelectedIndex == 1)
            {
                meals = db.Meals
                .Where(x => x.MealName == MealType.Lunch)
                .ToList();
            }
            else if (cboMeals.SelectedIndex == 2)
            {
                meals = db.Meals
                .Where(x => x.MealName == MealType.Snack)
                .ToList();
            }
            else if (cboMeals.SelectedIndex == 3)
            {
                meals = db.Meals
                .Where(x => x.MealName == MealType.Dinner)
                .ToList();
            }
            foreach (var meal in meals)
            {
                foreach (var food in meal.Foods)
                {
                    foods.Add(food);
                }
            }

            var dataList = foods
                .GroupBy(x => x.FoodName).Select(z => new
                {
                    Name = z.Key,
                    Count = z.Sum(y => y.Amount)
                }).OrderByDescending(a => a.Count).ToList();
            dgvFoodMeal.DataSource = dataList;

        }

        private void rbWeekly_Click(object sender, EventArgs e)
        {
            DateTime dtWeekDate = DateTime.Now.AddDays(-7);
            GetWeekUserAverages(dtWeekDate);
            GetWeekTotalAverages(dtWeekDate);

        }

        private void GetWeekUserAverages(DateTime dtWeekDate)
        {
            List<Meal> bUserMeals = user.Meals
               .Where(x => x.MealName == MealType.Breakfast && x.MealDate.Date > dtWeekDate.Date).ToList();
            decimal bTotalCalorie = bUserMeals.Sum(x => x.TotalMealCalories);
            List<Meal> lUserMeals = user.Meals
                .Where(x => x.MealName == MealType.Lunch && x.MealDate.Date > dtWeekDate.Date).ToList();
            decimal lTotalCalorie = lUserMeals.Sum(x => x.TotalMealCalories);
            List<Meal> sUserMeals = user.Meals
                .Where(x => x.MealName == MealType.Snack && x.MealDate.Date > dtWeekDate.Date).ToList();
            decimal sTotalCalorie = sUserMeals.Sum(x => x.TotalMealCalories);
            List<Meal> dUserMeals = user.Meals
            .Where(x => x.MealName == MealType.Dinner && x.MealDate.Date > dtWeekDate.Date).ToList();
            decimal dTotalCalorie = dUserMeals.Sum(x => x.TotalMealCalories);

            lblBUser.Text = $"{bTotalCalorie} kcal";
            lblLUser.Text = $"{lTotalCalorie} kcal";
            lblSUser.Text = $"{sTotalCalorie} kcal";
            lblDUser.Text = $"{dTotalCalorie} kcal";
        }
        private void GetWeekTotalAverages(DateTime dtWeekDate)
        {
            List<Meal> bMeals = db.Meals
                .Where(x => x.MealName == MealType.Breakfast && DbFunctions.TruncateTime(x.MealDate) > dtWeekDate).ToList();
            decimal bTotalCalorie = bMeals.Sum(x => x.TotalMealCalories);
            List<Meal> lMeals = db.Meals
                .Where(x => x.MealName == MealType.Lunch && DbFunctions.TruncateTime(x.MealDate) > dtWeekDate).ToList();
            decimal lTotalCalorie = lMeals.Sum(x => x.TotalMealCalories);
            List<Meal> sMeals = db.Meals
                .Where(x => x.MealName == MealType.Snack && DbFunctions.TruncateTime(x.MealDate) > dtWeekDate).ToList();
            decimal sTotalCalorie = sMeals.Sum(x => x.TotalMealCalories);
            List<Meal> dMeals = db.Meals
            .Where(x => x.MealName == MealType.Dinner && DbFunctions.TruncateTime(x.MealDate) > dtWeekDate).ToList();
            decimal dTotalCalorie = dMeals.Sum(x => x.TotalMealCalories);

            lblBTotal.Text = $"{bTotalCalorie} kcal";
            lblLTotal.Text = $"{lTotalCalorie} kcal";
            lblSTotal.Text = $"{sTotalCalorie} kcal";
            lblDTotal.Text = $"{dTotalCalorie} kcal";
        }

        private void rbMonthly_Click(object sender, EventArgs e)
        {
            DateTime dtMonthDate = DateTime.Now.AddMonths(-1);
            GetMonthUserAverages(dtMonthDate);
            GetMonthTotalAverages(dtMonthDate);
        }

        private void GetMonthUserAverages(DateTime dtMonthDate)
        {
            List<Meal> bUserMeals = user.Meals
               .Where(x => x.MealName == MealType.Breakfast && x.MealDate.Date > dtMonthDate.Date).ToList();
            decimal bTotalCalorie = bUserMeals.Sum(x => x.TotalMealCalories);
            List<Meal> lUserMeals = user.Meals
                .Where(x => x.MealName == MealType.Lunch && x.MealDate.Date > dtMonthDate.Date).ToList();
            decimal lTotalCalorie = lUserMeals.Sum(x => x.TotalMealCalories);
            List<Meal> sUserMeals = user.Meals
                .Where(x => x.MealName == MealType.Snack && x.MealDate.Date > dtMonthDate.Date).ToList();
            decimal sTotalCalorie = sUserMeals.Sum(x => x.TotalMealCalories);
            List<Meal> dUserMeals = user.Meals
            .Where(x => x.MealName == MealType.Dinner && x.MealDate.Date > dtMonthDate.Date).ToList();
            decimal dTotalCalorie = dUserMeals.Sum(x => x.TotalMealCalories);

            lblBUser.Text = $"{bTotalCalorie} kcal";
            lblLUser.Text = $"{lTotalCalorie} kcal";
            lblSUser.Text = $"{sTotalCalorie} kcal";
            lblDUser.Text = $"{dTotalCalorie} kcal";
        }

        private void GetMonthTotalAverages(DateTime dtMonthDate)
        {
            List<Meal> bMeals = db.Meals
                .Where(x => x.MealName == MealType.Breakfast && DbFunctions.TruncateTime(x.MealDate) > dtMonthDate).ToList();
            decimal bTotalCalorie = bMeals.Sum(x => x.TotalMealCalories);
            List<Meal> lMeals = db.Meals
                .Where(x => x.MealName == MealType.Lunch && DbFunctions.TruncateTime(x.MealDate) > dtMonthDate).ToList();
            decimal lTotalCalorie = lMeals.Sum(x => x.TotalMealCalories);
            List<Meal> sMeals = db.Meals
                .Where(x => x.MealName == MealType.Snack && DbFunctions.TruncateTime(x.MealDate) > dtMonthDate).ToList();
            decimal sTotalCalorie = sMeals.Sum(x => x.TotalMealCalories);
            List<Meal> dMeals = db.Meals
            .Where(x => x.MealName == MealType.Dinner && DbFunctions.TruncateTime(x.MealDate) > dtMonthDate).ToList();
            decimal dTotalCalorie = dMeals.Sum(x => x.TotalMealCalories);

            lblBTotal.Text = $"{bTotalCalorie} kcal";
            lblLTotal.Text = $"{lTotalCalorie} kcal";
            lblSTotal.Text = $"{sTotalCalorie} kcal";
            lblDTotal.Text = $"{dTotalCalorie} kcal";
        }

    }
}
