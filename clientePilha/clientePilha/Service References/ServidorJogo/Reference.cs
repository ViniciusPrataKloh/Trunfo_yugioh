//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientePilha.ServidorJogo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private int AtkField;
        
        private int DefField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Atk {
            get {
                return this.AtkField;
            }
            set {
                if ((this.AtkField.Equals(value) != true)) {
                    this.AtkField = value;
                    this.RaisePropertyChanged("Atk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Def {
            get {
                return this.DefField;
            }
            set {
                if ((this.DefField.Equals(value) != true)) {
                    this.DefField = value;
                    this.RaisePropertyChanged("Def");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServidorJogo.WsOperacoesSoap")]
    public interface WsOperacoesSoap {
        
        // CODEGEN: Generating message contract since element name getCardOponenteResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCardOponente", ReplyAction="*")]
        clientePilha.ServidorJogo.getCardOponenteResponse getCardOponente(clientePilha.ServidorJogo.getCardOponenteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCardOponente", ReplyAction="*")]
        System.Threading.Tasks.Task<clientePilha.ServidorJogo.getCardOponenteResponse> getCardOponenteAsync(clientePilha.ServidorJogo.getCardOponenteRequest request);
        
        // CODEGEN: Generating message contract since element name getStackResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getStack", ReplyAction="*")]
        clientePilha.ServidorJogo.getStackResponse getStack(clientePilha.ServidorJogo.getStackRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getStack", ReplyAction="*")]
        System.Threading.Tasks.Task<clientePilha.ServidorJogo.getStackResponse> getStackAsync(clientePilha.ServidorJogo.getStackRequest request);
        
        // CODEGEN: Generating message contract since element name carta from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/enviaCarta", ReplyAction="*")]
        clientePilha.ServidorJogo.enviaCartaResponse enviaCarta(clientePilha.ServidorJogo.enviaCartaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/enviaCarta", ReplyAction="*")]
        System.Threading.Tasks.Task<clientePilha.ServidorJogo.enviaCartaResponse> enviaCartaAsync(clientePilha.ServidorJogo.enviaCartaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCardOponenteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getCardOponente", Namespace="http://tempuri.org/", Order=0)]
        public clientePilha.ServidorJogo.getCardOponenteRequestBody Body;
        
        public getCardOponenteRequest() {
        }
        
        public getCardOponenteRequest(clientePilha.ServidorJogo.getCardOponenteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getCardOponenteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public getCardOponenteRequestBody() {
        }
        
        public getCardOponenteRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCardOponenteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getCardOponenteResponse", Namespace="http://tempuri.org/", Order=0)]
        public clientePilha.ServidorJogo.getCardOponenteResponseBody Body;
        
        public getCardOponenteResponse() {
        }
        
        public getCardOponenteResponse(clientePilha.ServidorJogo.getCardOponenteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getCardOponenteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public clientePilha.ServidorJogo.Card getCardOponenteResult;
        
        public getCardOponenteResponseBody() {
        }
        
        public getCardOponenteResponseBody(clientePilha.ServidorJogo.Card getCardOponenteResult) {
            this.getCardOponenteResult = getCardOponenteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getStackRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getStack", Namespace="http://tempuri.org/", Order=0)]
        public clientePilha.ServidorJogo.getStackRequestBody Body;
        
        public getStackRequest() {
        }
        
        public getStackRequest(clientePilha.ServidorJogo.getStackRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getStackRequestBody {
        
        public getStackRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getStackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getStackResponse", Namespace="http://tempuri.org/", Order=0)]
        public clientePilha.ServidorJogo.getStackResponseBody Body;
        
        public getStackResponse() {
        }
        
        public getStackResponse(clientePilha.ServidorJogo.getStackResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getStackResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public clientePilha.ServidorJogo.Card[] getStackResult;
        
        public getStackResponseBody() {
        }
        
        public getStackResponseBody(clientePilha.ServidorJogo.Card[] getStackResult) {
            this.getStackResult = getStackResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class enviaCartaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="enviaCarta", Namespace="http://tempuri.org/", Order=0)]
        public clientePilha.ServidorJogo.enviaCartaRequestBody Body;
        
        public enviaCartaRequest() {
        }
        
        public enviaCartaRequest(clientePilha.ServidorJogo.enviaCartaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class enviaCartaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public clientePilha.ServidorJogo.Card carta;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id;
        
        public enviaCartaRequestBody() {
        }
        
        public enviaCartaRequestBody(clientePilha.ServidorJogo.Card carta, int id) {
            this.carta = carta;
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class enviaCartaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="enviaCartaResponse", Namespace="http://tempuri.org/", Order=0)]
        public clientePilha.ServidorJogo.enviaCartaResponseBody Body;
        
        public enviaCartaResponse() {
        }
        
        public enviaCartaResponse(clientePilha.ServidorJogo.enviaCartaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class enviaCartaResponseBody {
        
        public enviaCartaResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WsOperacoesSoapChannel : clientePilha.ServidorJogo.WsOperacoesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsOperacoesSoapClient : System.ServiceModel.ClientBase<clientePilha.ServidorJogo.WsOperacoesSoap>, clientePilha.ServidorJogo.WsOperacoesSoap {
        
        public WsOperacoesSoapClient() {
        }
        
        public WsOperacoesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsOperacoesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsOperacoesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsOperacoesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientePilha.ServidorJogo.getCardOponenteResponse clientePilha.ServidorJogo.WsOperacoesSoap.getCardOponente(clientePilha.ServidorJogo.getCardOponenteRequest request) {
            return base.Channel.getCardOponente(request);
        }
        
        public clientePilha.ServidorJogo.Card getCardOponente(int id) {
            clientePilha.ServidorJogo.getCardOponenteRequest inValue = new clientePilha.ServidorJogo.getCardOponenteRequest();
            inValue.Body = new clientePilha.ServidorJogo.getCardOponenteRequestBody();
            inValue.Body.id = id;
            clientePilha.ServidorJogo.getCardOponenteResponse retVal = ((clientePilha.ServidorJogo.WsOperacoesSoap)(this)).getCardOponente(inValue);
            return retVal.Body.getCardOponenteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientePilha.ServidorJogo.getCardOponenteResponse> clientePilha.ServidorJogo.WsOperacoesSoap.getCardOponenteAsync(clientePilha.ServidorJogo.getCardOponenteRequest request) {
            return base.Channel.getCardOponenteAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientePilha.ServidorJogo.getCardOponenteResponse> getCardOponenteAsync(int id) {
            clientePilha.ServidorJogo.getCardOponenteRequest inValue = new clientePilha.ServidorJogo.getCardOponenteRequest();
            inValue.Body = new clientePilha.ServidorJogo.getCardOponenteRequestBody();
            inValue.Body.id = id;
            return ((clientePilha.ServidorJogo.WsOperacoesSoap)(this)).getCardOponenteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientePilha.ServidorJogo.getStackResponse clientePilha.ServidorJogo.WsOperacoesSoap.getStack(clientePilha.ServidorJogo.getStackRequest request) {
            return base.Channel.getStack(request);
        }
        
        public clientePilha.ServidorJogo.Card[] getStack() {
            clientePilha.ServidorJogo.getStackRequest inValue = new clientePilha.ServidorJogo.getStackRequest();
            inValue.Body = new clientePilha.ServidorJogo.getStackRequestBody();
            clientePilha.ServidorJogo.getStackResponse retVal = ((clientePilha.ServidorJogo.WsOperacoesSoap)(this)).getStack(inValue);
            return retVal.Body.getStackResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientePilha.ServidorJogo.getStackResponse> clientePilha.ServidorJogo.WsOperacoesSoap.getStackAsync(clientePilha.ServidorJogo.getStackRequest request) {
            return base.Channel.getStackAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientePilha.ServidorJogo.getStackResponse> getStackAsync() {
            clientePilha.ServidorJogo.getStackRequest inValue = new clientePilha.ServidorJogo.getStackRequest();
            inValue.Body = new clientePilha.ServidorJogo.getStackRequestBody();
            return ((clientePilha.ServidorJogo.WsOperacoesSoap)(this)).getStackAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientePilha.ServidorJogo.enviaCartaResponse clientePilha.ServidorJogo.WsOperacoesSoap.enviaCarta(clientePilha.ServidorJogo.enviaCartaRequest request) {
            return base.Channel.enviaCarta(request);
        }
        
        public void enviaCarta(clientePilha.ServidorJogo.Card carta, int id) {
            clientePilha.ServidorJogo.enviaCartaRequest inValue = new clientePilha.ServidorJogo.enviaCartaRequest();
            inValue.Body = new clientePilha.ServidorJogo.enviaCartaRequestBody();
            inValue.Body.carta = carta;
            inValue.Body.id = id;
            clientePilha.ServidorJogo.enviaCartaResponse retVal = ((clientePilha.ServidorJogo.WsOperacoesSoap)(this)).enviaCarta(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientePilha.ServidorJogo.enviaCartaResponse> clientePilha.ServidorJogo.WsOperacoesSoap.enviaCartaAsync(clientePilha.ServidorJogo.enviaCartaRequest request) {
            return base.Channel.enviaCartaAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientePilha.ServidorJogo.enviaCartaResponse> enviaCartaAsync(clientePilha.ServidorJogo.Card carta, int id) {
            clientePilha.ServidorJogo.enviaCartaRequest inValue = new clientePilha.ServidorJogo.enviaCartaRequest();
            inValue.Body = new clientePilha.ServidorJogo.enviaCartaRequestBody();
            inValue.Body.carta = carta;
            inValue.Body.id = id;
            return ((clientePilha.ServidorJogo.WsOperacoesSoap)(this)).enviaCartaAsync(inValue);
        }
    }
}
