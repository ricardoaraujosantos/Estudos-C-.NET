using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
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

            //GET e SET validação
            //Mes vallido
            //    Data m1 = new Data();
            //    m1.SetMes(4);
            //    m1.ApresentarMes();

            //Mes invalido
            //    Data m2 = new Data();
            //    m2.SetMes(14);
            //    m2.ApresentarMes();

           //GET e SET propriedades validações
           Data data1 = new Data();
           Data data2 = new Data();

           //Mes valido
           data1.Mes = 8;
           data1.ApresentarMes();

           //Mes invalido
           data2.Mes = 13;
           data2.ApresentarMes();

           //delegates
           Operacao op1 = new Operacao(Calculadora.somar);
           //delegate multi cast
           op1 += Calculadora.subtrair;
           op1.Invoke(15, 10);

           //Forma de instanciar sem o new
           Operacao op2 = Calculadora.subtrair;
           //delegate multi cast
           op2 += Calculadora.somar;
           op2(20, 10);
        }
    }
}