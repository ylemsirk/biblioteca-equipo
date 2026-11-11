class Program
{
    static void Main()
    {
        Datos.CargarEjemplo();
        int opcion;

        do
        {
            MostrarMenu();
            opcion = Utilidades.LeerEntero("Elige una opcion: ", 0, 6);
            Console.WriteLine();

            switch (opcion)
            {
                case 1: GestionLibros.Registrar(); break;
                case 2: GestionLibros.Listar(); break;
                case 3: GestionSocios.Registrar(); break;
                case 4: GestionPrestamos.Prestar(); break;
                case 5: GestionPrestamos.Devolver(); break;
                case 6: Reportes.Mostrar(); break;
                case 0: Console.WriteLine("Hasta luego!"); break;
            }

            if (opcion != 0) Utilidades.Pausa();

        } while (opcion != 0);
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("        SISTEMA DE BIBLIOTECA        ");
        Console.WriteLine("=====================================");
        Console.WriteLine(" 1. Registrar libro");
        Console.WriteLine(" 2. Listar libros");
        Console.WriteLine(" 3. Registrar socio");
        Console.WriteLine(" 4. Prestar libro");
        Console.WriteLine(" 5. Devolver libro");
        Console.WriteLine(" 6. Reporte de prestamos");
        Console.WriteLine(" 0. Salir");
        Console.WriteLine("-------------------------------------");
    }
}
