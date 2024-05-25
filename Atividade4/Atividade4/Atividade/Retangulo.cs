using System.Transactions;

namespace Atividade4.Atividade;

internal class Retangulo : IForma
{
    public double Comprimento { get; set; }
    public double Largura { get; set; }

    public double CalcularArea()
    {
        return Comprimento * Largura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Comprimento + Largura);
    }
}
