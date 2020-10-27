using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_vorm
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double per;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double P)
        {
            a = A;
            b = B;
            c = C;
            per = P;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }

        public string outputPer()
        {
            return Convert.ToString(per);
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Floor(Math.Sqrt((p * (p - a) * (p - b) * (p - c))));
            return s;
        }
        public double HalfPerimeter()
        {
            return Perimeter() / 2;
        }
        public double Height() // Метод нахождения высоты
        {
            double p = HalfPerimeter();
            double h = Math.Floor( 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a);
            return h;
        }

        public double heightFromS() // Метод нахождения высоты через площадь и сторону
        {
            double s = Surface();
            double h = Math.Floor((2 * s)/a);
            return h;
        }

        public double getCornerAlpha() //угол альфа
        {
            double cA = 0;
            cA = Math.Acos(((a * a) + (c * c) - (b * b)) / (2 * a * c))*(180/Math.PI);
            return cA;
            
        }

        public double getCornerBeta() //угол бета
        {
            double cB = 0;
            cB = Math.Acos(((a * a) + (b * b) - (c * c)) / (2 * a * c))*(180/Math.PI);
            return cB;
        }

        public double getCornerGamma() //угол гамма
        {
            double cG = 0;
            cG = Math.Acos(((b * b) + (c * c) - (a * a)) / (2 * c * b))*(180/Math.PI);
            return cG;
        }

        public double getSideFromCorner()
        {
            a = Math.Sqrt((b * b) + (c * c) - 2 * b * c * Math.Cos(getCornerAlpha()));
            return a;
        }
        


        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public double GetSetP
        {
            get
            { return c; }
            set
            { per = value; }
        }

        public bool ExistTriangle // Проверка, существует ли данный треугольник
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return true;
                else return false;
            }
        }
    }
}
 