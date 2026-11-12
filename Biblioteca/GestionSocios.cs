public static class GestionSocios
{
    public static void Registrar()
    {
        Console.WriteLine("--- REGISTRAR SOCIO ---");
        string nombre = Utilidades.LeerTexto("Nombre del socio: ");

        if (ExisteNombre(nombre))
        {
            Console.WriteLine("Ya existe un socio con ese nombre. No se registro.");
            return;
        }

        Socio nuevo = new Socio();
        nuevo.Id = Datos.Socios.Count + 1;
        nuevo.Nombre = nombre;
        Datos.Socios.Add(nuevo);

        Console.WriteLine($"Socio registrado: ID {nuevo.Id} - {nuevo.Nombre}");
    }

    public static Socio? BuscarPorId(int id)
    {
        for (int i = 0; i < Datos.Socios.Count; i++)
        {
            if (Datos.Socios[i].Id == id)
            {
                return Datos.Socios[i];
            }
        }
        return null;
    }

    public static bool ExisteNombre(string nombre)
    {
        for (int i = 0; i < Datos.Socios.Count; i++)
        {
            if (Datos.Socios[i].Nombre.ToLower() == nombre.ToLower())
            {
                return true;
            }
        }
        return false;
    }
}