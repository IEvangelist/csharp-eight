using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IEvangelist.CSharp.Eight
{
    class UsingDeclarations
    {
        static async Task Main()
        {
            await WriteLinesToFileClassicAsync(
                new[]
                {
                    "I still dispose explicitly...",
                    "Someday, I dream I won't have to."
                });

            await WriteLinesToFileAsync(
                new[]
                {
                    "The C# language, is great!",
                    "What will they think of next?"
                });
        }

        internal static async Task WriteLinesToFileClassicAsync(IEnumerable<string> lines)
        {
            using (var file = new StreamWriter("Text.txt"))
            {
                foreach (var line in lines)
                {
                    await file.WriteLineAsync(line);
                }
            }
        }

        internal static async Task WriteLinesToFileAsync(IEnumerable<string> lines)
        {
            // Implicitly disposes, when out of scope!

            using var file = new StreamWriter("Text.txt");
            foreach (var line in lines)
            {
                await file.WriteLineAsync(line);
            }

            // file is disposed here
        }
    }
}