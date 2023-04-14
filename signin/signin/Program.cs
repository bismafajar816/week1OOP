using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\oop\\week1\\enteries.txt";
            string[] names = new string[5];
            string[] passwords = new string[5];
            int choice;
          
            do
            {
                readData(path, names, passwords);
                Console.Clear();
                choice = menu();
                Console.Clear();
                if(choice == 1)
                {
                    Console.WriteLine("Write name: ");
                   string name = Console.ReadLine();
                    Console.Write("Write password: ");
                   string  password = Console.ReadLine();
                    signUp(path, name, password);
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Write name: ");
                    string name = Console.ReadLine();
                    Console.Write("Write password: ");
                    string password = Console.ReadLine();
                    signin(name, password, names, passwords);

                }
              
            }
            while (choice < 3);
            Console.ReadKey();

        }
        static int menu()
        {
            Console.WriteLine("1. Sign up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");
            int option;
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string dataParse(string line, int field)
        {
            string item = "";
            int commacount = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        static void readData(string path , string[] names, string[] passwords)
        {
            int x = 0;
           
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {

                    names[x] = dataParse(line, 1);
                    passwords[x] = dataParse(line, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;

                    }
                    

                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File does not exists");
            }

        }
       static void signin( string name, string passsword , string[] names, string[] passswords)
        {
            bool flag = false;
            for(int x = 0; x < 5; x++ )
            {
                if(name == names[x] && passsword == passswords[x] )
                {
                    Console.WriteLine("valid user");
                    flag = true;


              
            }
            }
            if (flag == false)
            {

                Console.WriteLine("Invalid user");
            }
            Console.ReadKey();
        }
        static void signUp(string path, string name , string password)
        {

            StreamWriter file = new StreamWriter(path , true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
        }


    }
}
