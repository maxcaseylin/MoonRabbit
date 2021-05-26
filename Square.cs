using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MoonRabbit
{
    //Square object, contains row, col
    public struct Square
    {

        public Square(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public int row { get; set; }
        public int col { get; set; }

        public String toString()
        {
            return String.Format("{0}{1}", (PieceType)col, row);
        }
    }
}
