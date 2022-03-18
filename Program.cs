using lab2.Entities;

public class Sistema
{
public static void Main(string[] args){

    List<Persona> listaPersonas = new List<Persona>();
    Persona alumno1 = new Alumno();
    ((Alumno)alumno1).Carne = "1012022";
    alumno1.Apellidos = "Lopez Ramirez";
    alumno1.Nombres = "Carlos Augusto";
    alumno1.Email = "carloslora@gmail.com";
    ((Alumno)alumno1).Creditos = 5;
    alumno1.TomarAsistencia();

    Persona profesor1 = new Profesor();
    ((Profesor)profesor1).Cui = "4018300490101";
    profesor1.Apellidos = "Cortez Gonzalez";
    profesor1.Nombres = "Juan Alberto";
    profesor1.Email = "cortezjuan@gmail.com";
    ((Profesor)profesor1).Cargo = "Maestro de Programacion";
    profesor1.TomarAsistencia();

    listaPersonas.Add(alumno1);
    listaPersonas.Add(profesor1);
    ImprimirInformacionGeneral(listaPersonas);

    static void ImprimirInformacionGeneral(List<Persona> personas)
    {
        Console.WriteLine($"Informacion General");
        foreach (Persona elemento in personas)
        {
            if (elemento is Alumno)
            {
                Console.WriteLine($"Datos: Carne {((Alumno)elemento).Carne}  / Apellidos: {elemento.Apellidos}  / Nombres: {elemento.Nombres}  / Creditos: {((Alumno)elemento).Creditos}");
                Console.WriteLine("Registro de Asistencia:");
                ((Alumno)elemento).TomarAsistencia();
            }
            else if (elemento is Profesor)
            {
                Console.WriteLine($"Datos: Cui  {((Profesor)elemento).Cui} / Apellidos  {elemento.Apellidos} / Nombres {elemento.Nombres} / Cargo {((Profesor)elemento).Cargo}");
                Console.WriteLine("Registro de Asistencia");
                ((Profesor)elemento).TomarAsistencia();
            }
        }
    }
    
}

}
