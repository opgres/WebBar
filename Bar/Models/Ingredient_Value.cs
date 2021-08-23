using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models
{
    public class Ingredient_Value
    {

        public int Id { get; set; }
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public string Value { get; set; }
        public virtual List<Cocktail> Cocktails { get; set; }
        public Ingredient_Value()
        {
            Cocktails = new List<Cocktail>();
        }

    }
}
