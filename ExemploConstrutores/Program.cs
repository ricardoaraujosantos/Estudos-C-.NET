using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] Args)
        {
           Pessoa p1 = new Pessoa("Ricardo", "Santos");  
           p1.Apresentar();
           
        }
    }
}