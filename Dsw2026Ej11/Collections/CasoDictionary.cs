using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> diccionario = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        diccionario[legajo] = alumno;
    }

    public Alumno? BuscarPorLegajo(int legajo)
    {
        diccionario.TryGetValue(legajo, out var alumno);
        return alumno;
    }
    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return diccionario;
    }

    public void EliminarAlumno(int legajo)
    {
        diccionario.Remove(legajo);
    }
}
