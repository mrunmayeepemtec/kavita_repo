using CrudApiAdo.net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CrudApiAdo.net.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetCustomers")]

        public List<CustomerModel> GetCustomer()
        {
            return LoadListFromDB();
        }

        [HttpGet]
        [Route("GetCustomerByID")]

        public List<CustomerModel> GetCustomerByID(string Id)
        {
            return LoadListFromDB().Where(e => e.Code == Id).ToList();
        }

        [HttpPost]
        [Route("PostCustomer")]

        public string PostCustomer(CustomerModel Obj)
        {
            //List<CustomerModel> listmain = new List<CustomerModel>();
            //listmain.Add(model);

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("Insert into Customer values('" + Obj.Code.ToString() + "','" + Obj.Name.ToString() + "','" + Obj.Email.ToString() + "','" + Obj.Phone.ToString() + "','" + Obj.Address.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return "Customer Added Successfully.";
        }

        [HttpDelete]
        [Route("DeleteCustomer")]

        public string DeleteCustomer(string Id)
        {

            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            SqlCommand cmd = new SqlCommand("Delete from Customer where Code='" + Id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return "Customer Delete Successfully.";
        }


        private List<CustomerModel> LoadListFromDB()
        {
            var customerList = new List<CustomerModel>();
            //List<CustomerModel> listmain = new List<CustomerModel>();
            DataTable dt = new DataTable();

            using(SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var customer = new CustomerModel()
                {
                   Code = dt.Rows[i]["Code"].ToString(),
                   Name = dt.Rows[i]["Name"].ToString(),
                   Email = dt.Rows[i]["Email"].ToString(),
                   Phone = dt.Rows[i]["Phone"].ToString(),
                   Address = dt.Rows[i]["Address"].ToString()
                };
                customerList.Add(customer);
            }
            return customerList;
        }
    }
}
