using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_02_Complex
{
  
    class Program
    {

      

        static void Main(string[] args)
        {
            var a = new Complex(1, 1);
            var b = new Complex(2, 2);
            var c = new Complex(1, 2);
            var d = new Complex(7, 7);

            ComplexTest.test("Test +", a + b, new Complex(3, 3));
            ComplexTest.test("Test -", a - b, new Complex(-1, -1));
            ComplexTest.test("Test *", a * b, new Complex(0, 4));
            ComplexTest.test("Test /", a / b, new Complex(0.5, 0));

            Console.ReadLine();
            
        }
    }
}
