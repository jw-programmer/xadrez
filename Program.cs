using System;
using Boad;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            var boad = new ChessBoad(8, 8);
            var pos = new Position(1, 4);
            System.Console.WriteLine(pos);
        }
    }
}
