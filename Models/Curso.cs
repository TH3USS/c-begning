using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void Adicionar(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int Quantidade(){
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool Remover(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void Listar(){
            Console.WriteLine($"Alunos do Curso de: {Nome}");
            int count = 1;
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine($"N° {count} - {aluno.NomeCompleto}");
                count ++;
            }
        }
    }
}