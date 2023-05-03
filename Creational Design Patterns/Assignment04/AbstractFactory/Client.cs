using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.AbstractFactory
{
    public class Client
    {
        private Furniture furniture;
        private Bedding bed; 

        public Client(Store store)
        {
            furniture=store.CreateFurniture();
            bed = store.CreateBedding();
        }

        public void Compare()
        {
          furniture.compareSitting(bed);
        }

    }
}
