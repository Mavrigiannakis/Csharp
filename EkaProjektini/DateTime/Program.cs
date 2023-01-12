internal class Program
{
    private static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("F", new System.Globalization.CultureInfo("fi-FI")));
    }
}