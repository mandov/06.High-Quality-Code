namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<Course> courses = new List<Course>();      

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Courses is null!");
                }

                if (value.Count == 0)
                {
                    throw new ArgumentException("Courses is empty!");
                }

                this.courses = value;
            }
        }
    }
}
