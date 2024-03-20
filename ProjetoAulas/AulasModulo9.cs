namespace Conversores;
public class Conversor
{
    public void ConvertAndParse()
    {
        //int numero = int.Parse("1");
        //int numero = Convert.ToInt32("1");
        //int numero = int.Parse(null);
        //Console.WriteLine(numero);
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);
    }

    public void AulaTryParse()
    {
        var numero = "123456";
        if(int.TryParse(numero, out int numeroConvertido))
        {
            Console.WriteLine("Numero foi convertido com sucesso!");
        }

        Console.WriteLine(numeroConvertido);
    }
}