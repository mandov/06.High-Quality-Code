namespace ClassChefInCSharp
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        private IList<Vegetable> content;

        public Bowl()
        {
            this.content = new List<Vegetable>();
        }

        public void Add(Vegetable vegetable)
        {
            if (vegetable == null)
            {
                throw new NullReferenceException();
            }

            this.content.Add(vegetable);
        }
    }
}