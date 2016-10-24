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

        public SailTile Tile
        {
            get;
            set;
        }

		public virtual int Cargo
		{
			get;
			private set;
		}

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
            // Check if the boat should dock
                if ( (Tile.Coords.x == Tile.Board.Port.Coords.x) && ( (Tile.Coords.y + 1) == Tile.Board.Port.Coords.y) )
                {
                    if (Cargo < MAX_CARGO)
                        Docked = true;
                    else {
                        Docked = false;
                        Move();
                    }
                }
            
        }

        public override void Tick()
		{
            // Move Ship
            //Cargo = 8;
            //Cargo = 8;

            Dock();
		    // Psuedo code
		    // Get next VaarVak : Vak.Board.SetVak(this, Vak.Coords + direction);
		}


        public override void Move()
        {
            Point newCoords = Tile.Coords - direction;

            //TODO Check if we can get rid of the cast
            //Tile tile = Tile.Board.Field[newCoords.x][newCoords.y];
            SailTile tile = Tile.Board.Field.Get<SailTile>(newCoords);

            var Boat = this;

            if(tile != null){

                if (tile is SailTile)
                {
                    tile.Contain = Boat;
                    Tile = tile;
                }                
            }
            else
            {
                //
                Tile.Coords = Tile.Board.Field.Get<SailTile>().Last().Coords;
                SailTile nextTile = Tile.Board.Field.Get<SailTile>(Tile.Coords - Tile.Direction);
                nextTile.Contain = Boat;
                Cargo = 0;
                
            }


        }
    }
}

