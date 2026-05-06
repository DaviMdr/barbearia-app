namespace BarbeariaApp.Models
{
    public class Barbeiro : Pessoa
    {
        public int Id { get; set; }

        public Barbeiro(int id, string nome, string telefone)
            : base(nome, telefone)
        {
            Id = id;
        }
    }
}