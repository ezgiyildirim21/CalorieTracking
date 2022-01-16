using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori.Models
{
    public class Category
    {
        public Category()
        {
            Foods = new List<Food>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
