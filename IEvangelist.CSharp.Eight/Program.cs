using static System.Console;

namespace IEvangelist.CSharp.Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            // PATTERN MATCHING IMPROVEMENTS

            // 1) Switch expressions...
            WriteLine($"Legacy switch: {SwitchExpressions.FromRainbow(Rainbow.Violet)}");
            WriteLine($"Expressive switch: {SwitchExpressions.TasteTheRainbow(Rainbow.Red)}");

            // 2) Property Patterns









            // Range / Index
            RangesAndIndices.WordUp();

            ReadLine();
        }
    }
}