namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public  Aluno(string name, string surName, string disciplina) : base(name, surName)
        {
            System.Console.WriteLine("Construtor class Aluno");
        }
    }
}