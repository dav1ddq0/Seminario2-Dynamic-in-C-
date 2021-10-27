namespace Dynamic
{
    //Interfaces

    public interface IFactoryPerson {
        IFactoryPersonFirstName Person ();
    }

    public interface IFactoryPersonFirstName {
        IFactoryPersonLastName FirstName (string first_name);
    }

    public interface IFactoryPersonLastName {
        Person LastName (string last_name);
    }

    public class Factory : IFactoryPerson, IFactoryPersonFirstName, IFactoryPersonLastName {
        Person _person;

        public Factory() {}
        
        public static Factory New() => new Factory();

        public IFactoryPersonFirstName Person () {
            _person = new Person();
            return this;
        }

        public IFactoryPersonLastName FirstName (string first_name) {
            _person.FirstName = first_name;
            return this;
        }

        public Person LastName (string last_name) {
            _person.LastName = last_name;
            return _person;
        }
    }
}