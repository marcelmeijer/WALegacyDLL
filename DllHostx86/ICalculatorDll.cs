using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace DllHostx86
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int RekenDllExample();
    }
}
