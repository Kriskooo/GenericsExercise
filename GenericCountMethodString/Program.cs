using System;

namespace GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < num; i++)
            {
                string element = Console.ReadLine();


                box.StoreElement.Add(element);
            }

            string compareElement = Console.ReadLine();
            Console.WriteLine(box.GreaterThan(compareElement));
        }
    }
}
