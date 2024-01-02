using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Projekt
{

    internal static class CalcLength
    {
        internal static void CalcMiles()
        {
            string userInput = "";
            double calcMilesInputValue = 0;
            bool calcMilesParse = false;
            bool calcMilesLoop = true;
            double milesToKilometers = 1.609;
            double kilometersToMiles = 0.6214;

            while (calcMilesLoop)
            {
                Console.WriteLine("Konvertering mellan Miles och kilometer, skriv X för att avsluta");
                Console.Write("Ange längd: ");

                userInput = Console.ReadLine();
                if (userInput.ToUpper() == "X")
                {
                    Menu.SubMenuLength();
                }

                else
                {
                    calcMilesParse = double.TryParse(userInput, out calcMilesInputValue);
                    if (calcMilesParse == false) 
                    {
                        Console.WriteLine("Det går endast att ange numeriska värden.");
                    }
                    else
                    {
                        Console.WriteLine($"\n" +
                            $"Konvertering mellan Miles och kilometer \n" +
                            $"{calcMilesInputValue} Miles är {String.Format("{0:0.##}", calcMilesInputValue * milesToKilometers)} Kilometer \n" +
                            $"{calcMilesInputValue} Kilometer är {String.Format("{0:0.##}", calcMilesInputValue * kilometersToMiles)} Miles \n" +
                            $"");
                    }
                }

                //calcMilesParse = double.TryParse(Console.ReadLine(), out calcMilesInputValue);
                //if (calcMilesParse == false)
                //{
                //    Console.WriteLine("Det går endast att ange numeriska värden");
                //}
                //else
                //{
                //    calcMilesLoop = false;
                //}

                //Console.WriteLine($"{calcMilesInputValue} miles är {calcMilesInputValue * milesToKilometers} kilometer" +
                //    $"\n{calcMilesInputValue} kilometer är {calcMilesInputValue * kilometersToMiles} miles");
                //Menu.SubMenuLength();
            }
        }

        internal static void CalcYards()
        {
            Console.WriteLine("Konvertering mellan yards och meter");
            Console.Write("Ange längd: ");
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

                Console.WriteLine($"{calcYardsInputValue} yards är {calcYardsInputValue * yardToMeter} meter" +
                    $"\n{calcYardsInputValue} meter är {calcYardsInputValue * MeterToYard} yards");
                Menu.SubMenuLength();

            }
        }

        internal static void CalcFoots()
        {
            Console.WriteLine("Konvertering mellan foot och decimeter");
            Console.Write("Ange längd: ");
            double calcFootInputValue = 0;
            bool calcFootParse = false;
            bool calcFootLoop = true;
            double footToDecimeter = 3.048;
            double decimeterToFoot = 0.3281;
            while (calcFootLoop)
            {
                calcFootParse = double.TryParse(Console.ReadLine(), out calcFootInputValue);
                if (calcFootParse == false || calcFootInputValue == 0 || calcFootInputValue < 0)
                {
                    Console.WriteLine("Vänligen kontrollera inmatat värde, kan endast vara positiva tal.");
                }
                else
                {
                    calcFootLoop = false;
                }

                Console.WriteLine($"{calcFootInputValue} foot är {calcFootInputValue * footToDecimeter} decimeter" +
                    $"\n{calcFootInputValue} decimetermeter är {calcFootInputValue * decimeterToFoot} foot");
                Menu.SubMenuLength();

            }
        }

        internal static void CalcInches()
        {
            Console.WriteLine("Konvertering mellan inches och centimeter");
            Console.Write("Ange längd: ");
            double calcInchInputValue = 0;
            bool calcInchParse = false;
            bool calcInchLoop = true;
            double inchToCentimeter = 2.540;
            double centimeterToInch = 0.3937;
            while (calcInchLoop)
            {
                calcInchParse = double.TryParse(Console.ReadLine(), out calcInchInputValue);
                if (calcInchParse == false || calcInchInputValue == 0 || calcInchInputValue < 0)
                {
                    Console.WriteLine("Vänligen kontrollera inmatat värde, kan endast vara positiva tal.");
                }
                else
                {
                    calcInchLoop = false;
                }

                Console.WriteLine($"{calcInchInputValue} yards är {calcInchInputValue * inchToCentimeter} meter" +
                    $"\n{calcInchInputValue} meter är {calcInchInputValue * centimeterToInch} yards");
                Menu.SubMenuLength();

            }
        }
    }
}
