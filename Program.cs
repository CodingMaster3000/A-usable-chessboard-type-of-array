namespace A_usable_chessboard_type_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int BOARD_WIDTH_AND_HEIGHT = 8;
            string move;
            bool checkmate = false;
            bool draw = false;
            string[,] board = new string[BOARD_WIDTH_AND_HEIGHT, BOARD_WIDTH_AND_HEIGHT];
            for (int i = 0; i < BOARD_WIDTH_AND_HEIGHT; i++)
            {
                for (int j = 0; j < BOARD_WIDTH_AND_HEIGHT; j++)
                {
                    board[i, j] = "0";
                }
            }
            for (int i = 0; i < BOARD_WIDTH_AND_HEIGHT; i++)
            {
                board[1, i] = "P";
                board[6, i] = "p";
            }
            board[0, 1] = "N";
            board[0, 6] = "N";
            board[7, 1] = "n";
            board[7, 6] = "n";
            board[0, 2] = "B";
            board[0, 5] = "B";
            board[7, 2] = "b";
            board[7, 5] = "b";
            board[0, 0] = "R";
            board[0, 7] = "R";
            board[7, 0] = "r";
            board[7, 7] = "r";
            board[0, 3] = "Q";
            board[7, 3] = "q";
            board[0, 4] = "K";
            board[7, 4] = "k";
            //"P" = Pawn, "K" = Knight, "B" = Bishop, "R" = Rook, "Q" = Queen, "K" = King, uppercase = white, lowercase = black
            for (int i = 0; i < BOARD_WIDTH_AND_HEIGHT; i++)
            {
                for (int j = 0; j < BOARD_WIDTH_AND_HEIGHT; j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            while (checkmate == false && draw == false)
            {
                move = Console.ReadLine();
                Console.WriteLine($"{move}");
            }
        }
    }
}
