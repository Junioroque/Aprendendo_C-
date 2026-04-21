using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {

/*Críterios da taxa:
Taxa de Sucesso = (Número de Testes Automatizados Bem-sucedidos 
/ Número Total de Testes Automatizados Realizados) * 100
*/
    static void Main(string[] args) {
      // Solicita ao usuário a entrada para o número de testes passados
      int testesPassados = Convert.ToInt32(Console.ReadLine());

      // Solicita ao usuário a entrada para o número total de testes
      int totalTestes = Convert.ToInt32(Console.ReadLine());

      // TODO: Calcule a taxa de sucesso e armazená-la na variável taxaSucesso:
      float taxaSucesso = ((float)testesPassados / (float)totalTestes) * 100f; 

      // Exibe a taxa de sucesso com 2 casas decimais
      Console.WriteLine($"Taxa de sucesso: {taxaSucesso:F2}%");
    }
  }
}