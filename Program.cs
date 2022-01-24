using System;

namespace BubbleSortAlgorithm
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] sequence = ConstructSequence();
        }

        static int[] ConstructSequence()
        {
            int[] sequence = { 5, 10, 15, 20, 3, 2, 31, 45, 69, 100, 99 };

            return sequence;
        }

        static void ShowUnsorted()
        {
            int[] sequence = ConstructSequence();

            string hello;

            foreach(int i in sequence)
            {
                hello = i + ", ";
            }
            return;
        }

        static void ShowSorted()
        {

        }
    }
}
