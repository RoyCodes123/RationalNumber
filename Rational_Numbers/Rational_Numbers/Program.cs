using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Numbers
{
    class Program
    {
        ///<summary> Function for addition multiplies numerator of num1 by denominator 
        /// of num2 and vice versa then adds to get new numerator of new number, multiplies the two denominators to get new denominator of new number</summary>
        static Rational Addition(Rational num1, Rational num2) { 
            int num, den;
            num = num1.GetNumerator() * num2.GetDenom() + num2.GetNumerator() * num1.GetDenom();
            den = num1.GetDenom() * num2.GetDenom();
            Rational p1 = new Rational(num, den);
            return p1;
        }

        ///<summary> Function for subtraction multiplies numerator of num1 by denominator 
        /// of num2 and vice versa then subtracts to get new numerator of new number, multiplies the two denominators to get new denominator of new number</summary>
        static Rational Subtraction(Rational num1, Rational num2)
        {
            int num, den;
            num = num1.GetNumerator() * num2.GetDenom() - num2.GetNumerator() * num1.GetDenom();
            den = num1.GetDenom() * num2.GetDenom();
            Rational p1 = new Rational(num, den);
            return p1;
        }

        static void Main(string[] args)
        {
            Rational num = new Rational(1, 4);
            Rational num2 = new Rational(2, 8);

            Console.WriteLine(num.IsEqual(num2));
            Console.WriteLine(num.GetDenom());
            Console.WriteLine(num.GetNumerator());
            Console.WriteLine(num.Divide(num2));
            Console.WriteLine(num.Multiply(num2));
            Console.WriteLine(Addition(num,num2));
            Console.WriteLine(Subtraction(num, num2));
        }
    }
}
