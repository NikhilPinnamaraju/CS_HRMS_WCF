using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using emplib;
namespace wcfemplib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmpservice
    {
        [OperationContract]
        List<employee> GetEmployees();
        [OperationContract]

         void addfield(employee emp);
        [OperationContract]
        void DeleteEmpById(int ecode);
        [OperationContract]
        void UpdateEmpById(employee emp);
        [OperationContract]
        employee GetEmpById(int ecode);

    }
   
}

  
