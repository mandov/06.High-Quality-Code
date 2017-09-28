namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string name, string teacherName)
            : base(name, teacherName)
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
           : base(name, teacherName, students)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
          : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("lab must not be null or empty!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            if (this.Lab != null)
            {
                st.Append("; Lab = ");
                st.Append(this.Lab);
            }
            st.Append(" }");
            return base.ToString() + st.ToString();

        }
    }
}