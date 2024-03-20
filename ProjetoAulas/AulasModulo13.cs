namespace Modulo13
{
    public class TrabalhandoComArquivos
    {
        public void AulaCriandoArquivo()
        {
            //var escrever = new StreamWriter("C:\\Cadastro.txt"); //cria o arquivo no caminho indicado;
            //var escrever = new StreamWriter("Cadastro.txt"); //cria o arquivo na raiz do executavel;
            var escrever = new StreamWriter("Cadastro.txt", true);
            Console.Write("Informe um nome: ");
            var nome = Console.ReadLine();
            escrever.WriteLine("ID...: " + Random.Shared.Next(01, 100));
            escrever.WriteLine("Nome: " + nome);
            escrever.WriteLine("--------------------");
            escrever.Close();
        }

        public void AulaLendoArquivos()
        {
            //var conteudo = File.ReadAllText("Cadastro.txt");
            //Console.WriteLine(conteudo);

            var ler = new StreamReader("Cadastro.txt");
            while(!ler.EndOfStream)
            {
                var linha = ler.ReadLine();
                Console.WriteLine(linha);
            }

            ler.Close();
        }

        public void AulaExcluindoArquivos()
        {
            if(File.Exists("Cadastro.txt"))
            {
                File.Delete("Cadastro.txt");
            }
        }
    }
}