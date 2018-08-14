using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int num1,int num2);
        [OperationContract]
        int Sub(int num1, int num2);
        [OperationContract]
        int Div(int num1, int num2);
        [OperationContract]
        int Mul(int num1, int num2);
    }
}
