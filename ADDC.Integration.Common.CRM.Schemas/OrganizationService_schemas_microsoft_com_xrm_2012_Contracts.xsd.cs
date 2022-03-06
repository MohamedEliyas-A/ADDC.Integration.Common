namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ExecuteMultipleSettings", @"OrganizationRequestCollection", @"OrganizationResponseCollection", @"ExecuteMultipleResponseItem"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrganizationService_schemas_microsoft_com_xrm_2012_Contracts : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:tns=""http://schemas.microsoft.com/xrm/2012/Contracts"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:ns5=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:ns2=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic"" namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""ExecuteMultipleSettings"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ContinueOnError"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ReturnResponses"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ExecuteMultipleSettings"" nillable=""true"" type=""tns:ExecuteMultipleSettings"" />
  <xs:complexType name=""OrganizationRequestCollection"">
    <xs:sequence>
      <xs:element xmlns:q91=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationRequest"" nillable=""true"" type=""q91:OrganizationRequest"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationRequestCollection"" nillable=""true"" type=""tns:OrganizationRequestCollection"" />
  <xs:complexType name=""OrganizationResponseCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ExecuteMultipleResponseItem"" nillable=""true"" type=""tns:ExecuteMultipleResponseItem"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationResponseCollection"" nillable=""true"" type=""tns:OrganizationResponseCollection"" />
  <xs:complexType name=""ExecuteMultipleResponseItem"">
    <xs:sequence>
      <xs:element xmlns:q92=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Fault"" nillable=""true"" type=""q92:OrganizationServiceFault"" />
      <xs:element minOccurs=""0"" name=""RequestIndex"" type=""xs:int"" />
      <xs:element xmlns:q93=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Response"" nillable=""true"" type=""q93:OrganizationResponse"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ExecuteMultipleResponseItem"" nillable=""true"" type=""tns:ExecuteMultipleResponseItem"" />
</xs:schema>";
        
        public OrganizationService_schemas_microsoft_com_xrm_2012_Contracts() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "ExecuteMultipleSettings";
                _RootElements[1] = "OrganizationRequestCollection";
                _RootElements[2] = "OrganizationResponseCollection";
                _RootElements[3] = "ExecuteMultipleResponseItem";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"ExecuteMultipleSettings")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ExecuteMultipleSettings"})]
        public sealed class ExecuteMultipleSettings : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ExecuteMultipleSettings() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ExecuteMultipleSettings";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"OrganizationRequestCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationRequestCollection"})]
        public sealed class OrganizationRequestCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationRequestCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationRequestCollection";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"OrganizationResponseCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationResponseCollection"})]
        public sealed class OrganizationResponseCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationResponseCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationResponseCollection";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://schemas.microsoft.com/xrm/2012/Contracts",@"ExecuteMultipleResponseItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ExecuteMultipleResponseItem"})]
        public sealed class ExecuteMultipleResponseItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ExecuteMultipleResponseItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ExecuteMultipleResponseItem";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
