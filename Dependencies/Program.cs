using Humanizer;


var culture = System.Globalization.CultureInfo.CurrentCulture;
Console.WriteLine(culture);
Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
Console.WriteLine("cachorro".ToQuantity(2));
Console.WriteLine(1018.ToWords());
Console.WriteLine(20.Ordinalize());

Console.WriteLine("\n\nQuantities");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation: ");
HumanizeDates();

static void HumanizeQuantities()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

