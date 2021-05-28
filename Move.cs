using System;
using System.Collections.Generic;
using System.Text;

namespace MoonRabbit
{

    //Move Encoding
    //ref: https://www.chessprogramming.org/Encoding_Moves
    //Moves are stored as init, target, and special move code, plus whether the move puts the opponent's king in check.
    //special move codes are in Types.cs
    public struct Move
    {
        public Square origin;
        public Square target;
        public bool check;
        public MoveType moveType;
    }
}
