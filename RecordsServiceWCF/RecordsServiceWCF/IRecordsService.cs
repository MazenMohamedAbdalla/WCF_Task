using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RecordsServiceWCF
{
    
    [ServiceContract]
    public interface IRecordsService
    {
        [OperationContract]
        bool checkName(string name);

        [OperationContract]
        int ageCalc(string birthDate);

        [OperationContract]
        int getAge();
    }

    
}
