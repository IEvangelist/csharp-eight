using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IEvangelist.CSharp.Eight
{
    class UsingDeclarations
    {
        internal static async Task WriteLinesToFileClassicAsync(IEnumerable<string> lines)
        {
            using (var file = new StreamWriter("Text.txt"))
            {
                foreach (string line in lines)
                {
                    await file.WriteLineAsync(line);
                }
            }
        }

        internal static async Task WriteLinesToFileAsync(IEnumerable<string> lines)
        {
            // Implicitly disposes, when out of scope!

            using var file = new StreamWriter("Text.txt");
            foreach (string line in lines)
            {
                await file.WriteLineAsync(line);
            }

            // file is disposed here
        }
    }
}