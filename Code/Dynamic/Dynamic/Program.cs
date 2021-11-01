using System;

namespace Dynamic
{



    class Program
    {
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

            var p4 = Factory.New.Person(
                FirstName: "Tom",
                LastName: "Parker",
                Age: 15
            );

            Console.WriteLine($"FirstName: {p4.FirstName} LastName: {p4.LastName}");

            var p5 = Factory.New.Person(
                FirstName: "Louis",
                LastName: "Dejardin",
    
                Manager: 
                    Factory.New.Person(
                FirstName: "Bertrand",
                LastName: "Le Roy"
                )
            );
            var x = Factory.New.Int;
            
            Console.WriteLine($"FirstName: {p5.FirstName} LastName: {p5.LastName}");
            Console.WriteLine($"Manager FirstName: {p5.Manager.FirstName} Manager LastName: {p5.Manager.LastName}");
            System.Console.WriteLine(x);
        }
    }
}