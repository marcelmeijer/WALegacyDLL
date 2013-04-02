using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFHostDLL
{
    [ServiceContract]
    public interface IRekenModuleService
    {
        [OperationContract]
        int RekenDllExample();

        [OperationContract]
        int RekenDllExampleMutex();
    }
}
