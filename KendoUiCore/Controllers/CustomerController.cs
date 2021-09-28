using KendoUiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KendoUiCore.Controllers
{
    public class CustomerController : Controller
    {
       CustomerRepository customerRepository = new CustomerRepository();
       public JsonResult GetAllCustomer()
        {
            var res = customerRepository.GetAllCustomer();
            var data = new
            {
                Items = res,
                TotalCount = res.Count
            };
            return new JsonResult(data);
        }
        
    }
}
