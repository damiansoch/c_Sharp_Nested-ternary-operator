using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Whats the current temperature?");

            float currentTemp;
            bool sucess =float.TryParse(Console.ReadLine(), out currentTemp );

            if (!sucess)
            {
                Console.WriteLine("Not a valid Temperature");
            }
            else
            {
                tempCheck(currentTemp);
            }

            
        }
        public static void tempCheck(float currentTemp)
        {
            string output = currentTemp < 16 ? "it is too cold here" : currentTemp >= 16 && currentTemp <= 28 ? "it is ok" : "it is hot here";

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
