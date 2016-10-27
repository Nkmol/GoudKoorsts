﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GoudkoortsModelLib.GeneratedCode.Model;

namespace Model
{
    using Helper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Boat : MovingObject
	{
        public readonly Point direction;
        public static int MAX_CARGO = 8;


        public bool Docked
        {
            get;
            set;
        }

		public virtual int Cargo
		{
			get;
			private set;
		}

	    public SailTile Tile
	    {
	        get; set; }

        public Boat(SailTile tile)
        {
            direction = new Point(-1, 0); // Boat always moves from right to left.

            Tile = tile;

        }

        public bool addCargo()
        {
            if(Cargo >= MAX_CARGO)
                return false;

            Cargo++;

            return true;
        }

        public void Dock()
        {
            // Check if the boat should doc

                if ( (Tile.Coords.x == Tile.Board.Port.Coords.x) && ( (Tile.Coords.y + 1) == Tile.Board.Port.Coords.y) )
                {
                    if (Cargo < MAX_CARGO)
                        Docked = true;
                    else {
                        Docked = false;
                        Move();
                    }
            }
            else
            {
                Move();
            }
            
        }

        public override void Tick()
		{
            //Cargo = 8;
            Dock();
		}


        public override void Move()
        {

            var t = Tile.Coords;
            var d = direction;
            var Boat = this;

            SailTile tile = null;
            Point newCoords = Tile.Coords + direction;

            if (newCoords.x != -1)
            {
                tile = Tile.Board.Field.Get<SailTile>(newCoords);
            }
                
            if(tile != null){

               Tile.Contain = null;
               tile.Contain = Boat;
               Tile = tile;
                                
            } else {
                //
                Tile.Coords = Tile.Board.Field.Get<SailTile>().Last().Coords;
                Tile.Contain = null;
                SailTile nextTile = Tile.Board.Field.Get<SailTile>(Tile.Coords);
                nextTile.Contain = Boat;
                Tile = nextTile;
                Cargo = 0;
                
            }


        }
    }
}

