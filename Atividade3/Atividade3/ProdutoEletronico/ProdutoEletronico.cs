namespace Atividade3.ProdutoEletronico;

internal class ProdutoEletronico
{
    public string Model { get; set; }
    public double Price { get; set; }

    public virtual string InfoShow ()
    {
         return $"Modelo: {Model}, Price: {Price:C}";
    }
}
