namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestIfNameIsEmpty()
        {
            var student = new Student(string.Empty,0);

            Assert.AreEqual(string.Empty, student.Name, "String is not empty!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestIfNameIsNull()
        {
            var student = new Student(null,0);

            Assert.AreEqual(null, student.Name, "String is not null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfUniqueNumberIsInRange()
        {
            var student = new Student("Gosho",0);

            Assert.IsTrue(student.UniqueNumber > 10000   && student.UniqueNumber > 99999, "UniqueNumber is in range!");
        }

        [TestMethod]
        public void TestIfNameGetterReturnsCorrectValue()
        {
            var student = new Student("Ivan",0);

            Assert.AreEqual("Ivan", student.Name, "Name Getter doesn't return correct value");
        }

        [TestMethod]
        public void TestIfUniqueNumberGetterReturnsCorrectValue()
        {
            var student = new Student("Pesho",12345);

            Assert.AreEqual(12345, student.UniqueNumber, "UniqueNumber Getter doesn't return correct value");
        }
    }
}
