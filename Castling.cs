using System;
using System.Collections.Generic;
using System.Text;

namespace MoonRabbit
{
	//this struct holds bools related to the conditions required to check for castling.
	//for example if a king or rook has moved AT ALL we can automatically set to false, and we don't have to check
	public struct Castling
	{
		public bool kingMoved;
		public bool kRookMoved;
		public bool qRookMoved;

		public Castling(bool kMoved,bool kRookMoved,bool qRookMoved)
		{
			this.kingMoved = kMoved;
			this.kRookMoved = kRookMoved;
			this.qRookMoved = qRookMoved;
		}
	}
}
