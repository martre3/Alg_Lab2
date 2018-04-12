using System;
using System.Collections.Generic;

namespace lab2
{
    public class FriendsPresents
    {
        private int[] presentList;
        private List<int> A = new List<int>();
        private List<int> B = new List<int>();
        private int valueDifference = 0;

        public FriendsPresents(int[] list){
            this.presentList = list;
        }

        public FriendsPresents(int[] presentList, List<int> A, List<int> B, int valueDifference)
        {
            this.presentList = presentList;
            this.A = A;
            this.B = B;
            this.valueDifference = valueDifference;
        }

        public void Print()
        {
            Console.WriteLine("Maziausias skirtumas: " + this.GetValueDiff());
            Console.WriteLine("A drauges dovanos: " + PrintList(A));
            Console.WriteLine("B drauges dovanos: " + PrintList(B));
            Console.WriteLine();
        }

        public int GetValueDiff()
        {
            return Math.Abs(this.valueDifference);
        }

        private String PrintList(List<int> list)
        {
            String str = "";

            foreach(int i in list)
            {
                str += i + " "; 
            }

            return str;
        }
        public void GiveToA(int presentValue)
        {
            A.Add(presentValue);
        }

        public void GiveToB(int presentValue)
        {
            B.Add(presentValue);
        }

        public FriendsPresents Clone()
        {
            return new FriendsPresents(this.presentList, CopyList(this.A), CopyList(this.B), this.valueDifference);
        }

        public List<int> CopyList(List<int> list)
        {
            List<int> newList = new List<int>();
            foreach (int i in list)
            {
                newList.Add(i);
            }
            return newList;
        }

        public FriendsPresents Give(int n, int m)
        {
            int val = D(n, m);
            this.valueDifference = this.valueDifference + val;
            return this;
        }

        private int D(int n, int m)
        {
            if (m == 0)
            {
                GiveToA(this.presentList[n]);
                return this.presentList[n];
            }

            if (m == 1)
            {
                GiveToB(this.presentList[n]);
                return -1 * this.presentList[n];
            }

            return 0;
        }

        static public FriendsPresents Min(FriendsPresents first, FriendsPresents second)
        {
            if (Math.Abs(first.valueDifference) < Math.Abs(second.valueDifference))
                return first;
            return second;
        }

    }
}
