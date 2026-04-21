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
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
                
            } 
        }

        public string Sobrenome {get; set;}
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        //Validar idade
        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        
        }

        //Metodo
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}