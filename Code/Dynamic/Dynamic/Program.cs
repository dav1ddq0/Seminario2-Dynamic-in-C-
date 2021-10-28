using System;
using System.Collections.Generic;
namespace Dynamic {
    class Program {
        static void Main(string[] args) {
            var p1 = Factory.New.Person;
            p1.FirstName = "Peter"; p1.LastName = "Johnson";

            var p2 = Factory.New.Person;
            p2["FirstName"] = "Jonathan";
            p2["LastName"] = "Mendelsohn";
            
            var p3 = Factory.New.Person.FirstName("Juana").LastName("De Arco");
            
            Console.WriteLine($"FirstName: {p1.FirstName} LastName: {p1.LastName}");
            Console.WriteLine($"FirstName: {p2.FirstName} LastName: {p2.LastName}");
            Console.WriteLine($"FirstName: {p3.FirstName} LastName: {p3.LastName}");

            var p4 = Factory.New.Person(new Dictionary<string, string>(){ {"FirstName", "Peter"}, {"LastName", "Jackson"} });
            Console.WriteLine($"FirstName: {p4.FirstName} LastName: {p4.LastName}");


        }
    }
}