namespace TicTacToe.Model
{
    /// <summary>
    /// -------------------
    /// |     |     |     |
    /// |  X  |  X  |  X  |
    /// |     |     |     |
    /// -------------------
    /// |     |     |     |
    /// |  X  |  X  |  X  |
    /// |     |     |     |
    /// -------------------
    /// |     |     |     |
    /// |  X  |  X  |  X  |
    /// |     |     |     |
    /// -------------------
    /// </summary>
    public class PlayField : IGameObject, IPlayField
    {
        public void Draw()
        {
            System.Console.WriteLine("------------------------------------------------|");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("------------------------------------------------|");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("------------------------------------------------|");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("|               |               |               |");
            System.Console.WriteLine("------------------------------------------------|");
        }

        // https://www.tutorialspoint.com/csharp/csharp_multi_dimensional_arrays.htm
        public static int[] Field1 { get; set; } = new int[2] { 8, 2 };
        public static int[] Field2 { get; set; } = new int[2] { 24, 2 };
        public static int[] Field3 { get; set; } = new int[2] { 40, 2 };
        public static int[] Field4 { get; set; } = new int[2] { 8, 6 };
        public static int[] Field5 { get; set; } = new int[2] { 24, 6 };
        public static int[] Field6 { get; set; } = new int[2] { 40, 6 };
        public static int[] Field7 { get; set; } = new int[2] { 8, 10 };
        public static int[] Field8 { get; set; } = new int[2] { 24, 10 };
        public static int[] Field9 { get; set; } = new int[2] { 40, 10 };
    }
}
