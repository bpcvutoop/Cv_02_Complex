using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_02_Complex
{
    class ComplexTest
    {
        public static void test(string NazevTestu, Complex ocekavana, Complex skutecna)
        {
            Console.WriteLine(NazevTestu);
            var epsilon = 0.000001;
            if ((Math.Abs(ocekavana.realna - skutecna.realna) < epsilon) && (Math.Abs(ocekavana.imaginarni - skutecna.imaginarni) < epsilon)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("CHYBA!!!");
                Console.WriteLine("Skutecna hodnota: " + skutecna);
                Console.WriteLine("Ocekavana hodnota: " + ocekavana);
            }


        }
    }
}
