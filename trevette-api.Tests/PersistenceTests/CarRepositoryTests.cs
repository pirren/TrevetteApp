using Moq;
using Moq.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using trevette_api.Domain.Models;
using trevette_api.Persistence.Contexts;
using trevette_api.Persistence.Repositories;
using Xunit;

namespace trevette_api.PersistenceTests
{
    public class CarRepositoryTests
    {
        [Fact]
        public async void ListAsync_ListingAllCars_ReturnsExpectedCarCount()
        {
            var mockContext = new Mock<DataContext>();
            var mockCars = GetMockCars();
            mockContext.Setup(x => x.Cars).ReturnsDbSet(mockCars);
            var carRepository = new CarRepository(mockContext.Object);

            var result = await carRepository.ListAsync();

            Assert.True(result.Length == mockCars.Count);
        }

        [Fact]
        public async void ListForsaleAsync_ListingAllCarsForSale_ReturnsExpectedCountOfCarsForsale()
        {
            var mockContext = new Mock<DataContext>();
            var mockCars = GetMockCars();
            mockContext.Setup(x => x.Cars).ReturnsDbSet(mockCars);
            var carRepository = new CarRepository(mockContext.Object);

            var result = await carRepository.ListAsync();
            var expected = 1;

            Assert.Equal(expected, result.Where(c => c.SalesObject != null).Count());
        }

        [Fact]
        public async void FindByIdAsync_GetSpecificCarById_ReturnsExpectedCarEntity()
        {
            var mockContext = new Mock<DataContext>();
            var mockCars = GetMockCars();
            mockContext.Setup(x => x.Cars).ReturnsDbSet(mockCars);
            var carRepository = new CarRepository(mockContext.Object);

            var result = await carRepository.FindByIdAsync(2);
            var expectedCar = new Car
            {
                CarId = 2,
                Model = "Volvo 240",
                Year = 1980,
                Mileage = 40000
            };
            var expected = (
                expectedCar.CarId == result.CarId
                && expectedCar.Model == result.Model
                && expectedCar.Year == result.Year
                && expectedCar.Mileage == result.Mileage
                );

            Assert.True(expected);
        }

        private static List<Car> GetMockCars()
        {
            return new List<Car>
            {
                new Car
                {
                    CarId = 1,
                    Model = "Porsche 911 Carrera",
                    Year = 1980,
                    Mileage = 12000,
                    SalesObject = new SalesObject
                    {
                        SalesObjectId = 1
                    }
                }, new Car
                {
                    CarId = 2,
                    Model = "Volvo 240",
                    Year = 1980,
                    Mileage = 40000
                }, new Car
                {
                    CarId = 3,
                    Model = "Saab 9-3",
                    Year = 2012,
                    Mileage = 3000
                }, new Car
                {
                    CarId = 4,
                    Model = "Ferrari 250 Testa Rossa",
                    Year = 1960,
                    Mileage = 15000
                }
            };
        }
    }
}
