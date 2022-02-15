using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_02_Complex
{
    public class Complex
    {
        double realna;
        double imaginarni;
        double sranda = 0.0;

        public Complex(double real = 0.0, double complex = 0.0)
        {
            this.realna = real;
            this.imaginarni = complex;

        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.realna + y.realna, x.imaginarni + y.imaginarni);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.realna - y.realna, x.imaginarni - y.imaginarni);
        }

        public static Complex operator *(Complex x, Complex y)
        { //(ac - bd) + (ad + bc)i
            //                      (x1y1 - x2y2) + (x1y2 + x2y1)i
            return new Complex(((x.realna * y.realna) - (x.imaginarni * y.imaginarni)), ((x.realna * y.imaginarni) + (x.imaginarni * y.realna)));
        }

        public static Complex operator /(Complex x, Complex y)
        { //(ac - bd) + (ad + bc)i
            //                      (x1y1 - x2y2) + (x1y2 + x2y1)i
            return new Complex(((x.realna * x.realna + x.imaginarni * y.imaginarni) / (y.realna * y.realna + y.imaginarni * y.imaginarni)), (x.imaginarni * x.realna - x.realna * y.imaginarni) / (y.realna * y.realna + y.imaginarni * y.imaginarni));
        }



        public void ToString(double real, double complex)
        {
            Console.WriteLine(real + complex + "i");
        }

    }
}
