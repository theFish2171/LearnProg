public partial class Program
{
    private static void SectionTitle(string title)
    {
        WriteLine();
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine(($"*** {title} ***"));
        ForegroundColor = previousColor;
    }
}
