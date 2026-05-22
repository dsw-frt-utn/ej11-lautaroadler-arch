using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var a1 = new Alumno(1, "Lautaro", 8);
        var a2 = new Alumno(2, "Joaquin", 7);
        var a3 = new Alumno(3, "Lisandro", 9);

        var caso = new CasoList();
        caso.AgregarAlumno(a1);
        caso.AgregarAlumno(a2);
        caso.AgregarAlumno(a3);

        caso.RetornarLista().ForEach(a => Console.WriteLine(a));

        var encontrado = caso.BuscarPorNombre("Lautaro");
        Console.WriteLine(encontrado!= null? encontrado.ToString() : "No Existe");

        var noExiste = caso.BuscarPorNombre("Felipe");
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        caso.EliminarAlumno(a2);
        caso.RetornarLista().ForEach(a=>  Console.WriteLine(a));

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var caso = new CasoDictionary();

        caso.AgregarAlumno(1, new Alumno(1, "Lautaro", 8));
        caso.AgregarAlumno(1, new Alumno(2, "Joaquin", 7));
        caso.AgregarAlumno(1, new Alumno(3, "Lisandro", 9));

        foreach (var par in caso.RetornarDiccionario())
            Console.WriteLine($"Legajo: {par.Key} - {par.Value.Nombre}");

        var encontrado = caso.BuscarPorLegajo(2);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        var noExiste = caso.BuscarPorLegajo(99);
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        caso.EliminarAlumno(2);
        foreach (var par in caso.RetornarDiccionario())
            Console.WriteLine($"Legajo: {par.Key} - {par.Value}");



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var caso = new CasoLinq();

        Console.WriteLine("Primero: " + caso.GetPrimero());
        Console.WriteLine("Último: " + caso.GetUltimo());
        Console.WriteLine("Total precios: " + $"{caso.GetTotalPrecios():C}");
        Console.WriteLine("\nLibros con Id > 15:");
        caso.GetListById().ForEach(l => Console.WriteLine(l));
        Console.WriteLine("\nTítulo y precio formateado:");

        foreach (var libro in Libro.CrearLista())
            caso.AgregarLibro(libro);
        Console.WriteLine("\nMayor precio: " + caso.GetMayorPrecio());
        Console.WriteLine("Menor precio: " + caso.GetMenorPrecio());
        Console.WriteLine("\nLibros sobre el promedio:");
        caso.GetMayorPromedio().ForEach(l => Console.WriteLine(l));
        Console.WriteLine("\nOrdenados por título descendente:");
        caso.GetOrdenadosPorTitulo().ForEach(l => Console.WriteLine(l));

    }

}

