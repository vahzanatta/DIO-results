using Microsoft.VisualBasic;

namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*
        string nomeCompleto = "Vanessa Zanatta";

        Func<char, bool> filtro = c => c == 'a';
        //var resultado = nomeCompleto.Where(filtro); //sintaxe de método;
        //var resultado = nomeCompleto.Where(p => p == 'a'); //lambda?

        var resultado = from c in nomeCompleto where c == 'n' select c; //sintaxe de consulta
        foreach (var letra in resultado)
        {
            Console.WriteLine(letra);
        }
        */

        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }

    }

    public void AulaOrdenacao()
    {
        //var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var nomes = new string[] {"Vanessa", "Felipe", "Rafael"};

        //var resultado = numeros.OrderBy(p => p); //ordena de forma crescente;
        var resultado = nomes.OrderByDescending(p => p); //ordena de forma descrescente;
        
        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }

    public void AulaFirstEFirstOfDefault()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        //var resultado = numeros.First();
        //var resultado = numeros.First(p => p > 15);
        var resultado = numeros.FirstOrDefault(p => p > 100, -99);

        Console.WriteLine(resultado);
    }
}