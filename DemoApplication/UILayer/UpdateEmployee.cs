using BAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class UpdateEmployee : Form
    {
        EmployeeManager em = new EmployeeManager();
        Employees emp = new Employees();
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void Navbtn_Click(object sender, EventArgs e)
        {
            NavigationForm ng = new NavigationForm();
            ng.Show();
            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            emp=em.SearchEmployeeData(Convert.ToInt32(txtEmpId.Text));
            txtName.Text = emp.EmployeeName;
            txtDept.Text = emp.Department;
            cmbUpdbx.SelectedIndex = emp.EmployeeTypeId-1;
        }

        private void btnUpdEmp_Click(object sender, EventArgs e)
        {
            emp.EmployeeId = Convert.ToInt32(txtEmpId.Text);
            emp.EmployeeName = txtName.Text;
            emp.Department = txtDept.Text;
            emp.EmployeeTypeId = cmbUpdbx.SelectedIndex+1;
            em.UpdateEmployeeData(emp);
            lblUpdStatus.Text = "Updated Successfully";
            
        }


 
    }
}
