using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Factory.New().Person().FirstName("Juana").LastName("De Arco");
            Console.WriteLine($"FirstName: {p1.FirstName} LastName: {p1.LastName}");
        }
    }
}