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
            EmployeeManager em = new EmployeeManager();
            Employees emp=em.SearchEmployeeData(Convert.ToInt32(txtEmpId.Text));
            txtName.Text = emp.EmployeeName;
            txtDept.Text = emp.Department;
            if(emp.EmployeeTypeId==1)
            { 
                cmbUpdbx.SelectedText="Permenent";
            }
            else
            {
                cmbUpdbx.SelectedText = "Contract";
            }
        }


 
    }
}
