using System;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 7, 3, 3, 3, 3, 3, 1 };
        Console.WriteLine($"Количество повторений: {arr.Length - arr.Distinct().Count()}");


    }
}
