using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bubblealgo
{
    class Program
    {
        public static void Show()
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number + ",");
            }
            Console.WriteLine("\n");
        }

        static int[] numbers = new int[] { 10, 2, 3, 4, 5, 1, 9 };
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");
            Show();

            for (int i=0; i<numbers.Length; i++)
            {
                for (int j=0; j< numbers.Length-1; j++)
                {  if(numbers[j] > numbers [j + 1])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;
            }
                }
            }

            Show();
        }
    }

}
    

