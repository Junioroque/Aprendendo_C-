using System;

namespace AnaliseDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a quantidade de testes bem-sucedidos:
      int testesBemSucedidos = int.Parse(Console.ReadLine());

      // Solicita ao usuário a quantidade de testes totais:
      int testesTotais = int.Parse(Console.ReadLine());

      // TODO: Implemente as condições para o cálculo da taxa de sucesso:
      //fórmula: taxaSucesso = (double)testesBemSucedidos / testesTotais.
      double taxaSucesso = ((double)testesBemSucedidos / (double)testesTotais) * 100;

      // TODO: Implemente uma estrutura condicional (if/else) para avaliar a taxa de sucesso e tomar decisões com base nela:
      // Se a taxa de sucesso for maior ou igual a 80%, o programa exibirá a mensagem "A funcionalidade esta pronta para lancamento."
      // Caso contrário, se a taxa de sucesso for menor que 80%, o programa exibirá a mensagem "A funcionalidade nao esta pronta para lancamento."
      if(taxaSucesso >= 80)
      {
         Console.WriteLine("A funcionalidade esta pronta para lancamento.");
      }
      else
      {
         Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");
      }
    }
  }
}