using System;
using System.Numerics;
using System.Collections.Generic;

namespace FibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a threshold (e.g. 100): ");
            BigInteger n = BigInteger.Parse(Console.ReadLine()!);

            var seq = FibonacciCalculator.Generate(n);
            Console.WriteLine($"Sequence ≤ {n}:");
            foreach (var x in seq) Console.Write(x + " ");
            Console.WriteLine();

            var (maxFib, count) = FibonacciCalculator.Stats(n);
            Console.WriteLine($"Max ≤ {n}: {maxFib}");
            Console.WriteLine($"Count: {count}");

            Console.Write("Enter range start: ");
            BigInteger start = BigInteger.Parse(Console.ReadLine()!);
            Console.Write("Enter range end:   ");
            BigInteger end = BigInteger.Parse(Console.ReadLine()!);

            if (end < start)
            {
                Console.WriteLine("Error: end < start");
                return;
            }

            FibonacciCalculator.StatsRange(start, end,
                                           out var th,
                                           out var mx,
                                           out var ct);

            Console.WriteLine("Threshold | MaxFib | Count");
            for (int i = 0; i < th.Length; i++)
                Console.WriteLine($"{th[i],9} | {mx[i],6} | {ct[i],5}");
        }
    }
}
