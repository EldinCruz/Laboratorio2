using lab2.Interfaces;

namespace lab2.Entities
{
    public abstract class Persona
    {
        public string Uuid { get; set;}
        public string Apellidos {get; set;}
        public string Nombres {get; set;}
        public string Email {get; set;}

        public Persona (string Uuid, string Apellidos, string Nombres, string Email)
        {
            this.Uuid = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }


    }
}