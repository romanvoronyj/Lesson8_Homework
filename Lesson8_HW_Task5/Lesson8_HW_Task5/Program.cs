using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HW_Task5
{
    class Program
    {
        static int[] CustomerArray(int[] massiv, int value)
        {
            int[] customerArray = new int[massiv.Length + 1];
            customerArray[0] = value;
            for (int i = 0; i < massiv.Length; i++)
            {
                customerArray[i + 1] = massiv[i];
            }
            return customerArray;
        }
        static int[] NewArray(int[] array)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[5] = 100;
            return newArray;
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            int[] massiv = NewArray(array);
            Console.Write("Отриманий масив:");
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write("{0} ", massiv[i]);
            }
            Console.WriteLine();
            Console.Write("Введіть значення першого елемента масива: ");
            int value = Int32.Parse(Console.ReadLine());
            int[] customerArray = CustomerArray(array, value);
            Console.Write("Новий масив:");
            for (int i = 0; i < customerArray.Length; i++)
            {
                Console.Write("{0} ", customerArray[i]);
            }


            Console.ReadKey();
        }
    }
}
