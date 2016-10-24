﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime;

namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class RailTile : Tile, IDirection
	{
        public Point Direction { get; set; }

        public Tile Next => Board.GetTile(Coords + Direction);

        public override Object Contain
        {
            get { return _contain; }
            set
            {
                if (value is Cart)
                    _contain = value;
                else
                    throw new ArgumentException();
            }
        }

	    private static readonly Dictionary<char, Point> DirectionMapping = new Dictionary<char, Point>()
	    {
	        {'→', Point.Right},
	        {'←', Point.Left},
	        {'↑', Point.Up},
	        {'↓', Point.Down},
	    };

        public RailTile(Point coords, Board board = null) : base(coords, board)
	    {
	        this.Coords = coords;
	        this.Board = board;
	    }

        public RailTile(Point coords, char direction, Board board = null) : this(coords, board)
        {
            Direction = DirectionMapping[direction];
        }


        public bool IsOccupied()
        {
            return (this.Contain != null);
        }
	}
}

