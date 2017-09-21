using RefactorTheFolwIfStatements;

class Startup
{
    static void Main()
    {
        Matrix matrix = new Matrix(4, 5);
        bool isInMatrix = matrix.IsPointIsInMatrix();
        bool shouldVisitCell = true;
        if (isInMatrix && shouldVisitCell)
        {
            matrix.VisitCell();
        }
    }
}