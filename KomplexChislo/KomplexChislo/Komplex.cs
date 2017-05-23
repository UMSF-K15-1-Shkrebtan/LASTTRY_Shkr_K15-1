using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomplexChislo
{
    class Komplex
    {
        public decimal a, b;

        public Komplex(decimal real=1, decimal img=3)
        {
            a = real; b = img;
        }

        public override string ToString()
        {
            if (b < 0)
            {
                return String.Format("{0}{1}i", a, b);
            }
            return String.Format("{0}+{1}i", a, b);
        }

        public static Komplex operator +(Komplex l, Komplex r)
        {
            return new Komplex(l.a + r.a, l.b + r.b);
        }

        public static Komplex operator -(Komplex l, Komplex r)
        {
            return new Komplex(l.a - r.a, l.b - r.b);
        }

        public static Komplex operator *(Komplex l, Komplex r)
        {
            return new Komplex(l.a * r.a - l.b * r.b, l.b * r.a + l.a * r.b);
        }


        public static Komplex operator /(Komplex l, Komplex r)
        {
            return new Komplex(((l.a *r.a)+(l.b *r.b))/((r.a*r.a)+(r.b*r.b)), ((r.a *l.b)-(r.b *l.a))/((r.a*r.a)+(r.b*r.b)));
        }
    }

}
