using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IObserver> observers = new List<IObserver>();
            ZitatDesTages zitat = new ZitatDesTages();

            observers.Add(new AppObserver(zitat));
            observers.Add(new AppObserver(zitat));
            observers.Add(new AppObserver(zitat));
            observers.Add(new LoggerObserver());
            observers.Add(new FacebookObserver(zitat));

            foreach (var observer in observers)
            {
                zitat.Register(observer);
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Was wollen Sie machen?");
                Console.WriteLine("n = neues Zitat");
                Console.WriteLine("s = Zitat anzeigen");
                Console.WriteLine("o = Liste der Observer anzeigen");
                Console.WriteLine("a = neuer App Observer");
                Console.WriteLine("l = neuer Logger Observer");
                Console.WriteLine("f = neuer Facebook Observer");
                Console.WriteLine("e = Programm verlassen");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                switch (Console.ReadLine())
                {
                    case "n":
                        Console.WriteLine("Bitte geben Sie das Zitat ein: ");
                        zitat.SetZitat(Console.ReadLine());
                        break;
                    case "s":
                        Console.WriteLine(zitat.GetZitat());
                        break;
                    case "o":
                        bool continueLoop;
                        do
                        {
                            continueLoop = true;
                            for (int i = 0; i < observers.Count; i++)
                            {
                                Console.WriteLine(i + " : " + observers[i].ToString());
                            }
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("Was wollen Sie machen?");
                            Console.WriteLine("ir = Observer an der Stelle i registrieren");
                            Console.WriteLine("iu = Observer an der Stelle i entfernen");
                            Console.WriteLine("e  = Zurück zum Hauptmenü");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine();
                            string userInput = Console.ReadLine();
                            if (userInput == "e")
                            {
                                continueLoop = false;
                                break;
                            }
                            else if (Char.IsDigit(userInput, 0) && userInput.Length > 1)
                            {
                                if (userInput[1] == 'r')
                                {
                                    zitat.Register(observers[Int32.Parse(userInput[0].ToString())]);
                                }
                                else if (userInput[1] == 'u')
                                {
                                    zitat.Unregister(observers[Int32.Parse(userInput[0].ToString())]);
                                }
                                else Console.WriteLine("inkorrekte Eingabe");
                            }
                            else Console.WriteLine("inkorrekte Eingabe");
                        } while (continueLoop);
                        break;
                    case "a":
                        observers.Add(new LoggerObserver());
                        break;
                    case "l":
                        observers.Add(new LoggerObserver());
                        break;
                    case "f":
                        observers.Add(new FacebookObserver(zitat));
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("inkorrekte Eingabe");
                        break;
                }
            }
        }
    }
}
