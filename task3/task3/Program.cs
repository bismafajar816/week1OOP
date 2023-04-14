using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task1();*/
            /*Task2();*/
            /*Task3();*/
            /* Task4();*/
            /* Task5();*/
            /*  Task6();*/
            /*Task();*/
            /* Task8();
             Task9();*/
            /* Task10();*/
            /* Task11();*/
            /*  Task12();*/
            /*  Task 13 parameters*/
            /*    Console.WriteLine("Enter number 1: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                int number2 = int.Parse(Console.ReadLine());
               Console.WriteLine("The sum is {0} ",Task13(number1 , number2));
                Console.ReadKey();*/
            Task14();
            Console.ReadKey();
            Task15();
            Console.ReadKey();


        }
        static void Task1()
        {
            Console.Write("Hello World");
            Console.Write("Hello World");

            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Hello World!!");
            Console.ReadKey();
        }
        static void Task3()
        {
            int number = 7;
            Console.WriteLine("Number is : ");
            Console.Write(number);
            Console.ReadKey();
        }
        static void Task4()
        {
            string line = "I'm Bisma Fajar";
            Console.WriteLine("string is : ");
            Console.Write(line);
            Console.ReadKey();
        }
        static void Task5()
        {
            float number = 7.3F;
            Console.WriteLine("Number is : ");
            Console.Write(number);
            Console.ReadKey();
        }
        static void Task6()
        {
            Char line = 'A';
            Console.WriteLine("Character is : ");
            Console.Write(line);
            Console.ReadKey();
        }
        static void Task()
        {
            float length;
            Console.WriteLine("Enter length");
            length = float.Parse(Console.ReadLine());
            float area = length*length;
            Console.WriteLine("Total area of square is: ");
            Console.Write(area);
            Console.ReadKey();

        }
        static void Task8()
        {
            string marks;
            int newmarks;
            Console.WriteLine("Enter your marks ");
            marks = Console.ReadLine();
            newmarks = int.Parse(marks);
            if (newmarks > 50)
            {
                Console.WriteLine("you are passed");

            }
            else
            {
                Console.WriteLine("you are failed");
            }
            Console.ReadKey();

        }
        static void Task9()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome jack");
                Console.ReadKey();
            }
        }
        static void Task10()
        {
            int num;
            int sum = 0;
            do
            {
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadKey();
        }
        static void Task11()
        {
            int[] array = new int[3];
            for(int x = 0; x < 3; x++)
            {
                Console.WriteLine("Enter number {0}: ", x);
                array[x] = int.Parse(Console.ReadLine());
            }
            int largest = array[0];
            for(int x = 1; x < 3; x++)
            {
                if(largest < array[x])
                {
                    largest = array[x];
                }
            }
            Console.WriteLine("Largest number is {0}  ", largest);
            Console.ReadKey();

        }

        static void Task12()
        {

            int age, price;
            int toy ;
            Console.Write("age of lilly: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Price of machine: ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Price of toy: ");
            toy = int.Parse(Console.ReadLine());
            int even, odd;
          
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
        static int Task13(int number1 , int number2)
        {
            return number1 + number2;
        }
        static void Task14()
        {
            string path = "D:\\oop\\week1\\data.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                file.Close();

            }
            else
            {
                Console.WriteLine("File does not exists ");
            }


        }
        static void Task15()
        {

            string path = "D:\\oop\\week1\\data.txt";
            StreamWriter file = new StreamWriter(path , true);
            file.WriteLine("goodbye");
            file.Flush();
            file.Close();
        }
        


    }
}
