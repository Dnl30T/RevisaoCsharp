using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoCsharp.Apps
{
    public class Calculator
    {
        public static void Menu() {
			Console.WriteLine($"How many operations do you wanna do?");
            int answer = int.Parse( Console.ReadLine() ?? "0");
            new Calculator().runCalculator( answer );
		}
		protected void Calculate()
        {
            Console.Clear();

            Console.WriteLine("Choose your operation \n" +
                "A -> Add \n" +
                "B -> subtract \n" +
                "C -> multiply \n" +
                "D -> Divide \n" +
                "E -> Exit");
#pragma warning disable CS8604 // Possible null reference argument.
            char operation = char.Parse(Console.ReadLine());
            if (operation == 'E')
            {
                Console.Clear();
                Environment.Exit(0);
            }
            Console.WriteLine("Input a Number:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input another Number:");
            float n2 = float.Parse(Console.ReadLine());
            switch (operation)
            {
                case 'A':
                    Console.WriteLine($"Result: {n1 + n2}");
                    break;
                case 'B':
                    Console.WriteLine($"Result: {n1 - n2}");
                    break;
                case 'C':
                    Console.WriteLine($"Result: {n1 * n2}");
                    break;
                case 'D':
                    Console.WriteLine($"Result: {n1 / n2}");
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
            Console.WriteLine("insert any value to proceed");
            var proceed = Console.ReadLine();
        }
        public void runCalculator(int amountOfOperations)
        {
            while (amountOfOperations > 0)
            {
                Calculate();
                amountOfOperations--;
            }
        }
    }
}
