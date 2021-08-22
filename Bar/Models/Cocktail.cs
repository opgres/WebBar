using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongDesc { get; set; }
        public string ShortDesc { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public Cocktail()
        {
            Ingredients = new List<Ingredient>();
        }


    }
}
