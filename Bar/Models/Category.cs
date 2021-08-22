using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Cocktail> Cocktails { get; set; }
    }
}
