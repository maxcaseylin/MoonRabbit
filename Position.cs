using System;
using System.Collections.Generic;
using System.Text;

namespace MoonRabbit
{
    //Represents a Position object, used as a node for minimax
    public class Position
    {

        //board representation, contains Pieces
        public Piece[,] board {
            get 
            {
                return board;            
            }
            set
            {
                board = new Piece[8, 8];
            }
        }

        //player turn
        public Types.Player turn;

        //is the player in check?
        public bool check;
        
        //checking for castling is computationally expensive
        public bool whiteCastle;
        public bool blackCastle;        

        //holds the square for en-passant if possible
        public Square? epSquare;

        //50-move rule -- keeps track of moves needed for rule 50
        public int rule50;

        //holds the previous board -- for unmake move
        public Position prev;

        public Move prevMove;

        public int halfMoves;
        public int depth;

        
        public void InitPosition()
        {

        }

    }

    
}
