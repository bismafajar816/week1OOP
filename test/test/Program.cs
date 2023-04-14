using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string marks;
            int newmarks;
            marks = Console.ReadLine();
            newmarks = int.Parse(marks);
            if(newmarks > 50)
            {
                Console.WriteLine("you are passed");

            }
            else
            {
                Console.WriteLine("you are failed");
            }
            Console.ReadKey();

        }
    }
}
