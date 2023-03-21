using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    internal class Program
    {
        // вывести массив в обратном порядке
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}:\t "); //\n переход на след.строку
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива");
            for (int i = myArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }


            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}
