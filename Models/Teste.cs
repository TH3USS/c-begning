using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.Models
{
    public class Teste
    {
    public void m1(){
        m2();
    }

    public void m2(){
        try{
            m3();
        }catch(Exception){
            Console.WriteLine("A");
        }
    }

    public void m3(){
        //o throw volta para cima procurando um catch
        throw new Exception("Ocorreu uma exceção");
    }
    }
}