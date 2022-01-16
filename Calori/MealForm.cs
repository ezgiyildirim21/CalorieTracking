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
    public partial class MealForm : Form
    {
        private readonly AppDbContext db;
        private readonly User user;
        private readonly Meal meal;

        public MealForm(AppDbContext db, User user, Meal meal)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;
            this.meal = meal;
            LoadData();
            LoadFoods();
        }

        private void LoadFoods()
        {
            if (meal.Foods.Count >= 0)
            {
                dgvFoods.DataSource = meal.Foods.Select(x => new
                {
                    Name = x.FoodName,
                    Porsion = x.Porsion,
                    Calorie = x.Calorie,
                    totalCalorie = x.Calorie * x.Amount
                }).ToList();
            }

        }

        private void LoadData()
        {
            cboCategory.Items.Clear();
            cboFoodName.Items.Clear();
            cboAddPorsion.Items.Clear();
            cboAddCategory.Items.Clear();

            cboCategory.DataSource = db.Categories.ToList();
            cboCategory.DisplayMember = "CategoryName";

            cboAddPorsion.DataSource = Enum.GetValues(typeof(Porsions));

            cboAddCategory.DataSource = db.Categories.ToList();
            cboAddCategory.DisplayMember = "CategoryName";

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)cboCategory.SelectedItem;
            cboFoodName.DisplayMember = "FoodName";
            List<Food> foods = db.Foods.Where(x => x.CategoryId == selectedCategory.CategoryId).ToList();
            List<Food> selectedFood = new List<Food>();

            for (int i = 0; i < foods.Count; i++)
            {
                if (!selectedFood.Any(x => x.FoodName == foods[i].FoodName))
                {
                    selectedFood.Add(foods[i]);
                }
            }
            cboFoodName.DataSource = selectedFood;
        }
        private void cboFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Food addFood = cboFoodName.SelectedItem as Food;
            lblPorsion.Text = $"{addFood.Porsion}";
           pboFoodImage.ImageLocation = addFood.ImagePath;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal amount = nudPorsion.Value;
            Food addFood = (Food)cboFoodName.SelectedItem;
            Food food = new Food();
            food.FoodName = addFood.FoodName;
            food.Porsion = addFood.Porsion;
            food.Calorie = addFood.Calorie;
            food.ImagePath = addFood.ImagePath;
            food.Category = addFood.Category;
            if (amount == 0) return;
            else
            {
                food.Amount = amount;
            }
            meal.TotalMealCalories += food.Calorie * food.Amount;
            meal.Foods.Add(food);
            db.SaveChanges();
            LoadFoods();
        }


        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            Food newFood = new Food();
            decimal amount = nudAddAmount.Value;
            decimal calorie = nudAddCalorie.Value;
            newFood.FoodName = txtAddFoodName.Text;
            if (calorie == 0) return;
            else
            {
                newFood.Calorie = calorie;
            }
            newFood.ImagePath = txtAddImgePath.Text;
            newFood.Porsion = (Porsions)cboAddPorsion.SelectedItem;
            if (amount == 0) return;
            else
            {
                newFood.Amount = amount;
            }
            newFood.Category = (Category)cboAddCategory.SelectedItem;
            // MessageBox.Show(cboAddPorsion.SelectedItem.GetType().ToString());
            db.Foods.Add(newFood);
            meal.Foods.Add(newFood);
            MessageBox.Show("The food has been successfully added.");
            db.SaveChanges();
        }

        private void dgvFoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string deletedFoodName = dgvFoods.SelectedRows[0].Cells[0].Value.ToString();
                Food deletedFood = meal.Foods.FirstOrDefault(x => x.FoodName == deletedFoodName);
                DialogResult dr = MessageBox.Show($"Are you sure you wanted to delete {deletedFoodName}?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    meal.Foods.Remove(deletedFood);
                meal.TotalMealCalories -= deletedFood.Calorie;
                db.SaveChanges();
            }
            LoadFoods();
        }
    }
}
