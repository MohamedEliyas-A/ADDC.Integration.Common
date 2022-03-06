namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"KeyValuePairOfstringanyType", @"KeyValuePairOfRelationshipQueryBaseX_PsK4FkN", @"KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF", @"KeyValuePairOfEndpointTypestringyDL0RVHi", @"ArrayOfKeyValuePairOfstringanyType", @"KeyValuePairOfstringQueryBasegUGIFE1S", @"KeyValuePairOfstringstring", @"KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns2=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:tns=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2012/Contracts"" xmlns:ns5=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:ns7=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:ns0=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk"" namespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""KeyValuePairOfstringanyType"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
          <GenericParameter Name=""anyType"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""key"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""value"" nillable=""true"" type=""xs:anyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfstringanyType"" nillable=""true"" type=""tns:KeyValuePairOfstringanyType"" />
  <xs:complexType name=""KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""Relationship"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
          <GenericParameter Name=""QueryBase"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q33=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""key"" nillable=""true"" type=""q33:Relationship"" />
      <xs:element xmlns:q34=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""value"" nillable=""true"" type=""q34:QueryBase"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"" nillable=""true"" type=""tns:KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"" />
  <xs:complexType name=""KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""DeletedMetadataFilters"" Namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
          <GenericParameter Name=""ArrayOfguid"" Namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q35=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" name=""key"" type=""q35:DeletedMetadataFilters"" />
      <xs:element xmlns:q36=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" name=""value"" nillable=""true"" type=""q36:ArrayOfguid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"" nillable=""true"" type=""tns:KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"" />
  <xs:complexType name=""KeyValuePairOfEndpointTypestringyDL0RVHi"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""EndpointType"" Namespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q37=""http://schemas.microsoft.com/xrm/2014/Contracts"" name=""key"" type=""q37:EndpointType"" />
      <xs:element name=""value"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfEndpointTypestringyDL0RVHi"" nillable=""true"" type=""tns:KeyValuePairOfEndpointTypestringyDL0RVHi"" />
  <xs:complexType name=""ArrayOfKeyValuePairOfstringanyType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfstringanyType"" type=""tns:KeyValuePairOfstringanyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfKeyValuePairOfstringanyType"" nillable=""true"" type=""tns:ArrayOfKeyValuePairOfstringanyType"" />
  <xs:complexType name=""KeyValuePairOfstringQueryBasegUGIFE1S"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
          <GenericParameter Name=""QueryBase"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""key"" nillable=""true"" type=""xs:string"" />
      <xs:element xmlns:q38=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""value"" nillable=""true"" type=""q38:QueryBase"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfstringQueryBasegUGIFE1S"" nillable=""true"" type=""tns:KeyValuePairOfstringQueryBasegUGIFE1S"" />
  <xs:complexType name=""KeyValuePairOfstringstring"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element name=""key"" nillable=""true"" type=""xs:string"" />
      <xs:element name=""value"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfstringstring"" nillable=""true"" type=""tns:KeyValuePairOfstringstring"" />
  <xs:complexType name=""KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""KeyValuePairOf{0}{1}{#}"" Namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""Relationship"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
          <GenericParameter Name=""EntityCollection"" Namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        </GenericType>
        <IsValueType xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsValueType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element xmlns:q39=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""key"" nillable=""true"" type=""q39:Relationship"" />
      <xs:element xmlns:q40=""http://schemas.microsoft.com/xrm/2011/Contracts"" name=""value"" nillable=""true"" type=""q40:EntityCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"" nillable=""true"" type=""tns:KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"" />
</xs:schema>";
        
        public OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [8];
                _RootElements[0] = "KeyValuePairOfstringanyType";
                _RootElements[1] = "KeyValuePairOfRelationshipQueryBaseX_PsK4FkN";
                _RootElements[2] = "KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF";
                _RootElements[3] = "KeyValuePairOfEndpointTypestringyDL0RVHi";
                _RootElements[4] = "ArrayOfKeyValuePairOfstringanyType";
                _RootElements[5] = "KeyValuePairOfstringQueryBasegUGIFE1S";
                _RootElements[6] = "KeyValuePairOfstringstring";
                _RootElements[7] = "KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfstringanyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfstringanyType"})]
        public sealed class KeyValuePairOfstringanyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfstringanyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfstringanyType";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfRelationshipQueryBaseX_PsK4FkN")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfRelationshipQueryBaseX_PsK4FkN"})]
        public sealed class KeyValuePairOfRelationshipQueryBaseX_PsK4FkN : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfRelationshipQueryBaseX_PsK4FkN() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfRelationshipQueryBaseX_PsK4FkN";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF"})]
        public sealed class KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfDeletedMetadataFiltersArrayOfguidPlUv_PKtF";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfEndpointTypestringyDL0RVHi")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfEndpointTypestringyDL0RVHi"})]
        public sealed class KeyValuePairOfEndpointTypestringyDL0RVHi : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfEndpointTypestringyDL0RVHi() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfEndpointTypestringyDL0RVHi";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"ArrayOfKeyValuePairOfstringanyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfKeyValuePairOfstringanyType"})]
        public sealed class ArrayOfKeyValuePairOfstringanyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfKeyValuePairOfstringanyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfKeyValuePairOfstringanyType";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfstringQueryBasegUGIFE1S")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfstringQueryBasegUGIFE1S"})]
        public sealed class KeyValuePairOfstringQueryBasegUGIFE1S : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfstringQueryBasegUGIFE1S() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfstringQueryBasegUGIFE1S";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfstringstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfstringstring"})]
        public sealed class KeyValuePairOfstringstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfstringstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfstringstring";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/System.Collections.Generic",@"KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN"})]
        public sealed class KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KeyValuePairOfRelationshipEntityCollectionX_PsK4FkN";
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
