using System;

namespace _5._6_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            int n_c = 0, n_l = 0, n_g = 0;
            int magiq_square = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Введите число массива: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,8} ", array[i, j]);
                }
            }
            Console.WriteLine();

            int[] sum_col = new int[N];
            int[] sum_lin = new int[N];
            int[] sum_diag = new int[2];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum_col[i] += array[i, j];
                    sum_lin[j] += array[i, j];
                    sum_diag[0] += (i == j) ? array[i, j] : 0;
                    sum_diag[1] += ((N - 1 - i) == j) ? array[i, j] : 0;
                }
            }

            Console.WriteLine();

            foreach (int a in sum_col)
            {
                n_c = n_c + 1;
                Console.WriteLine("Сумма в строке {0} = {1}", n_c, a);
            }
            foreach (int a in sum_lin)
            {
                n_l = n_l + 1;
                Console.WriteLine("Сумма в столбце {0} = {1}", n_l, a);
            }
            foreach (int a in sum_diag)
            {
                n_g = n_g + 1;
                Console.WriteLine("Сумма в диагонали {0} = {1}", n_g, a);
            }

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                if (sum_col[i] == sum_lin[i] && sum_col[i] == sum_diag[0] && sum_col[i] == sum_diag[1])
                {
                    magiq_square = 1;
                }
                else
                {
                    magiq_square = 0;
                }
            }

            if (magiq_square == 1)
            {
                Console.WriteLine("Матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Матрица НЕ является магическим квадратом");
            }


            Console.ReadKey();
        }
    }
}
