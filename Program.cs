using System;
using Boad;
using xadrez.Screen;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            var boad = new ChessBoad(8, 8);
            ChessConsole.PrintChessBoad(boad);
            var pos = new Position(1, 4);
            System.Console.WriteLine(pos);
        }
    }
}
