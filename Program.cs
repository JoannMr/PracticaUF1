class Program
{
    static void Main()
    {
        Console.WriteLine("Hola, este es mi humilde programa en C#");

        MostrarMensajePersonalizado();

        Console.WriteLine("¿Cuál es tu nombre?");
        string nombreUsuario = Console.ReadLine();

        SaludarUsuario(nombreUsuario);
    }

    static void MostrarMensajePersonalizado()
    {
        Console.WriteLine("Este programa necesita tus datos.");
    }

    static void SaludarUsuario(string nombre)
    {
        Console.WriteLine($"¡Hola, {nombre}! Bienvenido al programa.");
    }
}
