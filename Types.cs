using System;
using System.Collections.Generic;
using System.Text;

//Custom Types
namespace MoonRabbit
{
    public class Types
    {
        public enum PieceType
        {
            Pawn,
            Knight,
            Bishop,
            Rook,
            Queen,
            King
        }

        public enum Player
        {
            Black,
            White
        }

        public enum Column
        {
            a,
            b,
            c,
            d,
            e,
            f,
            g,
            h
        }

        public enum MoveType
        {
            Quiet,
            DoublePawnPush,
            KingCastle,
            QueenCastle,
            Captures,
            EP_Capture,
            KN_Promote,
            B_Promote,
            R_Promote,s
            Q_Promote,
            KN_ProCapture,
            B_ProCapture,
            R_ProCapture,
            Q_ProCapture
        }
            
    }
}
