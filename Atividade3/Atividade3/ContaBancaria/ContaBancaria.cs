namespace Atividade3.ContaBancaria;

internal class ContaBancaria
{
    protected double Saldo {  get; set; }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
    }

    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}
