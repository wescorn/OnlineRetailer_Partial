using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CustomerApi.Models;
using System;

namespace CustomerApi.Data
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly CustomerApiContext db;

        public CustomerRepository(CustomerApiContext context)
        {
            db = context;
        }

        Customer IRepository<Customer>.Add(Customer entity)
        {
            return entity; // Implement
        }

        void IRepository<Customer>.Edit(Customer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        Customer IRepository<Customer>.Get(int registrationNumber)
        {
            return db.Customers.FirstOrDefault(o => o.registrationNumber == registrationNumber);
        }

        IEnumerable<Customer> IRepository<Customer>.GetAll()
        {
            return db.Customers.ToList();
        }

        void IRepository<Customer>.Remove(int registrationNumber)
        {
            var customer = db.Customers.FirstOrDefault(p => p.registrationNumber == registrationNumber);
            db.Customers.Remove(customer);
            db.SaveChanges();
        }
    }
}
