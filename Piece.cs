using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;




namespace MoonRabbit
{
    //base pieces
    public struct Piece
    {

        //position of the piece, 0 - 7 and 0 - 7
        //TODO: check if there is a speed improvement by changing int to smaller mems instead
        public Square pos;

        //piece color
        public Player color { get; set; }

        //piece type
        public PieceType pieceType { get; set; }

        public Piece(Square pos, Player color, PieceType pieceType)
        {
            this.pos = pos;
            this.color = color;
            this.pieceType = pieceType;
        }

        //returns a string representation of piecetype and location
        //for example, a king at e5 would be represented at King@e5
        public String getLocation()
        {
            return String.Format("{0}@{1}{2}", pieceType, (Column) pos.col, pos.row);
        }

        public String toString()
        {
            return String.Format("{0} {1}", color, pieceType);
        }


    }
}
