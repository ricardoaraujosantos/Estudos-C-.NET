using System;
using exemploPoo.Helper;
using exemploPoo.Interfaces;
using exemploPoo.Moduls;

namespace exemploPoo
{
    class program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa();
            p1.Name = "Ricardo";
            p1.Idade = 33;
            p1.Apresentar();

            Professor f2 = new Professor();
            f2.Name = "Prof Leonardo";
            f2.Idade = 42;
            f2.Salario = 2000;
            f2.Apresentar();

            Aluno f1 = new Aluno();
            f1.Name = "Ryan";
            f1.Idade = 7;
            f1.Nota = 8;
            f1.Apresentar();

            Corrente c01 = new Corrente();
            c01.creditar(2000);
            c01.ExibirSaldo();
            
            //Valor valido
            Retangulos r1 = new Retangulos();
            System.Console.WriteLine("Calcular Area de um retangulo");
            r1.DefinirMedidas(20, 20);
            System.Console.WriteLine($"Area é igual a {r1.ObterArea()}");

            //Valor invalido
            Retangulos r2 = new Retangulos();
            r1.DefinirMedidas(0, 20);
            System.Console.WriteLine($"Area é igual a {r2.ObterArea()}");

            // Subrescrevendo Referencias System.Object
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());

            // Cauculadora interface
            ICalculadora calc = new CalculadoraComum();
            var number1= 20;
            var number2 = 5;
            System.Console.WriteLine("cauculadora");
            System.Console.WriteLine($"A soma de {number1} e {number2} é igual a " + calc.Somar(number1, number2));
            System.Console.WriteLine($"A subtração de {number1} e {number2} é igual a " + calc.Subtrair(number1, number2));
            System.Console.WriteLine($"A multiplicação de {number1} e {number2} é igual a " + calc.Multiplicar(number1, number2));
            System.Console.WriteLine($"A divisão de {number1} e {number2} é igual a " + calc.Dividir(number1, number2));

            // Manipulando caminho diretorios e arquivos
            var caminho = "C:\\trabalhandoarquivos";

            var caminhoPathCombine = Path.Combine(caminho, "teste3");
            var novoArquivo = Path.Combine(caminho, "novoarquivo.txt");

            var novoCaminho = Path.Combine(caminho, "teste2", "novoarquivo.txt");
            var novoCaminhocopy = Path.Combine(caminho, "teste2", "novoarquivoBkp.txt");
            
            var listaString = new List<string> {"1ª linha stream criada", "2ª linha stream criada", "3ª linha stream criada"};
            var listaStreamContinuacao = new List<string> {"4ª linha stream criada sem apagar linha anterior", "5ª linha stream criada sem apagar linha anterior", "6ª linha stream criada sem apagar linha anterior"};

            FileHelper helper = new FileHelper();
            
            //Listar diretorio
            System.Console.WriteLine("Listar caminhos diretorios");
            helper.ListarDiretorios(caminho);

            //Listar arquivo
            System.Console.WriteLine("Listar arquivo no diretorio");
            helper.ListarArquivosDiretorios(caminho);

            //Criar diretorio
            System.Console.WriteLine("Criando diretorios");
            helper.CriarDiretorio(Path.Combine(caminho, "teste3", "subteste3"));

            //Deletar diretorio
            //helper.DeletarDiretorio(caminhoPathCombine, true);

            //Criar arquivo texto
            helper.CriarNovoArquivoTexto(novoArquivo, "Criando um novo texto Aqui!");

            //texto com stream
            System.Console.WriteLine("Criando arquivo stream");
            helper.CriaArquivoTextoStream(novoArquivo, listaString);

            System.Console.WriteLine("Adicionar um novo stream sem apagar texto anterior");
            helper.AdicionarArquivoTextoStream(novoArquivo, listaStreamContinuacao);

            System.Console.WriteLine("Lendo Arquivo stream criado");
            helper.lerArquivoTextoStream(novoArquivo);

            //Mover arquivo
            //helper.moverArquivo(novoArquivo, novoCaminho);

            //Copiar arquivo 
            //helper.copiarArquivo(novoCaminho, novoCaminhocopy, false);

            //Delete arquivo copia
            //helper.deletarArquivo(novoCaminhocopy);
        }
    }
}