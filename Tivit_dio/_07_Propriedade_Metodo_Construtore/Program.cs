using System.Runtime.CompilerServices;
using _07_Propriedade_Metodo_Construtore.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Junio";
p1.Idade = 43;

p1.Apresentar();

Console.WriteLine("");
p1.Nome = "";
p1.Idade = 25;

p1.Apresentar();