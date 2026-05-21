namespace A_usable_chessboard_type_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int BOARD_WIDTH_AND_HEIGHT = 8;
            string move = "";
            bool checkmate = false;
            bool draw = false;
            bool whiteToMove = true;
            string[,] board = new string[BOARD_WIDTH_AND_HEIGHT, BOARD_WIDTH_AND_HEIGHT];
            string[] moveComponents = new string[3];
            List<string> movecomponents = new List<string> {"","",""};
            List<string> boardColums = new List<string> {"a","b","c","d","e", "f", "g", "h"};
            List<string> pieces = new List<string> {"P", "p", "N", "n", "B", "b", "R", "r", "Q", "q", "K", "k"};
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

            while (checkmate == false && draw == false)
            {
                Console.Write("/");
                Console.Write(" ");

                foreach (string boardColum in boardColums)
                {
                    Console.Write($"{boardColum}");
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int i = 0; i < BOARD_WIDTH_AND_HEIGHT; i++)
                {
                    Console.Write($"{i+1}");
                    Console.Write(" ");

                    for (int j = 0; j < BOARD_WIDTH_AND_HEIGHT; j++)
                    {
                        Console.Write(board[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine("");
                }
                move = Console.ReadLine();
                for (int i = 0;i < 2;  i++)
                {
                    moveComponents[i] = move[i].ToString();
                }
                moveComponents[2] = move[2].ToString();
                foreach (string piece in pieces)
                    if (piece == moveComponents[0])
                    {
                        for (int i = 0; i < BOARD_WIDTH_AND_HEIGHT; i++)
                        {
                            for (int j = 0; j < BOARD_WIDTH_AND_HEIGHT; j++)
                            {
                                if (board[j,i] == piece)
                                {
                                    board[j, i] = "0";
                                    for (int k = 0; k < BOARD_WIDTH_AND_HEIGHT; k++)
                                    {
                                        if (boardColums[k] == moveComponents[1])
                                        {
                                            board[k, Convert.ToInt32(moveComponents[2])-1] = piece;
                                        }
                                    }
                                }
                            }
                        }
                        Console.WriteLine($"{piece}");
                    }


                Console.WriteLine($"{move}");
            }
        }
    }
}
