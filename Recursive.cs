using System;
namespace lab2
{
    public class Recursive: FTask
    {
        public Recursive(int[] x, int[] y)
            : base(x, y){}

        public override int Execute()
        {
            return F(x.Length - 1, y.Length - 1);
        }

        private int F(int m, int n)
        {
            if (n == 0)
                return m;

            if (m == 0)
                return n;

            return Math.Min(1 + F(m - 1, n), Math.Min(1 + F(m, n - 1), D(m, n) + F(m - 1, n - 1)));
        }
    }
}
