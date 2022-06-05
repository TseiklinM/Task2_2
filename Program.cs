using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая предлагает пользователю ввести число и считает, 
            сколько раз это число встречается в массиве.*/

            //1.Ввод данных
            Console.Write(" Введите произвольное число от 0 до 100: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //2.Проверка условий ввода данных
            if (number < 0) number *= -1;
            if (number > 100) number = 50;
            if (size < 0) size *= -1;
            if (size == 0)
            {
                size = 100;
                Console.WriteLine($" Вы выбрали массив длинной 0. \n " +
                                    $" Размер массива автоматически увеличен до 100. \n");
            }

            //3.Решение
            int[] arrRandom = new int[size];
            Random rand = new Random(); //Для заполнения массива произвольными значениями
            int count = 0; //Счетчик значений
            for (int i = 0; i < arrRandom.Length; i++)
            {
                arrRandom[i] = rand.Next(0, 101);
                if (i % 25 == 0)
                    Console.Write("\n");
                else Console.Write(" " + arrRandom[i]);
                if (arrRandom[i] == number) //Проверка найденых значений
                    count++;
            }

            //4.Решение
            Console.WriteLine($"\n\n В массиве из {size} элементов, найдены {count} значений. ");
        }
    }
}
