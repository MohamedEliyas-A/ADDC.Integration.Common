namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EndpointAccessType", @"AttributeMapping", @"OrganizationDetail", @"EndpointCollection", @"EndpointType", @"OrganizationState"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrganizationService_schemas_microsoft_com_xrm_2014_Contracts : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:tns=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:ns5=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:ns2=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic"" namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
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
  <xs:simpleType name=""EndpointAccessType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Default"" />
      <xs:enumeration value=""Internet"" />
      <xs:enumeration value=""Intranet"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""EndpointAccessType"" nillable=""true"" type=""tns:EndpointAccessType"" />
  <xs:complexType name=""AttributeMapping"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AllowedSyncDirection"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""AttributeCrmDisplayName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AttributeCrmName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AttributeExchangeDisplayName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AttributeExchangeName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""AttributeMappingId"" type=""ns0:guid"" />
      <xs:element xmlns:q45=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""ComputedProperties"" nillable=""true"" type=""q45:ArrayOfstring"" />
      <xs:element minOccurs=""0"" name=""DefaultSyncDirection"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""EntityTypeCode"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""IsComputed"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""MappingName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""SyncDirection"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AttributeMapping"" nillable=""true"" type=""tns:AttributeMapping"" />
  <xs:complexType name=""OrganizationDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Endpoints"" nillable=""true"" type=""tns:EndpointCollection"" />
      <xs:element minOccurs=""0"" name=""FriendlyName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""OrganizationId"" type=""ns0:guid"" />
      <xs:element minOccurs=""0"" name=""OrganizationVersion"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""State"" type=""tns:OrganizationState"" />
      <xs:element minOccurs=""0"" name=""UniqueName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""UrlName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationDetail"" nillable=""true"" type=""tns:OrganizationDetail"" />
  <xs:complexType name=""EndpointCollection"">
    <xs:sequence>
      <xs:element xmlns:q46=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfEndpointTypestringyDL0RVHi"" type=""q46:KeyValuePairOfEndpointTypestringyDL0RVHi"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""EndpointCollection"" nillable=""true"" type=""tns:EndpointCollection"" />
  <xs:simpleType name=""EndpointType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""OrganizationService"" />
      <xs:enumeration value=""OrganizationDataService"" />
      <xs:enumeration value=""WebApplication"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""EndpointType"" nillable=""true"" type=""tns:EndpointType"" />
  <xs:simpleType name=""OrganizationState"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Enabled"" />
      <xs:enumeration value=""Disabled"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""OrganizationState"" nillable=""true"" type=""tns:OrganizationState"" />
</xs:schema>";
        
        public OrganizationService_schemas_microsoft_com_xrm_2014_Contracts() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "EndpointAccessType";
                _RootElements[1] = "AttributeMapping";
                _RootElements[2] = "OrganizationDetail";
                _RootElements[3] = "EndpointCollection";
                _RootElements[4] = "EndpointType";
                _RootElements[5] = "OrganizationState";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2014/Contracts",@"EndpointAccessType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EndpointAccessType"})]
        public sealed class EndpointAccessType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EndpointAccessType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EndpointAccessType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2014/Contracts",@"AttributeMapping")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeMapping"})]
        public sealed class AttributeMapping : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeMapping() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeMapping";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2014/Contracts",@"OrganizationDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationDetail"})]
        public sealed class OrganizationDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2014/Contracts",@"EndpointCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EndpointCollection"})]
        public sealed class EndpointCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EndpointCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EndpointCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2014/Contracts",@"EndpointType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EndpointType"})]
        public sealed class EndpointType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EndpointType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EndpointType";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2014/Contracts",@"OrganizationState")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationState"})]
        public sealed class OrganizationState : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationState() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationState";
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
