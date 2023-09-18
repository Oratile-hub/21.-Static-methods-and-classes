using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Static_methods_and_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi salute = new SayHi();

            //salute.sayHello("Oratile"); Cannot be accessed by an object since the method is static

            SayHi.sayHello("Oratile");
            

            Console.WriteLine(Math.Sqrt(144));

            //freeze console
            Console.ReadLine();
        }
    }
}
