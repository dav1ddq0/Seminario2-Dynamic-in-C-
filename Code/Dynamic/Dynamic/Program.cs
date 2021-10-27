using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Persona().FirstName("Ana").LastName("De Armas");
            var p2 = new Persona().FirstName("Juana").LastName("De Arco");
            Console.WriteLine($"FirstName: {p1.firstName} LastName: {p1.lastName}");
            Console.WriteLine($"FirstName: {p2.firstName} LastName: {p2.lastName}");
            
            
        }
    }
}