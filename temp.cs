using System;
using System.Collections.Generic;
using System.Linq;

namespace TemperatureCalculator
{
    public class Calculator
    {
      public static void ConvertAndDisplay(String fromUnit , string toUnit , Func<double,double> conversion){
    Console.WriteLine($"Enter the temperature in {fromUnit}");
            if(double.TryParse(Console.ReadLine(),out double inputTemp)){
                if(fromUnit=="Kelvin" && inputTemp <0){
                    System.Console.WriteLine("Wrong number Kelvin couldn't be in negative");
                    return;
                }
                else{
                   double result = conversion(inputTemp);
                   System.Console.WriteLine($"{inputTemp} °{fromUnit} = {result:F2} °{toUnit}");
                }
            }
            else{
                System.Console.WriteLine("Invalid value you need to enter a numeric value");
            }

      }

     public static double CelsiusToFahrenheit(double c) => (c * 9/5 ) + 32;
    public static double CelsiusToKelvin(double c) => c + 273.5 ;
    public static double FahrenheitToCelsius(double f) => (f-32) * 5/9 ;
    public static double FahrenheitToKelvin(double f) =>CelsiusToKelvin(FahrenheitToCelsius(f)) ;
    public static double KelvinToCelsius(double k) => k - 273.5;
    public static double KelvinToFahrenheit(double k) => CelsiusToFahrenheit(KelvinToCelsius(k));




        
    }
}