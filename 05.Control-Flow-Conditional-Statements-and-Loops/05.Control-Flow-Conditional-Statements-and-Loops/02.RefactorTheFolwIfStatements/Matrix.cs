namespace RefactorTheFolwIfStatements
{
    using System;

    public class Matrix
    {
        private const int MinRow = 0;
        private const int MaxRow = 10;
        private const int MinCol = 0;
        private const int MaxCol = 10;

        private int currentRow;
        private int currentCol;

        public Matrix(int currentRow, int currrentCol)
        {
            this.currentRow = currentRow;
            this.currentCol = currrentCol;
        }

        public bool IsPointIsInMatrix()
        {
            bool isOutOfRowRange = this.currentRow >= MinRow && this.currentRow <= MaxRow;
            bool isOutOfColRange = this.currentCol >= MinCol && this.currentCol <= MaxCol;
            bool isInMatrix = isOutOfColRange && isOutOfRowRange;

            return isInMatrix;
        }

        public void VisitCell()
        {
            Console.WriteLine($"You visit row:{currentRow} col:{currentCol}");
        }
    }
}
