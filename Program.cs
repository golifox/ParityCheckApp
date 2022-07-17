using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParityApp
{
    internal class Program
    {
        static bool foo1(int number) // O(1)
        {
            return (number % 2 == 0); //remainder of division by 2
        }

        static bool foo2(int number) // O(1) + faster
        {
            return !Convert.ToBoolean(number & 1); // bitwise operation
        }


        static void Main(string[] args)
        {
            int number = 0;
            string parity = " is parity!", //result string for more readable view
                   not_parity = " isn`t parity";


            Console.WriteLine("Input number:"); 
            number = Convert.ToInt32(Console.ReadLine()); //input number in INT
            

            Console.WriteLine("foo1: " + number + (foo1(number) ? parity : not_parity) + Environment.NewLine); //write results of foo1
            Console.WriteLine("foo2: " + number + (foo2(number) ? parity : not_parity) + Environment.NewLine); //write results of foo2
            Console.Read();
        }
    }
}
