using lab2.Interfaces;

namespace lab2.Entities
{
    public class Profesor : Persona, IOperaciones
    {
       
        public string Cui { get; set;}
        public string Cargo { get; set;}


        public Profesor() : base()
        {

        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
        : base (uuid, apellidos, nombres, email)
        {
            this.Cui = cui;
            this.Cargo = cargo;

        }

        public bool EliminarAsignatura (string Asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de: {this.Apellidos} {this.Nombres} la asignatura de: {this.Cargo}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.Uuid} {this.Apellidos} {this.Nombres} {this.Cargo}");
        }
        public override  void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia de: {this.Apellidos} {this.Nombres}");
        }
    }
}