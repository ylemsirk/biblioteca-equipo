public static class GestionLibros
{
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
    }

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