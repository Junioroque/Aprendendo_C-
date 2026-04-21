using System;

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      // TODO: Solicite ao usuário que digite o nome do teste:
      Console.WriteLine("Digite o teste: ");
      string teste = Console.ReadLine();

      // TODO: Solicite ao usuário que digite a descrição do erro:
      Console.WriteLine("Digite o error do teste: ");
      string descricaoDoErro = Console.ReadLine();

      // Se o teste falhar, exibe a descrição do erro:
      Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");
    }
  }
}