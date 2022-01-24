/*
 * The purpose of this program is to be able to use the bubble sorting algorithm on a sequence of numbers.
 * 24/01/2022
 * William Burton
 */

using System;

namespace BubbleSortAlgorithm
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] sequence = ConstructSequence(); // Get the sequence of numbers
            Console.WriteLine(sequence); // Output the sequence of numbers onto console
        }

        static int[] ConstructSequence() // This will create the sequence but initially will have a set array
        {
            int[] sequence = { 5, 10, 15, 20, 3, 2, 31, 45, 69, 100, 99 }; // The sequence of numbers used without the program

            return sequence;
        }

        static void ShowUnsorted() // This will output the unsorted sequence
        {
            int[] sequence = ConstructSequence(); // Get the sequence and set it to an variable

            string hello; // Set string to return at some point

            foreach(int i in sequence) // Iterate over the numbers and add it to the string
            {
                hello = i + ", ";
            }
            return;
        }

        static void ShowSorted() // This will output the sorted sequence
        {

        }
    }
}
