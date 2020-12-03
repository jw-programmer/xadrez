using System;
using Board;
using Chess;
using xadrez.Screen;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var match = new ChessMatch();
                while(!match.Finish)
                {
                    Console.Clear();
                    ChessConsole.PrintChessBoard(match.Board);

                    Console.Write("Digite a posição: ");
                    Position origin = ChessConsole.ReadChessPositon().ToPosition();

                    Console.Write("Digite o Destino: ");
                    Position destiny = ChessConsole.ReadChessPositon().ToPosition();

                    match.ExecMove(origin, destiny);
                }
                
                // ChessPosition pos = new ChessPosition('c',7);
                // System.Console.WriteLine(pos);

                // System.Console.WriteLine(pos.ToPosition());
            }
            catch (BoardException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
