namespace BarbeariaApp.Services
{
    public class Barba : IServico
    {
        public string Nome => "Barba";

        public double CalcularPreco()
        {
            return 30.0;
        }
    }
}