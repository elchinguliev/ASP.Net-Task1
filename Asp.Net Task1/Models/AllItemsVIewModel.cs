using Asp.Net_Task1.Entities;

namespace Asp.Net_Task1.Models
{
    public class AllItemsVIewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public IEnumerable<HoteMeal> HotMeals { get; set; }
        public IEnumerable<Fastfood> FastFoods { get; set; }
    }
}
