using System;

namespace exemploPoo.Moduls
{
    public class Pessoa
    {
        public string Name {get; set;}

        public int Idade {get; set;}

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Name} minha idade é {Idade} anos. Sou a classe Pessoa Pai!");
        }
    }
}