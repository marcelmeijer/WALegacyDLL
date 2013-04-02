using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DllHostx86
{
    class CalculatorDll : ICalcService
    {
        //REMARK: msvcr110d.dll is needed because the Win32Project1.dll is build in debug mode.

        [DllImport("Win32Project1.dll", SetLastError = true)]
        public static extern Int32 Calculate(Int32 delay);

        public int RekenDllExample()
        {
            return Calculate(Convert.ToInt32(ConfigurationManager.AppSettings["sleep"].ToString()));
        }
    }
}
