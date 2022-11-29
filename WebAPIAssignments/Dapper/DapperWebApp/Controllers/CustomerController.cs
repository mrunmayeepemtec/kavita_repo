using Dapper;
using DapperWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperWebApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<CustomerModel>("CustomerViewAll"));
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if(id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CustomerId", id);
                return View(DapperORM.ReturnList<CustomerModel>("CustomerViewById", param).FirstOrDefault<CustomerModel>());
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(CustomerModel cust)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CustomerId", cust.CustomerId);
            param.Add("@Name", cust.Name);
            param.Add("@Address", cust.Address);
            param.Add("@Age", cust.Age);
            param.Add("@Email", cust.Email);
            param.Add("@Phone", cust.Phone);
            DapperORM.ExecuteWithoutReturn("CustomerAddOrEdit", param);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CustomerId", id);
            DapperORM.ExecuteWithoutReturn("CustomerDeleteByID", param);
            return RedirectToAction("Index");
        }
    }
}