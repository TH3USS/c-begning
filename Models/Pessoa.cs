using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }

        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome){
            nome = Nome;
            sobrenome = Sobrenome;
        }


        //prop |tab|
        private string _name;
        private int _idade;
        public string Nome { 

            // => esse sinal é chamado de Body Expreshions, é um return simplificado
            get => _name.ToUpper();
            
            
             set{
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _name = value;
             }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade {
            get => _idade;
            
            
             set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }

                _idade = value;
             }
        }

        public void apresentar(){
            Console.WriteLine($"Olá meu nome é {NomeCompleto}, e tenho {Idade} anos!");
        }
    }
}