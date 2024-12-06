using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cone cone = new Cone(8, 10);
            Console.WriteLine(cone.ToString());
            Circle circle = new Circle(8);
            Console.WriteLine(circle.ToString());
            Console.ReadLine();
        }
    }
}
