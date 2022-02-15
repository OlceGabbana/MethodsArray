using System;

namespace MethodsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет. Задача: 1.  найти разность между максимальным и минимальным элементами массива. " +
                "2.поменять местами макс и мин массива. 3.  * отсортировать массив");
            Console.WriteLine("");
            Console.Write("Введите количество элементов в массиве: ");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[s];
            Random rand = new Random();
            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(20);
                Console.WriteLine($"Значение {x}-го элемента массива = {myArray[x]}");
            }
            // **********************************************
            int max = int.MinValue;
            int min = 0;
            for 
            /* int max = myArray.Max();
            int min = myArray.Min();*/
            Console.WriteLine("");
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");

            // **********************************************

        }
    }
}
