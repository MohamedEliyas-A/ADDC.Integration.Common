namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AttributeTypeDisplayName", @"ConstantsBase", @"StringFormatName", @"ImageAttributeMetadata", @"ArrayOfAttributeTypeDisplayName"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrganizationService_schemas_microsoft_com_xrm_2013_Metadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:tns=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:ns2=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns5=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic"" namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""AttributeTypeDisplayName"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:ConstantsBase"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AttributeTypeDisplayName"" nillable=""true"" type=""tns:AttributeTypeDisplayName"" />
  <xs:complexType name=""ConstantsBase"">
    <xs:annotation>
      <xs:appinfo>
        <GenericType Name=""ConstantsBase"" Namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">
          <GenericParameter Name=""string"" Namespace=""http://www.w3.org/2001/XMLSchema"" />
        </GenericType>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Value"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ConstantsBase"" nillable=""true"" type=""tns:ConstantsBase"" />
  <xs:complexType name=""StringFormatName"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:ConstantsBase"">
        <xs:sequence />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""StringFormatName"" nillable=""true"" type=""tns:StringFormatName"" />
  <xs:complexType name=""ImageAttributeMetadata"">
    <xs:complexContent mixed=""false"">
      <xs:extension xmlns:q90=""http://schemas.microsoft.com/xrm/2011/Metadata"" base=""q90:AttributeMetadata"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""IsPrimaryImage"" nillable=""true"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" name=""MaxHeight"" nillable=""true"" type=""xs:short"" />
          <xs:element minOccurs=""0"" name=""MaxWidth"" nillable=""true"" type=""xs:short"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""ImageAttributeMetadata"" nillable=""true"" type=""tns:ImageAttributeMetadata"" />
  <xs:complexType name=""ArrayOfAttributeTypeDisplayName"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttributeTypeDisplayName"" nillable=""true"" type=""tns:AttributeTypeDisplayName"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAttributeTypeDisplayName"" nillable=""true"" type=""tns:ArrayOfAttributeTypeDisplayName"" />
</xs:schema>";
        
        public OrganizationService_schemas_microsoft_com_xrm_2013_Metadata() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "AttributeTypeDisplayName";
                _RootElements[1] = "ConstantsBase";
                _RootElements[2] = "StringFormatName";
                _RootElements[3] = "ImageAttributeMetadata";
                _RootElements[4] = "ArrayOfAttributeTypeDisplayName";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"AttributeTypeDisplayName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeTypeDisplayName"})]
        public sealed class AttributeTypeDisplayName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeTypeDisplayName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeTypeDisplayName";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"ConstantsBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConstantsBase"})]
        public sealed class ConstantsBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConstantsBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConstantsBase";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"StringFormatName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StringFormatName"})]
        public sealed class StringFormatName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StringFormatName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StringFormatName";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"ImageAttributeMetadata")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ImageAttributeMetadata"})]
        public sealed class ImageAttributeMetadata : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ImageAttributeMetadata() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ImageAttributeMetadata";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2013/Metadata",@"ArrayOfAttributeTypeDisplayName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAttributeTypeDisplayName"})]
        public sealed class ArrayOfAttributeTypeDisplayName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAttributeTypeDisplayName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAttributeTypeDisplayName";
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
