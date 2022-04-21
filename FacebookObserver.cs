using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class FacebookObserver : IObserver
    {
        private ZitatDesTages zitatInstanz;

        public FacebookObserver(ZitatDesTages zitat) 
        {
            zitatInstanz = zitat;
        }

        public void Update()
        {
            Console.WriteLine("---------FacebookObserver---------");
            Console.WriteLine("Neuer Post wird erstellt: \"" 
                + zitatInstanz.GetZitat() + "\"");
            Console.WriteLine();

            //Auskommentieren um eine Nachrichtenkaskade zu simulieren
            //zitatInstanz.SetZitat("Kaskade");
        }
    }
}
