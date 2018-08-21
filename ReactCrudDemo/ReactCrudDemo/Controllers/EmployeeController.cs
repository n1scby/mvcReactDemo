using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactCrudDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactCrudDemo.Controllers
{
   
    public class EmployeeController : Controller
    {

        EmployeeDataAccessLayer objEmployee = new EmployeeDataAccessLayer();

        // GET: api/<controller>
        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return objEmployee.GetAllEmployees();
        }

        // GET Details
        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public TblEmployee Details(int id)
        {
            return objEmployee.GetEmployeeData(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Employee/Create")]
        public int Create(TblEmployee employee)
        {
            return objEmployee.AddEmployee(employee);
        }

        // PUT 
        [HttpPut]
        [Route("api/Employee/Edit")]
        public int Edit(TblEmployee employee)
        {
            return objEmployee.UpdateEmployee(employee);
        }

        // DELETE 
        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return objEmployee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route ("api/Employee/GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return objEmployee.GetCities();
        }

    }
}
