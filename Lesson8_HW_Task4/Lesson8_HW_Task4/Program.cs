using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HW_Task4
{
    class Program
    {
        static int[] MyReverse(int[] mass)
        {
            Console.Write("\nІнвертований масив:");
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", i);
            }
            return mass;
        }
        static int[] SubArray(int[] array, ref int index, int count)// як вивести масив починаючи з номера елемента, введеного користувачем ?
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i >= index && i < count)
                {
                    Console.WriteLine(i);
                }
            }
            return array;

        }
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість значень масиву: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] massiv = new int[n];
            int num = 0;
            Console.Write("Масив:");
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write("{0} ", i);
            }
            int[] myArray = MyReverse(massiv);
            Console.WriteLine();

            Console.Write("Введіть номер елемента масиву: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість елемінтів у масиві: ");
            int count = int.Parse(Console.ReadLine());

            SubArray(massiv, ref num, n);

            Console.ReadKey();
        }
    }
}
