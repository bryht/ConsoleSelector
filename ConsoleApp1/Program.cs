
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSelector
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!!");
            Console.WriteLine();

            string[] options = { "aaaa", "bbbb", "ccccc", "ddddd", "eeeee" };
            var chooseIndex = SingleOptions("Please choose the right one", options);
            Console.WriteLine("You choose:" + options[chooseIndex]);

            Console.WriteLine();

            string[] options1 = { "111", "222", "333", "444", "555" };
            var chooseItems = MultipleOptions("Please choose the right one with space", options1);
            foreach (var item in chooseItems)
            {
                Console.WriteLine("You choose:" + options1[item]);
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to stop!");
            Console.ReadLine();


        }

        static int SingleOptions(string title, string[] options)
        {

            Console.WriteLine(title + ":");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("[ ]" + (i + 1) + ". " + options[i]);
            }

            var topNum = Console.CursorTop - options.Length;
            var bottomNum = Console.CursorTop;
            var chooseIndex = 0;
            Console.CursorTop = topNum;
            Console.Write("[*");
            Console.CursorLeft = 0;
            bool flag = true;
            while (flag)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > topNum)
                        {
                            Console.Write("[ ");
                            Console.CursorLeft = 0;
                            Console.CursorTop--;
                            chooseIndex--;
                            Console.Write("[*");
                            Console.CursorLeft = 0;
                        }

                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < bottomNum - 1)
                        {
                            Console.Write("[ ");
                            Console.CursorLeft = 0;
                            Console.CursorTop++;
                            chooseIndex++;
                            Console.Write("[*");
                            Console.CursorLeft = 0;
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

        static List<int> MultipleOptions(string title, string[] options)
        {

            Console.WriteLine(title + ":");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine("[ ]" + (i + 1) + ". " + options[i]);
            }

            var topNum = Console.CursorTop - options.Length;
            var bottomNum = Console.CursorTop;
            var currentIndex = 0;
            var chooseIndex = new List<int>();
            Console.CursorTop = topNum;

            bool flag = true;
            while (flag)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > topNum)
                        {
                            Console.CursorTop--;
                            currentIndex--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < bottomNum - 1)
                        {
                            Console.CursorTop++;
                            currentIndex++;
                        }
                        break;

                    case ConsoleKey.Spacebar:

                        if (chooseIndex.Contains(currentIndex))
                        {
                            chooseIndex.Remove(currentIndex);
                            Console.Write("[ ");
                            Console.CursorLeft = 0;
                        }
                        else
                        {
                            chooseIndex.Add(currentIndex);
                            Console.Write("[*");
                            Console.CursorLeft = 0;
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
