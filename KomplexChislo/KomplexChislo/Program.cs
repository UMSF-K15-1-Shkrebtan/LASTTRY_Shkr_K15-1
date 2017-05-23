using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KomplexChislo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое комплексное число через энтер");

            Komplex a = new Komplex(decimal.Parse(Console.ReadLine()), decimal.Parse(Console.ReadLine()));
            Komplex b = new Komplex(2, 5);
           
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);


            Console.ReadKey(); 
        }
    }
}
