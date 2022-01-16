using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori.Models
{
    public class User
    {
        public User()
        {
            Meals = new List<Meal>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal  Weight { get; set; }
        public decimal Height { get; set; }
        public Gender  Gender { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }



    }
    public enum Gender
    {
        Female,
        Male,
        Unspecified
    }
}
