using Microsoft.EntityFrameworkCore.ChangeTracking;
using Packt.CS7;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        // cache the customers in a thread-safe dictionary
        // to imporve performance
        private static ConcurrentDictionary<string, Customer> customerCache;

        private Northwind db;

        public CustomerRepository(Northwind db)
        {
            this.db = db;

            // pre-load customers from database as a normal
            // Dictionary with CustomerID is the key,
            // then convert to a thread-safe ConcurrentDictionary
            if (customerCache == null)
            {
                customerCache = new ConcurrentDictionary<string, Customer>(db.Customers.ToDictionary(c => c.CustomerID));
            }
        }

        public async Task<Customer> CreateAsync(Customer c)
        {
            // normalize CustomerID into uppercase
            c.CustomerID = c.CustomerID.ToUpper();

            // add to database using EF core
            EntityEntry<Customer> added = await db.Customers.AddAsync(c);

            int affected = await db.SaveChangesAsync();

            if (affected == 1)
            {
                // if the customer is new, add it to cache, else
                // call UpdateCahce method
                return customerCache.AddOrUpdate(c.CustomerID, c, UpdateCache);
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<Customer>> RetrieveAllAsync()
        {
            // for performance, get from cache
            return await Task.Run<IEnumerable<Customer>>(() => customerCache.Values);
        }

        public async Task<Customer> RetrieveAsync(string id)
        {
            return await Task.Run(() =>
            {
                // for performace, get from cache
                id = id.ToUpper();
                customerCache.TryGetValue(id, out Customer c);
                return c;
            });
        }

        public Customer UpdateCache(string id, Customer c)
        {
            if (customerCache.TryGetValue(id, out Customer old))
            {
                if (customerCache.TryUpdate(id, c, old))
                {
                    return c;
                }
            }

            return null;
        }

        public async Task<Customer> UpdateAsync(string id, Customer c)
        {
            return await Task.Run(() =>
            {
                // normalize customer ID
                id = id.ToUpper();
                c.CustomerID = c.CustomerID.ToUpper();

                // update in database
                db.Customers.Update(c);
                int affected = db.SaveChanges();

                if (affected == 1)
                {
                    // update in cache
                    return Task.Run(() => UpdateCache(id, c));
                }

                return null;
            });
        }

        public async Task<bool> DeleteAsync(string id)
        {
            return await Task.Run(() =>
            {
                id = id.ToUpper();

                // remove from database
                Customer c = db.Customers.Find(id);
                db.Customers.Remove(c);
                int affected = db.SaveChanges();

                if (affected == 1)
                {
                    // remove from cache
                    return Task.Run(() => customerCache.TryRemove(id, out c));
                }
                else
                {
                    return null;
                }
            });
        }
    }
}
