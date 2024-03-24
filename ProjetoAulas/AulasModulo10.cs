using System.Runtime.CompilerServices;

namespace Modulo10
{

    public class TrabalhandoComStrings
    {
        public void ConverterParaLetrasMinusculas()
        {
            Console.Write("Favor digitar alguma informacao: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.ToLower());
        }

        public void ConverterParaLetrasMaiusculas()
        {
            Console.Write("Favor digitar alguma informacao: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.ToUpper());
        }

        public void AulaSubstring()
        {
            Console.Write("Favor digitar alguma informacao: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.Substring(0, 7));
        }

        public void AulaRange()
        {
            string nomeArquivo = "2024_02_28_backup.bak";

            var ano = nomeArquivo[..4];
            Console.WriteLine(ano);

            string extensao = nomeArquivo[^3..];
            Console.WriteLine(extensao);

            string nome = nomeArquivo[11..^4];
            Console.WriteLine(nome);

            string apenasName = nomeArquivo[..^4];
            Console.WriteLine(apenasName);
        }

        public void AulaContains()
        {
            string nomeArquivo = "2024_02_28_backup.bak";
            //Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));

            if (nomeArquivo.Contains("backup"))
            {
                Console.WriteLine("Palavra encontrada!");
            }
            else
            {
                Console.WriteLine("Palavra nao encontrada!");
            }
        }

        public void AulaTrim()
        {
            string teste = "**VANESSA ZANATTA**";

            Console.WriteLine("TOTAL: " + teste.Trim('*'));
            Console.WriteLine("INICIO: " + teste.TrimStart('*'));
            Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
        }

        public void AulaStartWithEndWith()
        {
            string teste = "Curso Csharp";
            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
            Console.WriteLine("FINAL: " + teste.EndsWith("Csharp02"));
        }

        public void AulaReplace()
        {
            string teste = "Curso Csharp";
            Console.WriteLine(teste);
            Console.WriteLine(teste.Replace("Csharp", "C#"));
        }

        public void AulaLength()
        {
            string teste = Console.ReadLine();
            Console.WriteLine(teste);
            Console.WriteLine(teste.Length);
        }
    }
}
