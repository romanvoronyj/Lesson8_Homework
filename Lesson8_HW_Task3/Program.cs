using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість значень масиву:\t ");
            int elementsQty = Int32.Parse(Console.ReadLine());
            int[] array = new int[elementsQty];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введіть {0}-й елемент массиву: ", i);
                array[i] = Int32.Parse(Console.ReadLine());    
            }
            Console.Write("Масив: " );
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }

            Console.WriteLine();

            int maxValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine("Найбільше значення масиву: {0}", maxValue);

            int minValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine("Найменше значення масиву: {0}", minValue);

            int totalSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                totalSum += array[i];
            }
            Console.WriteLine("Сума елементів масиву складає: {0}", totalSum);

            double averageValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                averageValue = (double)totalSum / elementsQty;
            }
            Console.WriteLine("Середнє арифметичне елементів масиву складає: {0}", averageValue);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] << 31 != 0)
                Console.WriteLine("Непарнe {0}-е значення масиву: {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }

}
