namespace Atividade3.ProdutoEletronico;

internal class SmartPhone : ProdutoEletronico
{
    public string OperacionalSystem { get; set; }

    public override string InfoShow()
    {
        return $"{base.InfoShow()}, OS: {OperacionalSystem}";
    }
}
