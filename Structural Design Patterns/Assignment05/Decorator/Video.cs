using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Decorator
{
    public class Video : Player
    {
        public void play()
        {
            Console.WriteLine("Play a video ");
        }
      
    }
}
