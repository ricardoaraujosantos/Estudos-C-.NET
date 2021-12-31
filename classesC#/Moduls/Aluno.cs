namespace exemploPoo.Moduls
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }   
     public override void Apresentar()
        {
            Console.WriteLine($"Ola, o meu nome é {Name} minha idade é {Idade} anos, minha nota é {Nota}, Sou classe Aluno filha da classe Pessoa Pai, herdo seus atributos e sobreescrevo seu metodo Apresentar()");
        }
    }
}