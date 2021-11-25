using System;

namespace ForLoopActivity
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("\nENTER THE BEGINNING OF THE LOOP: ");
            int beginning = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nENTER THE END OF THE LOOP: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nRANGE OF NUMBERS FROM {beginning} UP TO {end}");
            for (int i = beginning; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\nTHE SUM OF THE NUMBER FROM {beginning} UP TO {end} IS: {sum}");
            Console.ReadKey();
        }
    }
}