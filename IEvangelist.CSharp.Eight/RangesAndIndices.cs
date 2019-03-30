using System;

namespace IEvangelist.CSharp.Eight
{
    class RangesAndIndices
    {
        internal static void WordUp()
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

            // Oh look, IDE suggestions... "yes, please"!
            Console.WriteLine($"The last word is {words[words.Length - 1]}");

            var quickBrownFox = words[1..4];
            Console.WriteLine(string.Join(" ", quickBrownFox));

            // This is called a "Range phrase"
            // It's just a Range type declaration and assignment.
            // "readonly struct"
            Range lastTwo = ^2..;

            // Ranges have a start/end Index.
            // "readonly struct"
            Index start = lastTwo.Start;
            Index end = lastTwo.End;

            // The "Index" struct has these members:
            bool isFromEnd = start.IsFromEnd;
            int value = start.Value;

            var lazyDog = words[lastTwo];
            Console.WriteLine(string.Join(" ", lazyDog));

            var allWords = words[..];     // Contains everything.
            var firstPhrase = words[..4]; // Contains "The" through "fox"
            var lastPhrase = words[6..];  // Contains "the, "lazy" and "dog"

            Console.WriteLine(string.Join(" ", allWords));
            Console.WriteLine(string.Join(" ", firstPhrase));
            Console.WriteLine(string.Join(" ", lastPhrase));
        }
    }
}