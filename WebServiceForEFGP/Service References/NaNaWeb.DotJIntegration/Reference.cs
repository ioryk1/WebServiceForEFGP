﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceForEFGP.NaNaWeb.DotJIntegration {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice.nana.dsc.com/", ConfigurationName="NaNaWeb.DotJIntegration.DotJIntegration")]
    public interface DotJIntegration {
        
        [System.ServiceModel.OperationContractAttribute()]
        void runMethod();
        
        [System.ServiceModel.OperationContractAttribute()]
        void runMethodAsync();
        
        [System.ServiceModel.OperationContractAttribute()]
        void invokeDotJProcessResetService();
        
        [System.ServiceModel.OperationContractAttribute()]
        void invokeDotJProcessResetServiceAsync();
        
        [System.ServiceModel.OperationContractAttribute()]
        void invokeDotJConfirmService();
        
        [System.ServiceModel.OperationContractAttribute()]
        void invokeDotJConfirmServiceAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DotJIntegrationChannel : WebServiceForEFGP.NaNaWeb.DotJIntegration.DotJIntegration, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DotJIntegrationClient : System.ServiceModel.ClientBase<WebServiceForEFGP.NaNaWeb.DotJIntegration.DotJIntegration>, WebServiceForEFGP.NaNaWeb.DotJIntegration.DotJIntegration {
        
        public DotJIntegrationClient() {
        }
        
        public DotJIntegrationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DotJIntegrationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DotJIntegrationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DotJIntegrationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void runMethod() {
            base.Channel.runMethod();
        }
        
        public void runMethodAsync() {
            base.Channel.runMethodAsync();
        }
        
        public void invokeDotJProcessResetService() {
            base.Channel.invokeDotJProcessResetService();
        }
        
        public void invokeDotJProcessResetServiceAsync() {
            base.Channel.invokeDotJProcessResetServiceAsync();
        }
        
        public void invokeDotJConfirmService() {
            base.Channel.invokeDotJConfirmService();
        }
        
        public void invokeDotJConfirmServiceAsync() {
            base.Channel.invokeDotJConfirmServiceAsync();
        }
    }
}
