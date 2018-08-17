using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeQueryRepository
    {
        public Employee GetEmployeeById(int EmpId)
        {
            SqlDataReader sdr = DbClass.ExecuteReader("spEmployees_GetAllById", System.Data.CommandType.StoredProcedure,
                                                        new SqlParameter("@Id",EmpId)
                                                     );
            Employee emp=new Employee();
            while(sdr.Read())
            {
                emp.Id = Convert.ToInt32(sdr["Id"].ToString());
                emp.Name = sdr["Name"].ToString();
                emp.Department = sdr["Department"].ToString();
            }
            sdr.Close();
            return emp;
        }
        public List<Employee> ShowEmployees()
        {
            SqlDataReader sdr = DbClass.ExecuteReader("spEmployees_GetAll", System.Data.CommandType.StoredProcedure);
            List<Employee> listEmployee = new List<Employee>();
            while(sdr.Read())
            {
                listEmployee.Add(
                    new Employee()
                    {
                        Id = Convert.ToInt32(sdr["Id"].ToString()),
                        Name = sdr["Name"].ToString(),
                        Department = sdr["Department"].ToString()
                    });
            }
            sdr.Close();
            return listEmployee;
        }
    }
}
