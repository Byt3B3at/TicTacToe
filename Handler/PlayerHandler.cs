using System;
using System.Collections.Generic;
using System.Threading;
using TicTacToe.Model;

namespace TicTacToe.Handler
{
    public class PlayerHandler : IMovementHandler
    {
        private Thread MovementThread { get; set; }
        private static readonly object _lock = new object();

        private readonly List<ConsoleKey> ListOfAllowedConsoleKeysForPlayerMovement = new List<ConsoleKey>
        {
                ConsoleKey.DownArrow,
                ConsoleKey.LeftArrow,
                ConsoleKey.RightArrow,
                ConsoleKey.UpArrow,
                ConsoleKey.X
        };

        public void Init()
        {
            MovementThread = new Thread(ProcessPlayerMovement);
            MovementThread.Start();
        }

        private void ProcessPlayerMovement()
        {
            ConsoleKey pressedKey;
            do
            {
                lock (_lock)
                {
                    pressedKey = Console.ReadKey(true).Key;
                    if (!ListOfAllowedConsoleKeysForPlayerMovement.Contains(pressedKey))
                        continue;
                    else if (pressedKey == ConsoleKey.DownArrow)
                        TurnDownHandler();
                    else if (pressedKey == ConsoleKey.LeftArrow)
                        TurnLeftHandler();
                    else if (pressedKey == ConsoleKey.RightArrow)
                        TurnRightHandler();
                    else if (pressedKey == ConsoleKey.UpArrow)
                        TurnUpHandler();
                }
            }
            while (pressedKey != ConsoleKey.X);
        }

        // needs 2x keypress
        public void TurnDownHandler()
        {
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            // If not already at one of the bottom fields...
            if (!((left == PlayField.Field7[0] && top == PlayField.Field7[1])
                || (left == PlayField.Field8[0] && top == PlayField.Field8[1])
                || (left == PlayField.Field9[0] && top == PlayField.Field9[1])))
            {
                top += 4;
                // ...turn down...
                Console.SetCursorPosition(left, top);
            }
        }

        // needs 3x keypress
        public void TurnLeftHandler()
        {
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            // If not already at one of the outer left fields...
            if (!((left == PlayField.Field1[0] && top == PlayField.Field1[1])
                || (left == PlayField.Field4[0] && top == PlayField.Field4[1])
                || (left == PlayField.Field7[0] && top == PlayField.Field7[1])))
            {
                left -= 16;
                // ...turn left...
                Console.SetCursorPosition(left, top);
            }
        }

        // needs 4x keypress
        public void TurnRightHandler()
        {
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            // If not already at one of the outer right fields...
            if (!((left == PlayField.Field3[0] && top == PlayField.Field3[1])
                || (left == PlayField.Field6[0] && top == PlayField.Field6[1])
                || (left == PlayField.Field9[0] && top == PlayField.Field9[1])))
            {
                left += 16;
                // ...turn right...
                Console.SetCursorPosition(left, top);
            }
        }

        // needs 5x keypress
        public void TurnUpHandler()
        {
            var left = Console.CursorLeft;
            var top = Console.CursorTop;
            // If not already at one of the top fields...
            if (!((left == PlayField.Field1[0] && top == PlayField.Field1[1])
                || (left == PlayField.Field2[0] && top == PlayField.Field2[1])
                || (left == PlayField.Field3[0] && top == PlayField.Field3[1])))
            {
                top -= 4;
                // ...turn up...
                Console.SetCursorPosition(left, top);
            }
        }
    }
}
