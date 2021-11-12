using System;

namespace Open_Lab_01._04
{
    public class Triangle
    {
        public double Area(double foundation, double height)
        {
            throw new NotImplementedException();
            Console.WriteLine("zadaj výšku");
            double viska = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("zadaj stranu");
            double strana = Convert.ToDouble(Console.ReadLine());
            double vipocet = strana * viska / 2;
            Console.WriteLine("vísledok " + vipocet);
        }
    }
}