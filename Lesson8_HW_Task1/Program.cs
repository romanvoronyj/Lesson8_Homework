using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            array[6] = 7;
            array[7] = 8;
            array[8] = 9;
            array[9] = 10;

            Console.WriteLine(array[9]);
            Console.WriteLine(array[8]);
            Console.WriteLine(array[7]);
            Console.WriteLine(array[6]);
            Console.WriteLine(array[5]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[0]);

            Console.ReadKey();
        }
    }
}
