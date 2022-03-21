using lab2.Entities;
using lab2.Interfaces;
public class Program
{
private static List<Persona> ListaGeneral = new List<Persona>();
public static void Main(string[] args){

    Alumno CarlosGonzales = new Alumno ("123", "Gonzales Pires", "Carlos Rodrigo", "cgonzales@gmail.com", "2022001",30);
    Profesor EdwinTumax = new Profesor ("505", "Tumax Colindres", "Edwin Ramiro", "etumax@gmail.com", "2344210490101", "Instructor de Informatica");
    
    OperarRegistro(CarlosGonzales);
    OperarRegistro(EdwinTumax);

    RegistrarAsistencia(CarlosGonzales);
    RegistrarAsistencia(EdwinTumax);

    VerMisDatos(CarlosGonzales);
    VerMisDatos(EdwinTumax);

    QuitarAsignatura(CarlosGonzales, "Matematica");
    QuitarAsignatura(EdwinTumax, "Informatica");


        
}

    public static void VerMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno) elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);

        }else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListarMisDatos(auxiliar.Cui);
        }
    }
    public static void RegistrarAsistencia(Persona elemento)
    {
        foreach(Persona registro in ListaGeneral)
        {
            if(registro.Uuid == elemento.Uuid)
             {
                 elemento.TomarAsistencia();
             }
        }
        
    }
    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }
    public static void OperarRegistro(Persona elemento)
    {
        ListaGeneral.Add(elemento);
    }
}
