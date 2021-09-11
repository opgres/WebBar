using Bar.Models;
using Bar.Models.E;
using Bar.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Bar.Controllers
{
    public class AdminController : Controller
    {
        private  AppDbContext db;

       
        public AdminController(AppDbContext context)
        {
            db = context;
        }
        [HttpGet]
        public ViewResult WorkwithDb()
        {
            
            ViewBag.Ingredients = db.Ingredients.ToList();
            ViewBag.Categories = new SelectList(db.Categories, "Id", "Name");
            ViewBag.IngredientValue = db.Ingredient_Values.ToList();
            return View();
        }      

        [HttpPost]//дает возможность получить информацию и в дальнейшем ее обработать
        public ActionResult WorkwithDb(Cocktail cocktail, int[] selectedValues)
        {
            foreach (var c in db.Ingredient_Values.Where(co => selectedValues.Contains(co.Id)))
            {
                cocktail.Ingredient_Values.Add(c);
            }
            db.Cocktails.Add(cocktail);
            db.SaveChanges();
            
            return Redirect("WorkwithDb");
        }
        public ActionResult _AddIngr(Ingredient ingredient)
        {
            db.Ingredients.Add(ingredient);
            db.SaveChanges();
            return Redirect("WorkwithDb");
        }
        public ActionResult _AddIngr_Value(Ingredient_Value ingredient_v)
        {
            db.Ingredient_Values.Add(ingredient_v);
            db.SaveChanges();
            return Redirect("WorkwithDb");
        }
        public ActionResult _AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return Redirect("WorkwithDb");
        }
      
    }
}
