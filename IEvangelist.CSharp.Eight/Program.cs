using System.Threading.Tasks;
using static System.Console;

namespace IEvangelist.CSharp.Eight
{
    class Program
    {
        static async Task Main()
        {
            #region PATTERN MATCHING IMPROVEMENTS

            //WriteLine("1. SWITCH EXPRESSIONS");
            //WriteLine($"Legacy switch: {SwitchExpressions.FromRainbow(Rainbow.Violet)}");
            //WriteLine($"Expressive switch: {SwitchExpressions.TasteTheRainbow(Rainbow.Red)}");
            //
            //
            //WriteLine("2. PROPERTY PATTERNS");
            //var brookfieldSalesTax =
            //    PropertyPatterns.ComputeSalesTax(
            //        new Address { State = "WI", City = "Brookfield" },
            //        100);
            //WriteLine($"Brookfiled Sales Tax:{brookfieldSalesTax}");
            //
            //var milwaukeeSalesTax =
            //    PropertyPatterns.ComputeSalesTax(
            //        new Address { State = "WI", City = "Milwaukee" },
            //        100);
            //WriteLine($"Milwaukee Sales Tax: {milwaukeeSalesTax}");
            //
            //
            //WriteLine("3. TUPLE PATTERNS");
            //WriteLine($"{TuplePatterns.RockPaperScissors("rock", "rock")}");
            //WriteLine($"{TuplePatterns.RockPaperScissors("rock", "paper")}");
            //WriteLine($"{TuplePatterns.RockPaperScissors("scissors", "paper")}");
            //WriteLine($"{TuplePatterns.RockPaperScissors("rock", "scissors")}");
            //
            //
            //WriteLine("4. OBJECT PATTERNS");
            //WriteLine($"Square: {ObjectPatterns.ShapeDetails(new Rectangle(7, 7))}");
            //
            //
            //WriteLine("POSITIONAL PATTERNS");
            //WriteLine($"Point quadrant = {PositionalPatterns.AsQuadrant(new Point(-3, 9))}");

            #endregion

            #region ASYNC STREAMS

            //await AsyncStreams.GetExampleAsync();

            #endregion

            #region RANGE & INDEX

            // Range / Index
            //RangesAndIndices.WordUp();

            #endregion

            #region STATIC LOCAL FUNCTIONS

            StaticLocalFunctions.ClassicCapture();
            StaticLocalFunctions.NonCapturing();

            #endregion

            #region USING DECLARATIONS

            await UsingDeclarations.WriteLinesToFileClassicAsync(
                new[]
                {
                    "I still dispose explicitly...",
                    "Someday, I dream I won't have to."
                });

            await UsingDeclarations.WriteLinesToFileAsync(
                new[] 
                {
                    "The C# language, is great!",
                    "What will they think of next?"
                });

            #endregion

            await Task.CompletedTask;

            WriteLine("Press any key to continue.");
            ReadLine();
        }
    }
}