namespace SimpleConsoleApp
{
    using Newtonsoft.Json;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out");
            var result = JsonConvert.SerializeObject(new object[] { });
        }
    }
}
