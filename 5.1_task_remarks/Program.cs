using System;

namespace _5._1_task_remarks
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] array = new double[7];
            Console.WriteLine("Введите 7 (семь) чисел: ");
            for (int i = 0; i < 7; i++)
            {
                double N = Convert.ToDouble(Console.ReadLine());                
                sum += N;
                array[i] += N;                
            }

            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.WriteLine();                        
            Console.WriteLine("Среднее арифмитическое равно {0:f2}", sum / 7);
            Console.ReadKey();
        }
    }
}
