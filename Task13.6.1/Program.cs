using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task13._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alltext = System.IO.File.ReadAllText("text1.txt").Split(new char[] { ' ', '\n', '\t' });
            double result1, result2;
            var stopWatch = Stopwatch.StartNew();
            var listStrings = new List<string>(alltext);
            Console.WriteLine($"Создание списка: {result1 = stopWatch.Elapsed.TotalMilliseconds}  мс");
            
            stopWatch = Stopwatch.StartNew();
            var linkedListStrings = new LinkedList<string>(alltext);
            Console.WriteLine($"Создание связного списка: {result2 = stopWatch.Elapsed.TotalMilliseconds}  мс");
            Console.WriteLine($"\nСоздание List в {Math.Round(result2 / result1, 2)} раз быстрее, чем LinkedList");
            Console.ReadKey();
        }
    }
}
