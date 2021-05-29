using System;
using System.Collections.Generic;
using System.Text;

//Custom Types
namespace MoonRabbit
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
        White,
        Black
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
    
    //TODO: refactor names
    public enum MoveType
    {
        Quiet,
        DoublePawnPush,
        KingCastle,
        QueenCastle,
        Captures,
        EPCapture,
        KNPro,
        BPro,
        RPro,
        QPro,
        KNProCapture,
        BProCapture,
        RProCapture,
        QProCapture
    }
     
}
