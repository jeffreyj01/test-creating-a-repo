using HelloWorldLibrary;
using System;

namespace HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass hello = new MainClass();
            Console.WriteLine(hello.HelloWorld());
            Console.ReadLine();
        }
    }
}
