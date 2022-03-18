using lab2.Interfaces;

namespace lab2.Entities
{
    public class Profesor: Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }


        public void TomarAsitencia()
        {
            Console.WriteLine($"Tomar asistencia {this.Cui}");
        }
    }
}