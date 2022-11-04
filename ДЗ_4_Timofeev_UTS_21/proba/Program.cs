using System;
class Program
{
   public static void Main(string[] args)
    {
        int n = 3; int m = 5;
        Random rnd = new Random();
        int[,] a = new int[n, m];
        Console.WriteLine("Матрица: \n");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = rnd.Next(-1, 10);
                Console.Write("{0}\t", a[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n--------------------------------------------------------\n");

        int k = 0; //количество совпадающих элементов

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++);
            k = a.Distinct().Count();

        }
    }
}