using Board;

namespace xadrez.Screen
{
    class ChessConsole
    {
        public static void PrintChessBoard(ChessBoard boad)
        {
            for (int i = 0; i < boad.Rows; i++)
            {
                for (var j = 0; j < boad.Columns; j++)
                {
                    if (boad.piece(i, j) == null)
                    {
                        System.Console.Write("= ");
                    }
                    else
                    {
                        System.Console.Write(boad.piece(i, j) + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}