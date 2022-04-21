using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class LoggerObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("---------LoggerObserver---------");
            Console.WriteLine("Neues Zitat des Tages um " 
                + DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine();
        }
    }
}
