using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeManager.svc or EmployeeManager.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeManager : IEmployeeManager
    {
        EmployeeCommandRepository ecr = new EmployeeCommandRepository();
        EmployeeQueryRepository eqr = new EmployeeQueryRepository();

        public List<Employee> GetAllEmployee()
        {
            return eqr.ShowEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return eqr.GetEmployeeById(id);
        }

        public void Insert(Employee emp)
        {
            ecr.SaveEmployee(emp);
        }

        public void Update(Employee emp)
        {
             ecr.UpdateEmployee(emp);
        }

        public void Delete(int id)
        {
            ecr.DeleteEmployee(id);
        }
    }
}
