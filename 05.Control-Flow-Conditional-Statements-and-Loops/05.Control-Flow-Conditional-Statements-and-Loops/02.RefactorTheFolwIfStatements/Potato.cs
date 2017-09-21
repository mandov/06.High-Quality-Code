namespace RefactorTheFolwIfStatements
{
    public class Potato
    {
        private bool isPeeled;
        private bool isRotten;

        public Potato(bool isPeeled, bool isRotten)
        {
            this.isPeeled = isPeeled;
            this.isRotten = isRotten;
        }

        public bool IsBeenPeeled
        {
            get { return this.isPeeled; }
        }

        public bool IsRotten
        {
            get { return this.isRotten; }
        }
    }
}