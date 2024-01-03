using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Projekt
{
    static internal class CalcTemperature
    {
        internal static void CalcTemp()
        {
            string userInput = "";
            double temperatureInputValue = 0;
            bool temperatureParse = false;
            bool temperatureLoop = true;

            while (temperatureLoop)
            {
                Console.WriteLine("Konvertering av temperaturer, Skriv X för att avsluta");
                Console.Write("Ange temperatur: ");

                userInput = Console.ReadLine();
                if (userInput.ToUpper() == "X")
                {
                    break;
                }

                else
                {
                    temperatureParse = double.TryParse(userInput, out temperatureInputValue);

                    if (temperatureParse == false)
                    {

                        Console.WriteLine("Det går endast att ange numeriska värden");
                    }
                    else
                    {
                        string result = $"Konvertering mellan Celcius,Fahrenheit och Kelvin \n" +

                            $"{temperatureInputValue} Celcius är {String.Format("{0:0.##}", (temperatureInputValue * 1.8) + 32)} Fahrenheit \n" +
                            $"{temperatureInputValue} Celcius är {String.Format("{0:0.##}", temperatureInputValue + 273.15)} Kelvin \n" +
                            $"\n" +
                            $"Konvertering från Fahrenheit \n" +
                            $"{temperatureInputValue} Fahrenheit är {String.Format("{0:0.##}", (temperatureInputValue - 32) / 1.8)} Celcius \n" +
                            $"{temperatureInputValue} Fahrenheit är {String.Format("{0:0.##}", (temperatureInputValue + 459.67) / 1.8)} Kelvin \n" +
                            $"\n" +
                            $"Konvertering från Kelvin \n" +
                            $"{temperatureInputValue} Kelvin är {String.Format("{0:0.##}", temperatureInputValue - 273.15)} Celcius \n" +
                            $"{temperatureInputValue} Kelvin är {String.Format("{0:0.##}", (temperatureInputValue * 1.8) - 459.67)} Fahrenheit \n" ;

                        Console.WriteLine(result);
                        WriteToFile logFile = new WriteToFile(result);
                    }
                }
            }
        }
    }
}
