using Atividade3.FormasGeometricas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Square: ");
        int side = int.Parse(Console.ReadLine()!);
        Square square = new Square {Side = side};
        Console.WriteLine($"Área {square.AreaCalculator()}");
    }
}