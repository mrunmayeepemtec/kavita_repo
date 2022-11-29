using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CrudApiEntityFramework.DataModels;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CrudApiEntityFramework.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("GetCustomersEF")]

        public List<Customer> GetCustomersEF()
        {
            ado_dbContext context = new ado_dbContext();
            return context.Customers.ToList();
        }

        [HttpGet]
        [Route("GetCustomerByIDEF")]

        public List<Customer> GetCustomerByIDEF(string Id)
        {
            ado_dbContext context = new ado_dbContext();
            return context.Customers.Where(e => e.Code == Id).ToList();
        }

        [HttpPost]
        [Route("PostCustomerEF")]

        public string PostCustomerEF(Customer Obj)
        {
            ado_dbContext context = new ado_dbContext();
            context.Customers.Add(Obj);
            context.SaveChanges();
            return "Customer Added Successfully.";
        }

        [HttpDelete]
        [Route("DeleteCustomerEF")]

        public string DeleteCustomerEF(string Id)
        {

            ado_dbContext context = new ado_dbContext();
            var result = context.Customers.Where(e => e.Code == Id);
            context.Remove(result);
            context.SaveChanges();
             


            return "Customer Delete Successfully.";
        }



    }
}
