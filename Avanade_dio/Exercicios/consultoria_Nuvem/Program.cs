using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê a entrada do usuário
        Console.WriteLine("Digite a quantidade: ");
        string entrada = Console.ReadLine();

        // TODO: Divida a entrada em partes
        string[] partes = entrada.Split(" ");
       
        // TODO: Implemente o primeiro elemento, que é o número de dias (interações)
        int numero = int.Parse(partes[0]);
    
        // TODO: Retorne a saída, ela deve ser a quantidade de interações seguida da palavra "interacoes"
        Console.WriteLine($"{numero} interacoes");  
    }
}