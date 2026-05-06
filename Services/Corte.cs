namespace BarbeariaApp.Services
{
    public class Corte : IServico
    {
        public string Nome => "Corte de Cabelo";

        public double CalcularPreco()
        {
            return 50.0;
        }
    }
}