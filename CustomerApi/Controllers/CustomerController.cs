﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CustomerApi.Data;
using CustomerApi.Models;
using RestSharp;

namespace CustomerApi.Controllers
{
    /*  TO DO
     *  Register (company name and registration number, email address, phone number, billing and shipping address.)
        Change (email address, phone number, billing and shipping address.)

        When the online retail system receives an order, the following actions should take place:
        
        Before customers can submit orders, they must register themselves
        
        When a new order is created, the number of items ordered for each product are reserved in the system.

        when the ordered items are shipped, the reservations are removed, and the number of items in stock are decremented for each ordered product.

        Because customers pay on delivery, no credit card information is needed.

        the customer does not exist, the order should be rejected, and the client, who sent the request, should be notified.

        The retail system should check the customer’s credit standing and the inventory level before accepting the order.

        If the customer has outstanding bills, the order should be rejected, and the customer should be notified.

        Similarly, if some items in the order are not in stock, the order should be rejected, and the customer should be notified.

        If the customer is in good credit standing and the order items are all in stock, the order should be accepted, and an order confirmation should be returned to the customer.

        For each product, the following information should be available: Product registration number, name, price, category, the number of items in stock, and the number of items reserved.
     */
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> repository;

        public CustomerController(IRepository<Customer> repos)
        {
            repository = repos;
        }

        // GET: customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return repository.GetAll();
        }

        // register a custoemr
        [HttpPost]
        public IActionResult Post ([FromBody] Customer Customer)
        {
            //Implement

            return NoContent();
        }

        // change customer information
        [HttpPut]
        public IActionResult Put ([FromBody] Customer Customer)
        {
            //Implement

            return NoContent();
        }
    }
}
