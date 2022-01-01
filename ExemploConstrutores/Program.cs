using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] Args)
        {
            //Construtor
           Pessoa p1 = new Pessoa("Ricardo", "Santos");  
           p1.Apresentar();

            //Construtor private padrão Singleton
           Log log = Log.getInstance();
           log.propriedadeLog = "Instancia teste";

           Log log2 = Log.getInstance();
           System.Console.WriteLine(log2.propriedadeLog);

           //Construtor por herança
           Aluno a1 = new Aluno("Ricardo","Santos", "C-Sharp");
           a1.Apresentar();

        }
    }
}