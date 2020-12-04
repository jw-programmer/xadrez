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
                   try
                   {
                        Console.Clear();
                    ChessConsole.PrintChessBoard(match.Board);

                    Console.Write("Digite a posição: ");
                    Position origin = ChessConsole.ReadChessPositon().ToPosition();
                    match.OriginPosIsValid(origin);

                    bool[,] posibleMoves = match.Board.piece(origin).PosibleMoves();

                    Console.Clear();
                    ChessConsole.PrintChessBoard(match.Board, posibleMoves);

                    Console.Write("Digite o Destino: ");
                    Position destiny = ChessConsole.ReadChessPositon().ToPosition();

                    match.ExecMove(origin, destiny);
                   }catch(BoardException e)
                   {
                       Console.WriteLine(e.Message);
                       Console.ReadLine();
                   }
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
