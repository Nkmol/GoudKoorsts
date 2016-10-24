﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Security.Cryptography;

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Timers;

    public class Game : ITickAble, IRunAble
	{
        public const int TIME_INTERVAL = 10000; // Miliseconds


        public int TimeTick
        {
            get;
            private set;
        }

		public virtual Timer Timer
		{
			get;
			set;
		}

        public Board Board
        {
            get;
            set;
        }

        public Game()
        {
            // Create Timer
            Timer = new Timer();
            Timer.Elapsed += new ElapsedEventHandler((source, e) => Tick());
            Timer.Interval = 1000;
            TimeTick = TIME_INTERVAL;


            // Load game objects
            GenerateGame();
        }

		public virtual void GenerateGame()
		{
            // Create board
            Board = Board.Generate();
		    Board.Game = this;
		}

		public virtual void Tick()
		{
            if (TimeTick <= 0)
                TimeTick = TIME_INTERVAL;
            else
                TimeTick -= 1000;



		    // TODO : Board.Lock()
		}

        public void Run()
        {
            Timer.Enabled = true;

            // Activate any Runnable in board
            Board.Run();
        }

	}
}

