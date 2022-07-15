using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double a = (fahrenheit - 32) * 5 / 9;
        return a;
    }
    public static double CelsiusToFahrenheit(double celsius)
    {
        double answer = (celsius * 9) / 5 + 32;
        return answer;
    }
}
