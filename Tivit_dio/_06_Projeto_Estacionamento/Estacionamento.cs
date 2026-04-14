
namespace _06_Projeto_Estacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial =0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("OI");
        }

        public void RemoverVeiculo()
        {
            Console.Write("OI oi");
        }

        public void ListarVeiculos()
        {
             Console.Write("OI  oi oi");
        }
        
    }
}