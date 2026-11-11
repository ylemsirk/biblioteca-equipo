public static class Utilidades
{
  
    public static int LeerEntero(string mensaje, int min, int max)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
        {
            Console.Write($"  Dato invalido (entre {min} y {max}). Intenta de nuevo: ");
        }
        return valor;
    }

    public static string LeerTexto(string mensaje)
    {
        string? texto;
        do
        {
            Console.Write(mensaje);
            texto = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(texto));
        return texto.Trim();
    }

    public static void Pausa()
    {
        Console.WriteLine();
        Console.Write("Presiona ENTER para continuar...");
        Console.ReadLine();
    }
}
