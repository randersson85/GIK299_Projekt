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
            }
        }

        internal static void CalcYards()
        {
            string userInput = "";
            double calcYardsInputValue = 0;
            bool calcYardsParse = false;
            bool calcYardsLoop = true;
            double yardToMeter = 0.9144;
            double MeterToYard = 1.094;



            while (calcYardsLoop)
            {
                Console.WriteLine("Konvertering mellan yards och meter tryck x för att avsluta");
                Console.Write("Ange längd: ");

                userInput = Console.ReadLine();
                if (userInput.ToUpper() == "X")
                {
                    Menu.SubMenuLength();
                }
                else
                {
                    calcYardsParse = double.TryParse(userInput, out calcYardsInputValue);
                }
                if (calcYardsParse == false)
                {
                    Console.WriteLine("Det går endast att ange numeriska värden.");
                }
                else
                {
                    Console.WriteLine($"\nKonvertering mellan Yards och Meter \n" +
                        $"{calcYardsInputValue} Yards är: {String.Format("{0:0.##}", calcYardsInputValue * yardToMeter)} Meter" +
                        $"{calcYardsInputValue} Meter är {String.Format("{0:0.##}", calcYardsInputValue * MeterToYard)} Yards");

                }
            }
        }

        internal static void CalcFoots()
        {
            string userInput = "";
            double calcFootInputValue = 0;
            bool calcFootParse = false;
            bool calcFootLoop = true;
            double footToDecimeter = 3.048;
            double decimeterToFoot = 0.3281;
            while (calcFootLoop)
            {
                Console.WriteLine("Konvertering mellan foot och decimeter");
                Console.Write("Ange längd: ");
                userInput = Console.ReadLine();

                if (userInput.ToUpper() == "X") 
                {
                    Menu.SubMenuLength();
                }
                else
                {
                    calcFootParse = double.TryParse(userInput, out calcFootInputValue);
                    if (calcFootParse == false)
                    {
                        Console.WriteLine("Det går endast att ange numeriska värden");
                    }
                    else
                    {
                        Console.WriteLine($"\n" +
                            $"Konvertering mellan foot och decimeter \n" +
                            $"{calcFootInputValue} Foot är: {String.Format("{0:0.##}", calcFootInputValue * footToDecimeter)} Decimeter \n" +
                            $"{calcFootInputValue} Decimeter är: {String.Format("{0:0.##}", calcFootInputValue * decimeterToFoot)} Foot");
                            
                    }
                }
            }
        }

        internal static void CalcInches()
        {
            string userInput = "";
            double calcInchInputValue = 0;
            bool calcInchParse = false;
            bool calcInchLoop = true;
            double inchToCentimeter = 2.540;
            double centimeterToInch = 0.3937;
            while (calcInchLoop)
            {
                Console.WriteLine("Konvertering mellan inches och centimeter");
                Console.Write("Ange längd: ");
                userInput = Console.ReadLine();
                if (userInput.ToUpper() == "X")
                {
                    Menu.SubMenuLength();
                }
                else
                {
                    calcInchParse = double.TryParse(userInput, out calcInchInputValue);
                    if (calcInchParse == false)
                    {
                        Console.WriteLine("Det går endast att ange numeriska värden.");
                    }
                    else
                    {
                        Console.WriteLine($"\n" +
                            $"Konvertering mellan inches och centimeter \n" +
                            $"{calcInchInputValue} Inches är: {String.Format("{0:0.##}", calcInchInputValue * inchToCentimeter)} Centimeter \n" +
                            $"{calcInchInputValue} Centimeter är: {String.Format("{0:0.##}", calcInchInputValue * centimeterToInch)}  Inches\n");

                    }
                }

            }
        }
    }
}
