using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace WCFHostDLL
{
    public class RekenModuleService : IRekenModuleService
    {
        private static Mutex mutex = new Mutex();

        public int RekenDllExample()
        {
            var ff = new NativeDllCalculator.CalcServiceClient();
            return ff.RekenDllExample();
        }

        public int RekenDllExampleMutex()
        {
            int result = 0;

            mutex.WaitOne();
            try
            {
                result = RekenDllExample();
            }
            finally
            {
                mutex.ReleaseMutex();
            }

            return result;
        }
    }
}
