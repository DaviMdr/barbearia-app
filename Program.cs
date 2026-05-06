using BarbeariaApp.Models;
using BarbeariaApp.Services;

class Program
{
    static List<Cliente> clientes = new();
    static List<Barbeiro> barbeiros = new();
    static List<Agendamento> agendamentos = new();

    static int idCliente = 1;
    static int idBarbeiro = 1;

    static void Main()
    {
        // barbeiros fixos
        barbeiros.Add(new Barbeiro(idBarbeiro++, "Matheus", "1111-1111"));
        barbeiros.Add(new Barbeiro(idBarbeiro++, "Juan", "2222-2222"));

        int opcao;

        do
        {
            Console.WriteLine("\n=== BARBEARIA ===");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Criar Agendamento");
            Console.WriteLine("3 - Listar Agendamentos");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    CriarAgendamento();
                    break;
                case 3:
                    ListarAgendamentos();
                    break;
            }

        } while (opcao != 0);
    }

    static void CadastrarCliente()
    {
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido.");
            return;
        }

        Console.Write("Telefone: ");
        string? telefone = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(telefone))
        {
            Console.WriteLine("Telefone inválido.");
            return;
        }

        clientes.Add(new Cliente(idCliente++, nome, telefone));

        Console.WriteLine("Cliente cadastrado!");
    }

    static void CriarAgendamento()
    {
        if (clientes.Count == 0)
        {
            Console.WriteLine("Cadastre um cliente primeiro.");
            return;
        }

        Console.WriteLine("\nClientes:");
        foreach (var c in clientes)
        {
            Console.WriteLine($"{c.Id} - {c.Nome}");
        }

        Console.Write("ID do cliente: ");
        if (!int.TryParse(Console.ReadLine(), out int idClienteEscolhido))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        Cliente? cliente = clientes.Find(c => c.Id == idClienteEscolhido);

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado.");
            return;
        }

        Console.WriteLine("\nBarbeiros:");
        foreach (var b in barbeiros)
        {
            Console.WriteLine($"{b.Id} - {b.Nome}");
        }

        Console.Write("ID do barbeiro: ");
        if (!int.TryParse(Console.ReadLine(), out int idBarb))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        Barbeiro? barbeiro = barbeiros.Find(b => b.Id == idBarb);

        if (barbeiro == null)
        {
            Console.WriteLine("Barbeiro não encontrado.");
            return;
        }

        Console.WriteLine("\nServiços:");
        Console.WriteLine("1 - Corte");
        Console.WriteLine("2 - Barba");

        Console.Write("Escolha: ");
        if (!int.TryParse(Console.ReadLine(), out int op))
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        IServico? servico = op switch
        {
            1 => new Corte(),
            2 => new Barba(),
            _ => null
        };

        if (servico == null)
        {
            Console.WriteLine("Serviço inválido.");
            return;
        }

        Console.Write("Data (ex: 22/04/2026 14:00): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            Console.WriteLine("Data inválida.");
            return;
        }

        agendamentos.Add(new Agendamento(cliente, barbeiro, servico, data.ToString("dd/MM/yyyy HH:mm")));

        Console.WriteLine("Agendamento criado!");
    }

    static void ListarAgendamentos()
    {
        if (agendamentos.Count == 0)
        {
            Console.WriteLine("Nenhum agendamento encontrado.");
            return;
        }

        foreach (var ag in agendamentos)
        {
            ag.ExibirResumo();
        }
    }
}