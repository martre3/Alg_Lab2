using System;
using System.Collections.Generic;

namespace lab2
{
    public class Sharing: STask
    {
        int[] x;
        private List<FriendsPresents> posibilities = new List<FriendsPresents>();

        public Sharing(int[] x)
        {
            this.x = x;
        }

        public override void Execute()
        {
            Split(new FriendsPresents(x), x.Length, -1);
            // FriendsPresents min = FindMinDiff(this.posibilities);
            this.PrintAllMin(this.posibilities);
          //  Console.WriteLine(min.Print());
        }

        private void Split(FriendsPresents pr, int n, int m)
        {
            FriendsPresents f1 = pr.Give(n, m);
            FriendsPresents f2 = f1.Clone();
            Share(f1, n - 1, 0);
            Share(f2, n - 1, 1);
        }

        private void Share(FriendsPresents pr, int n, int m)
        {

            if (n == 0)
            {
                pr.Give(n, m);
                posibilities.Add(pr);
                return;
            }

            Split(pr, n, m);
        }

        private FriendsPresents FindMinDiff(List<FriendsPresents> list)
        {
            FriendsPresents min = list[0];


            foreach (FriendsPresents p in posibilities)
            {
                min = FriendsPresents.Min(min, p);
            }

            return min;
        }

        private void PrintAllMin(List<FriendsPresents> list)
        {
            if (list.Count == 0)
                return;
            
            List<FriendsPresents> min = FindAllWithSmallestDiff(list);

            foreach (FriendsPresents p in min)
            {
                p.Print();
            }
        }

        private List<FriendsPresents> FindAllWithSmallestDiff(List<FriendsPresents> list)
        {
            List<FriendsPresents> min = new List<FriendsPresents>();
            min.Add(list[0]);
            foreach (FriendsPresents p in list)
            {
                if (p.GetValueDiff() < min[0].GetValueDiff())
                {
                    min = new List<FriendsPresents>();
                    min.Add(p);
                }
                else if (p.GetValueDiff() == min[0].GetValueDiff())
                    min.Add(p);
            }

            return min;
        }
    }
}
