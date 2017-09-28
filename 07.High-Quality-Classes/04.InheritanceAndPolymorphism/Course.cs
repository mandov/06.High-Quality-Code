namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string name)       
        {
            this.Name = name;
        }

        public Course(string name, string teacherName)          
        {
            this.Name = name;
            this.TeacherName = teacherName;
        }

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!Regex.IsMatch(value, "^[a-zA-Z\\s]+$"))
                {
                    throw new ArgumentException("Invalid  name.");
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be empty or null!");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (!Regex.IsMatch(value, "^[a-zA-Z\\s]+$"))
                {
                    throw new ArgumentException("Invalid teacher name.");
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Teacher name must not be empty or null!");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                  
                        throw new ArgumentException("Students list must not null!");
                    
                }

                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
