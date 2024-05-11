namespace Atividade3.ProdutoEletronico;

internal class Tablet : ProdutoEletronico
{
    public int inch { get; set; }

    public override string InfoShow()
    {
        return $"{base.InfoShow()}, Inch: {inch}";
    }
}
