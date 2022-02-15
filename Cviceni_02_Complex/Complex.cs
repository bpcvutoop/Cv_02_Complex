using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_02_Complex
{
    public class Complex
    {
        public double Realna;
        public double imaginarni;

        

        public Complex(double real = 0.0, double complex = 0.0)
        {
            this.Realna = real;
            this.imaginarni = complex;

        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.Realna + y.Realna, x.imaginarni + y.imaginarni);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.Realna - y.Realna, x.imaginarni - y.imaginarni);
        }

        public static Complex operator *(Complex x, Complex y)
        { //(ac - bd) + (ad + bc)i
            //                      (x1y1 - x2y2) + (x1y2 + x2y1)i
            return new Complex(((x.Realna * y.Realna) - (x.imaginarni * y.imaginarni)), ((x.Realna * y.imaginarni) + (x.imaginarni * y.Realna)));
        }

        public static Complex operator /(Complex x, Complex y)
        { //(ac - bd) + (ad + bc)i
            //                      (x1y1 - x2y2) + (x1y2 + x2y1)i
            return new Complex(((x.Realna * x.Realna + x.imaginarni * y.imaginarni) / (y.Realna * y.Realna + y.imaginarni * y.imaginarni)), (x.imaginarni * x.Realna - x.Realna * y.imaginarni) / (y.Realna * y.Realna + y.imaginarni * y.imaginarni));
        }
        
        public static bool operator ==(Complex x, Complex y)
        {
            if ((x.Realna == y.Realna) && (x.imaginarni == y.imaginarni))
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Complex x, Complex y)
        {
            if ((x.Realna != y.Realna) || (x.imaginarni != y.imaginarni))
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            if (imaginarni < 0)
            {
                return (Realna + "-" + imaginarni + "i");
            }else
            {
                return (Realna + "+" + imaginarni + "i");
            }
        }

        public static Complex ComplexConjugate(Complex x)
        {
            return new Complex(x.Realna - x.imaginarni);
        }

        public static Complex Module(Complex x)
        {
            return new Complex(Math.Sqrt(x.Realna * x.Realna) + (x.imaginarni * x.imaginarni));
        }

        public double Argument(Complex x)
        {
            return (Math.Atan2(x.imaginarni, x.Realna));
            //return new Complex(Math.Atan2(x.imaginarni, x.realna));
        }
       
    }
}
