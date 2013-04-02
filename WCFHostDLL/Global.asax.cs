using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WCFHostDLL.NativeDllCalculator;

namespace WCFHostDLL
{
    public class Global : System.Web.HttpApplication
    {
        string dllHostPath = @"Redist\DllHostx86.exe";

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        private const int ClientInitTimeOut = 20; // in seconds

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Make sure that our dll host is running
            EnsureDllHostRunning();

            // Make sure the client is connected
            EnsureCalcServiceClientConnected();
        }

        private void EnsureDllHostRunning()
        {
            Process[] p = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(dllHostPath));
            if (p.Length == 0)
            {
                Application["CalcServiceClient"] = null;
                //ProcessStartInfo psi = new ProcessStartInfo(dllHostPath);
                ProcessStartInfo psi = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dllHostPath).ToString());
                Process dllHost = Process.Start(psi);
            }
        }

        private void EnsureCalcServiceClientConnected()
        {
            CalcServiceClient client;
            client = (CalcServiceClient)Application["CalcServiceClient"];
            if (client == null || client.State != System.ServiceModel.CommunicationState.Opened)
            {
                client = GetCalcServiceClient();
                Application["CalcServiceClient"] = client;
            }
        }

        private CalcServiceClient GetCalcServiceClient()
        {
            CalcServiceClient serv = null;

            int retryCount = 0;
            bool connected = false;
            while (retryCount < ClientInitTimeOut * 10)
            {
                try
                {

                    EndpointAddress address = new EndpointAddress("net.pipe://localhost/CalculatorService");
                    NetNamedPipeBinding binding = new NetNamedPipeBinding();
                    binding.ReceiveTimeout = TimeSpan.MaxValue;

                    serv = new CalcServiceClient(binding, address);
                    serv.Open();
                    if (serv.State == System.ServiceModel.CommunicationState.Opened)
                    {
                        connected = true;
                        break;
                    }
                }
                catch (Exception e)
                {
                }

                retryCount++;
                System.Threading.Thread.Sleep(100);
            }

            if (!connected)
            {
                throw new TimeoutException("Couldn't connect to the calculator service.");
            }

            return serv;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}