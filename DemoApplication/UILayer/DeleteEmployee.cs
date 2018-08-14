using BAL;
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
    public partial class DeleteEmployee : Form
    {
        EmployeeManager em = new EmployeeManager();
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void Navbtn_Click(object sender, EventArgs e)
        {
            NavigationForm ng = new NavigationForm();
            ng.Show();
            Hide();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(txtEmpId.Text);
            em.DeleteEmployeeData(empId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(txtEmpId.Text);
            
            if(em.SearchEmployeeData(empId)!=null)
            {
                lblSearchData.Text = "Data Found...Do you want to delete this?";
            }
            else
            {
                lblSearchData.Text = "Data Not Found...";
            }
        }
    }
}
