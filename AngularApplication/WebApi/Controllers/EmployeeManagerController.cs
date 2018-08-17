using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.EmployeeManagerService;

namespace WebApi.Controllers
{
    [RoutePrefix("Employee")]
    public class EmployeeManagerController : ApiController
    {
        EmployeeManagerClient emc = new EmployeeManagerClient();
        [Route("GetAll")]
        [HttpGet]
        public Employee[] GetAllEmployee()
        {
            return emc.GetAllEmployee();
        }

        [Route("GetById")]
        [HttpGet]
        public Employee GetEmployeeById(int id)
        {
            return emc.GetEmployeeById(id);
        }

        [Route("Insert")]
        [HttpPost]
        public void Insert([FromBody]Employee emp)
        {
            emc.Insert(emp);
        }

        [Route("Update")]
        [HttpPut]
        public void Update([FromBody]Employee emp)
        {
            emc.Update(emp);
        }

        [Route("Delete")]
        [HttpPut]
        public void Delete(int id)
        {
            emc.Delete(id);
        }
    }
}
