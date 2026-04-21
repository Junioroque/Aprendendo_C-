using System.Runtime.CompilerServices;
using _07_Propriedade_Metodo_Construtore.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Junio";
p1.Idade = 43;

p1.Apresentar();

Console.WriteLine("");
p1.Nome = "Carla";
p1.Idade = 29;



p1.Apresentar();

p1.Nome = "Cezar";
p1.Sobrenome = "Souza";
p1.Idade = 33;
p1.Apresentar();