﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Helper;
using Process;

namespace Model
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Board : ITickAble, IRunAble
    {
		public virtual DynamicDoubleList<Tile> Field
		{
			get;
			set;
		}

        public static Dictionary<int, SwitchTile> Switches
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

        public PortTile Port
        {
            get;
            set;
        }


		public virtual Game Game
		{
			get;
			set;
		}

        public SynchronizedCollection<MovingObject> MovsRef { get; set; }


        public Board()
	    {
	        Field = new DynamicDoubleList<Tile>();
            MovsRef = new SynchronizedCollection<MovingObject>();
	    }


	    public const string Level = "goudkoortsmap.txt";

		public static Board Generate()
		{

            Board board = new Board();
            Switches = new Dictionary<int, SwitchTile>();
		    int keyCounter = 0;

		    int y = 0;
		    foreach (var row in FileParser.readFileLines(Level))
		    {
		        int x = 0;
		        foreach (char c in row)
		        {
		            Point p = new Point(x, y);
		            Tile tile = Tile.Create(c, p);

		            tile.Board = board; // set parent
                    
                    // TODO overloading method for special preperation for each Tile Type
		            if (tile is SwitchTile)  // check if Tile belongs to the switches
		            {
		                SwitchTile switchTile = (SwitchTile)tile;
                        Switches.Add(keyCounter++, switchTile); // increase the counter to fetch the next key
		            } 

                    // TODO Ugly 
                    if(c == 'B')
                        board.MovsRef.Add((Boat)tile.Contain);

		            board.Field[x, y] = tile; // Add to the field

                       x++;
                }
                y++;
            }

            board.Port = (PortTile)board.Field.Get<PortTile>().First();

            return board;
        }

        public bool IsInside(Point coords)
        {
            return coords.y >= 0 && coords.x >= 0 && coords.y < Field.Count &&
                   coords.x < Field[coords.y].Count;
        }

        public void Lock()
        {
        }

        public List<T> GetAllThatContains<T>()
        {
            return (from b in Field from a in b select a.Contain).OfType<T>().ToList();
        }

        public void Tick()
        {
            foreach (MovingObject s in MovsRef)
                s.Tick();
        }

        public void Run()
        {
            // Activate all tickAble object inside the board

            // Activate runables
            foreach (IRunAble s in GetAllThatContains<IRunAble>())
                s.Run();
        }
    }
}

