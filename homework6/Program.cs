using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    internal class Program
    {
        // заполнить массив с клавиатуры
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int[] myArray = new int[int.Parse(Console.ReadLine())];


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива {i}");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Размер массива =" + myArray.Length);
            Console.WriteLine("Массив: {0}", String.Join(" ", myArray));
            Console.ReadLine();
            //Console.Write("Введите количество элементов массива:\t");
            //int elementsCount = int.Parse(Console.ReadLine());

            //int[] myArray = new int[elementsCount];
            //for (int i = 0; i < myArray.Length; i++)
            //rray[i] = int.Parse(Console.ReadLine());
            //}{
                           //    Console.Write($"\nВведите элемент массива под индексом {i}:\t "); //\n переход на след.строку
                           //    myA
            //Console.WriteLine("Вывод массива");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Console.ReadLine();
        }
    }
}