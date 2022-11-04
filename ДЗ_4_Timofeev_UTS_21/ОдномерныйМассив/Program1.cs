using System;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Введите размер масива: ");
            int n = int.Parse(Console.ReadLine());



            int[] M1 = new int[n];
            Random rand = new Random();
            for (int i = 0; i < M1.Length; i++)
            {
                M1[i] = rand.Next(-10, 10);
            }

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n Массив: ");
            foreach (var i in M1)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("\n\n--------------------------------------------------------------------------------------------------");

            int count = 0;
            for (int i = 0; i < M1.Length; i++)
            {
                if (M1[i] < 0)
                    count++;
            }
            Console.WriteLine($"\n Количество отрицательных элементов массива = {count}");

            Console.WriteLine("\n Массив: ");
            foreach (var i in M1)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("\n\n--------------------------------------------------------------------------------------------------");



            int min = 0;
            int minI = 0;

            for (int i = 0; i < M1.Length; i++)
            {
                if (Math.Abs(M1[i]) < min)
                {
                    min = M1[i];
                    minI = i;
                }
            }


            int sum = 0;
            for (int i = minI + 2; i < M1.Length; i++)
            {
                sum += Math.Abs(M1[i]);
            }
            Console.WriteLine($"\n Сумму модулей элементов массива, расположенных после минимального по модулю элемента = {sum}");

            Console.WriteLine("\n Массив: ");
            foreach (var i in M1)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("\n\n--------------------------------------------------------------------------------------------------");

            for (int i = 0; i < M1.Length; i++)
            {
                if (M1[i] < 0)
                    M1[i] *= M1[i];
            }
            Array.Sort(M1);
            Console.WriteLine("\n Преобразованный массив: ");
            for (int i = 0; i < M1.Length; i++)
            {
                Console.Write($" {M1[i]} ");
            }

            Console.WriteLine("\n\n- - - - - - - - - - - - - - - - -");

            Console.WriteLine("\n Массив: ");
            foreach (var i in M1)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("\n\n--------------------------------------------------------------------------------------------------");

            Console.Write("\n");
        }
         
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n НЕКОРРЕКТНЫЙ ВВОД МАССИВА!");
            Console.ResetColor();
        }
        
    }
}
