using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Physics: ");
            int physicsMarks = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistryMarks = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int mathMarks = int.Parse(Console.ReadLine());

            int totalMarks = physicsMarks + chemistryMarks + mathMarks;

            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else if (totalMarks >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
        }
    }
}
