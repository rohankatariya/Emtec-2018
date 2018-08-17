using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeManager" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeManager
    {
        [OperationContract]
        List<Employee> GetAllEmployee();

        [OperationContract]
        Employee GetEmployeeById(int id);

        [OperationContract]
        void Insert(Employee emp);

        [OperationContract]
        void Update(Employee emp);

        [OperationContract]
        void Delete(int id);

    }
}
