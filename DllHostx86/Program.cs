using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;

namespace DllHostx86
{
    /// <summary>
    /// Build the resulting executable in the Redist directory of the WCFHostDLL project.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("net.pipe://localhost/CalculatorService");

            NetNamedPipeBinding binding = new NetNamedPipeBinding();
            binding.ReceiveTimeout = TimeSpan.MaxValue;

            using (ServiceHost host = new ServiceHost(typeof(CalculatorDll)))
            {
                var ff = host.AddServiceEndpoint(typeof(ICalcService), binding, address);
                ServiceMetadataBehavior metadata = new ServiceMetadataBehavior();

                host.Description.Behaviors.Add(metadata);
                host.Description.Behaviors.OfType<ServiceDebugBehavior>().First().IncludeExceptionDetailInFaults = true;

                Binding mexBinding = MetadataExchangeBindings.CreateMexNamedPipeBinding();
                Uri mexAddress = new Uri("net.pipe://localhost/CalculatorService/Mex");
                host.AddServiceEndpoint(typeof(IMetadataExchange), mexBinding, mexAddress);
                
                host.Open();

                Console.WriteLine("The receiver is ready");
                Console.ReadLine();
            }
        }
    }
}
