public static class GestionLibros
{
    // Pide los datos de un libro y lo agrega a la lista
    public static void Registrar()
    {
        Console.WriteLine("--- REGISTRAR LIBRO ---");
        string titulo = Utilidades.LeerTexto("Titulo: ");
        string autor = Utilidades.LeerTexto("Autor: ");
        int stock = Utilidades.LeerEntero("Stock (1-100): ", 1, 100);

        Libro nuevo = new Libro
        {
            Id = Datos.Libros.Count + 1,
            Titulo = titulo,
            Autor = autor,
            Stock = stock
        };
        Datos.Libros.Add(nuevo);

        Console.WriteLine();
        Console.WriteLine($"Libro registrado con ID {nuevo.Id}: {nuevo.Titulo} ({nuevo.Stock} copias)");
    }
// Muestra todos los libros en formato de tabla
    public static void Listar()
    {
        Console.WriteLine("--- LISTA DE LIBROS ---");

        if (Datos.Libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        Console.WriteLine("{0,-5}{1,-30}{2,-20}{3,6}", "ID", "Titulo", "Autor", "Stock");
        Console.WriteLine(new string('-', 61));
        for (int i = 0; i < Datos.Libros.Count; i++)
        {
            Libro l = Datos.Libros[i];
            Console.WriteLine("{0,-5}{1,-30}{2,-20}{3,6}", l.Id, l.Titulo, l.Autor, l.Stock);
        }

        Console.WriteLine();
        Console.WriteLine($"Total de libros: {Datos.Libros.Count}");
    }
// Recibe un id y devuelve el libro, o null si no existedotnet build
    public static Libro? BuscarPorId(int id)
    {
        for (int i = 0; i < Datos.Libros.Count; i++)
        {
            if (Datos.Libros[i].Id == id)
            {
                return Datos.Libros[i];
            }
        }
        return null;
    }
}