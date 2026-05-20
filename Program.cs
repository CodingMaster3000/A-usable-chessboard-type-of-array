namespace A_usable_chessboard_type_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[8, 8];


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = "0";
                }
            }
            for (int i = 0; i < 8; i++)
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

            for (int i = 0;i < 8;i++)
            {
                for (int j = 0;j < 8;j++)
                {
                    Console.Write(board[i,j]);
                    Console.Write(" ");

                }
                Console.WriteLine("");

            }
        }
    }
}
