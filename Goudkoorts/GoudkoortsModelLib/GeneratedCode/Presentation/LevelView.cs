﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics;
using Model;
using Process;

namespace Presentation
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class LevelView
	{

		public virtual void Print(Board board)
		{
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Time :" + Math.Round(board.Game.TimeTick / 1000f));
            Console.WriteLine("Score : " + board.Game.Score);
		    Console.WriteLine();

            foreach (List<Tile> row in board.Field)
		    {
		        foreach (Tile tile in row)
		        {
		            Console.ForegroundColor = ConsoleColor.White;
		            FactoryView.CreateTile(tile)?.Draw();
		        }
                Console.WriteLine();
		    }

            Console.WriteLine("\nDe volgende knoppen besturen de switches op de map: ");
            Console.WriteLine("Toetsenbord knoppen: {0}", string.Join(", ", GameController.SwitchButtons));
		}

	}
}

