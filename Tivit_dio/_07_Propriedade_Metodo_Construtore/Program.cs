using System.Runtime.CompilerServices;
using _07_Propriedade_Metodo_Construtore.Models;

Pessoa p1 = new Pessoa(nome: "Junio", sobrenome: "Cunha");//Se quiser passar parametros para identificar é tem que ser exatamente o que está na classe.
p1.Idade = 43;

Pessoa p2 = new Pessoa("Cezar", "Souza");
p2.Idade = 33;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();

Console.WriteLine(" ");
//Concatenação de string vai juntar 2 texto
string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);