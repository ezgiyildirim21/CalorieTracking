using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori.Models
{
    public class Food
    {
        public Food()
        {
            Meals = new List<Meal>();
        }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal Calorie { get; set; }
        public string ImagePath { get; set; }
        public Porsions Porsion { get; set; }
        public decimal Amount { get; set; }

        public int? CategoryId  { get; set; }
        public virtual Category Category { get; set; } 
        
        public virtual ICollection<Meal> Meals { get; set; } 

    }
    public enum Porsions
    {
        piece,
        gram,
        slice,
        millilitre
    }
}
