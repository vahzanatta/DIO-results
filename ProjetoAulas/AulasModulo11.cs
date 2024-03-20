namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2024, 02, 28, 20, 43, 37);
        var date2 = DateTime.Parse("2024/02/28 20:43:37");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);

        //DateTimeOffset.UtcNow
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2024-02-28");

        //var diff = date1 - date2;
        var diff = date1.Subtract(date2);

        Console.WriteLine((int)diff.TotalDays); //int converte em inteiro;
        Console.WriteLine(diff.TotalHours);
    }

    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.AddDays(7).ToString("dd-MM-yy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(6).ToString("dd-MM-yy HH:mm:ss"));
        Console.WriteLine(date1.AddYears(5).ToString("dd-MM-yy HH:mm:ss"));
    }

    public void AulaAdicionandoHoraMinutoSegundos()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddHours(7).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(6).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(5).ToString("HH:mm:ss"));
    }

    public void AulaRecuperandoDiaDaSemana()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        //var somenteData = new DateOnly(2024, 02, 28);
        var somenteData = DateOnly.Parse("2024-02-28");

        Console.WriteLine(somenteData.ToString("dd-MM-yyyy"));
    }

    public void AulaTimeOnly()
    {
        var somenteHora1 = new TimeOnly(21, 23, 19);
        var somenteHora2 = TimeOnly.Parse("21:23:19");

        Console.WriteLine(somenteHora1);
        Console.WriteLine(somenteHora2.ToString("HH:mm:ss"));
    }
}