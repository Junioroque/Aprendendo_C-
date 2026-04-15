
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
            Console.WriteLine("Digite a placa do ve[iculo para estacionar: ");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digit a placa do veículo para remover: ");

            string placa = " ";

            //verifica se o veiculo existe
            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                //TODO: Pedir para o usuário digitar a quantidade de horas que  o veiculo ficou estacionado
                //TODO: Realizar o seguinte cálculo: "precoInicial + precoFinal * para variavel
                //IMPRIME AQUI
                int hora = 0;
                decimal valorTotal = 0;

                //TODO: Remover a placa digitada da lista de veiculos
                //IMPREMENTE AQUI
                Console.WriteLine($"O veiculo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
            }


        }

        public void ListarVeiculos()
        {
            //Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                //TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                //IMPRIME AQUI
            }else
            {
                Console.Write("Não há veículos estacionados.");
            }
             
        }
        
    }
}