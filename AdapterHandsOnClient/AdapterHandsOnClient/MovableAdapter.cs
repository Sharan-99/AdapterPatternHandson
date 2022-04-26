using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterHandsOn;

namespace AdapterHandsOnClient
{
    public interface MovableAdapter
    {
        double GetSpeed();
        double GetPrice();                                  //Newly added feature
    }
}
