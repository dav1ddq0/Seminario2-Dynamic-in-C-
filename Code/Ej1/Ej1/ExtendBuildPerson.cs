namespace Ej1
{
    public  static class ExtendBuildPerson
    {
        public static Person Person(this BuildPerson buildP, string FirstName, string LastName) {
            return new Person(FirstName, LastName);
        }


        
    }
}