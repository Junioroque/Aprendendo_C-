using System; 

class Programa 
{
/* Entrada
A entrada deve receber uma string que representa o tipo de serviço que o cliente deseja: 
"basico", "intermediario", "avancado" ou "premium".

Saída
Deverá retornar uma string com a recomendação do plano: "Recomendado: plano basico", 
"Recomendado: plano intermediario" ou "Recomendado: plano avancado". 
Lembrando que o plano "premium", deverá ser indicado o plano avancado.*
*/
    static void Main() 
    {
        Console.WriteLine("Digite o seu plano: ");

        string entrada = Console.ReadLine(); 

        // TODO: Verifique se a entrada é igual a "basico"
        if(entrada == "basico"){
        // TODO: Se for, imprima a recomendação para o plano básico  
          Console.WriteLine("Recomendado: plano basico");
          
        }else if(entrada == "intermediario"){
        // TODO: Caso contrário, verifique se a entrada é igual a "intermediario" 
          Console.WriteLine("Recomendado: plano intermediario");
        
        // TODO: Se não for nenhum dos anteriores, verifique se é "avancado" ou "premium"
        }else if(entrada == "avancado" || entrada == "premium"){
          
          Console.WriteLine("Recomendado: plano avancado");  
        }
            
    }
}