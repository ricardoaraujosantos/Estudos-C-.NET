namespace exemploPoo.Moduls
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Ola, o meu nome é {Name} minha idade é {Idade} anos! Meu salario mensal é {Salario} mil, Sou classe filha de pessoa herdo seus atributos e sobreescrevo seu metodo Apresentar() de forma selada");
        }
    }
}