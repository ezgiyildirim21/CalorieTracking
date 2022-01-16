using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori.Models
{
    public class Meal
    {
        public Meal()
        {
            Foods=new List<Food>();
            Users=new List<User>();
        }
        public int MealId { get; set; }
        public MealType MealName { get; set; }
        public DateTime MealDate { get; set; } = DateTime.Now;

        public decimal TotalMealCalories { get; set; }
        public virtual List<Food> Foods { get; set; }
        public virtual ICollection<User> Users { get; set; }



        
        //TODO Kalori metodu eklenicek 

    }
    public enum MealType
    {
        Breakfast,
        Lunch,
        Snack,
        Dinner

    }

}
    
