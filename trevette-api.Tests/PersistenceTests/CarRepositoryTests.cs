using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        private static List<Car> GetMockCars()
        {
            return new List<Car>
            {
                new Car
                {
                    CarId = 1,
                    Model = "Porsche 911 Carrera",
                    Year = 1980,
                    Mileage = 12000
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
