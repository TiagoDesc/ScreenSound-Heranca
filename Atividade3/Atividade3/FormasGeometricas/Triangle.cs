namespace Atividade3.FormasGeometricas;

internal class Triangle : Shape
{
    public double Bases {  get; set; }
    public double Height {  get; set; }

    public override double AreaCalculator()
    {
        return Bases * Height / 2;
    }

    public override double PerimeterCalculator()
    {
        return Bases + Height + Math.Sqrt(Bases * Bases + Height * Height);
    }
}
