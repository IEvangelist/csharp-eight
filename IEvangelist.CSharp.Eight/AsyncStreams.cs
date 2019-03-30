using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEvangelist.CSharp.Eight
{
    class AsyncStreams
    {
        internal struct Statement
        {
            public int Id { get; }

            public string Description { get; }

            public Statement(int id, string description) 
                => (Id, Description) = (id, description);
        }

        internal static IEnumerable<Statement> GetStatements(bool error)
        {
            if (error)
            {
                throw new Exception("Oops, we messed up 😬");
            }

            yield return new Statement(1, "C# is cool!");
            yield return new Statement(2, "C# orginally named COOL.");
            yield return new Statement(3, "More examples...");
        }

        internal static Task<IEnumerable<Statement>> GetStatementsAsync() 
            => Task.FromResult(Enumerable.Empty<Statement>()); // Imagine...

        internal static async IAsyncEnumerable<Statement> GetStatementsAsync(bool error)
        {
            foreach (var statement in GetStatements(error))
            {
                await Task.Delay(350);
                yield return statement;
            }
        }

        internal async Task GetExampleAsync()
        {
            // Deferred execution
            // Plus the potential for suspended execution 
            await foreach (var statement in GetStatementsAsync(false))
            {
                Console.WriteLine(statement);
            }
        }
    }
}