using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.FactoryMethod
{
    // https://www.youtube.com/watch?v=EcFVTgRHJLM
    public abstract class Recipe
    {
        public Recipe() {
            this.AddIngredients();
        }

        private List<Ingredients> _ingredients = new List<Ingredients>();
        public List<Ingredients> Ingredients { get { return _ingredients; } }



        //Factory Method
        public abstract void AddIngredients();

    }
}
