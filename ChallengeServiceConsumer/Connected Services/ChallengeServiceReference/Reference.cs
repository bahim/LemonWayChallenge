﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChallengeServiceConsumer.ChallengeServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChallengeServiceReference.ServiceSoap")]
    public interface ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        // CODEGEN: Generating message contract since element name xml from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/JsonToXml", ReplyAction="*")]
        ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlResponse JsonToXml(ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class JsonToXmlRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="JsonToXml", Namespace="http://tempuri.org/", Order=0)]
        public ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequestBody Body;
        
        public JsonToXmlRequest() {
        }
        
        public JsonToXmlRequest(ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class JsonToXmlRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public JsonToXmlRequestBody() {
        }
        
        public JsonToXmlRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class JsonToXmlResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="JsonToXmlResponse", Namespace="http://tempuri.org/", Order=0)]
        public ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlResponseBody Body;
        
        public JsonToXmlResponse() {
        }
        
        public JsonToXmlResponse(ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class JsonToXmlResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string JsonToXmlResult;
        
        public JsonToXmlResponseBody() {
        }
        
        public JsonToXmlResponseBody(string JsonToXmlResult) {
            this.JsonToXmlResult = JsonToXmlResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : ChallengeServiceConsumer.ChallengeServiceReference.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<ChallengeServiceConsumer.ChallengeServiceReference.ServiceSoap>, ChallengeServiceConsumer.ChallengeServiceReference.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlResponse ChallengeServiceConsumer.ChallengeServiceReference.ServiceSoap.JsonToXml(ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequest request) {
            return base.Channel.JsonToXml(request);
        }
        
        public string JsonToXml(string xml) {
            ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequest inValue = new ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequest();
            inValue.Body = new ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlRequestBody();
            inValue.Body.xml = xml;
            ChallengeServiceConsumer.ChallengeServiceReference.JsonToXmlResponse retVal = ((ChallengeServiceConsumer.ChallengeServiceReference.ServiceSoap)(this)).JsonToXml(inValue);
            return retVal.Body.JsonToXmlResult;
        }
    }
}