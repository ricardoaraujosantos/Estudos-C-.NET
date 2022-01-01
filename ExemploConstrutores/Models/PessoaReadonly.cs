namespace ExemploConstrutores.Models
{
    public class PessoaReadonly
    {
        private readonly string name = "Ricardo";
        private readonly string surName;

        public PessoaReadonly(string name, string surName)
        {
            this.name = "José";
            this.surName = "Santos"; 
            System.Console.WriteLine("Modificador Readonly");
        }
        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {name} {surName}");
        }
    }
}