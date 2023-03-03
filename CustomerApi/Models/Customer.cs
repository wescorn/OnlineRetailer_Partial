﻿namespace CustomerApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int RegistrationNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string DefaultBillingAddress { get; set; }
        public string DefaultShippingAddress { get; set;}
    }
}
