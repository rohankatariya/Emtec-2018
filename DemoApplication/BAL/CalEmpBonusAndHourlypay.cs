using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CalEmpBonusAndHourlypay
    {
        public IEmployeeManager DecideAndCalculate(int empTypeId)
        {
            IEmployeeManager imp = null;

            if(empTypeId == 1)
            {
                imp = new PermenentEmployeeType();
            }
            else
            {
                imp = new ContractEmployeeType();
            }
            return imp;
        }
    }
}
