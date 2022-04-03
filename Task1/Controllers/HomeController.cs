using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task1.Entities;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Drinks()
        {
            List<Food> foods = new List<Food>()
            {
                new Food(){FoodName = "Fresh Velvet", Price = 15.5, URL="freshVelvet.jpg"},
                new Food(){FoodName = "Molten Bomb", Price = 7.3, URL="moltenBomb.jpg"},
                new Food(){FoodName = "Sake Five", Price = 6.1, URL="sakeFive.jpg"},
                new Food(){FoodName = "Stale Slammer", Price = 9.9, URL="staleSlammer.png"},
                new Food(){FoodName = "Spiced Light", Price = 78.4, URL="spicedLight.jpg"},
                new Food(){FoodName = "Molten Bomb", Price = 14.7, URL="moltenBomb.jpg"},
            };
            return View(foods);
        }
        public IActionResult HotMeal()
        {
            List<Food> foods = new List<Food>()
            {
                new Food(){FoodName = "Split Pea Soup", Price = 15.5, URL="splitPeaSoup.jpg"},
                new Food(){FoodName = "Pineapple Chicken", Price = 7.3, URL="pineappleChicken.jpg"},
                new Food(){FoodName = "Lemony Chicken & Orzo Soup", Price = 6.1, URL="lemonyChicken.png"},
                new Food(){FoodName = "Lemony Asparagus Pasta", Price = 9.9, URL="lemonyAsparagusPasta.jpg"},
                new Food(){FoodName = "Garlicky Shrimp Zucchini Boats", Price = 78.4, URL="garlickyShrimpZucchiniBoats.jpg"}
            };
            return View(foods);
        }
        public IActionResult fastFood()
        {
            List<Food> foods = new List<Food>()
            {
                new Food(){FoodName = "VegaFast", Price = 15.5, URL="vegaFast.jpg"},
                new Food(){FoodName = "burganic", Price = 7.3, URL="burganic.jpg"},
                new Food(){FoodName = "tortilicious", Price = 6.1, URL="tortilicious.jpg"},
                new Food(){FoodName = "Pancake World", Price = 9.9, URL="pancakeWorld.jpg"},
                new Food(){FoodName = "Sweet Munchies", Price = 78.4, URL="sweetMunchies.jpg"}
            };
            return View(foods);
        }
    }
}