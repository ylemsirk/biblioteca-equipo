public static class GestionPrestamos
{
    // METODO 1: PRESTAR LIBRO
    public static void Prestar()
    {
        Console.WriteLine("===== PRESTAR LIBRO =====");

        // Comprobar que existan libros y socios
        if (Datos.Libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        if (Datos.Socios.Count == 0)
        {
            Console.WriteLine("No hay socios registrados.");
            return;
        }

        // Solicitar ID del libro
        int idLibro = Utilidades.LeerEntero(
            "Ingrese el ID del libro: ", 1, Datos.Libros.Count);

        // Buscar el libro
        Libro? libro = GestionLibros.BuscarPorId(idLibro);

        if (libro == null)
        {
            Console.WriteLine("El libro no existe.");
            return;
        }

        // Comprobar disponibilidad
        if (libro.Stock <= 0)
        {
            Console.WriteLine("No hay ejemplares disponibles.");
            return;
        }

        // Solicitar ID del socio
        int idSocio = Utilidades.LeerEntero(
            "Ingrese el ID del socio: ", 1, Datos.Socios.Count);

        Socio? socio = GestionSocios.BuscarPorId(idSocio);

        if (socio == null)
        {
            Console.WriteLine("El socio no existe.");
            return;
        }

        // Crear el préstamo
        Prestamo nuevoPrestamo = new Prestamo
        {
            IdLibro = idLibro,
            IdSocio = idSocio,
            Fecha = DateTime.Now,
            Devuelto = false
        };

        // Guardar el préstamo
        Datos.Prestamos.Add(nuevoPrestamo);

        // Disminuir el stock
        libro.Stock--;

        Console.WriteLine();
        Console.WriteLine("¡Prestamo registrado correctamente!");
        Console.WriteLine($"Libro: {libro.Titulo}");
        Console.WriteLine($"Socio: {socio.Nombre}");
        Console.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy}");
        Console.WriteLine($"Stock restante: {libro.Stock}");
    }


    // METODO 2: DEVOLVER LIBRO
    public static void Devolver()
    {
        Console.WriteLine("===== DEVOLVER LIBRO =====");

        if (Datos.Prestamos.Count == 0)
        {
            Console.WriteLine("No existen prestamos registrados.");
            return;
        }

        if (Datos.Libros.Count == 0 || Datos.Socios.Count == 0)
        {
            Console.WriteLine("No hay libros o socios registrados.");
            return;
        }

        // Solicitar IDs
        int idLibro = Utilidades.LeerEntero(
            "Ingrese el ID del libro: ", 1, Datos.Libros.Count);

        int idSocio = Utilidades.LeerEntero(
            "Ingrese el ID del socio: ", 1, Datos.Socios.Count);

        // Buscar préstamo activo
        Prestamo? prestamoEncontrado = null;

        foreach (Prestamo prestamo in Datos.Prestamos)
        {
            if (prestamo.IdLibro == idLibro &&
                prestamo.IdSocio == idSocio &&
                prestamo.Devuelto == false)
            {
                prestamoEncontrado = prestamo;
                break;
            }
        }

        if (prestamoEncontrado == null)
        {
            Console.WriteLine("No se encontro un prestamo activo.");
            return;
        }

        // Marcar como devuelto
        prestamoEncontrado.Devuelto = true;

        // Recuperar el libro y aumentar el stock
        Libro? libro = GestionLibros.BuscarPorId(idLibro);

        if (libro != null)
        {
            libro.Stock++;

            Console.WriteLine();
            Console.WriteLine("¡Libro devuelto correctamente!");
            Console.WriteLine($"Libro: {libro.Titulo}");
            Console.WriteLine($"Stock actual: {libro.Stock}");
        }
    }


    // METODO 3: CONTAR PRESTAMOS ACTIVOS
    public static int ContarPrestamosActivos()
    {
        int contador = 0;

        foreach (Prestamo prestamo in Datos.Prestamos)
        {
            if (prestamo.Devuelto == false)
            {
                contador++;
            }
        }

        return contador;
    }
}