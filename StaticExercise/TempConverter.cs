using System;
namespace StaticExercise
{
    public static class TempConverter
    {
       

        public static double FarenheitToCelcius(double f)
        {
            return (f - 32) * (5 / 9);
        }

        public static double CelsiusToFarenheit(double c)
        {
            return (c * (9 / 5)) + 32;
        }
    }
}
