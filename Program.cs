using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Question
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string author = Console.ReadLine();

            Console.Write("Enter the publication year: ");
            int publicationYear = int.Parse(Console.ReadLine());

            Console.Write("Enter the ISBN: ");
            string isbn = Console.ReadLine();



            Console.WriteLine("\nBook information: ");
          
            Console.WriteLine("Title:{0} " , title);
           
            Console.WriteLine("Author:{0} " ,author);
            
            Console.WriteLine("Publication Year:{0} ",  publicationYear);
          
            Console.WriteLine("ISBN:{0} " , isbn);
            

        }
    }
}
