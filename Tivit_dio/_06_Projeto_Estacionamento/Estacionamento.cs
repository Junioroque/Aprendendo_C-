
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
            //TODO: Pedir  para o usúario digitar uma placa (ReadLine) e adicionar na lista "veículos"
            //IMPRIME AQUI
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine()?? "";
            veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");

            string placa = Console.ReadLine()!;
           

            //verifica se o veiculo existe
            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                //TODO: Pedir para o usuário digitar a quantidade de horas que  o veiculo ficou estacionado
                //TODO: Realizar o seguinte cálculo: "precoInicial + precoFinal * para variavel
                //IMPRIME AQUI
                int hora = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * hora);

                //TODO: Remover a placa digitada da lista de veiculos
                //IMPREMENTE AQUI
                 veiculos.Remove(placa);
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
                for(int i = 0; i < veiculos.Count; i++)
                {
                     Console.WriteLine($"{i + 1} - {veiculos[i]}");
                }
            }else
            {
                Console.Write("Não há veículos estacionados.");
            }
             
        }
        
    }
}