using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class XYPOSitive
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            bool bothPositive = (x > 0) && (y > 0);

            Console.WriteLine(bothPositive);
        }
    }
}
