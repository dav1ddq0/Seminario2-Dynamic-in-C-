namespace Ej1
{
    public  static class ExtendPerson
    {
        public static Person FirstName(this Person person, string name)
        {
            person.FirstName = name;
            return person;
        }

        public static Person LastName(this Person person, string name)
        {
            person.LastName = name;
            return person;
        }
        
    }
}