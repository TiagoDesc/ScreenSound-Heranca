using System.Transactions;

namespace Atividade3.FormasGeometricas;

internal class Circle : Shape
{
    public double Radius { get; set; }

    public override double AreaCalculator()
    {
        return Math.PI * Radius * Radius;
    }

    public override double PerimeterCalculator()
    {
        return 2 * Math.PI * Radius;
    }
}
