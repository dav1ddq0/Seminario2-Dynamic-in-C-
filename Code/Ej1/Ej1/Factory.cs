namespace Ej1
{
    public class Factory{
        
        public static BuildPerson New{
            get{
                return new BuildPerson();
            }
        }
    }
}