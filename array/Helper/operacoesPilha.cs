namespace array.Helper
{
    public class operacoesPilha
    {
        public void imprimirPilha(Stack<string> pilhaLivro)
        {
            while (pilhaLivro.Count > 0)
            {
                 System.Console.WriteLine("Proximo livro para leitura {0}", pilhaLivro.Peek());
                 System.Console.WriteLine("A leitura do livro {0} foi efetuada com sucesso", pilhaLivro.Pop());
                 System.Console.WriteLine("Resta {0} livros para ser lido", pilhaLivro.Count);
            }
        }
    }
}