using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AppObserver : IObserver
    {
        private ZitatDesTages zitatInstanz;

        public AppObserver(ZitatDesTages zitat)
        {
            zitatInstanz = zitat;
        }

        public void Update()
        { 
            Console.WriteLine("---------AppObserver---------");
            Console.WriteLine("Nettes Zitat: \"" + zitatInstanz.GetZitat() + "\"");
            Console.WriteLine();
        }
    }
}
