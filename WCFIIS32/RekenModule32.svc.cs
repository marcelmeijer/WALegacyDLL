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

namespace WCFIIS32
{
    public class RekenModule32 : IRekenModule32
    {
        [DllImport("Win32Project1.dll", SetLastError = true)]
        public static extern Int32 Calculate(Int32 delay);

        private static Mutex mutex = new Mutex();

        public int Calculate32()
        {
            return Calculate(Convert.ToInt32(RoleEnvironment.GetConfigurationSettingValue("sleep").ToString()));
        }

        public int Calculate32Mutex()
        {
            int result = 0;

            mutex.WaitOne();
            try
            {
                result = Calculate32();
            }
            finally
            {
                mutex.ReleaseMutex();
            }

            return result;
        }
    }
}
