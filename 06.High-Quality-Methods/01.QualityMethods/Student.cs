namespace QualityMethods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string BornDate { get; set; }

        public bool IsOlderThan(string bornDate)
        {
            DateTime firstDate = DateTime.Parse(this.BornDate);
            DateTime secondDate = DateTime.Parse(bornDate);
            bool isOlder = firstDate > secondDate;

            return !isOlder;
        }
    }
}