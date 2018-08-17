using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IEmployeeCommandRepository
    {
        void SaveEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int empId);
    }
}
