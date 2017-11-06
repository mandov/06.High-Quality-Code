namespace Matrix
{
    using System;
    using System.Text;

    public class WalkInMatrix
    {
        private int size;
        private int[,] matrix;
        private int numberOfMoves = 1;
        private int currentRow;
        private int currentCol;
        private int nextRow = 1;
        private int nextCol = 1;

        public WalkInMatrix(int size)
        {
            this.Size = size;
            this.matrix = new int[this.Size, this.Size];
            this.FillMatrix();
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (0 > value || 100 < value)
                {
                    throw new ArgumentException("Size is not in [0 - 100] range");
                }

                this.size = value;
            }
        }

        private void FillMatrix()
        {
            while (true)
            {
                this.matrix[currentRow, currentCol] = numberOfMoves;

                if (!CheckForContinuingPath())
                {
                    numberOfMoves++;
                    FindEmptyCell();
                    nextCol = 1;
                    nextRow = 1;
                    if (!CheckForContinuingPath())
                    {
                        break;
                    }

                    this.matrix[currentRow, currentCol] = numberOfMoves;

                }

                if (IsItOutOfRange(currentRow + nextRow) || IsItOutOfRange(currentCol + nextCol) || matrix[currentRow + nextRow, currentCol + nextCol] != 0)
                {
                    while (IsItOutOfRange(currentRow + nextRow) || IsItOutOfRange(currentCol + nextCol) || matrix[currentRow + nextRow, currentCol + nextCol] != 0)
                    {
                        ChangeDirection();
                    }
                }

                currentRow += nextRow;
                currentCol += nextCol;
                numberOfMoves++;
            }
        }

        private void ChangeDirection()
        {
            int[] directionsRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int numberInSequence = 0;
            for (int count = 0; count < directionsRow.Length; count++)
            {
                if (directionsRow[count] == this.nextRow && directionsCol[count] == this.nextCol)
                {
                    numberInSequence = count;
                    break;
                }
            }

            if (numberInSequence == directionsRow.Length - 1)
            {
                this.nextRow = directionsRow[0];
                this.nextCol = directionsCol[0];

            }
            else
            {
                this.nextRow = directionsRow[numberInSequence + 1];
                this.nextCol = directionsCol[numberInSequence + 1];
            }
        }

        private bool CheckForContinuingPath()
        {
            int[] directionsRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            SetToZeroIndexesWhichGoesOutOfRange(ref directionsRow, ref directionsCol);
            return IsThereEmptyCell(directionsRow, directionsCol);
        }

        private void SetToZeroIndexesWhichGoesOutOfRange(ref int[] directionsRow, ref int[] directionsCol)
        {
            for (int i = 0; i < directionsRow.Length; i++)
            {
                if (IsItOutOfRange(currentRow + directionsRow[i]))
                {
                    directionsRow[i] = 0;
                }

                if (IsItOutOfRange(currentCol + directionsCol[i]))
                {
                    directionsCol[i] = 0;
                }
            }
        }

        private bool IsThereEmptyCell(int[] directionsRow, int[] directionsCol)
        {
            for (int i = 0; i < directionsRow.Length; i++)
            {
                if (this.matrix[this.currentRow + directionsRow[i], this.currentCol + directionsCol[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsItOutOfRange(int index)
        {
            if (index < 0 || index >= this.size)
            {
                return true;
            }

            return false;
        }

        private void FindEmptyCell()
        {
            this.currentRow = 0;
            this.currentCol = 0;
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(0); j++)
                {
                    if (this.matrix[i, j] == 0)
                    {
                        this.currentRow = i;
                        this.currentCol = j;
                        return;
                    }
                }
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    stringBuilder.AppendFormat("{0,3}", matrix[row, col]);
                }

                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}