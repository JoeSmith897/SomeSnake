﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class GameOver
    {

        public static void gameOver(int _length, int _height) {
            Console.SetCursorPosition(_length / 2 - 4, _height / 2); Console.WriteLine("GameOver");
            Console.SetCursorPosition(_length / 2 - 13, (_height / 2) + 2); Console.WriteLine("Press any key for continue");
            Console.ReadLine();
            Console.SetCursorPosition(_length, _height + 3);
        }

    }
}
