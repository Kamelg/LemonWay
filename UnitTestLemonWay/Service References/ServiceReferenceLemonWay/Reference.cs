﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestLemonWay.ServiceReferenceLemonWay {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:11968/WebServiceTestTechnique.asmx/", ConfigurationName="ServiceReferenceLemonWay.WebServiceTestTechniqueSoap")]
    public interface WebServiceTestTechniqueSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11968/WebServiceTestTechnique.asmx/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://localhost:11968/WebServiceTestTechnique.asmx/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:11968/WebServiceTestTechnique.asmx/XmlToJson", ReplyAction="*")]
        UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonResponse XmlToJson(UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://localhost:11968/WebServiceTestTechnique.asmx/", Order=0)]
        public UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost:11968/WebServiceTestTechnique.asmx/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://localhost:11968/WebServiceTestTechnique.asmx/", Order=0)]
        public UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost:11968/WebServiceTestTechnique.asmx/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceTestTechniqueSoapChannel : UnitTestLemonWay.ServiceReferenceLemonWay.WebServiceTestTechniqueSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceTestTechniqueSoapClient : System.ServiceModel.ClientBase<UnitTestLemonWay.ServiceReferenceLemonWay.WebServiceTestTechniqueSoap>, UnitTestLemonWay.ServiceReferenceLemonWay.WebServiceTestTechniqueSoap {
        
        public WebServiceTestTechniqueSoapClient() {
        }
        
        public WebServiceTestTechniqueSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceTestTechniqueSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceTestTechniqueSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceTestTechniqueSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonResponse UnitTestLemonWay.ServiceReferenceLemonWay.WebServiceTestTechniqueSoap.XmlToJson(UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequest inValue = new UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequest();
            inValue.Body = new UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            UnitTestLemonWay.ServiceReferenceLemonWay.XmlToJsonResponse retVal = ((UnitTestLemonWay.ServiceReferenceLemonWay.WebServiceTestTechniqueSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
    }
}
