namespace Atividade3.FormasGeometricas;

internal class Square : Shape
{
    public double Side {  get; set; }
    public override double AreaCalculator()
    {
        return Side * Side;
    }

    public override double PerimeterCalculator()
    {
        return 4 * Side;
    }
}
