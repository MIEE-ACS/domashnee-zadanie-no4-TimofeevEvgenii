using System;
class Program
{
    class mylist
    {
        public int kol { get; set; }
        public List<int> list { get; set; }
        public mylist(int kol, List<int> list)
        {
            this.kol = kol;
            this.list = list;
        }
    }
    static void Main(string[] args)
    {
        int n = 4; int m = 5;

        Random rnd = new Random();
        int[,] matrix = new int[n, m];
        List<int> t = new List<int>(m);
        List<mylist> mlist = new List<mylist>();
        int kol = 0; //количество совпадающих элементов

        Console.WriteLine("Матрица: \n");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rnd.Next(-1, 10);
                Console.Write("{0}\t", matrix[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n--------------------------------------------------------\n");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++) t.Add(matrix[i, j]);
            kol = t.Distinct().Count();
            mlist.Add(new mylist(kol, t.ToList()));
            t.Clear();
        }

        mlist = mlist.OrderBy(el => el.kol).ToList();

        Console.Write("Упорядочная матрица: \n");
        foreach (var item in mlist)
        {
            foreach (var i in item.list)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nМатрица: \n");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}\t", matrix[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n--------------------------------------------------------\n");

        int count = 0; // Количество элементов в стоблце
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) if (matrix[j, i] >= 0) count++;
            if (count == n)
            {
                Console.WriteLine("номер первого столбца, где нет отрицательных элементов {0}", ++i);
                break;
            }
            count = 0;

        }

        Console.WriteLine("\nМатрица: \n");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}\t", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

}

// данный код я взял из интернета, сам я не понимаю как это сделать 