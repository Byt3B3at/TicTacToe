using TicTacToe.Handler;
using TicTacToe.Model;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            var GameHandlerInstance = new GameHandler(new PlayField());
            GameHandlerInstance.GameStartHandler();
        }
    }
}
