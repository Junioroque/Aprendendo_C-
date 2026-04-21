using System.Runtime.CompilerServices;
using _07_Propriedade_Metodo_Construtore.Models;

Pessoa p1 = new Pessoa("Junio", "Cunha");
p1.Idade = 43;

Pessoa p2 = new Pessoa("Cezar", "Souza");
p2.Idade = 33;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();