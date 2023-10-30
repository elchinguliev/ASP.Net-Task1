using Asp.Net_Task1.Entities;
using Asp.Net_Task1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace Asp.Net_Task1.Controllers
{
    public class HomeController : Controller
    {

        List<Drink> drinks = new List<Drink>
        {
                new Drink
                {
                    DrinkId= 1,
                    DrinkName = "Badamli",
                    DrinkPrice=1
                    
                },
                new Drink
                {
                    DrinkId= 2,
                    DrinkName = "Cola",
                    DrinkPrice=2
                },
                new Drink
                {
                    DrinkId= 3,
                    DrinkName = "Jack Daniels",
                    DrinkPrice=53
                },

        };


        List<HoteMeal> hotMeals = new List<HoteMeal>
        {
                new HoteMeal
                {
                    HotMealId= 1,
                    HotMealName = "Fajitas",
                    HotMealPrice=9
                
                },
                new HoteMeal
                {
                    HotMealId= 2,
                    HotMealName = "Beef",
                    HotMealPrice=14

                },
                new HoteMeal
                {
                    HotMealId= 3,
                    HotMealName = "Chicken",
                    HotMealPrice=6

                },
        };


        List<Fastfood> fastFoods = new List<Fastfood>
        {
            new Fastfood
            {
                FastFoodId= 1,
                FastFoodName = "Pizza",
                FastFoodPrice=9
               
            },

            new Fastfood
            {
                FastFoodId= 2,
                FastFoodName = "Hamburger",
                FastFoodPrice=4
            },
            new Fastfood
            {
                FastFoodId= 3,
                FastFoodName = "Cizburger",
                FastFoodPrice=5
            }
        };

        public IActionResult Index()
        {
            dynamic allitemsVIewModel = new AllItemsVIewModel();
            allitemsVIewModel.Drinks = GetDrinks();
            allitemsVIewModel.HotMeals = GetHotMeals();
            allitemsVIewModel.FastFoods = GetFastFoods();
            return View(allitemsVIewModel);
        }

        public List<Fastfood> GetFastFoods()
        {
            return fastFoods;
        }
        public IActionResult FastFoods(int id = -1)
        {
            if (id == -1)
            {
                return View(GetFastFoods());
            }
            else
            {
                List<Fastfood> list = new List<Fastfood>();
                var data = GetFastFoods().FirstOrDefault(d => d.FastFoodId == id);
                list.Add(data);
                return View(list);
            }
        }



        public List<HoteMeal> GetHotMeals()
        {
            return hotMeals;
        }

        public IActionResult HotMeals(int id = -1)
        {
            if (id == -1)
            {
                return View(GetHotMeals());
            }
            else
            {
                List<HoteMeal> list = new List<HoteMeal>();
                var data = GetHotMeals().FirstOrDefault(d => d.HotMealId == id);
                list.Add(data);
                return View(list);
            }
        }

        public List<Drink> GetDrinks()
        {
            return drinks;
        }
        public IActionResult Drinks(int id = -1)
        {
            if (id == -1)
            {
                return View(GetDrinks());
            }
            else
            {
                List<Drink> list = new List<Drink>();
                var data = GetDrinks().FirstOrDefault(d => d.DrinkId == id);
                list.Add(data);
                return View(list);
            }
        }

    }
}