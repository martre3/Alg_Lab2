using System;
namespace lab2
{
    public class DynamicRecursive: FTask
    {
        public DynamicRecursive(int[] x, int[] y)
            : base(x, y){ }

        public override int Execute()
        {
            int m = x.Length;
            int n = y.Length;
            Memo memo = new Memo(m, n);

            // int?[,] memo = new int?[m, n];

            //return Convert.ToInt32(F(m, n, memo));
            return F(--m, --n, memo);
        }

        private int F(int m, int n, Memo memo)
        {
            if (memo.IsSet(m, n))
                return memo[m, n];
            
            if (n == 0)
                return m;

            if (m == 0)
                return n;

            int result = Math.Min(1 + F(m - 1, n, memo), Math.Min(1 + F(m, n - 1, memo), D(m, n) + F(m - 1, n - 1, memo)));
            memo[m, n] = result;
            return result;
        }
    }
}
