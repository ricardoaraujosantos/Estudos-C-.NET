namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string name;
        private string surName;

        public Pessoa()
        {
            name = string.Empty;
            surName = string.Empty;
        }

        public Pessoa(string name, string surName)
        {
            this.name = name;
            this.surName = surName; 
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {name} {surName}");
        }
    }
}