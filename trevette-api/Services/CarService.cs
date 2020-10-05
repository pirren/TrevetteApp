using Serilog;
using System;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Repositories;
using trevette_api.Domain.Services;
using trevette_api.Domain.Services.Communication;

namespace trevette_api.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CarService(ICarRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Car[]> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public async Task<CarResponse> SaveAsync(Car car)
        {
            try
            {
                await _repository.AddAsync(car);
                await _unitOfWork.CompleteAsync();

                return new CarResponse(car);
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred when saving the car: {0}", ex.Message);
                return new CarResponse($"An error occurred when saving the car: {ex.Message}");
            }
        }

        public async Task<CarResponse> UpdateAsync(int id, Car car)
        {
            var existingCar = await _repository.FindByIdAsync(id);

            if (existingCar == null)
                return new CarResponse("Car not found");

            existingCar.Model = car.Model;
            existingCar.Year = car.Year;
            existingCar.Mileage = car.Mileage;
            existingCar.Photos = car.Photos;

            try
            {
                _repository.Update(existingCar);
                await _unitOfWork.CompleteAsync();

                return new CarResponse(existingCar);
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred when updating the car: {0}", ex.Message);
                return new CarResponse($"An error occurred when updating the car: {ex.Message}");
            }
        }

        public async Task<CarResponse> DeleteAsync(int id)
        {
            var existingCar = await _repository.FindByIdAsync(id);

            if (existingCar == null)
                return new CarResponse("Car not found.");

            try
            {
                _repository.Remove(existingCar);
                await _unitOfWork.CompleteAsync();

                return new CarResponse(existingCar);
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred when deleting the car: {0}", ex.Message);
                return new CarResponse($"An error occurred when deleting the car: {ex.Message}");
            }
        }
    }
}
