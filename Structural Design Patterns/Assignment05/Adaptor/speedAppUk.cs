using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Adaptor
{
    public class speedAppUk : speedAdaptor
    {
        private Speed _speedapp;
        public speedAppUk(Speed speedapp)
        {
            _speedapp= speedapp;
        }

        public Double getSpeed()
        {
            return conbertToKm(_speedapp.getSpeed());
        }

        public Double conbertToKm(double speed)
        {
            return speed * 1.60;
        }
    }
}
