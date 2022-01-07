using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 01 : ");
            float no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 02 : ");
            float no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Opperation : [+, -, *, /, %]");
            string ope = Console.ReadLine();

            Operations oper = new Operations();

            switch (ope)
            {
                case "+":
                    Console.WriteLine("Sumation : {0}", oper.Sum(no1, no2));
                    break;

                case "-":
                    Console.WriteLine("Substraction : {0}", oper.Sub(no1, no2));
                    break;
                case "*":
                    Console.WriteLine("Multiplication : {0}", oper.Multi(no1, no2));
                    break;

                case "/":
                    Console.WriteLine("Divition : {0}", oper.Divi(no1, no2));
                    break;

                case "%":
                    Console.WriteLine("Remainder : {0}", oper.Rem(no1, no2));
                    break;


                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            Console.ReadKey();
        }
    }
}
