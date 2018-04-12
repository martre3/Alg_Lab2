using System;

namespace lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] x = new int[] { 
                2, 1, 1, 4, 5, 7, 1
            };

            int[] y = new int[] {
            8, 9, 10, 15, 6, 1, 2, 3
            };

            FTask simple = new Recursive(x, y);
            FTask dynamic = new DynamicRecursive(x, y);

            Console.WriteLine(simple.Execute());
            Console.WriteLine(dynamic.Execute());

            Console.WriteLine("-----Antras-------");
            Sharing share = new Sharing(x);
            share.Execute();
        }
    }
}
