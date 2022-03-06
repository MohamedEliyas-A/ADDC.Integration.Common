namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Create", @"CreateResponse", @"Retrieve", @"RetrieveResponse", @"Update", @"UpdateResponse", @"Delete", @"DeleteResponse", @"Execute", @"ExecuteResponse", @"Associate", @"AssociateResponse", @"Disassociate", @"DisassociateResponse", @"RetrieveMultiple", @"RetrieveMultipleResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    public sealed class OrganizationService_schemas_microsoft_com_xrm_2011_Contracts_Services : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://schemas.microsoft.com/xrm/2011/Contracts/Services"" xmlns:ns5=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:ns8=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:ns2=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns0=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:ns7=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2012/Contracts"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts/Services"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
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
  <xs:element name=""Create"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""entity"" nillable=""true"" type=""q1:Entity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreateResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.microsoft.com/2003/10/Serialization/"" minOccurs=""0"" name=""CreateResult"" type=""q2:guid"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Retrieve"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""entityName"" nillable=""true"" type=""xs:string"" />
        <xs:element xmlns:q3=""http://schemas.microsoft.com/2003/10/Serialization/"" minOccurs=""0"" name=""id"" type=""q3:guid"" />
        <xs:element xmlns:q4=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""columnSet"" nillable=""true"" type=""q4:ColumnSet"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RetrieveResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q5=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""RetrieveResult"" nillable=""true"" type=""q5:Entity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Update"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q6=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""entity"" nillable=""true"" type=""q6:Entity"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""UpdateResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Delete"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""entityName"" nillable=""true"" type=""xs:string"" />
        <xs:element xmlns:q7=""http://schemas.microsoft.com/2003/10/Serialization/"" minOccurs=""0"" name=""id"" type=""q7:guid"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DeleteResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Execute"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q8=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""request"" nillable=""true"" type=""q8:OrganizationRequest"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ExecuteResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q9=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""ExecuteResult"" nillable=""true"" type=""q9:OrganizationResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Associate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""entityName"" nillable=""true"" type=""xs:string"" />
        <xs:element xmlns:q10=""http://schemas.microsoft.com/2003/10/Serialization/"" minOccurs=""0"" name=""entityId"" type=""q10:guid"" />
        <xs:element xmlns:q11=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""relationship"" nillable=""true"" type=""q11:Relationship"" />
        <xs:element xmlns:q12=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""relatedEntities"" nillable=""true"" type=""q12:EntityReferenceCollection"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AssociateResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Disassociate"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""entityName"" nillable=""true"" type=""xs:string"" />
        <xs:element xmlns:q13=""http://schemas.microsoft.com/2003/10/Serialization/"" minOccurs=""0"" name=""entityId"" type=""q13:guid"" />
        <xs:element xmlns:q14=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""relationship"" nillable=""true"" type=""q14:Relationship"" />
        <xs:element xmlns:q15=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""relatedEntities"" nillable=""true"" type=""q15:EntityReferenceCollection"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DisassociateResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
  <xs:element name=""RetrieveMultiple"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q16=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""query"" nillable=""true"" type=""q16:QueryBase"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RetrieveMultipleResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q17=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""RetrieveMultipleResult"" nillable=""true"" type=""q17:EntityCollection"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrganizationService_schemas_microsoft_com_xrm_2011_Contracts_Services() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [16];
                _RootElements[0] = "Create";
                _RootElements[1] = "CreateResponse";
                _RootElements[2] = "Retrieve";
                _RootElements[3] = "RetrieveResponse";
                _RootElements[4] = "Update";
                _RootElements[5] = "UpdateResponse";
                _RootElements[6] = "Delete";
                _RootElements[7] = "DeleteResponse";
                _RootElements[8] = "Execute";
                _RootElements[9] = "ExecuteResponse";
                _RootElements[10] = "Associate";
                _RootElements[11] = "AssociateResponse";
                _RootElements[12] = "Disassociate";
                _RootElements[13] = "DisassociateResponse";
                _RootElements[14] = "RetrieveMultiple";
                _RootElements[15] = "RetrieveMultipleResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Create")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Create"})]
        public sealed class Create : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Create() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Create";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"CreateResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreateResponse"})]
        public sealed class CreateResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreateResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreateResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Retrieve")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Retrieve"})]
        public sealed class Retrieve : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Retrieve() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Retrieve";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"RetrieveResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RetrieveResponse"})]
        public sealed class RetrieveResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RetrieveResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RetrieveResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Update")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Update"})]
        public sealed class Update : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Update() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Update";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"UpdateResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UpdateResponse"})]
        public sealed class UpdateResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UpdateResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UpdateResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Delete")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Delete"})]
        public sealed class Delete : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Delete() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Delete";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"DeleteResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeleteResponse"})]
        public sealed class DeleteResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeleteResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeleteResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Execute")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Execute"})]
        public sealed class Execute : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Execute() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Execute";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"ExecuteResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ExecuteResponse"})]
        public sealed class ExecuteResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ExecuteResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ExecuteResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Associate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Associate"})]
        public sealed class Associate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Associate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Associate";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"AssociateResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AssociateResponse"})]
        public sealed class AssociateResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AssociateResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AssociateResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"Disassociate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Disassociate"})]
        public sealed class Disassociate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Disassociate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Disassociate";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"DisassociateResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DisassociateResponse"})]
        public sealed class DisassociateResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DisassociateResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DisassociateResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"RetrieveMultiple")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RetrieveMultiple"})]
        public sealed class RetrieveMultiple : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RetrieveMultiple() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RetrieveMultiple";
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
        
        [Schema(@"http://schemas.microsoft.com/xrm/2011/Contracts/Services",@"RetrieveMultipleResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RetrieveMultipleResponse"})]
        public sealed class RetrieveMultipleResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RetrieveMultipleResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RetrieveMultipleResponse";
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
