﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Helper;

namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Board
	{
		public virtual DynamicDoubleList<Tile> Field
		{
			get;
			set;
		}

        public virtual IEnumerable<Tile> Vak
		{
			get;
			set;
		}

		public virtual IEnumerable<Storage> Loods
		{
			get;
			set;
		}

		public virtual Game Game
		{
			get;
			set;
		}

	    public Board()
	    {
	        Field = new DynamicDoubleList<Tile>();
	    }

	    public const string Level = "goudkoortsmap.txt";

		public static Board Generate()
		{
            Board board = new Board();
		    var enumerator = FileParser.readFileLines(Level).GetEnumerator();

		    int y = 0;
		    while (enumerator.MoveNext())
		    {
		        int x = 0;
		        foreach (char c in enumerator.Current)
		        {
		            Point p = new Point(x, y);
		            Tile tile = Tile.Create(c, p);

		            tile.Board = board; // set parent

		            board.Field[x, y] = tile; // Add to the field

                    x++;
                }
		        y++;
		    }

            // Clean
            enumerator.Dispose();

            return board;
		}

	}
}

