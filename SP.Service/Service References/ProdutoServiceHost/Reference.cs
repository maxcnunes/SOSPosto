﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP.Service.ProdutoServiceHost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProdutoServiceHost.IProdutoService")]
    public interface IProdutoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProdutoService/Inserir", ReplyAction="http://tempuri.org/IProdutoService/InserirResponse")]
        SP.Contract.Data.Produto Inserir(SP.Contract.Data.Produto _produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProdutoService/BuscarTodos", ReplyAction="http://tempuri.org/IProdutoService/BuscarTodosResponse")]
        SP.Contract.Data.Produto[] BuscarTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProdutoService/QtdeDisponivel", ReplyAction="http://tempuri.org/IProdutoService/QtdeDisponivelResponse")]
        bool QtdeDisponivel(SP.Contract.Data.Produto _produto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProdutoServiceChannel : SP.Service.ProdutoServiceHost.IProdutoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProdutoServiceClient : System.ServiceModel.ClientBase<SP.Service.ProdutoServiceHost.IProdutoService>, SP.Service.ProdutoServiceHost.IProdutoService {
        
        public ProdutoServiceClient() {
        }
        
        public ProdutoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProdutoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProdutoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProdutoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SP.Contract.Data.Produto Inserir(SP.Contract.Data.Produto _produto) {
            return base.Channel.Inserir(_produto);
        }
        
        public SP.Contract.Data.Produto[] BuscarTodos() {
            return base.Channel.BuscarTodos();
        }
        
        public bool QtdeDisponivel(SP.Contract.Data.Produto _produto) {
            return base.Channel.QtdeDisponivel(_produto);
        }
    }
}