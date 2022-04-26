using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterHandsOn;
namespace AdapterHandsOnClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Console.WriteLine("After converting from MPH to KMPH: "+bugattiVeyronAdapter.GetSpeed());
            Console.WriteLine("After converting from USD to EURO: " + bugattiVeyronAdapter.GetPrice());
            Console.ReadKey();

        }
    }
}
