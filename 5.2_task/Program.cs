using System;

namespace _5._2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int S = 0;
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("Максимальное значение = {0}", max);

            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                    min = a;
            }
            Console.WriteLine("Минимальное значение = {0}", min);
            Console.WriteLine("Сумма максимального и минимального значения = {0}", max + min);
            Console.ReadKey();
        }
    }
}
