using lab2.Interfaces;

namespace lab2.Entities
{
    public class Alumno : Persona, IOperaciones

    {
        public string Carne { get; set; }
        public int Creditos { get; set; }

        public void TomarAsitencia()
        {
            Console.WriteLine($"Asistencia con Carne {this.Carne}");
        }
    }
}