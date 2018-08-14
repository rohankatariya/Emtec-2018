using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class EmployeeManager
    {
        EmployeeCommandRepository ecr = new EmployeeCommandRepository();
        EmployeeQueryRepository eqr = new EmployeeQueryRepository();

        public void SaveEmployeeData(Employees emp)
        {
            if(emp.EmployeeTypeId==1)
            {
                emp.HourlyPay = 20;
                emp.Bonusinc = 5;
            }
            else if(emp.EmployeeTypeId==2)
            {
                emp.HourlyPay = 15;
                emp.Bonusinc = 3;
            }
            
            ecr.SaveEmployee(emp);
        }
        public void UpdateEmployeeData(Employees emp)
        {
            if (emp.EmployeeTypeId == 1)
            {
                emp.HourlyPay = 20;
                emp.Bonusinc = 5;
            }
            else if (emp.EmployeeTypeId == 2)
            {
                emp.HourlyPay = 15;
                emp.Bonusinc = 3;
            }
            ecr.UpdateEmployee(emp);
        }
        public Employees SearchEmployeeData(int EmpId)
        {
            Employees emp = eqr.SearchResult(EmpId);
            return emp;
        }
    }
}
