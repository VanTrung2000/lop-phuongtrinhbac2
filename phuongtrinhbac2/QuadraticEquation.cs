using System;
using System.Collections.Generic;
using System.Text;

namespace phuongtrinhbac2
{
    class QuadraticEquation
    {
        double a,b,c;
        
        public QuadraticEquation(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant()
        {
            
            return  b * b - (4 * a * c);
        }
        public double GetRoot()
        {
            return -b / (2.0 * a);
        }
        public double GetRoot1()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }
        public double GetRoot2()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }
    }
}
