using System;
using System.Collections.Generic;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accediendo directamente a los atributos
            var p1 = Factory.New.Person;
            p1.FirstName = "David";
            p1.LastName = "De Quesada";
            // Accediendo a los atributos en forma de diccionario
            var p2 = Factory.New.Person;
            p2["FirstName"] = "Louis";
            p2["LastName"] = "Dejardin";


            // Inicializando mediante una "fluent interface"
            var p3 = Factory.New.Person.FirstName("Leonardo").LastName("Da Vinci");
            // Con notación similar a JSON
            var p4 = Factory.New.Person(new Dictionary<string, string>(){{"FirstName", "Peter"}, {"LastName", "Jackson"} });
            
            System.Console.WriteLine(p1.ToString());
            System.Console.WriteLine(p2.ToString());
            System.Console.WriteLine(p3.ToString());
            System.Console.WriteLine(p4.ToString());
        }
    }
}