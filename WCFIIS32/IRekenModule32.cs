using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFIIS32
{
    [ServiceContract]
    public interface IRekenModule32
    {
        [OperationContract]
        int Calculate32();

        [OperationContract]
        int Calculate32Mutex();
    }
}
