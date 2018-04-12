using System;
namespace lab2
{
    public class Memo
    {
        private int?[,] memo;

        public Memo(int x, int y)
        {
            memo = new int?[x, y];
        }

        public int this[int x, int y]
        {
            get{
                return Convert.ToInt32(memo[x, y]);
            }
            set{
                memo[x, y] = value;
            }
        }

        public Boolean IsSet(int x, int y)
        {
            return !(memo[x, y] == null);
        }
    }
}
