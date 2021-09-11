using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models.ViewModels
{
    public class ViewAdmin
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Category> Categories { get; set; }
        public List<Ingredient_Value> Values { get; set; }


    }
}
