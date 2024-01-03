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
                int mainMenuChoice = 0;
                bool menuChoiceParse = false;
                menuChoiceParse = int.TryParse(userInput, out mainMenuChoice);
                if (menuChoiceParse = false || mainMenuChoice == 0 || mainMenuChoice < 0 || mainMenuChoice > 4) {

                    Console.WriteLine("Du kan endast ange numeriska värden mellan 1-4");
                }
                switch (mainMenuChoice)
                {

                    case 1:
                        {
                            SubMenuLength();
                        }
                        break;

                    case 2:
                        {
                            SubMenuTemp();
                        }
                        break;
                    case 3:
                        {
                            SubMenuWeight();
                        }
                        break;

                    case 4:
                        {
                            loopMainMenu = false;
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Du kan endast välja ett tal mellan 1-4");
                        }
                        break;
                }
            }
        }

        internal static void SubMenuLength()
        {
            bool lengthMenuLoop = true;
            bool lengthMenuParse = false;
            string userInput = "";
            int menuChoice = 0;

            while (lengthMenuLoop)
            {
                Console.WriteLine("Konvertering av längd" +
                    "\n------------------------------" +
                    "\n1. Konvertering miles/kilometer" +
                    "\n2. Konvertering yard/meter" +
                    "\n3. Konvertering foot/decimeter" +
                    "\n4. Konvertering inches/centimeter" +
                    "\n5. Tillbaka till huvudmenyn" +
                    "\n------------------------------");


                userInput = Console.ReadLine();

                lengthMenuParse = int.TryParse(userInput, out menuChoice);

                if (lengthMenuParse = false || menuChoice == 0 || menuChoice < 0 || menuChoice > 5)
                {
                    Console.WriteLine("Felaktigt val ange en siffra mellan 1-5");
                }

                else
                {

                    switch (menuChoice)
                    {
                        case 1:
                            {
                                CalcLength.CalcMiles();
                            }
                            break;

                        case 2:
                            {
                                CalcLength.CalcYards();

                            }
                            break;
                        case 3:
                            {
                                CalcLength.CalcFoots();
                            }
                            break;
                        case 4:
                            {
                                CalcLength.CalcInches();
                            }
                            break;
                        case 5:
                            {
                                lengthMenuLoop = false;
                                break;
                            }
                            break;
                    }
                }
            }
        }
        internal static void SubMenuTemp()
        {
            CalcTemperature.CalcTemp();
        }

        internal static void SubMenuWeight()
        {
            bool weightMenuLoop = true;
            bool weightMenuParse = false;
            string userInput = "";
            int menuChoice = 0;

            while (weightMenuLoop)
            {
                Console.WriteLine("Konvertering av vikt" +
                    "\n------------------------------" +
                    "\n1. Konvertering pounds/kilo" +
                    "\n2. Konvertering ounces/gram" +
                    "\n3. Tillbaka till huvudmenyn" +
                    "\n------------------------------");


                userInput = Console.ReadLine();

                weightMenuLoop = int.TryParse(userInput, out menuChoice);

                if (weightMenuLoop = false || menuChoice == 0 || menuChoice < 0 || menuChoice > 3)
                {
                    Console.WriteLine("Felaktigt val ange en siffra mellan 1-3");
                }

                else
                {

                    switch (menuChoice)
                    {
                        case 1:
                            {
                                CalcWeights.CalcPound();
                            }
                            break;

                        case 2:
                            {
                                CalcWeights.CalcOunces();

                            }
                            break;

                        case 3:
                            {
                                MainMenu();
                            }
                            break;
                    }
                }
            }
        }
    }
}