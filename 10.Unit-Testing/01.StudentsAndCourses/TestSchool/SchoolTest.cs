namespace TestSchool
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestIfCourseValueIsNull()
        {
            var school = new School();
            List<Course> courses = null;

            school.Courses = courses;

            Assert.AreEqual(null, school.Courses, "School coureses is not null!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfCourseValueIsEmpty()
        {
            var school = new School();
            List<Course> courses = new List<Course>();

            school.Courses = courses;

            Assert.AreEqual(0, school.Courses.Count, "School courses is not empty!");
        }

        [TestMethod]
        public void TestIfCoursesGetterWillReturnCorrectValue()
        {
            var school = new School();
            List<Student> students = new List<Student>();       
            List<Course> courses = new List<Course>();

            courses.Add(new Course(students));
            school.Courses = courses;

            Assert.AreEqual(courses, school.Courses, "Getter don't return same result");
        }
    }
}
