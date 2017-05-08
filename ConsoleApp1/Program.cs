
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
            var chooseIndex = ConsoleHelper.SingleOptions("Please choose the right one", options);
            Console.WriteLine("Your choose is:" + options[chooseIndex]);

            Console.WriteLine();

            string[] options1 = { "111", "222", "333", "444", "555" };
            var chooseItems = ConsoleHelper.MultipleOptions("Please choose the right one with space", options1);
            foreach (var item in chooseItems)
            {
                Console.WriteLine("Your choose are:" + options1[item]);
            }

            Console.WriteLine();

            var intInput = ConsoleHelper.InputInt("Please input a int num:");
            Console.WriteLine("Your input num is:"+intInput);


            Console.WriteLine();
            Console.WriteLine("Press any key to stop!");
            Console.ReadLine();


        }

    }
}
