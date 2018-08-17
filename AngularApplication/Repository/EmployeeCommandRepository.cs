using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public void SaveEmployee(Employee emp)
        {
            DbClass.ExecuteNonQuery("spEmployees_Insert", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter("@Name", emp.Name),
                                    new SqlParameter("@Department", emp.Department)
                                    ); 
        }
        public void UpdateEmployee(Employee emp)
        {
            DbClass.ExecuteNonQuery("spEmployees_Update", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter("@Id", emp.Id),
                                    new SqlParameter("@Name", emp.Name),
                                    new SqlParameter("@Department", emp.Department)
                                    );
        }
        public void DeleteEmployee(int empId)
        {
            DbClass.ExecuteNonQuery("spEmployees_Delete", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter("@Id", empId)
                                    );
        }
    }
}
