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

        /*  
            INPUT the initial list of values //Array 

            STORE the initial list of values in initiallist //Array 

            OUTPUT "your initial list is " followed by initiallist //Array 

            START LOOP COUNTER CONTROLLED UNTIL the length of Initiallist – 2 is met //For 

            START LOOP COUNT CONTROLLED Until length of Initiallist – 2 //For 

            IF intial list value == initiallist + 1 value //if 

            STORE the value of initiallist + 1 in Tempvalue //Array 

            SET initiallist + 1 = initiallist //Array 

            SET initiallist = Tempvalue //Array 

            End Loop //endfor 

            End Loop //endfor 

            Output - "Your sorted list is" followed by initial list  
        */

        static void Main(string[] args)
        {
            int[] initial = {4, 7, 3, 1, 9, 12, 20, 45, 74, 69, 55, 1};

            int number;

            Console.WriteLine("Your initial list is:");
            foreach (int i in initial)
            {
                Console.WriteLine(i + ", ");
            }

            for(number = 0; number < initial.Length -2; number++)
            {
                for(int i = 0; i < initial.Length - 2; i++)
                {
                    if(initial[i] > initial[i + 1])
                    {

                    }
                }
            }
        }
    }
}
