using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.FactoryMethod
{
    internal class IceCream : Recipe
    {
        public override void AddIngredients()
        {
            {
                Ingredients.Add(new MilkProduct());
                Ingredients.Add(new Flavour());
                Ingredients.Add(new ChoclateChip());

            }

        }
    }
}
