using System;

namespace phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            int c = int.Parse(Console.ReadLine());
            QuadraticEquation phuongtrinh = new QuadraticEquation(a,b,c);

            Console.WriteLine("Delta=" + phuongtrinh.GetDiscriminant());

            if(phuongtrinh.GetDiscriminant() > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                Console.WriteLine("X1:" + phuongtrinh.GetRoot1());
                Console.WriteLine("X1:" + phuongtrinh.GetRoot1());

            }
            else if (phuongtrinh.GetDiscriminant() == 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem duy nhat" + phuongtrinh.GetRoot());
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }


        }
    }
}
