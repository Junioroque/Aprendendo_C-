using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Propriedade_Metodo_Construtore.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");

            for(int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "N° " + (count+1) + " - " + Alunos[count].NomeCompleto;
                
                //Interpolação de string
                string texto = $"N° {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}