namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ArrayOfBusinessNotificationParameter", @"BusinessNotificationParameter", @"BusinessNotificationParameterType", @"BusinessNotificationSeverity"})]
    public sealed class OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Crm_Sdk_Messages : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""ArrayOfBusinessNotificationParameter"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BusinessNotificationParameter"" nillable=""true"" type=""tns:BusinessNotificationParameter"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfBusinessNotificationParameter"" nillable=""true"" type=""tns:ArrayOfBusinessNotificationParameter"" />
  <xs:complexType name=""BusinessNotificationParameter"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Data"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ParameterType"" type=""tns:BusinessNotificationParameterType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BusinessNotificationParameter"" nillable=""true"" type=""tns:BusinessNotificationParameter"" />
  <xs:simpleType name=""BusinessNotificationParameterType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""String"" />
      <xs:enumeration value=""Attribute"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""BusinessNotificationParameterType"" nillable=""true"" type=""tns:BusinessNotificationParameterType"" />
  <xs:simpleType name=""BusinessNotificationSeverity"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Error"" />
      <xs:enumeration value=""Warning"" />
      <xs:enumeration value=""Information"" />
      <xs:enumeration value=""UserDefined"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""BusinessNotificationSeverity"" nillable=""true"" type=""tns:BusinessNotificationSeverity"" />
</xs:schema>";
        
        public OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Crm_Sdk_Messages() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "ArrayOfBusinessNotificationParameter";
                _RootElements[1] = "BusinessNotificationParameter";
                _RootElements[2] = "BusinessNotificationParameterType";
                _RootElements[3] = "BusinessNotificationSeverity";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages",@"ArrayOfBusinessNotificationParameter")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfBusinessNotificationParameter"})]
        public sealed class ArrayOfBusinessNotificationParameter : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfBusinessNotificationParameter() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfBusinessNotificationParameter";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages",@"BusinessNotificationParameter")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BusinessNotificationParameter"})]
        public sealed class BusinessNotificationParameter : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BusinessNotificationParameter() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BusinessNotificationParameter";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages",@"BusinessNotificationParameterType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BusinessNotificationParameterType"})]
        public sealed class BusinessNotificationParameterType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BusinessNotificationParameterType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BusinessNotificationParameterType";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages",@"BusinessNotificationSeverity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BusinessNotificationSeverity"})]
        public sealed class BusinessNotificationSeverity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BusinessNotificationSeverity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BusinessNotificationSeverity";
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
