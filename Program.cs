using System.Diagnostics;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Генерация массива случайных слов размером 100000 элементов. 
        string[] words = new string[100000];

        Random rnd = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int length = rnd.Next(3, 8);

            char[] chars = new char[length];

            for (int j = 0; j < length; j++)
                chars[j] = (char)rnd.Next('a', 'z');

            words[i] = new string(chars);
        }

        // Замер времени до сортировки. 
        Stopwatch swBeforeSort = Stopwatch.StartNew();

        // Сортировка массива случайных слов. 
        Array.Sort(words);

        // Замер времени после сортировки. 
        swBeforeSort.Stop();

        Console.WriteLine($"Время, затраченное на сортировку: {swBeforeSort.ElapsedMilliseconds} ms");

        Console.ReadKey();
    }
}