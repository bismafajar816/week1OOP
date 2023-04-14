using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {

            int age, price;
           Console.Write("age: ");
           age = int.Parse(  Console.ReadLine());
            Console.Write("Price: ");
            price = int.Parse(Console.ReadLine());
            int even, odd;
            int toy = 3;
            int final = 0;
            int final1 = 0;
            int evenmoney = 0;
            int total = 0;
            int oddmoney = 0;
            even = age / 2;
            odd = age - even;

            for (int e = 1; e <= even; e++)
            {
                evenmoney = evenmoney + 10;
                final = final + evenmoney;
            }
            for (int o = 1; o <= odd; o++)
            {
                oddmoney = odd * toy;
            }

            total = final - even;
            final1 = oddmoney + total;
            if (final1 >= price)
            {
                Console.WriteLine("You can buy");
            }
            else
            {
                Console.WriteLine("You can't buy");
            }
            Console.ReadKey();


        }
    }
}
