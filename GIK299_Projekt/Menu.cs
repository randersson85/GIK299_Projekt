using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GIK299_Projekt
{

    internal static class Menu
    {
        internal static void MainMenu()
        {
            bool loopMainMenu = true;
            while (loopMainMenu)
            {
                Console.WriteLine(
                    "Huvudmeny:" +
                    "\nVälj typ av konvertering" +
                    "\n------------------------------" +
                    "\n 1. Längd" +
                    "\n 2. Temperatur" +
                    "\n 3. Vikt" +
                    "\n 4. Avsluta programmet" +
                    "\n------------------------------");

                var userInput = Console.ReadLine();
                switch (userInput)
                {

                    case "1":
                        {
                            SubMenuLength();
                        }
                        break;

                    case "2":
                        {
                            SubMenuTemp();
                        }
                        break;
                    case "3":
                        {
                            //SubMenuWeight();
                        }
                        break;

                        case "4":
                        {
                            loopMainMenu = false;
                        }break;

                    default:
                        {
                            Console.WriteLine("Du kan endast välja ett tal mellan 1-4");
                        }break;
                }
            }
        }

        internal static void SubMenuLength()
        {
            Console.WriteLine("Konvertering av längd" +
                "\n------------------------------" +
                "\n1. Konvertering miles/kilometer" +
                "\n2. Konvertering yard/meter" +
                "\n3. Konvertering foot/centimeter" +
                "\n4. Konvertering inches/centimeter" +
                "\n5. Tillbaka till huvudmenyn" +
                "\n------------------------------");

            var subMenuLengthUserInput = Console.ReadLine();
            switch (subMenuLengthUserInput)
            {
                case "1":
                    {
                        CalcLength.CalcMiles();
                    }
                    break;

                case "2":
                    {
                        CalcLength.CalcYards();

                    }
                    break;
                case "3":
                    {
                        CalcLength.CalcFoots();
                    }
                    break;
                case "4":
                    {
                        CalcLength.CalcInches();
                    }
                    break;
                case "5":
                    {
                        MainMenu();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Felaktigt val ange en siffra mellan 1-5");
                    }
                    break;
            }
        }
        internal static void SubMenuTemp()
        {
            CalcTemperature.CalcTemp();
        }
    }
}