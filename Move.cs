using System;
using System.Collections.Generic;
using System.Text;

namespace MoonRabbit
{

    //Move Encoding
    //ref: https://www.chessprogramming.org/Encoding_Moves
    //Moves are stored as init, target, and special move code.
    //special move codes are in Types.cs
    public struct Move
    {
        public Square origin;
        public Square target;
        public Types.MoveType moveType;
    }
}
