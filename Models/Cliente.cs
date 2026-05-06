namespace BarbeariaApp.Models
{
    public class Cliente : Pessoa
    {
        public int Id { get; set; }

        public Cliente(int id, string nome, string telefone)
            : base(nome, telefone)
        {
            Id = id;
        }
    }
}