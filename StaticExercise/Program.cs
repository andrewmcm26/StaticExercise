using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp1 = TempConverter.CelsiusToFarenheit(0);
            Console.WriteLine(temp1);

            var temp2 = TempConverter.FarenheitToCelcius(32);
            Console.WriteLine(temp2);
        }
    }
}
