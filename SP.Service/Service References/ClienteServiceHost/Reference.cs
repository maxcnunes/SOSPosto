﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP.Service.ClienteServiceHost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClienteServiceHost.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Inserir", ReplyAction="http://tempuri.org/IClienteService/InserirResponse")]
        SP.Contract.Data.Cliente Inserir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/BuscarPeloCodigo", ReplyAction="http://tempuri.org/IClienteService/BuscarPeloCodigoResponse")]
        SP.Contract.Data.Cliente BuscarPeloCodigo(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/BuscarPeloCartaoESenha", ReplyAction="http://tempuri.org/IClienteService/BuscarPeloCartaoESenhaResponse")]
        SP.Contract.Data.Cliente BuscarPeloCartaoESenha(string cartao, string senha);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : SP.Service.ClienteServiceHost.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<SP.Service.ClienteServiceHost.IClienteService>, SP.Service.ClienteServiceHost.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SP.Contract.Data.Cliente Inserir() {
            return base.Channel.Inserir();
        }
        
        public SP.Contract.Data.Cliente BuscarPeloCodigo(int codigo) {
            return base.Channel.BuscarPeloCodigo(codigo);
        }
        
        public SP.Contract.Data.Cliente BuscarPeloCartaoESenha(string cartao, string senha) {
            return base.Channel.BuscarPeloCartaoESenha(cartao, senha);
        }
    }
}
