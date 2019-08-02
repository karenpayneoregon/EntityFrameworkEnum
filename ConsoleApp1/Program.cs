using System;
using EnumGeneratorLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ops = new Generator();
            var results = ops.Create(".\\SQLEXPRESS", 
                "NorthWindAzureForInserts", 
                "Categories", 
                "CategoryID", 
                "CategoryName");

            Console.WriteLine(results);
            Console.ReadLine();

        }
    }
}
