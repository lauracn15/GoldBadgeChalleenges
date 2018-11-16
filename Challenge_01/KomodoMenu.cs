using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    class KomodoMenu
    {
        public string Name { get; set; }
        public int FoodNumber { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public KomodoMenu(string name, int foodNumber, string ingredients, string description, decimal price)
        {
            Name = name;
            FoodNumber = foodNumber;
            Ingredients = ingredients;
            Description = description;
            Price = price;
        }
        public KomodoMenu()
        {

        }

    }
}
