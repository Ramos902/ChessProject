using ChessProject.Board.BoardExceptions;

namespace ChessProject.Board
{
    class ChessBoard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public ChessBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines, Columns];
        }

        public Piece PiecePos(int line, int column)
        {
            return Pieces[line, column];
        }
        public Piece PiecePos(Position position)
        {
            return Pieces[position.Line, position.Column];
        }

        public void PieceAdd(Piece piece, Position position)
        {
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool PositionIsValid(Position position)
        {
            if(position.Line < 0 || position.Line > Lines || position.Column < 0 || position.Column > Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!PositionIsValid(position))
            {
                throw new BoardException("Invalid Position");
            }
        }

    }
}