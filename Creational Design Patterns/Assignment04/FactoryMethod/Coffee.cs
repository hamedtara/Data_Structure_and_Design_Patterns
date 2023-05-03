using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.FactoryMethod
{
    public class Coffee : Recipe
    {
        public override void AddIngredients()
        {
            {
                Ingredients.Add(new Waterproduct());
                Ingredients.Add(new CoffeeProduct());
                Ingredients.Add(new SugarProduct());

            }

        }

    }
}
