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
    using System.Timers;

    public class Game : ITickAble
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

            // Load game objects
            GenerateGame();
        }

		public virtual void GenerateGame()
		{
            // Create board
            Board = Board.Generate();
		}

		public virtual void Tick()
		{
            Console.WriteLine(++TimeTick); // visual test
            if (TimeTick >= TIME_INTERVAL / 1000) TimeTick = 0;
            
            // TODO : Board.Lock()
		}

        public void Run()
        {
            Timer.Enabled = true;
        }

	}
}

