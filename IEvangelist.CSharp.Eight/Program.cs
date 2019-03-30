using static System.Console;

namespace IEvangelist.CSharp.Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            // PATTERN MATCHING IMPROVEMENTS

            // 1) Switch expressions...
            WriteLine("1. SWITCH EXPRESSIONS");
            WriteLine($"Legacy switch: {SwitchExpressions.FromRainbow(Rainbow.Violet)}");
            WriteLine($"Expressive switch: {SwitchExpressions.TasteTheRainbow(Rainbow.Red)}");

            // 2) Property Patterns
            WriteLine("2. PROPERTY PATTERNS");
            var brookfieldSalesTax =
                PropertyPatterns.ComputeSalesTax(
                    new Address { State = "WI", City = "Brookfield" },
                    100);
            WriteLine($"Brookfiled Sales Tax:{brookfieldSalesTax}");

            var milwaukeeSalesTax =
                PropertyPatterns.ComputeSalesTax(
                    new Address { State = "WI", City = "Milwaukee" },
                    100);
            WriteLine($"Milwaukee Sales Tax: {milwaukeeSalesTax}");

            // 3) Tuple Patterns
            WriteLine("3. TUPLE PATTERNS");
            WriteLine($"{TuplePatterns.RockPaperScissors("rock", "rock")}");
            WriteLine($"{TuplePatterns.RockPaperScissors("rock", "paper")}");
            WriteLine($"{TuplePatterns.RockPaperScissors("scissors", "paper")}");
            WriteLine($"{TuplePatterns.RockPaperScissors("rock", "scissors")}");

            // 4) Object Patterns
            WriteLine("4. OBJECT PATTERNS");
            WriteLine($"Square: {ObjectPatterns.ShapeDetails(new Rectangle(7, 7))}");

            // 5) Positional Patterns
            WriteLine("POSITIONAL PATTERNS");
            WriteLine($"Point quadrant = {PositionalPatterns.AsQuadrant(new Point(-3, 9))}");

            // Range / Index
            RangesAndIndices.WordUp();

            ReadLine();
        }
    }
}