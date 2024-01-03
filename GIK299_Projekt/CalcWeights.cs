using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Projekt
{
    internal static class CalcWeights
    {
        internal static void CalcPound()
        {
            string userInput = "";
            double calcPoundInputValue = 0;
            bool calcPoundParse = false;
            bool calcPoundLoop = true;
            double poundToKilo = 0.4536;
            double kiloToPound = 2.205;

            while (calcPoundLoop)
            {
                Console.WriteLine("Konvertering mellan pound och kilo, skriv X för att avsluta");
                Console.Write("Ange vikt: ");
                userInput = Console.ReadLine();

                if (userInput.ToUpper() == "X")
                {
                    break;
                }
                else
                {
                    calcPoundParse = double.TryParse(userInput, out calcPoundInputValue);
                    if (calcPoundParse == false || calcPoundInputValue == 0 || calcPoundInputValue < 0 )
                    {
                        Console.WriteLine("Det går endast att ange positiva numeriska värden.");
                    }
                    else
                    {
                        string result = $"Konvertering mellan Pounds och Kilo \n" +
                            $"{calcPoundInputValue} Pounds är: {String.Format("{0:0.##}", calcPoundInputValue * poundToKilo)} Kilo \n" +
                            $"{calcPoundInputValue} Kilo är: {String.Format("{0:0.##}", calcPoundInputValue * kiloToPound)} Pound";

                        Console.WriteLine(result);
                        WriteToFile logFile = new WriteToFile(result);

                    }
                }
            }


        }  internal static void CalcOunces()
        {
            string userInput = "";
            double calcOuncesInputValue = 0;
            bool calcOuncesParse = false;
            bool calcOuncesLoop = true;
            double ouncesTogram = 28.35;
            double gramToOunces = 0.03527;

            while (calcOuncesLoop)
            {
                Console.WriteLine("Konvertering mellan Ounces och gram, skriv X för att avsluta");
                Console.Write("Ange vikt: ");
                userInput = Console.ReadLine();

                if (userInput.ToUpper() == "X")
                {
                    break;
                }
                else
                {
                    calcOuncesParse = double.TryParse(userInput, out calcOuncesInputValue);
                    if (calcOuncesParse == false || calcOuncesInputValue == 0 || calcOuncesInputValue < 0)
                    {
                        Console.WriteLine("Det går endast att ange positiva numeriska värden.");
                    }
                    else
                    {
                            string result = $"Konvertering mellan Ounces och Gram \n" +
                            $"{calcOuncesInputValue} Ounces är: {String.Format("{0:0.##}", calcOuncesInputValue * ouncesTogram)} gram \n" +
                            $"{calcOuncesInputValue} gram är: {String.Format("{0:0.##}", calcOuncesInputValue * gramToOunces)} Ounces" ;

                          
                    }
                }
            }
        }

    }





    }

