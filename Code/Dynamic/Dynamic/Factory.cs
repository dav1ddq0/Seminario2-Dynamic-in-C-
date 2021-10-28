using System.Collections.Generic;

namespace Dynamic
{
    //Interfaces

    // public interface IFactoryPersonFirstName {
    //     IFactoryPersonLastName FirstName (string first_name);
    // }

    // public interface IFactoryPersonLastName {
    //     Person LastName (string last_name);
    // }
    public static class FactoryExt {
        public static Person Person(this Factory f, Dictionary<string, string> jsonLikeInput) {
            return new Person(jsonLikeInput);
        }
    }

    public class Factory {
        // Person _person;
        public static Factory New { get { return new Factory(); } }
        
        public Person Person { get { return new Person(); } } 

        // public IFactoryPersonLastName FirstName (string first_name) {
        //     _person.FirstName = first_name;
        //     return this;
        // }

        // public Person LastName (string last_name) {
        //     _person.LastName = last_name;
        //     return _person;
        // }
    }
}