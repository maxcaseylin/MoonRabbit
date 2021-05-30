using System;

namespace MoonRabbit
{
    class Program
    {
        static void Main(string[] args)
        {

            Position b = new Position();
            b.FromFen("rn2kb1r/pbpqpppp/1p3n2/3p4/2PP3P/2N1PN2/PP3PP1/R1BQKB1R b KQkq - 0 6");
            Console.WriteLine(b.BoardToString());
        }
    }
}
