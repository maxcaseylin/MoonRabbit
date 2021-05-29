using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml;

namespace MoonRabbit
{
    //Represents a Position object, used as a node for minimax
    public class Position
    {

        //mailbox board representation, contains Pieces
        public Piece?[,] board;


        public Piece?[] whitePieces;
        public Piece?[] blackPieces;

        //player turn
        public Player turn;

        //is the player in check?
        public bool check;

        //checking for castling is computationally expensive, we should store some conditions somewhere else
        public Castling whiteCastle;
        public Castling blackCastle;

        //holds the square for en-passant if possible
        public Square? epSquare;

        //50-move rule -- keeps track of moves needed for rule 50
        public int rule50;

        //holds the previous board -- for unmake move
        public Position? prev;

        public Move? prevMove;

        public int halfMoves;
        public int depth;

        
        public Square?[] checkers; //squares the king is recieving check from
        public Piece?[][] pinners; //pieces that are pinning another piece to the king, row 0 is for white, row 1 is for black
        public Piece?[][] blockers; // pieces that are blocking a check on the king

        //default constructor calls InitPosition
        public Position()
        {
            InitPosition();
        }

        //initializes this Position object to the starting position
        public void InitPosition()
        {
            turn = Player.White;
            check = false;
            whiteCastle = new Castling(false, false, false);
            blackCastle = new Castling(false, false, false);
            epSquare = null;
            rule50 = 0;
            prev = null;
            prevMove = null;
            halfMoves = 0;
            depth = 0;

            //initialize the board
            board = new Piece?[8, 8];
            whitePieces = new Piece?[16];
            blackPieces = new Piece?[16];

            //first fill the board with Pawns
            //this means that pos 0-7 in whitePieces and blackPieces are Pawns
            for (int i = 0; i < 8; i++)
            {
                var whitePawn = new Piece(new Square(1, i), Player.White, PieceType.Pawn);
                var blackPawn = new Piece(new Square(6, i), Player.Black, PieceType.Pawn);

                //add to board
                board[1, i] = whitePawn;
                board[6, i] = blackPawn;

                //append to whitePieces
                whitePieces[i] = whitePawn;
                blackPieces[i] = blackPawn;
            }

            //fill the 1st and last row with the black pieces
            for (int i = 0; i < 8; i++)
            {

                PieceType p;
                //assign piecetype based off of column
                switch (i)
                {

                    // Rooks
                    case 0:
                    case 7:
                        p = PieceType.Rook;
                        break;
                    // Knights
                    case 1:
                    case 6:
                        p = PieceType.Knight;
                        break;
                    // Bishops
                    case 2:
                    case 5:
                        p = PieceType.Bishop;
                        break;
                    // Queen
                    case 3:
                        p = PieceType.Queen;
                        break;
                    case 4:
                        p = PieceType.King;
                        break;
                    default:
                        //used to suppress errors
                        p = PieceType.Pawn;
                        break;
                }

                var whitePiece = new Piece(new Square(0, i), Player.White, p);
                var blackPiece = new Piece(new Square(7, i), Player.Black, p);

                board[0, i] = whitePiece;
                board[7, i] = blackPiece;

                whitePieces[8 + i] = whitePiece;
                blackPieces[8 + i] = blackPiece;

            }

        }

        //initializes this Position object to the position from FEN
        //TODO: Implementation
        public void FromFen(String fen)
        {

        }

        //returns a String representation of the board
        public String BoardToString()
        {
            String output = "";
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < 8; j++)
                {
                    Piece? p = board[i, j];
                    if (!p.HasValue)
                    {
                        output += " ";
                    }
                    else
                    {
                        switch (p?.pieceType)
                        {
                            case PieceType.Pawn:
                                output += "P";
                                break;
                            case PieceType.Knight:
                                output += "N";
                                break;
                            case PieceType.Bishop:
                                output += "B";
                                break;
                            case PieceType.King:
                                output += "K";
                                break;
                            case PieceType.Queen:
                                output += "Q";
                                break;
                            case PieceType.Rook:
                                output += "R";
                                break;
                        }


                    }

                    //if at h-file, create
                    if (j == 7)
                    {
                        output += "\r\n";
                    }
                }
            }

            return output;
        }

        //checks if a piece with pieceType exists on the square(that is, not null and is pieceType)
        public bool IsPieceThere(Square sq, PieceType pieceType)
        {
            return board[sq.row, sq.col].HasValue && board[sq.row, sq.col]?.pieceType == pieceType;
        }

        //TODO: checks if the board is in checkmate
        public bool IsCheckMate()
		{
            if (!check)
			{
                return false;
			}
            return true;
		}

        //TODO: checks if the opposing king is in check
        public bool IsCheck()
		{
            return false;
		}

        //genereates a list of ALL legal moves that can be made
        public List<Move> GenMoves()
		{
            List<Move> moves = new List<Move>();

            //TODO: for each piece, generate all moves.
            return moves;
		}

        public void GenPawnMoves(List<Move> moves, Piece piece)
		{
            if (piece.pieceType != PieceType.Pawn)
			{
                throw new ArgumentException("Piece is not a Pawn");
            }

            if (blockers[(int) piece.pieceType].Contains(piece))
			{
                //the pawn is blocking a check, so it can't be moved
                return;
			}
		}


        //makes move
        public void MakeMove() 
        { 
        }

        //unmakes move
        public Position UnMakeMove()
		{
            return prev;
		}
    }

    
}
