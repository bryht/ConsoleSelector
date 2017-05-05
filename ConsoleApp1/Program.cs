
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!!");
            Console.WriteLine();

            string[] options = { "aaaa", "bbbb", "ccccc", "ddddd", "eeeee" };
            var chooseIndex=Options("Please choose the right one", options);
            Console.WriteLine("You choose:" + options[chooseIndex]);

            Console.WriteLine();

            string[] options1 = { "111", "222", "333", "444", "555" };
            var chooseIndex1 = Options("Please choose the right one", options1);
            Console.WriteLine("You choose:" + options1[chooseIndex1]);

            Console.WriteLine();
            Console.WriteLine("Press any key to stop!");
            Console.ReadLine();
            
           
        }

        static int Options(string title,string [] options) {
          
            Console.WriteLine(title+":");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + options[i]);
            }

            var topNum = Console.CursorTop - options.Length;
            var bottomNum = Console.CursorTop;
            var chooseIndex = 0;
            Console.CursorTop = topNum;
            bool flag = true;
            while (flag)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop>topNum)
                        {
                            Console.CursorTop--;
                            chooseIndex--;
                        }
                       
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop<bottomNum-1)
                        {
                            Console.CursorTop++;
                            chooseIndex++;
                        }
                        break;

                    case ConsoleKey.Enter:
                        flag = false;
                        Console.CursorTop = bottomNum;
                       
                        break;
                    default:
                        break;
                }
            }

            return chooseIndex;

        }

        
    }
}
