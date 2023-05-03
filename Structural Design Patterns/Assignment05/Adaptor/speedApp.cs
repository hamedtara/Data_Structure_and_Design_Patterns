using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Adaptor
{
    public class speedApp : Speed
    {
        public int _speedInmilesPerhour;
        public speedApp(int speedInmilesPerhour) {
        
        _speedInmilesPerhour= speedInmilesPerhour;
        }

        public double getSpeed()
        {
            return _speedInmilesPerhour;
        }

    }
}
