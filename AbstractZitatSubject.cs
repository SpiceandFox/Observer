using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class AbstractZitatSubject
    {

        private List<IObserver> observers = new List<IObserver>();

        protected void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void Register(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                Console.WriteLine("Observer bereits registriert");
            }
            else
            {
                observers.Add(observer);
                Console.WriteLine("Observer wurde registriert");
            }
        }

        public void Unregister(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
                Console.WriteLine("Observer wurde entfernt");
            }
            else
            {
                Console.WriteLine("Observer nicht registriert");
            }
        }
    }
}
