using ChessProject.Board;

namespace ChessProject
{
    class Screen
    {
        public static void PrintBoard(ChessBoard Board)
        {
            for (int i = 0; i < Board.Lines; i++)
            {
                for (int j = 0; j < Board.Lines; j++)
                {
                    if (Board.PiecePos(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(Board.PiecePos(i, j) + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}