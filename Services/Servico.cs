namespace BarbeariaApp.Services
{
    public interface IServico
    {
        string Nome { get; }
        double CalcularPreco();
    }
}