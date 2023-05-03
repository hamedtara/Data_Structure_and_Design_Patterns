using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Decorator
{
    public class BaseEnhancer : PlayerEnhancer
    {
        public int HeightBoss { get; set; }

        public BaseEnhancer(Player player) : base(player)
        {
        }

        public override void play()
        {
            base.play();
            Console.WriteLine("Changing the voice to Dolby");
            Console.WriteLine($"Adjust height Base to {HeightBoss} ");
        }
    }

}
