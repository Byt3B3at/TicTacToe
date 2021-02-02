using System;
using TicTacToe.Model;

namespace TicTacToe.Handler
{
    public class GameHandler : IGameHandler
    {
        private readonly PlayField PlayFieldInstance;
        private readonly PlayerHandler PlayerHandlerInstance;

        public GameHandler(IPlayField playField)
        {
            PlayFieldInstance = (PlayField)playField;
            PlayFieldInstance.Draw();

            PlayerHandlerInstance = new PlayerHandler();
        }

        public bool GameEndHandler()
        {
            foreach (var WinningCondition in WinningConditions)
            {
                // TODO: Check after 3 moves every next move, if NPC/Player reached WinningCondition.
                for (int i = 0; i < WinningCondition.GetLength(0); i++)
                {
                    // ...
                }
            }
            return false;
        }

        public void GameStartHandler()
        {
            Console.SetCursorPosition(PlayField.Field1[0], PlayField.Field1[1]); // Offset 1 needed at the start...?!

            PlayerHandlerInstance.Init();
        }

        /// <summary>
        /// Using WinningConditions to show the possible Positions for an X or an O.
        /// </summary>
        public void DrawWinningConditions()
        {
            foreach (var WinningCondition in GameHandler.WinningConditions)
            {
                // Length gibt die Anzahl aller Elemente in allen Dimensionen zurueck;
                // GetLength(n) nur aus der angegebenen Dimension des Arrays.
                for (int i = 0; i < WinningCondition.GetLength(0); i++)
                {
                    Console.SetCursorPosition(WinningCondition[i, 0], WinningCondition[i, 1]);
                    Console.Write("X");
                }
            }
        }

        /// <summary>
        /// "Hard coded" WinningConditions.
        /// TODO: Implement every single WinningCondition and/or develop an Algorithm that counts 3 in a row as a victory.
        /// - need to define what is a "row"
        /// - if "row" is given = win/loss
        /// </summary>
        /// <remarks>
        /// Declaration and Initialization of Jagged array with four 2-D arrays.
        /// </remarks>
        public static int[][,] WinningConditions { get; set; } = new int[8][,]
        {
            new int[,]
            {
                { PlayField.Field1[0], PlayField.Field1[1] },   /// |  X  |  X  |  X  |
                { PlayField.Field2[0], PlayField.Field2[1] },   /// |     |     |     |
                { PlayField.Field3[0], PlayField.Field3[1] }    /// |     |     |     |
            },
            new int[,]
            {
                { PlayField.Field4[0], PlayField.Field4[1] },   /// |     |     |     |
                { PlayField.Field5[0], PlayField.Field5[1] },   /// |  X  |  X  |  X  |
                { PlayField.Field6[0], PlayField.Field6[1] }    /// |     |     |     |
            },
            new int[,]
            {
                { PlayField.Field7[0], PlayField.Field7[1] },   /// |     |     |     |
                { PlayField.Field8[0], PlayField.Field8[1] },   /// |     |     |     |
                { PlayField.Field9[0], PlayField.Field9[1] }    /// |  X  |  X  |  X  |
            },
            new int[,]
            {
                { PlayField.Field1[0], PlayField.Field1[1] },   /// |  X  |     |     |
                { PlayField.Field5[0], PlayField.Field5[1] },   /// |     |  X  |     |
                { PlayField.Field9[0], PlayField.Field9[1] }    /// |     |     |  X  |
            },
            new int[,]
            {
                { PlayField.Field3[0], PlayField.Field3[1] },   /// |     |     |  X  |
                { PlayField.Field5[0], PlayField.Field5[1] },   /// |     |  X  |     |
                { PlayField.Field8[0], PlayField.Field8[1] }    /// |  X  |     |     |
            },
            new int[,]
            {
                { PlayField.Field1[0], PlayField.Field1[1] },   /// |  X  |     |     |
                { PlayField.Field4[0], PlayField.Field4[1] },   /// |  X  |     |     |
                { PlayField.Field7[0], PlayField.Field7[1] }    /// |  X  |     |     |
            },
            new int[,]
            {
                { PlayField.Field2[0], PlayField.Field2[1] },   /// |     |  X  |     |
                { PlayField.Field5[0], PlayField.Field5[1] },   /// |     |  X  |     |
                { PlayField.Field8[0], PlayField.Field8[1] }    /// |     |  X  |     |
            },
            new int[,]
            {
                { PlayField.Field3[0], PlayField.Field3[1] },   /// |     |     |  X  |
                { PlayField.Field6[0], PlayField.Field6[1] },   /// |     |     |  X  |
                { PlayField.Field9[0], PlayField.Field9[1] }    /// |     |     |  X  |
            },
        };
    }
}
