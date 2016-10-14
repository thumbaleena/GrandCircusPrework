using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input, reverse = "";
            /* identify variables for input and reversed input */
            int Length;
            /* identify variable to hold # of characters */
            Console.Write("Hit me with a number: ");
            /* get input */
            Input = Console.ReadLine();
            /* process input */
            Length = Input.Length - 1;
            /* calculate length of input (# of characters) */
            while (Length >= 0)
            {
                reverse = reverse + Input[Length];
                Length--;
            }
            /* while the length is greater than zero, program loops through the characters backward, reversing the input) */
            Console.WriteLine("Backwards Man Says: {0}", reverse);
            /* display the calculated output from the while loop */
            Console.WriteLine("Thanks for Playing!");
            Console.ReadLine();
            /* gravy */
            /* prevents window from automatically closing */
        }
    }
}