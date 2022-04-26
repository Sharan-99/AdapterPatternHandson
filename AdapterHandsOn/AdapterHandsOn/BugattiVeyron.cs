using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHandsOn
{
    public class BugattiVeyron:Movable
    {
        public double GetSpeed()
        {
            return 268;
        }
        public double GetPrice()                          //Newly added feature
        {
            return 105;
        }
    }
}
