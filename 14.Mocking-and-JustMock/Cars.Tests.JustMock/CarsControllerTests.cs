namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SearchShouldReturnBMW()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Search("BMW"));
            Assert.AreEqual("BMW", model[0].Make);
        }

        [TestMethod]
        public void SortedByYearShouldReturn2005()
        {
            var cars = (IList<Car>)this.carsData.SortedByYear();
            Assert.AreEqual(2005, cars[0].Year);
        }


        [TestMethod]
        public void SortedByMakeShouldReturnAudi()
        {
            var cars = (IList<Car>)this.carsData.SortedByYear();
            Assert.AreEqual("Audi", cars[0].Make);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortShouldThrowArgumentExceptionWhenParameterIsInvalid()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort("type"));
        }

        [TestMethod]
        public void ShouldReturnLikeFirstElementAudiWhenIsSortedByMake()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));
            Assert.AreEqual("Audi", cars[0].Make);
        }

        [TestMethod]
        public void ShouldRetunLikeFirstElement2005WhenIsSortedByYear()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));
            Assert.AreEqual(2005, cars[0].Year);
        }

        [TestMethod]
        public void DetailForvalidCarShouldWorkCOrrectly()
        {
            var detailsForCar = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual(1, detailsForCar.Id);
            Assert.AreEqual("Audi", detailsForCar.Make);
            Assert.AreEqual(2005, detailsForCar.Year);
        }
        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
