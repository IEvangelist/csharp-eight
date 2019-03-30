using System.Collections.Generic;
using System.IO;

namespace IEvangelist.CSharp.Eight
{
    class UsingDeclarations
    {
        internal static void WriteLinesToFileClassic(IEnumerable<string> lines)
        {
            using (var file = new StreamWriter("Text.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }

        internal static void WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new StreamWriter("Text.txt");
            foreach (string line in lines)
            {
                file.WriteLine(line);
            }

            // file is disposed here
        }
    }
}