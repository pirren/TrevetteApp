using System;
using System.Threading.Tasks;
using trevette_api.Domain.Models;
using trevette_api.Domain.Repositories;
using trevette_api.Domain.Services;
using trevette_api.Domain.Services.Communication;

namespace trevette_api.Services
{
    public class SalesObjectService : ISalesObjectService
    {
        private readonly ISalesObjectRepository _repository;

        public SalesObjectService(ISalesObjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<SalesObject[]> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<SalesObject[]> ListInstockAsync()
        {
            return await _repository.ListInstockAsync();
        }

        public Task<SalesObject> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SalesObjectResponse> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SalesObjectResponse> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SalesObjectResponse> DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
