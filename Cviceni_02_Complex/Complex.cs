using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_02_Complex
{
    public class Complex
    {
        public double realna;
        public double imaginarni;

        

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
        
        public static bool operator ==(Complex x, Complex y)
        {
            if ((x.realna == y.realna) && (x.imaginarni == y.imaginarni))
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Complex x, Complex y)
        {
            if ((x.realna != y.realna) || (x.imaginarni != y.imaginarni))
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            if (imaginarni < 0)
            {
                return (realna + "-" + imaginarni + "i");
            }else
            {
                return (realna + "+" + imaginarni + "i");
            }
        }

        public static Complex ComplexConjugate(Complex x)
        {
            return new Complex(x.realna - x.imaginarni);
        }

        public static Complex Module(Complex x)
        {
            return new Complex(Math.Sqrt(x.realna * x.realna) + (x.imaginarni * x.imaginarni));
        }

        public static Complex Argument(Complex x)
        {
            return new Complex(Math.Atan2(x.imaginarni, x.realna));
        }
       
    }
}
