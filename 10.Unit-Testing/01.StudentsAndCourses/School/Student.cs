namespace StudentsAndCourses
{
    using System;

    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name is null or empty!");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value > 10000 || value > 99999)
                {
                    throw new ArgumentException("uniqueNumber must be in range [10000 - 99999]");
                }

                this.uniqueNumber = value;
            }
        }
    }
}
