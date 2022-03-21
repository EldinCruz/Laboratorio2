using lab2.Interfaces;

namespace lab2.Entities;
    public class Alumno : Persona, IOperaciones

    {
        public string Carne { get; set; }
        public int Creditos { get; set; }
        public Alumno() : base ()
        {
            
        }

        public Alumno (string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
            : base (uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.Creditos = numeroCreditos;
        }

        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de:  {this.Apellidos} {this.Nombres}, Perdera la cantidad de: {this.Creditos} Creditos");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.Uuid} {this.Apellidos} {this.Nombres} {this.Creditos} ");

        }
        public override void TomarAsistencia()
        {
            Console.WriteLine($"Tomando Asistencia de: {this.Apellidos} {this.Nombres}");
        }
    
}