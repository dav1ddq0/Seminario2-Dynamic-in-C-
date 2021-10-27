namespace Dynamic
{
    public class Persona
    {

        public string firstName{get;set;}
        public string lastName{get;set;}
        public Persona FirstName(string firstName){
            
            this.firstName = firstName;
            return this;
        }

        public Persona LastName(string lastName){
            this.lastName = lastName;
            return this;
        }
    }
}