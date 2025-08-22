
//Jheremy Siles - Liceo Oscar Bonilla A-26
public class Estudiante
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }

    public void Informacion()
    {
        Console.WriteLine($"Bienvenido: {Nombre} {Apellido}");
    }
}

//Clase principal del programa
public class Program
{
    public static void Main()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Jhon";
        estudiante1.Apellido = "Siles";
        estudiante1.Informacion();
        Estudiante estudiante2 = new Estudiante();
        estudiante2.Nombre = "Jhon";
        estudiante2.Apellido = "Siles";
        estudiante2.Informacion();

        Auto auto1 = new Auto();
        auto1.Color = "Rojo"
        auto1.Marca = "Ford";
        auto1.Frenar();
    }
}
public class Auto
{
    public string? Color { get; set; }
    public string? Marca { get; set; }

    public void Frenar()
    {
        Console.WriteLine($"Su auto acaba de frenar");
        Console.WriteLine($"{Marca} - {Color} ");
    }
}