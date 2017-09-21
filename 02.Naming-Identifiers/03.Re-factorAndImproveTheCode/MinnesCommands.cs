namespace RefactorAndImproveTheCode
{
    using System;
    using System.Collections.Generic;

    public static class MinnesCommands
    {
        public static void YourTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char numberOfBombs = NumberOfBombs(bombs, row, col);
            bombs[row, col] = numberOfBombs;
            field[row, col] = numberOfBombs;
        }

        public static void DrawGameField(char[,] gameField)
        {
            int rols = gameField.GetLength(0);
            int cols = gameField.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rols; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", gameField[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public static char[,] PlantTheBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int randomNumber in randomNumbers)
            {
                int col = randomNumber / cols;
                int row = randomNumber % cols;
                if (row == 0 && randomNumber != 0)
                {
                    col--;
                    row = col;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        public static char NumberOfBombs(char[,] gameField, int row, int col)
        {
            int counter = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < col)
            {
                if (gameField[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }

        public static void Standings(List<Player> player)
        {
            Console.WriteLine("\nPoints:");
            if (player.Count > 0)
            {
                for (int i = 0; i < player.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, player[i].Name, player[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty standings!\n");
            }
        }
    }
}