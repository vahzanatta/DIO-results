//Console.WriteLine("First program!");

using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using Cadastro;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaClasses(); //isso é um método?
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            //AulaClasseAbstrata();
            //AulaRecord();
            //AulaInterface();
            //Conversores();
            //TrabalhandoComStrings();
            //TrabalhandoComDatas();
            //TrabalhandoComExcecoes();
            //TrabalhandoComArquivos();
            TrabalhandoComLinq();
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);

            /* var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado";
            
            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());
            */
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);
        }

        private static void AulaHeranca()
        {
            /*
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Sarandi";
            pessoaFisica.Cidade = "Porto Alegre";
            pessoaFisica.Cep = "98765-432";
            pessoaFisica.CPF = "987.654.321-10";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
            */

            var funcionario = new Cadastro.Funcionario();
            funcionario.Id = 2;
            funcionario.Endereco = "Cidade Baixa";
            funcionario.Cidade = "Porto Alegre";
            funcionario.Cep = "23456-789";
            funcionario.CPF = "101.234.567-89";

            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
        }

        private static void AulaClasseSelada()
        {
            /*
            var configuracao = new Cadastro.Configuracao();
            configuracao.Host = "localhost";
            */

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Cacau";
            cachorro.ImprimirDados();
        }

        private static void AulaRecord()
        {
            //var curso1 = new Cadastro.Curso {Id = 1, Descricao = "Curso"};
            //var curso2 = new Cadastro.Curso {Id = 1, Descricao = "Curso"};

            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = curso1 with { Descricao = "Novo teste" };

            //var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            //var curso2 = curso1;
            //curso2.Descricao = "Teste";
            //var curso2 = new Cadastro.CursoTeste();
            //curso2.Id = curso1.Id;
            //curso2.Descricao = "Nova descricao";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);

            //Console.WriteLine(curso1 == curso2);
            //Console.WriteLine(curso1.Equals(curso2));
        }
        
        private static void AulaInterface()
        {
            var NotificacaoCliente = new Cadastro.NotificacaoCliente();
            NotificacaoCliente.Notificar();
            NotificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            //conversores.ConvertAndParse();
            conversores.AulaTryParse();
        }

        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            //trabalhandoComStrings.ConverterParaLetrasMinusculas();
            //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
            //trabalhandoComStrings.AulaSubstring();
            //trabalhandoComStrings.AulaRange();
            //trabalhandoComStrings.AulaContains();
            //trabalhandoComStrings.AulaTrim();
            //trabalhandoComStrings.AulaStartWithEndWith();
            //trabalhandoComStrings.AulaReplace();
            trabalhandoComStrings.AulaLength();
        }

        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
            //trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            //trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundos();
            //trabalhandoComDatas.AulaRecuperandoDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly();
            //trabalhandoComDatas.AulaTimeOnly();
        }

        private static void TrabalhandoComExcecoes()
        {
            var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
            //trabalhandoComExcecoes.AulaGerandoExceptions();
            trabalhandoComExcecoes.AulaTratandoExceptions();
        }

        private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
            //trabalhandoComArquivos.AulaCriandoArquivo();
            //trabalhandoComArquivos.AulaLendoArquivos();
            //trabalhandoComArquivos.AulaExcluindoArquivos();
        }

        private static void TrabalhandoComLinq()
        {
            var linq = new Modulo14.TrabalhandoComLinq();
            //linq.AulaWhere();
            //linq.AulaOrdenacao();
            //linq.AulaTake();
            //linq.AulaCount();
            linq.AulaFirstEFirstOfDefault();
        }
    }
}

/*
namespace Cadastro
{
    public class Cliente
    {

    }

    public class Funcionario
    {

    }
}

namespace Financeiro
{
    public class ContasReceber
    {

    }

    public class Funcionario
    {

    }
}
*/