using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source 
            List<int> numbers = new List<int>(){0,1,4,8,2,6,5,7,3,9};

            // Create Query 
           var query = from n in numbers
                where (n % 2 == 0)
                orderby n
                select n;

            int count = query.Count();
            Console.WriteLine($"Count: {count}");

            var avg = query.Average();
            Console.WriteLine($"Average : {avg}");

            var max = query.Max();
            Console.WriteLine($"Max : {max}");

            var min = query.Min();
            Console.WriteLine($"Min : {min}");

            var first = query.First();
            Console.WriteLine($"First : {first}");
            PrintInfo(query);   

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void PrintInfo(dynamic query)
        {
            foreach (var num in query)
            {
                Console.WriteLine(num);
            }
        }
       


    }
}
