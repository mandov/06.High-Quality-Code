using System;
using System.Linq;

class Startup
{
    static void Main()
    {
        string size = Console.ReadLine();
        int row = Convert.ToInt32(size.Substring(0, 1));
        int col = Convert.ToInt32(size.Substring(size.Length - 1, 1));
        char[,] den = new char[row, col];
        for (int i = 0; i < den.GetLength(0); i++)
        {
            char[] path = Console.ReadLine().ToCharArray();
            for (int j = 0; j < den.GetLength(1); j++)
            {
                den[i, j] = path[j];
            }
        }

        int curCol = 0;
        for (int i = 0; i < den.GetLength(1); i++)
        {
            if (den[0, i] == 's')
            {
                curCol = i;
            }
        }

        bool stop = false;
        string[] directions = Console.ReadLine().Split(',').ToArray();
        int counter = 0;
        int length = 3;
        int curRow = 0;
        int moves = 0;
        while (directions.Length >= counter)
        {
            moves++;

            if (moves == 5)
            {
                length--;
                moves = 0;
            }

            if (length <= 0)
            {
                Console.WriteLine("Snacky will starve at [{0},{1}]", curRow, curCol);
                break;
            }

            switch (directions[counter])
            {
                case "d":
                    curRow++;
                    if (curRow > den.GetLength(0) - 1)
                    {
                        Console.WriteLine("Snacky will be lost into the depths with length {0}", length);
                        stop = true;
                        break;
                    }

                    break;
                case "u":
                    curRow--;
                    break;
                case "l":
                    curCol--;
                    if (curCol < 0)
                    {
                        curCol = den.GetLength(1) - 1;
                    }

                    break;
                case "r":
                    curCol++;
                    if (curCol > den.GetLength(1) - 1)
                    {
                        curCol = 0;
                    }

                    break;
                default:
                    break;
            }

            int startCol = curCol;
            int startRow = curRow;
            counter++;
            if (startRow == curRow && startCol == curCol)
            {
                Console.WriteLine("Snacky will get out with length {0}", length);
                break;
            }

            if (stop)
            {
                break;
            }

            switch (den[curRow, curCol])
            {
                case '*':
                    length++;
                    den[curRow, curCol] = ' ';
                    break;
                case '#':
                    length--;
                    Console.WriteLine("Snacky will hit a rock at [{0},{1}]", curRow, curCol);
                    stop = true;
                    break;
                case '.': break;
            }

            if (stop)
            {
                break;
            }

            if (counter > directions.Length - 1)
            {
                Console.WriteLine("Snacky will be stuck in the den at [{0},{1}]", curRow, curCol);
                break;
            }
        }
    }
}