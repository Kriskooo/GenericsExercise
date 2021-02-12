using GenericCountMethodString;
using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < num; i++)
            {
                double number = double.Parse(Console.ReadLine());


                box.StoreElement.Add(number);
            }

            double compareNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(box.GreaterThan(compareNumber));
        }
    }
}
