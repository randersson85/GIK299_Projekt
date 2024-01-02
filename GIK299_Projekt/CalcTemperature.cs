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
                    Menu.MainMenu();
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
                        Console.WriteLine($"\nKonvertering från Celcius: \n" +

                            
                            $"{temperatureInputValue} Celcius är {String.Format("{0:0.##}", (temperatureInputValue * 1.8) + 32)} Fahrenheit \n" +
                            $"{temperatureInputValue} Celcius är {String.Format("{0:0.##}", temperatureInputValue + 273.15)} Kelvin \n" +
                            $"\n" +
                            $"Konvertering från Fahrenheit \n" +
                            $"{temperatureInputValue} Fahrenheit är {String.Format("{0:0.##}", (temperatureInputValue - 32) / 1.8)} Celcius \n" +
                            $"{temperatureInputValue} Fahrenheit är {String.Format("{0:0.##}", (temperatureInputValue + 459.67) /1.8)} Kelvin \n" +
                            $"\n" +
                            $"Konvertering från Kelvin \n" +
                            $"{temperatureInputValue} Kelvin är {String.Format("{0:0.##}", temperatureInputValue - 273.15)} Celcius \n" +
                            $"{temperatureInputValue} Kelvin är {String.Format("{0:0.##}", (temperatureInputValue * 1.8) - 459.67)} Fahrenheit \n");                
                    }
                    }


            }

        }



        //{
        //    double tempInputValue = 0;
        //    bool tempParse = false;
        //    double celciusToKelvin = 274.2;
        //    double celciusToFahrenheit = 32.00;
        //    double kelvinToCelcius = -272.2;
        //    double kelvinToFahrenheit = -458.0;
        //    double fahrenheitToKelvin = 255.9;
        //    double fahrenheitToCelcius = -17.22;

        //    Console.WriteLine("Konvertering av temperaturer");
        //    Console.Write("Ange temperatur: ");

        //    tempParse =  double.TryParse(Console.ReadLine(), out tempInputValue);
        //    if (tempParse == false)
        //    {
        //        Console.WriteLine("Vänligen kontrollera inmatat värde, det går endast att ange numeriska värden.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Konvertering av Celcius \n" +
        //            $"{tempInputValue} Celcius är {tempInputValue * celciusToFahrenheit} Fahrenheit \n" +
        //            $"{tempInputValue} Celcius är {tempInputValue * celciusToKelvin} Kelvin \n" +
        //            $"" +
        //            $"Konvertering av Fahrenheit \n" +
        //            $"{tempInputValue} Fahrenheit är {tempInputValue * fahrenheitToCelcius} Celcius\n" +
        //            $"{tempInputValue} Fahrenheit är {tempInputValue * fahrenheitToKelvin} Kelvin\n" +
        //            $"" +
        //            $"Konvertering av Kelvin\n " +
        //            $"{tempInputValue} Kelvin är: {tempInputValue * kelvinToCelcius} Celcius \n" +
        //            $"{tempInputValue} Kelvin är: {tempInputValue * kelvinToFahrenheit} Fahrenheit");
        //    }

        //}
    }
}
