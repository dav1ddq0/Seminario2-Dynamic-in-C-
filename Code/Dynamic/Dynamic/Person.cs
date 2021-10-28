using System;
using System.Collections.Generic;

namespace Dynamic
{
    public static class PersonExt {
        public static Person FirstName(this Person p, string first_name) {
            p.FirstName = first_name;
            return p;
        }

        public static Person LastName(this Person p, string last_name) {
            p.LastName = last_name;
            return p;
        }
    }

    public class Person {
        public string FirstName{get;set;}
        public string LastName{get;set;}

        public Person() {}
        
        public Person(Dictionary<string, string> jsonLikeInput) {
            if (jsonLikeInput.ContainsKey("FirstName")) FirstName = jsonLikeInput["FirstName"];
            if (jsonLikeInput.ContainsKey("LastName")) LastName = jsonLikeInput["LastName"];
        }

        public string this[string prop]
        {
            get { 
                if (prop == "FirstName") return FirstName;
                else if (prop == "LastName") return LastName;
                throw new Exception("Invalid prop");
             }

            set { 
                if (prop == "FirstName") FirstName = value; 
                else if (prop == "LastName") LastName = value; 
                throw new Exception("Invalid prop");
             }
        }
    }
}