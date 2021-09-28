using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KendoUiCore.Models
{
    public class CustomerRepository
    {
        public List<CustomerModel> GetAllCustomer()
        {
            var customerList = new List<CustomerModel>()
            {
                        new CustomerModel() { CustomerID = "1", ContactName= "Jonh 1", CompanyName= "IVS 1", Country= "US" },
                        new CustomerModel() { CustomerID= "2", ContactName= "Jonh 2", CompanyName= "IVS 1", Country= "Uk" },
                        new CustomerModel() { CustomerID= "3", ContactName= "Jonh 3", CompanyName= "IVS 1", Country= "CN" },
                        new CustomerModel() { CustomerID= "4", ContactName= "Jonh 4", CompanyName= "IVS 1", Country= "VN" },
                        new CustomerModel() { CustomerID= "5", ContactName= "Jonh 5", CompanyName= "IVS 1", Country= "US" },
                        new CustomerModel() { CustomerID= "6", ContactName= "Jonh 6", CompanyName= "IVS 1", Country= "HK" },                 
                        new CustomerModel() { CustomerID= "7", ContactName= "Jonh 7", CompanyName= "IVS 1", Country= "Uk" },
                        new CustomerModel() { CustomerID= "8", ContactName= "Jonh 8", CompanyName= "IVS 1", Country= "CN" },
                        new CustomerModel() { CustomerID= "9", ContactName= "Jonh 9", CompanyName= "IVS 1", Country= "VN" },
                        new CustomerModel() { CustomerID= "10", ContactName= "Jonh 10", CompanyName= "IVS 1", Country= "US" }

            };
            return customerList;
        }
            
    }
}
