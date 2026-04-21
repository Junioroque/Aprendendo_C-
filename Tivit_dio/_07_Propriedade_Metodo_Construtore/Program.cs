using System.Runtime.CompilerServices;
using _07_Propriedade_Metodo_Construtore.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Junio";
p1.Sobrenome = "Cunha";
p1.Idade = 43;

Pessoa p2 = new Pessoa();

p2.Nome = "Cezar";
p2.Sobrenome = "Souza";
p2.Idade = 33;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAluno();