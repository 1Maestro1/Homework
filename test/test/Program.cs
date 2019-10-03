using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            Console.WriteLine(helloWorld.World());
            Console.WriteLine(new HelloWorld().World());
            Console.WriteLine($"World {helloWorld.World()}");
            string @string = "Hello " + "World!!!";
            Console.WriteLine(@string);
            Console.ReadKey();
        }
    }
}
