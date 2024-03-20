//namespace Cadastro;

using System.Data;

namespace Cadastro
{
    public static class Calculos //criação de uma classe estatica, não precisa ser isntanciada;
    {
        public static int SomarNumeros(int a, int b) //as funções devem ser estaticas também;
        {
            return a + b;
        }
    }
    public class Produto //criação da classe Produto;
    {
        private int Id; // criação de uma propriedade/atributo privado;

        public string Descricao { get; set; } //criação de uma propriedade/atributo publico;
                                              //get permite acesso a propriedade para recuperar o valor e set permite atribuição de valor;

        //public readonly int Estoque; //propriedade/atributo apenas leitura, só pode ser modificada através do cosntrutor da classe;

        public int Estoque { get; } //forma alternativa para readonly;
        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao() //criação de método que aqui imprime algo;
                                        //void não retorna valor, apenas executa;
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
    }
    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("CEP: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa //PessoaFisica herda as propriedades/atributos de Pessoa;
    {
        public string CPF { get; set; }
        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica //Funcionario herda de PessoaFisica que herda de Pessoa;
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao //criação de uma classe selada que desabilita que outras classes herdem as propriedades/atributos;
    {
        public string Host { get; set; }
    }

    public abstract class Animal //criação de uma classe abstrata que não permite ser instanciada;
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome do animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetInformacoes());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo.";
        }
    }

    /*
    public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }
            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
    }
    */

    public record Curso(int Id, string Descricao);
    public class CursoTeste
    {
        public int Id {get; set;}
        public string Descricao {get; set;}
    }   

    public interface INotificacao //força as classes que as herdam sejam obrigadas a implementar o código;
    {
        string Descricao {get; set;}
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificacao cliente.");
        }
        
        public void NotificarOutros()
        {
            Console.WriteLine("Notificacao outros.");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao {get; set;}
        public void Notificar()
        {
            Console.WriteLine("Notificacao funcionario.");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificacao outros.");
        }
    }
}