﻿using System.Collections.Generic;
using System.Linq;
using CustomerApi.Models;
using System;

namespace CustomerApi.Data
{
    public class DbInitializer : IDbInitializer
    {
        // This method will create and seed the database.
        public void Initialize(CustomerApiContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Look for any Products
            if (context.Customers.Any())
            {
                return; // DB has been seeded
            }

            List<Customer> customer = new List<Customer>
            {
                new Customer { companyName = "Bad Company", registrationNumber = 1, emailAddress = "bcompanyofficial@bcompany.com", phoneNumber = "51223432" } // TODO Need Default Billing and Shipping Address
            };

            context.Customers.AddRange(customer);
            context.SaveChanges();
        }
    }
}
