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
            //while (loopMainMenu)
            {
                Console.WriteLine(
                    "Huvudmeny:" +
                    "\nVälj typ av konvertering" +
                    "\n------------------------------" +
                    "\n 1. Längd" +
                    "\n 2. Temperatur" +
                    "\n 3. Vikt" +
                    "\n------------------------------");

                var userInput = Console.ReadLine();
                switch (userInput)
                {

                    case "1":
                        {
                            SubMenuLength();
                        }
                        break;
                }
            }
        }

        static void SubMenuLength()
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
                        calcMiles();
                    }
                    break;

                case "2":
                    {
                        calcYards();

                    }
                    break;
                case "3":
                    {
                        //calcFoots();
                    }
                    break;
                case "4":
                    {
                        //calcInches();
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

        static void calcMiles()
        {
            Console.WriteLine("Räkna ut miles");
        }

        static void calcYards()
        {
            Console.WriteLine("Konvertering mellan yards och meter");
            Console.Write("Ange längd:");
            double calcYardsInputValue = 0;
            bool calcYardsParse = false;
            bool calcYardsLoop = true;
            double yardToMeter = 0.9144;
            double MeterToYard = 1.094;
                while (calcYardsLoop)
            {
                calcYardsParse = double.TryParse(Console.ReadLine(), out calcYardsInputValue);
                if (calcYardsParse == false || calcYardsInputValue == 0 || calcYardsInputValue < 0)
                {
                    Console.WriteLine("Vänligen kontrollera inmatat värde, kan endast vara positiva tal.");
                }
                else
                {
                    calcYardsLoop = false;
                }

                Console.WriteLine($"{calcYardsInputValue} yards är {calcYardsInputValue*yardToMeter} meter" +
                    $"\n{calcYardsInputValue} meter är {calcYardsInputValue*MeterToYard} yards");

            }
            
            
        }

    }
}