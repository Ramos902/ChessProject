namespace ChessProject.Board
{
    class Piece
    {
        public Position Position { get; set; }
        public ChessBoard Board { get; protected set; }
        public Color Color { get; protected set; }
        public int QtyMoves { get; protected set; }

        public Piece(Position position, ChessBoard board, Color color)
        {
            this.Position = position;
            this.Board = board;
            this.Color = color;
            this.QtyMoves = 0;
        }
    }
}