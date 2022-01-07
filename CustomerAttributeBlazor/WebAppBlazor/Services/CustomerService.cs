using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppBlazor.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace WebAppBlazor.Services
{
    public class CustomerService : ICustomerService
    {
        public HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CustomerAttributeModel>> getAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<CustomerAttributeModel>>("/api/CustomerAttribute");
            return result;
        }

        public async Task<CustomerAttributeModel> GetOne(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<CustomerAttributeModel>("/api/CustomerAttribute");
            return result;
        }

        public Task<CustomerAttributeModel> Create(CustomerAttributeModel newCust)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAttributeModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerAttributeModel> Edit(CustomerAttributeModel editCust)
        {
            throw new NotImplementedException();
        }

    }
}
