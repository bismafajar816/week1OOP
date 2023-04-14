using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        readData();
        Console.ReadKey();

    }
    static void readData()
    {
        string path = "D:\\oop\\week1\\customers.txt";
        int orders;
       
        string names;

        int numberOfOrder;
        int orderPrice;
        Console.WriteLine("Enter the minimum number of orders: ");
        numberOfOrder = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price of order: ");
        orderPrice = int.Parse(Console.ReadLine());
        int count = 0;
        string price;
        if (File.Exists(path))
        {
            StreamReader file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {

                names = dataParse(line, 1);
                orders = int.Parse(dataParse(line, 2));
                price = dataParse(line, 3);
                int[] arrayInt = new int[orders];


                for (int y = 0; y < orders; y++)
                {
                   
                    arrayInt[y] = int.Parse(dataParseAgain(price, y));
                    if (arrayInt[y] > orderPrice)
                    {
                        count++;
                    }
                }
                if (count >= numberOfOrder)
                {
                    Console.WriteLine( names);
                }
              


            }
            file.Close();
        }
        else
        {
            Console.WriteLine("File does not exists");
        }

    }
    static string dataParse(string line, int field)
    {
        string item = "";
        int spacecount = 1;
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == ' ')
            {
                spacecount++;
            }
            else if (spacecount == field)
            {
                item = item + line[i];
            }
        }
        return item;
    }
    static string dataParseAgain(string line, int field )
    {
        string item = "";
        int spacecount = 0;
        for (int i = 1; i < line.Length - 1; i++)
        {
            if (line[i] == ',')
            {
                spacecount++;
            }
            else if (spacecount == field)
            {
                item = item + line[i];
            }
        }
        return item;
    }
}
