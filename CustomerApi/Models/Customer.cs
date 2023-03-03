namespace CustomerApi.Models
{
    public class Customer
    {
        public string companyName { get; set; }
        public int registrationNumber { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public Address defaultBillingAddress { get; set; }
        public Address defaultShippingAddress { get; set;}
    }
}
