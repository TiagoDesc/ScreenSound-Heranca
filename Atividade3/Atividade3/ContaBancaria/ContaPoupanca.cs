namespace Atividade3.ContaBancaria;

internal class ContaPoupanca : ContaBancaria
{
    private double TaxaRendimento { get; set; }

    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + TaxaRendimento);
    }
}
