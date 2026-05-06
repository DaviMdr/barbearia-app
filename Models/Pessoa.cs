namespace BarbeariaApp.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}
