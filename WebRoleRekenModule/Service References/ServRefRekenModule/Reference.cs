﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRoleRekenModule.ServRefRekenModule {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServRefRekenModule.IRekenModuleService")]
    public interface IRekenModuleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRekenModuleService/RekenDllExample", ReplyAction="http://tempuri.org/IRekenModuleService/RekenDllExampleResponse")]
        int RekenDllExample();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRekenModuleService/RekenDllExampleMutex", ReplyAction="http://tempuri.org/IRekenModuleService/RekenDllExampleMutexResponse")]
        int RekenDllExampleMutex();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRekenModuleServiceChannel : WebRoleRekenModule.ServRefRekenModule.IRekenModuleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RekenModuleServiceClient : System.ServiceModel.ClientBase<WebRoleRekenModule.ServRefRekenModule.IRekenModuleService>, WebRoleRekenModule.ServRefRekenModule.IRekenModuleService {
        
        public RekenModuleServiceClient() {
        }
        
        public RekenModuleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RekenModuleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RekenModuleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RekenModuleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int RekenDllExample() {
            return base.Channel.RekenDllExample();
        }
        
        public int RekenDllExampleMutex() {
            return base.Channel.RekenDllExampleMutex();
        }
    }
}
