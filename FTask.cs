using System;
namespace lab2
{
    abstract public class FTask
    {
        protected int[] x;
        protected int[] y;

        protected FTask(int[] x, int[] y)
        {
            this.x = x;
            this.y = y;
        }

        abstract public int Execute();

        protected int D(int m, int n)
        {
            if (x[m] == y[n])
                return 1;
            return 0;
        }
    }
}
