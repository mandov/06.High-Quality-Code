namespace TestSchool
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;
 
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfCourseListAddedMoreStudentsWhenReachMaximum()
        {
            var students = new List<Student>();
            for (int i = 0; i < 40; i++)
            {
                students.Add(new Student("Petyr",i));
            }

            var course = new Course(students);
        }

        [TestMethod]
        public void TestIfStudentsGetterReturnsCorrectValue()
        {
            var students = new List<Student>();
            students.Add(new Student("Todor",123));

            var course = new Course(students);

            Assert.AreEqual(students, course.Students, "Students Getter in Course doesn't returns correct value");
        }
    }
}