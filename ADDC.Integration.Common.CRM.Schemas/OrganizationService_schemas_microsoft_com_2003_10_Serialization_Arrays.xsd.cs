namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfboolean", @"ArrayOfint", @"ArrayOfstring", @"ArrayOfArrayOfstring", @"ArrayOfdouble", @"ArrayOfdecimal", @"ArrayOfguid", @"ArrayOfdateTime", @"ArrayOfKeyValueOfstringstring", @"ArrayOfanyType", @"ArrayOfKeyValueOfintstring"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns2=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:ns8=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:ns5=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns7=""http://schemas.microsoft.com/xrm/2012/Contracts"" xmlns:ns0=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" xmlns:tns=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2013/Metadata"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk"" namespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
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
  <xs:complexType name=""ArrayOfboolean"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""boolean"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfboolean"" nillable=""true"" type=""tns:ArrayOfboolean"" />
  <xs:complexType name=""ArrayOfint"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""int"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfint"" nillable=""true"" type=""tns:ArrayOfint"" />
  <xs:complexType name=""ArrayOfstring"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""string"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfstring"" nillable=""true"" type=""tns:ArrayOfstring"" />
  <xs:complexType name=""ArrayOfArrayOfstring"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfstring"" nillable=""true"" type=""tns:ArrayOfstring"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfstring"" nillable=""true"" type=""tns:ArrayOfArrayOfstring"" />
  <xs:complexType name=""ArrayOfdouble"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""double"" type=""xs:double"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfdouble"" nillable=""true"" type=""tns:ArrayOfdouble"" />
  <xs:complexType name=""ArrayOfdecimal"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""decimal"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfdecimal"" nillable=""true"" type=""tns:ArrayOfdecimal"" />
  <xs:complexType name=""ArrayOfguid"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""guid"" type=""ns2:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfguid"" nillable=""true"" type=""tns:ArrayOfguid"" />
  <xs:complexType name=""ArrayOfdateTime"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""dateTime"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfdateTime"" nillable=""true"" type=""tns:ArrayOfdateTime"" />
  <xs:complexType name=""ArrayOfKeyValueOfstringstring"">
    <xs:annotation>
      <xs:appinfo>
        <IsDictionary xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsDictionary>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValueOfstringstring"">
        <xs:complexType>
          <xs:sequence>
            <xs:element name=""Key"" nillable=""true"" type=""xs:string"" />
            <xs:element name=""Value"" nillable=""true"" type=""xs:string"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfKeyValueOfstringstring"" nillable=""true"" type=""tns:ArrayOfKeyValueOfstringstring"" />
  <xs:complexType name=""ArrayOfanyType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""anyType"" nillable=""true"" type=""xs:anyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfanyType"" nillable=""true"" type=""tns:ArrayOfanyType"" />
  <xs:complexType name=""ArrayOfKeyValueOfintstring"">
    <xs:annotation>
      <xs:appinfo>
        <IsDictionary xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">true</IsDictionary>
      </xs:appinfo>
    </xs:annotation>
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValueOfintstring"">
        <xs:complexType>
          <xs:sequence>
            <xs:element name=""Key"" type=""xs:int"" />
            <xs:element name=""Value"" nillable=""true"" type=""xs:string"" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfKeyValueOfintstring"" nillable=""true"" type=""tns:ArrayOfKeyValueOfintstring"" />
</xs:schema>";
        
        public OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [11];
                _RootElements[0] = "ArrayOfboolean";
                _RootElements[1] = "ArrayOfint";
                _RootElements[2] = "ArrayOfstring";
                _RootElements[3] = "ArrayOfArrayOfstring";
                _RootElements[4] = "ArrayOfdouble";
                _RootElements[5] = "ArrayOfdecimal";
                _RootElements[6] = "ArrayOfguid";
                _RootElements[7] = "ArrayOfdateTime";
                _RootElements[8] = "ArrayOfKeyValueOfstringstring";
                _RootElements[9] = "ArrayOfanyType";
                _RootElements[10] = "ArrayOfKeyValueOfintstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfboolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfboolean"})]
        public sealed class ArrayOfboolean : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfboolean() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfboolean";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfint")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfint"})]
        public sealed class ArrayOfint : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfint() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfint";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfstring"})]
        public sealed class ArrayOfstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfArrayOfstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfstring"})]
        public sealed class ArrayOfArrayOfstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfdouble")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfdouble"})]
        public sealed class ArrayOfdouble : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfdouble() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfdouble";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfdecimal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfdecimal"})]
        public sealed class ArrayOfdecimal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfdecimal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfdecimal";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfguid")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfguid"})]
        public sealed class ArrayOfguid : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfguid() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfguid";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfdateTime")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfdateTime"})]
        public sealed class ArrayOfdateTime : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfdateTime() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfdateTime";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfKeyValueOfstringstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfKeyValueOfstringstring"})]
        public sealed class ArrayOfKeyValueOfstringstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfKeyValueOfstringstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfKeyValueOfstringstring";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfanyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfanyType"})]
        public sealed class ArrayOfanyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfanyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfanyType";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/Arrays",@"ArrayOfKeyValueOfintstring")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfKeyValueOfintstring"})]
        public sealed class ArrayOfKeyValueOfintstring : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfKeyValueOfintstring() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfKeyValueOfintstring";
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
