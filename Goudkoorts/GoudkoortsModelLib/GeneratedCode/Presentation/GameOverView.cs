using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudkoortsModelLib.GeneratedCode.Presentation
{
    class GameOverView
    {
        public virtual void Print(Board board)
        {

            string gameover = "\n _______                                             \n";
            gameover += "(_______)                                            \n";
            gameover += " _   ___ _____ ____  _____     ___ _   _ _____  ____ \n";
            gameover += "| | (_  (____ |    \\| ___ |   / _ \\ | | | ___ |/ ___)\n";
            gameover += "| |___) / ___ | | | | ____|  | |_| \\ V /| ____| |    \n";
            gameover += " \\_____/\\_____|_|_|_|_____)   \\___/ \\_/ |_____)_|    \n";
            gameover += "                                                     \n";

            Console.WriteLine("Your score was: " + board.Game.Score);

            Console.ReadKey();
        }

    }
}
