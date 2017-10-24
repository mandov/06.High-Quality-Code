namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private List<Student> students = new List<Student>();

        public Course(List<Student> students)
        {
            this.Students = students;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {    
                if (value.Count >= 30 || this.students.Count >= 30)
                {
                    throw new ArgumentException("Course can't have more than 30 students!");
                }

                this.students = value;
            }
        }
    }
}
