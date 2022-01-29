using System;

namespace _5._4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
            int count = 0;
            for (int i = 1; i < 20; i += 2)
            {
                if (array[i] > 0 && array[i] % 2 == 1)
                {
                    count++;
                }

            }

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0}", count);
            Console.ReadKey();
        }
    }
}
