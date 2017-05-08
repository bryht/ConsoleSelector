using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSelector
{
     class ConsoleHelper
    {

        public static string InputString(string title) {
            Console.WriteLine(title);
            var result = Console.ReadLine();
            return result;
        }

        public static int InputInt(string title) {
            var result = 0;
            var readStr = string.Empty;
            var flag = true;
            while (flag)
            {
                Console.WriteLine(title);
                readStr = Console.ReadLine();
                if (Int32.TryParse(readStr, out result))
                {
                    flag = false;
                }
            }

            return result;
        }

        public static bool InputBool(string title) {
            Console.WriteLine(title);
            var result = Console.ReadKey();
            switch (result.Key)
            {
                case ConsoleKey.Y:
                    return true;
                default:
                    return false;
            }
        }

        public static int SingleOptions(string title, string[] options)
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

        public static List<int> MultipleOptions(string title, string[] options)
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
