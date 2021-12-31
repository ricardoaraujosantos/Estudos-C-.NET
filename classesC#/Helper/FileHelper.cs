using System.Collections.Generic;

namespace exemploPoo.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var caminhoDiretorio = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retornoCaminho in caminhoDiretorio)
            {
                System.Console.WriteLine(retornoCaminho);
            }
        }

        public void ListarArquivosDiretorios(string caminhoArq)
        {
            var caminhoDiretorio = Directory.GetFiles(caminhoArq, "*", SearchOption.AllDirectories);

             foreach (var retornoCaminho in caminhoDiretorio)
            {
                System.Console.WriteLine(retornoCaminho);
            }
        }
        public void CriarDiretorio(string caminhoDir)
        {
            var retornoDiretorio = Directory.CreateDirectory(caminhoDir);
            System.Console.WriteLine(retornoDiretorio.FullName);
        }
        public void DeletarDiretorio(string caminhoDel, bool apagarDiretorio)
        {
            Directory.Delete(caminhoDel, apagarDiretorio);
        }

        public void CriarNovoArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriaArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void AdicionarNovoArquivo(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
         public void AdicionarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void lerArquivoTexto(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void lerArquivoTextoStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void moverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho, novoCaminho);
        }

        public void copiarArquivo(string caminho, string novoCaminhoCopy, bool sobrescreverArquivo)
        {
            File.Copy(caminho, novoCaminhoCopy);
        }

        public void deletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}