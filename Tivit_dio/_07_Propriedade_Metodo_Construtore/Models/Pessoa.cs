using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _07_Propriedade_Metodo_Construtore.Models
{
    public class Pessoa
    {
        //Class Pessoa tem 2 propriedades

        private string _nome; 
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                {
                   if(value == "")
                   {
                       throw new ArgumentException("O nome não pode ser vazio");
                   }
                   _nome = value;
                }
            } 
        }

        public int Idade 
        { 
            get; 
            set;
        
        }

        //Metodo
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}