﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class RailTile : Tile
	{
        public Point Direction { get; set; }

		public virtual Cart Cart
		{
			get;
			set;
		}

	    public RailTile(Point coords, Board board = null) : base(coords, board)
	    {
	        this.Coords = coords;
	        this.Board = board;
	    }


        public bool IsOccupied()
        {
            return (this.Cart != null);
        }
	}
}

