public class Libro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public string Autor { get; set; } = "";
    public int Stock { get; set; }
}

public class Socio
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
}

public class Prestamo
{
    public int IdLibro { get; set; }
    public int IdSocio { get; set; }
    public DateTime Fecha { get; set; }
    public bool Devuelto { get; set; }
}

public static class Datos
{
    public static List<Libro> Libros = new List<Libro>();
    public static List<Socio> Socios = new List<Socio>();
    public static List<Prestamo> Prestamos = new List<Prestamo>();

    public static void CargarEjemplo()
    {
        Libros.Add(new Libro { Id = 1, Titulo = "Cien anos de soledad", Autor = "Garcia Marquez", Stock = 3 });
        Libros.Add(new Libro { Id = 2, Titulo = "El Principito", Autor = "Saint-Exupery", Stock = 2 });
        Socios.Add(new Socio { Id = 1, Nombre = "Ana Perez" });
        Socios.Add(new Socio { Id = 2, Nombre = "Luis Gomez" });
    }
}
