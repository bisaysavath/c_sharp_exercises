using Packt.CS7;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindService.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateAsync(Customer C);
        Task<IEnumerable<Customer>> RetrieveAllAsync();
        Task<Customer> RetrieveAsync(string id);
        Task<Customer> UpdateAsync(string id, Customer c);
        Task<bool> DeleteAsync(string id);
    }
}
