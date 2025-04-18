using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibApp
{
    public static class FibonacciCalculator
    {
        public static List<BigInteger> Generate(BigInteger maxValue)
        {
            var seq = new List<BigInteger>();
            if (maxValue < 1) return seq;

            BigInteger a = 1, b = 2;
            seq.Add(a);

            if (maxValue >= 2)
            {
                seq.Add(b);
                while (true)
                {
                    BigInteger next = a + b;
                    if (next > maxValue) break;
                    seq.Add(next);
                    a = b;
                    b = next;
                }
            }

            return seq;
        }

        public static (BigInteger maxFib, int count) Stats(BigInteger n)
        {
            var s = Generate(n);
            if (s.Count == 0) return (0, 0);
            return (s[^1], s.Count);
        }

        public static void StatsRange(
            BigInteger start, BigInteger end,
            out BigInteger[] thresholds,
            out BigInteger[] maxFibs,
            out int[] counts)
        {
            int length = (int)((end - start) + 1);
            thresholds = new BigInteger[length];
            maxFibs = new BigInteger[length];
            counts = new int[length];

            for (int i = 0; i < length; i++)
            {
                BigInteger t = start + i;
                thresholds[i] = t;
                var (m, c) = Stats(t);
                maxFibs[i] = m;
                counts[i] = c;
            }
        }
    }
}
