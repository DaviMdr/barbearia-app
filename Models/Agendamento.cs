using BarbeariaApp.Services;

namespace BarbeariaApp.Models
{
    public class Agendamento
    {
        public Cliente Cliente { get; set; }
        public Barbeiro Barbeiro { get; set; }
        public IServico Servico { get; set; }
        public string Data { get; set; }

        public Agendamento(Cliente cliente, Barbeiro barbeiro, IServico servico, string data)
        {
            Cliente = cliente;
            Barbeiro = barbeiro;
            Servico = servico;
            Data = data;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("\n--- Agendamento ---");
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"Barbeiro: {Barbeiro.Nome}");
            Console.WriteLine($"Serviço: {Servico.Nome}");
            Console.WriteLine($"Data: {Data}");
            Console.WriteLine($"Preço: R${Servico.CalcularPreco()}");
        }
    }
}