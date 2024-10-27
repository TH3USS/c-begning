using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class LeituraArquivos
    {
        public (bool sucesso, string[] linhas, int quant, string descarte) LerArquivo(string caminho){
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count(), "descarte");
            } catch{
                return (false, new string[0], 0, "a");
            }
        }
    }
}