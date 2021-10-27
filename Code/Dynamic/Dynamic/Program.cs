using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Factory.New().Person().FirstName("Juana").LastName("De Arco");
            var p2 = Factory.New().Person().FirstName("Ana").LastName("De Armas");

            var p3 = Factory.New().Person();
            // p3.firstName = "Louis";
            // p3.lastName = "Dejardin";

            Console.WriteLine($"FirstName: {p1.firstName} LastName: {p1.lastName}");
            Console.WriteLine($"FirstName: {p2.firstName} LastName: {p2.lastName}");
        }
    }
}