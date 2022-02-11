using System;
namespace Geometrus.Алихан
{
    public class Class1
    {
        public static void Main()
        {
            Console.Write("Длина: ");
            int A = Convert.ToInt32(Console.ReadLine());
            

            int area = A * A;

            Console.WriteLine("Площадь квадрата: {0}", area);
            Console.ReadLine();
        }
    }
}