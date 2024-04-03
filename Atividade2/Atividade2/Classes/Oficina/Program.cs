namespace Atividade2.Classes.Oficina;

internal class Program
{
    static void Main()
    {
        Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
        Cliente cliente = new Cliente("Carlos", "987654321");
        Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
        Oficina oficina = new Oficina();

        oficina.AgendamentoDeServico(meuCarro, cliente, mecanico, "2023-12-18");
        oficina.RealizarServico(meuCarro, mecanico);
    }

}
