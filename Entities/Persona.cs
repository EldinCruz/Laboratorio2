using lab2.Interfaces;

namespace lab2.Entities
{
    public abstract class Persona
    {
        public string Uuid { get; set;}
        public string Apellidos {get; set;}
        public string Nombres {get; set;}
        public string Email {get; set;}

        public void TomarAsistencia()
        {
            Console.WriteLine($"Astiencia con carné");
        }


    }
}