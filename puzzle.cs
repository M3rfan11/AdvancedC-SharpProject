using System;
namespace puzzle{
public static class puzzleSolver{
      static int[,] board = new int[4, 4];
    static int blankX, blankY;
    static Random rand = new Random();

       public  static void InitializeBoard()
    {
        int num = 1;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                board[i, j] = num++;

        board[3, 3] = 0; // Blank
        blankX = 3;
        blankY = 3;
    }

   public static void ShuffleBoard()
    {
        for (int i = 0; i < 1000; i++)
        {
            int direction = rand.Next(4);
            int newX = blankX, newY = blankY;

            switch (direction)
            {
                case 0: newX = blankX + 1; break; // Up
                case 1: newX = blankX - 1; break; // Down
                case 2: newY = blankY + 1; break; // Left
                case 3: newY = blankY - 1; break; // Right
            }

            Move(newX, newY);
        }
    }

   public static void Move(int x, int y)
    {
        if (x >= 0 && x < 4 && y >= 0 && y < 4)
        {
            board[blankX, blankY] = board[x, y];
            board[x, y] = 0;
            blankX = x;
            blankY = y;
        }
    }

   public static void PrintBoard()
    {
        Console.WriteLine("===> 15 Puzzle <===\n");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (board[i, j] == 0)
                    Console.Write("    ");
                else
                    Console.Write($"{board[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

 public static bool IsSolved()
    {
        int count = 1;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                if (i == 3 && j == 3) return board[i, j] == 0;
                if (board[i, j] != count++) return false;
            }
        return true;
    }
    public static void MoveBlank(ConsoleKey key)
{
    switch (key)
    {
        case ConsoleKey.W: Move(blankX + 1, blankY); break;
        case ConsoleKey.S: Move(blankX - 1, blankY); break;
        case ConsoleKey.A: Move(blankX, blankY + 1); break;
        case ConsoleKey.D: Move(blankX, blankY - 1); break;
    }
}
}

}