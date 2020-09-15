using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public static class PythagoreanTriplet
{
    private static bool IsPythagoreanTriplet(int a, int b, int c) => a * a + b * b == c * c;

    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        // Constraints:
        //      1) a < b < c
        //      2) a + b + c = sum        (N == sum)
        //      3) a^2 + b^2 = c^2
        //      4) a > 0
        //
        //  We derive from above that:
        //      a < sum / 3
        //      b < c
        //      c = sum - a - b

        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a + 1, c = sum - a - b;
                 b < c;
                 b++, c--)
            {
                if (IsPythagoreanTriplet(a, b, c))
                    yield return (a, b, c);
            }
        }



        ublic class Triplet
    {
        readonly int[] _t;
        readonly int _sum;

        public Triplet(int a, int b, int c)
        {
            _t = new[] { a, b, c }.OrderBy(t => t).ToArray();
        }

        public int Sum()
        {
            return _t.Sum();
        }

        public int Product()
        {
            return _t.Aggregate(1, (acc, i) => acc * i);
        }

        public bool IsPythagorean()
        {
            return _t[0] * _t[0] + _t[1] * _t[1] == _t[2] * _t[2];
        }

        const double TOLERANCE = 1E-9;

        public static IEnumerable<Triplet> Where(int maxFactor, int minFactor = 1, int sum = 0)
        {
            return from i in Enumerable.Range(minFactor, maxFactor - 2 - minFactor)
                   from j in Enumerable.Range(i + 1, maxFactor - 1 - (i + 1))
                   let k = Math.Sqrt(i * i + j * j)
                   where Math.Abs(k - Math.Floor(k)) < TOLERANCE && k <= maxFactor
                   where sum == 0 || sum == i + j + (int)k
                   select new Triplet(i, j, (int)k);
        }









        amespace ExercismProject.pythagorean_triplet
        {
    public class Triplet
        {
            private int a;
            private int b;
            private int c;

            public Triplet(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public int Sum()
            {
                return this.a + this.b + this.c;
            }

            public int Product()
            {
                return this.a * this.b * this.c;
            }

            public bool IsPythagorean()
            {
                return Math.Pow(this.a, 2) + Math.Pow(this.b, 2) == Math.Pow(this.c, 2);
            }

            public static IEnumerable<Triplet> Where(int maxFactor)
            {
                return Where(1, maxFactor);
            }

            public static IEnumerable<Triplet> Where(int minFactor, int maxFactor)
            {
                List<Triplet> result = new List<Triplet>();

                for (int i = minFactor - 1; i < maxFactor; i++)
                {
                    for (int j = i; j < maxFactor; j++)
                    {
                        for (int k = j; k < maxFactor; k++)
                        {
                            Triplet triplet = new Triplet(i + 1, j + 1, k + 1);
                            if (triplet.IsPythagorean())
                            {
                                result.Add(triplet);
                            }
                        }
                    }
                }


                return result;
            }

            public static IEnumerable<Triplet> WhereSum(int sum, int maxFactor)
            {
                return Where(maxFactor).Where(x => x.Sum() == sum);
            }
        }







        public int A, B, C;
        private const double Epsilon = 0.000001;

        public Triplet(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int Sum()
        {
            return A + B + C;
        }

        public int Product()
        {
            return A * B * C;
        }

        public bool IsPythagorean()
        {
            return A * A + B * B == C * C;
        }

        public static IEnumerable<Triplet> Where(int minFactor = 1, int maxFactor = 100, int sum = 0)
        {
            for (int a = minFactor; a <= maxFactor - 2; a++)
                for (int b = a + 1; b <= maxFactor - 1; b++)
                {
                    double c = Math.Sqrt(a * a + b * b);
                    if (c > maxFactor)
                    {
                        break;
                    }
                    int ci = (int)c;
                    if ((Math.Abs(c - ci) > Epsilon))
                    {
                        continue;
                    }
                    if (sum == 0 || sum == a + b + ci)
                    {
                        yield return new Triplet(a, b, ci);
                    }
                }
        }









        using System.Collections.Generic;
using System.Linq;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> results = new List<(int a, int b, int c)>();

        int a = 0, b = 0, c = 0;
        for (a = 1; a < sum / 3; a++)
        {
            for (b = a; b < sum / 2; b++)
            {
                c = sum - a - b;

                if (a * a + b * b == c * c)
                {
                    results.Add((a, b, c));
                    break;
                }
            }
        }

        return results;
    }
}
