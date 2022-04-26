using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterHandsOn;

namespace AdapterHandsOnClient
{
    public class MovableAdapterImpl:MovableAdapter
    {
        Movable luxuryCars;
        public MovableAdapterImpl(Movable m)
        {
            luxuryCars = m;
        }
        public double GetSpeed()
        {
            return convertMPHtoKMPH(luxuryCars.GetSpeed());
        }

        public double convertMPHtoKMPH(double speed)
        {
            return speed * 1.60934;
        }

        public double GetPrice()                                          //Newly added feature
        {
            return convertUSDtoEURO(luxuryCars.GetPrice());
        }

        public double convertUSDtoEURO(double price)                      //Newly added feature
        {
            return price * 0.8818;
        }
    }
}
