using System.Xml.Linq;

namespace deliverable4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 25 numbers in the Fibonacci sequence: ");
            /*
             * Create a C# console application that computes the first 25 numbers of the Fibonacci sequence, where 
             * f(n) = f(n-2)+f(n-1)
             * Instructions:
             * 1. The program doesn't ask the user anything, it will just run and execute code. No user input.
             * 2. Have the program execute an array that is of size 25 elements.
             * 3. Then, have the code simply display in the Console the following 25 times (Here is a sample of the output):
             * Fibonacci number (0) = 0
             * Fibonacci number (1) = 1
             * Fibonacci number (2) = 1
             * Fibonacci number (3) = 2
             * .......... and so on .....
             * Fibonacci number (24) = 46368
             */
            //define array with Fibonacci sequence
            int[] fibSeq = new int[25];
            fibSeq[0] = 0;
            fibSeq[1] = 1;
            
            for (int startingNum = 2; startingNum < 25; startingNum++) 
            {
                fibSeq[startingNum] = fibSeq[startingNum - 1] + fibSeq[startingNum - 2];
            }

            foreach (int element in fibSeq )
            {
                Console.WriteLine(element);
            }
        }
    }
}