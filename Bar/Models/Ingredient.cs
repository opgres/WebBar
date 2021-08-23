using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Degrees { get; set; }

        public virtual List<Ingredient_Value> Ingredient_Values { get; set; }

    }
}
