namespace ADDC.Integration.Common.CRM.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AppointmentProposal", @"ArrayOfProposalParty", @"ProposalParty", @"ArrayOfAppointmentProposal", @"ArrayOfArrayOfAppointmentProposal", @"SearchDirection", @"ArrayOfSearchDirection", @"ArrayOfArrayOfSearchDirection", @"AppointmentRequest", @"ArrayOfAppointmentsToIgnore", @"AppointmentsToIgnore", @"ArrayOfConstraintRelation", @"ConstraintRelation", @"ArrayOfObjectiveRelation", @"ObjectiveRelation", @"ArrayOfRequiredResource", @"RequiredResource", @"ArrayOfAppointmentRequest", @"ArrayOfArrayOfAppointmentRequest", 
@"ArrayOfArrayOfAppointmentsToIgnore", @"AuditDetail", @"ShareAuditDetail", @"AccessRights", @"AttributeAuditDetail", @"RelationshipAuditDetail", @"ArrayOfAuditDetail", @"ArrayOfArrayOfAuditDetail", @"ArrayOfAttributeAuditDetail", @"ArrayOfArrayOfAttributeAuditDetail", @"AuditDetailCollection", @"ArrayOfAuditDetailCollection", @"ArrayOfArrayOfAuditDetailCollection", @"AuditPartitionDetail", @"ArrayOfAuditPartitionDetail", @"ArrayOfArrayOfAuditPartitionDetail", @"AuditPartitionDetailCollection", 
@"ArrayOfAuditPartitionDetailCollection", @"ArrayOfArrayOfAuditPartitionDetailCollection", @"ComponentDetail", @"ArrayOfComponentDetail", @"ArrayOfArrayOfComponentDetail", @"ArrayOfArrayOfConstraintRelation", @"BulkOperationSource", @"ArrayOfBulkOperationSource", @"ArrayOfArrayOfBulkOperationSource", @"EntitySource", @"ArrayOfEntitySource", @"ArrayOfArrayOfEntitySource", @"TargetFieldType", @"ArrayOfTargetFieldType", @"ArrayOfArrayOfTargetFieldType", @"PropagationOwnershipOptions", 
@"ArrayOfPropagationOwnershipOptions", @"ArrayOfArrayOfPropagationOwnershipOptions", @"RollupType", @"ArrayOfRollupType", @"ArrayOfArrayOfRollupType", @"ErrorInfo", @"ArrayOfResourceInfo", @"ResourceInfo", @"ArrayOfErrorInfo", @"ArrayOfArrayOfErrorInfo", @"InputArgumentCollection", @"ArrayOfInputArgumentCollection", @"ArrayOfArrayOfInputArgumentCollection", @"BusinessNotification", @"ArrayOfBusinessNotification", @"ArrayOfArrayOfBusinessNotification", @"MissingComponent", @"ArrayOfMissingComponent", 
@"ArrayOfArrayOfMissingComponent", @"ArrayOfArrayOfObjectiveRelation", @"OrganizationResources", @"ArrayOfOrganizationResources", @"ArrayOfArrayOfOrganizationResources", @"PrincipalAccess", @"ArrayOfPrincipalAccess", @"ArrayOfArrayOfPrincipalAccess", @"ArrayOfAccessRights", @"ArrayOfArrayOfAccessRights", @"ArrayOfArrayOfProposalParty", @"ArrayOfRelationshipAuditDetail", @"ArrayOfArrayOfRelationshipAuditDetail", @"ArrayOfArrayOfRequiredResource", @"ArrayOfArrayOfResourceInfo", @"RibbonLocationFilters", 
@"ArrayOfRibbonLocationFilters", @"ArrayOfArrayOfRibbonLocationFilters", @"PrivilegeDepth", @"ArrayOfPrivilegeDepth", @"ArrayOfArrayOfPrivilegeDepth", @"RolePrivilege", @"ArrayOfRolePrivilege", @"ArrayOfArrayOfRolePrivilege", @"SearchResults", @"TraceInfo", @"ArrayOfSearchResults", @"ArrayOfArrayOfSearchResults", @"ArrayOfShareAuditDetail", @"ArrayOfArrayOfShareAuditDetail", @"RolePrivilegeAuditDetail", @"ArrayOfRolePrivilegeAuditDetail", @"ArrayOfArrayOfRolePrivilegeAuditDetail", 
@"TimeInfo", @"SubCode", @"TimeCode", @"ArrayOfTimeInfo", @"ArrayOfArrayOfTimeInfo", @"ArrayOfTimeCode", @"ArrayOfArrayOfTimeCode", @"ArrayOfSubCode", @"ArrayOfArrayOfSubCode", @"ArrayOfTraceInfo", @"ArrayOfArrayOfTraceInfo", @"UserAccessAuditDetail", @"ArrayOfUserAccessAuditDetail", @"ArrayOfArrayOfUserAccessAuditDetail", @"ValidationResult", @"ArrayOfValidationResult", @"ArrayOfArrayOfValidationResult", @"CacheItem", @"ArrayOfCacheItem", @"ArrayOfArrayOfCacheItem", @"FaultType", 
@"ArrayOfFaultType", @"ArrayOfArrayOfFaultType", @"QueryByEntityNameDictionary", @"ArrayOfQueryByEntityNameDictionary", @"ArrayOfArrayOfQueryByEntityNameDictionary", @"ResetSyncStateInfo", @"ArrayOfResetSyncStateInfo", @"ArrayOfArrayOfResetSyncStateInfo", @"SdkMessageProcessingStepImageRegistration", @"ArrayOfSdkMessageProcessingStepImageRegistration", @"ArrayOfArrayOfSdkMessageProcessingStepImageRegistration", @"SdkMessageProcessingStepRegistration", @"ArrayOfSdkMessageProcessingStepRegistration", 
@"ArrayOfArrayOfSdkMessageProcessingStepRegistration", @"SyncAction", @"ArrayOfSyncAction", @"ArrayOfArrayOfSyncAction"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Crm_Sdk_Messages", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Crm_Sdk_Messages))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata", typeof(global::ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata))]
    public sealed class OrganizationService_schemas_microsoft_com_crm_2011_Contracts : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns10=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" xmlns:ns2=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns8=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" xmlns:ns5=""http://schemas.microsoft.com/xrm/2014/Contracts"" xmlns:ns3=""http://schemas.microsoft.com/xrm/2011/Contracts"" xmlns:ns9=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" xmlns:ns0=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" xmlns:tns=""http://schemas.microsoft.com/crm/2011/Contracts"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns4=""http://schemas.microsoft.com/xrm/2011/Metadata"" xmlns:ns6=""http://schemas.microsoft.com/xrm/2013/Metadata"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:ns7=""http://schemas.microsoft.com/xrm/2012/Contracts"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/crm/2011/Contracts"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Crm_Sdk_Messages"" namespace=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2011_Metadata_Query"" namespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization_Arrays"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_System_Collections_Generic"" namespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_datacontract_org_2004_07_Microsoft_Xrm_Sdk"" namespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2014_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2012_Contracts"" namespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_2003_10_Serialization"" namespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
  <xs:import schemaLocation=""ADDC.Integration.Common.CRM.Schemas.OrganizationService_schemas_microsoft_com_xrm_2013_Metadata"" namespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2012/Contracts"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2014/Contracts"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Contracts"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata"" />
        <b:reference targetNamespace=""http://schemas.datacontract.org/2004/07/Microsoft.Xrm.Sdk"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2013/Metadata"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/xrm/2011/Metadata/Query"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""AppointmentProposal"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""End"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""ProposalParties"" nillable=""true"" type=""tns:ArrayOfProposalParty"" />
      <xs:element minOccurs=""0"" name=""SiteId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""SiteName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Start"" nillable=""true"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AppointmentProposal"" nillable=""true"" type=""tns:AppointmentProposal"" />
  <xs:complexType name=""ArrayOfProposalParty"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ProposalParty"" nillable=""true"" type=""tns:ProposalParty"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfProposalParty"" nillable=""true"" type=""tns:ArrayOfProposalParty"" />
  <xs:complexType name=""ProposalParty"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EffortRequired"" type=""xs:double"" />
      <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ResourceId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""ResourceSpecId"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ProposalParty"" nillable=""true"" type=""tns:ProposalParty"" />
  <xs:complexType name=""ArrayOfAppointmentProposal"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AppointmentProposal"" nillable=""true"" type=""tns:AppointmentProposal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAppointmentProposal"" nillable=""true"" type=""tns:ArrayOfAppointmentProposal"" />
  <xs:complexType name=""ArrayOfArrayOfAppointmentProposal"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAppointmentProposal"" nillable=""true"" type=""tns:ArrayOfAppointmentProposal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAppointmentProposal"" nillable=""true"" type=""tns:ArrayOfArrayOfAppointmentProposal"" />
  <xs:simpleType name=""SearchDirection"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Forward"" />
      <xs:enumeration value=""Backward"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""SearchDirection"" nillable=""true"" type=""tns:SearchDirection"" />
  <xs:complexType name=""ArrayOfSearchDirection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SearchDirection"" type=""tns:SearchDirection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSearchDirection"" nillable=""true"" type=""tns:ArrayOfSearchDirection"" />
  <xs:complexType name=""ArrayOfArrayOfSearchDirection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfSearchDirection"" nillable=""true"" type=""tns:ArrayOfSearchDirection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfSearchDirection"" nillable=""true"" type=""tns:ArrayOfArrayOfSearchDirection"" />
  <xs:complexType name=""AppointmentRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AnchorOffset"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""AppointmentsToIgnore"" nillable=""true"" type=""tns:ArrayOfAppointmentsToIgnore"" />
      <xs:element minOccurs=""0"" name=""Constraints"" nillable=""true"" type=""tns:ArrayOfConstraintRelation"" />
      <xs:element minOccurs=""0"" name=""Direction"" type=""tns:SearchDirection"" />
      <xs:element minOccurs=""0"" name=""Duration"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""NumberOfResults"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Objectives"" nillable=""true"" type=""tns:ArrayOfObjectiveRelation"" />
      <xs:element minOccurs=""0"" name=""RecurrenceDuration"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""RecurrenceTimeZoneCode"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""RequiredResources"" nillable=""true"" type=""tns:ArrayOfRequiredResource"" />
      <xs:element minOccurs=""0"" name=""SearchRecurrenceRule"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""SearchRecurrenceStart"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""SearchWindowEnd"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""SearchWindowStart"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""ServiceId"" type=""ns1:guid"" />
      <xs:element xmlns:q94=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Sites"" nillable=""true"" type=""q94:ArrayOfguid"" />
      <xs:element minOccurs=""0"" name=""UserTimeZoneCode"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AppointmentRequest"" nillable=""true"" type=""tns:AppointmentRequest"" />
  <xs:complexType name=""ArrayOfAppointmentsToIgnore"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AppointmentsToIgnore"" nillable=""true"" type=""tns:AppointmentsToIgnore"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAppointmentsToIgnore"" nillable=""true"" type=""tns:ArrayOfAppointmentsToIgnore"" />
  <xs:complexType name=""AppointmentsToIgnore"">
    <xs:sequence>
      <xs:element xmlns:q95=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Appointments"" nillable=""true"" type=""q95:ArrayOfguid"" />
      <xs:element minOccurs=""0"" name=""ResourceId"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AppointmentsToIgnore"" nillable=""true"" type=""tns:AppointmentsToIgnore"" />
  <xs:complexType name=""ArrayOfConstraintRelation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ConstraintRelation"" nillable=""true"" type=""tns:ConstraintRelation"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfConstraintRelation"" nillable=""true"" type=""tns:ArrayOfConstraintRelation"" />
  <xs:complexType name=""ConstraintRelation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ConstraintType"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Constraints"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ObjectId"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ConstraintRelation"" nillable=""true"" type=""tns:ConstraintRelation"" />
  <xs:complexType name=""ArrayOfObjectiveRelation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ObjectiveRelation"" nillable=""true"" type=""tns:ObjectiveRelation"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfObjectiveRelation"" nillable=""true"" type=""tns:ArrayOfObjectiveRelation"" />
  <xs:complexType name=""ObjectiveRelation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ObjectiveExpression"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ResourceSpecId"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ObjectiveRelation"" nillable=""true"" type=""tns:ObjectiveRelation"" />
  <xs:complexType name=""ArrayOfRequiredResource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RequiredResource"" nillable=""true"" type=""tns:RequiredResource"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRequiredResource"" nillable=""true"" type=""tns:ArrayOfRequiredResource"" />
  <xs:complexType name=""RequiredResource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ResourceId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""ResourceSpecId"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""RequiredResource"" nillable=""true"" type=""tns:RequiredResource"" />
  <xs:complexType name=""ArrayOfAppointmentRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AppointmentRequest"" nillable=""true"" type=""tns:AppointmentRequest"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAppointmentRequest"" nillable=""true"" type=""tns:ArrayOfAppointmentRequest"" />
  <xs:complexType name=""ArrayOfArrayOfAppointmentRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAppointmentRequest"" nillable=""true"" type=""tns:ArrayOfAppointmentRequest"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAppointmentRequest"" nillable=""true"" type=""tns:ArrayOfArrayOfAppointmentRequest"" />
  <xs:complexType name=""ArrayOfArrayOfAppointmentsToIgnore"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAppointmentsToIgnore"" nillable=""true"" type=""tns:ArrayOfAppointmentsToIgnore"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAppointmentsToIgnore"" nillable=""true"" type=""tns:ArrayOfArrayOfAppointmentsToIgnore"" />
  <xs:complexType name=""AuditDetail"">
    <xs:sequence>
      <xs:element xmlns:q96=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""AuditRecord"" nillable=""true"" type=""q96:Entity"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AuditDetail"" nillable=""true"" type=""tns:AuditDetail"" />
  <xs:complexType name=""ShareAuditDetail"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AuditDetail"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""NewPrivileges"" type=""tns:AccessRights"" />
          <xs:element minOccurs=""0"" name=""OldPrivileges"" type=""tns:AccessRights"" />
          <xs:element xmlns:q97=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Principal"" nillable=""true"" type=""q97:EntityReference"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""ShareAuditDetail"" nillable=""true"" type=""tns:ShareAuditDetail"" />
  <xs:simpleType name=""AccessRights"">
    <xs:list>
      <xs:simpleType>
        <xs:restriction base=""xs:string"">
          <xs:enumeration value=""None"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">0</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""ReadAccess"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">1</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""WriteAccess"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">2</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""AppendAccess"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">4</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""AppendToAccess"" />
          <xs:enumeration value=""CreateAccess"" />
          <xs:enumeration value=""DeleteAccess"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">65536</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""ShareAccess"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">262144</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value=""AssignAccess"">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns=""http://schemas.microsoft.com/2003/10/Serialization/"">524288</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
    </xs:list>
  </xs:simpleType>
  <xs:element name=""AccessRights"" nillable=""true"" type=""tns:AccessRights"" />
  <xs:complexType name=""AttributeAuditDetail"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AuditDetail"">
        <xs:sequence>
          <xs:element xmlns:q98=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""InvalidNewValueAttributes"" nillable=""true"" type=""q98:ArrayOfstring"" />
          <xs:element xmlns:q99=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""NewValue"" nillable=""true"" type=""q99:Entity"" />
          <xs:element xmlns:q100=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""OldValue"" nillable=""true"" type=""q100:Entity"" />
          <xs:element xmlns:q101=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""DeletedAttributes"" nillable=""true"" type=""q101:ArrayOfKeyValueOfintstring"" />
          <xs:element minOccurs=""0"" name=""LocLabelLanguageCode"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AttributeAuditDetail"" nillable=""true"" type=""tns:AttributeAuditDetail"" />
  <xs:complexType name=""RelationshipAuditDetail"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AuditDetail"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""RelationshipName"" nillable=""true"" type=""xs:string"" />
          <xs:element xmlns:q102=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""TargetRecords"" nillable=""true"" type=""q102:ArrayOfEntityReference"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""RelationshipAuditDetail"" nillable=""true"" type=""tns:RelationshipAuditDetail"" />
  <xs:complexType name=""ArrayOfAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AuditDetail"" nillable=""true"" type=""tns:AuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAuditDetail"" nillable=""true"" type=""tns:ArrayOfAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAuditDetail"" nillable=""true"" type=""tns:ArrayOfAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAuditDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfAuditDetail"" />
  <xs:complexType name=""ArrayOfAttributeAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttributeAuditDetail"" nillable=""true"" type=""tns:AttributeAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAttributeAuditDetail"" nillable=""true"" type=""tns:ArrayOfAttributeAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfAttributeAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAttributeAuditDetail"" nillable=""true"" type=""tns:ArrayOfAttributeAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAttributeAuditDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfAttributeAuditDetail"" />
  <xs:complexType name=""AuditDetailCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AuditDetails"" nillable=""true"" type=""tns:ArrayOfAuditDetail"" />
      <xs:element minOccurs=""0"" name=""MoreRecords"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""PagingCookie"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TotalRecordCount"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AuditDetailCollection"" nillable=""true"" type=""tns:AuditDetailCollection"" />
  <xs:complexType name=""ArrayOfAuditDetailCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AuditDetailCollection"" nillable=""true"" type=""tns:AuditDetailCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAuditDetailCollection"" nillable=""true"" type=""tns:ArrayOfAuditDetailCollection"" />
  <xs:complexType name=""ArrayOfArrayOfAuditDetailCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAuditDetailCollection"" nillable=""true"" type=""tns:ArrayOfAuditDetailCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAuditDetailCollection"" nillable=""true"" type=""tns:ArrayOfArrayOfAuditDetailCollection"" />
  <xs:complexType name=""AuditPartitionDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EndDate"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""PartitionNumber"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Size"" type=""xs:long"" />
      <xs:element minOccurs=""0"" name=""StartDate"" nillable=""true"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AuditPartitionDetail"" nillable=""true"" type=""tns:AuditPartitionDetail"" />
  <xs:complexType name=""ArrayOfAuditPartitionDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AuditPartitionDetail"" nillable=""true"" type=""tns:AuditPartitionDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAuditPartitionDetail"" nillable=""true"" type=""tns:ArrayOfAuditPartitionDetail"" />
  <xs:complexType name=""ArrayOfArrayOfAuditPartitionDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAuditPartitionDetail"" nillable=""true"" type=""tns:ArrayOfAuditPartitionDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAuditPartitionDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfAuditPartitionDetail"" />
  <xs:complexType name=""AuditPartitionDetailCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AuditPartitionDetail"" nillable=""true"" type=""tns:AuditPartitionDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AuditPartitionDetailCollection"" nillable=""true"" type=""tns:AuditPartitionDetailCollection"" />
  <xs:complexType name=""ArrayOfAuditPartitionDetailCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AuditPartitionDetailCollection"" nillable=""true"" type=""tns:AuditPartitionDetailCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAuditPartitionDetailCollection"" nillable=""true"" type=""tns:ArrayOfAuditPartitionDetailCollection"" />
  <xs:complexType name=""ArrayOfArrayOfAuditPartitionDetailCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAuditPartitionDetailCollection"" nillable=""true"" type=""tns:ArrayOfAuditPartitionDetailCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAuditPartitionDetailCollection"" nillable=""true"" type=""tns:ArrayOfArrayOfAuditPartitionDetailCollection"" />
  <xs:complexType name=""ComponentDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Id"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""ParentDisplayName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ParentId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""ParentSchemaName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""SchemaName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Solution"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Type"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ComponentDetail"" nillable=""true"" type=""tns:ComponentDetail"" />
  <xs:complexType name=""ArrayOfComponentDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ComponentDetail"" nillable=""true"" type=""tns:ComponentDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfComponentDetail"" nillable=""true"" type=""tns:ArrayOfComponentDetail"" />
  <xs:complexType name=""ArrayOfArrayOfComponentDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfComponentDetail"" nillable=""true"" type=""tns:ArrayOfComponentDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfComponentDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfComponentDetail"" />
  <xs:complexType name=""ArrayOfArrayOfConstraintRelation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfConstraintRelation"" nillable=""true"" type=""tns:ArrayOfConstraintRelation"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfConstraintRelation"" nillable=""true"" type=""tns:ArrayOfArrayOfConstraintRelation"" />
  <xs:simpleType name=""BulkOperationSource"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""QuickCampaign"" />
      <xs:enumeration value=""CampaignActivity"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""BulkOperationSource"" nillable=""true"" type=""tns:BulkOperationSource"" />
  <xs:complexType name=""ArrayOfBulkOperationSource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BulkOperationSource"" type=""tns:BulkOperationSource"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfBulkOperationSource"" nillable=""true"" type=""tns:ArrayOfBulkOperationSource"" />
  <xs:complexType name=""ArrayOfArrayOfBulkOperationSource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfBulkOperationSource"" nillable=""true"" type=""tns:ArrayOfBulkOperationSource"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfBulkOperationSource"" nillable=""true"" type=""tns:ArrayOfArrayOfBulkOperationSource"" />
  <xs:simpleType name=""EntitySource"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Account"" />
      <xs:enumeration value=""Contact"" />
      <xs:enumeration value=""Lead"" />
      <xs:enumeration value=""All"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""EntitySource"" nillable=""true"" type=""tns:EntitySource"" />
  <xs:complexType name=""ArrayOfEntitySource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EntitySource"" type=""tns:EntitySource"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfEntitySource"" nillable=""true"" type=""tns:ArrayOfEntitySource"" />
  <xs:complexType name=""ArrayOfArrayOfEntitySource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfEntitySource"" nillable=""true"" type=""tns:ArrayOfEntitySource"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfEntitySource"" nillable=""true"" type=""tns:ArrayOfArrayOfEntitySource"" />
  <xs:simpleType name=""TargetFieldType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""All"" />
      <xs:enumeration value=""ValidForCreate"" />
      <xs:enumeration value=""ValidForUpdate"" />
      <xs:enumeration value=""ValidForRead"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""TargetFieldType"" nillable=""true"" type=""tns:TargetFieldType"" />
  <xs:complexType name=""ArrayOfTargetFieldType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TargetFieldType"" type=""tns:TargetFieldType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfTargetFieldType"" nillable=""true"" type=""tns:ArrayOfTargetFieldType"" />
  <xs:complexType name=""ArrayOfArrayOfTargetFieldType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfTargetFieldType"" nillable=""true"" type=""tns:ArrayOfTargetFieldType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfTargetFieldType"" nillable=""true"" type=""tns:ArrayOfArrayOfTargetFieldType"" />
  <xs:simpleType name=""PropagationOwnershipOptions"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Caller"" />
      <xs:enumeration value=""ListMemberOwner"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""PropagationOwnershipOptions"" nillable=""true"" type=""tns:PropagationOwnershipOptions"" />
  <xs:complexType name=""ArrayOfPropagationOwnershipOptions"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PropagationOwnershipOptions"" type=""tns:PropagationOwnershipOptions"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPropagationOwnershipOptions"" nillable=""true"" type=""tns:ArrayOfPropagationOwnershipOptions"" />
  <xs:complexType name=""ArrayOfArrayOfPropagationOwnershipOptions"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfPropagationOwnershipOptions"" nillable=""true"" type=""tns:ArrayOfPropagationOwnershipOptions"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfPropagationOwnershipOptions"" nillable=""true"" type=""tns:ArrayOfArrayOfPropagationOwnershipOptions"" />
  <xs:simpleType name=""RollupType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Related"" />
      <xs:enumeration value=""Extended"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""RollupType"" nillable=""true"" type=""tns:RollupType"" />
  <xs:complexType name=""ArrayOfRollupType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RollupType"" type=""tns:RollupType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRollupType"" nillable=""true"" type=""tns:ArrayOfRollupType"" />
  <xs:complexType name=""ArrayOfArrayOfRollupType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfRollupType"" nillable=""true"" type=""tns:ArrayOfRollupType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfRollupType"" nillable=""true"" type=""tns:ArrayOfArrayOfRollupType"" />
  <xs:complexType name=""ErrorInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ErrorCode"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ResourceList"" nillable=""true"" type=""tns:ArrayOfResourceInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ErrorInfo"" nillable=""true"" type=""tns:ErrorInfo"" />
  <xs:complexType name=""ArrayOfResourceInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ResourceInfo"" nillable=""true"" type=""tns:ResourceInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfResourceInfo"" nillable=""true"" type=""tns:ArrayOfResourceInfo"" />
  <xs:complexType name=""ResourceInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DisplayName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""EntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Id"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ResourceInfo"" nillable=""true"" type=""tns:ResourceInfo"" />
  <xs:complexType name=""ArrayOfErrorInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ErrorInfo"" nillable=""true"" type=""tns:ErrorInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfErrorInfo"" nillable=""true"" type=""tns:ArrayOfErrorInfo"" />
  <xs:complexType name=""ArrayOfArrayOfErrorInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfErrorInfo"" nillable=""true"" type=""tns:ArrayOfErrorInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfErrorInfo"" nillable=""true"" type=""tns:ArrayOfArrayOfErrorInfo"" />
  <xs:complexType name=""InputArgumentCollection"">
    <xs:sequence>
      <xs:element xmlns:q103=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" name=""Arguments"" nillable=""true"" type=""q103:ArrayOfKeyValuePairOfstringanyType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""InputArgumentCollection"" nillable=""true"" type=""tns:InputArgumentCollection"" />
  <xs:complexType name=""ArrayOfInputArgumentCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""InputArgumentCollection"" nillable=""true"" type=""tns:InputArgumentCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfInputArgumentCollection"" nillable=""true"" type=""tns:ArrayOfInputArgumentCollection"" />
  <xs:complexType name=""ArrayOfArrayOfInputArgumentCollection"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfInputArgumentCollection"" nillable=""true"" type=""tns:ArrayOfInputArgumentCollection"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfInputArgumentCollection"" nillable=""true"" type=""tns:ArrayOfArrayOfInputArgumentCollection"" />
  <xs:complexType name=""BusinessNotification"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Message"" nillable=""true"" type=""xs:string"" />
      <xs:element xmlns:q104=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" minOccurs=""0"" name=""Parameters"" nillable=""true"" type=""q104:ArrayOfBusinessNotificationParameter"" />
      <xs:element xmlns:q105=""http://schemas.datacontract.org/2004/07/Microsoft.Crm.Sdk.Messages"" minOccurs=""0"" name=""Severity"" type=""q105:BusinessNotificationSeverity"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BusinessNotification"" nillable=""true"" type=""tns:BusinessNotification"" />
  <xs:complexType name=""ArrayOfBusinessNotification"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BusinessNotification"" nillable=""true"" type=""tns:BusinessNotification"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfBusinessNotification"" nillable=""true"" type=""tns:ArrayOfBusinessNotification"" />
  <xs:complexType name=""ArrayOfArrayOfBusinessNotification"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfBusinessNotification"" nillable=""true"" type=""tns:ArrayOfBusinessNotification"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfBusinessNotification"" nillable=""true"" type=""tns:ArrayOfArrayOfBusinessNotification"" />
  <xs:complexType name=""MissingComponent"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DependentComponent"" nillable=""true"" type=""tns:ComponentDetail"" />
      <xs:element minOccurs=""0"" name=""RequiredComponent"" nillable=""true"" type=""tns:ComponentDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""MissingComponent"" nillable=""true"" type=""tns:MissingComponent"" />
  <xs:complexType name=""ArrayOfMissingComponent"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MissingComponent"" nillable=""true"" type=""tns:MissingComponent"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfMissingComponent"" nillable=""true"" type=""tns:ArrayOfMissingComponent"" />
  <xs:complexType name=""ArrayOfArrayOfMissingComponent"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfMissingComponent"" nillable=""true"" type=""tns:ArrayOfMissingComponent"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfMissingComponent"" nillable=""true"" type=""tns:ArrayOfArrayOfMissingComponent"" />
  <xs:complexType name=""ArrayOfArrayOfObjectiveRelation"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfObjectiveRelation"" nillable=""true"" type=""tns:ArrayOfObjectiveRelation"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfObjectiveRelation"" nillable=""true"" type=""tns:ArrayOfArrayOfObjectiveRelation"" />
  <xs:complexType name=""OrganizationResources"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CurrentNumberOfActiveUsers"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CurrentNumberOfCustomEntities"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CurrentNumberOfNonInteractiveUsers"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CurrentNumberOfPublishedWorkflows"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CurrentStorage"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MaxNumberOfActiveUsers"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MaxNumberOfCustomEntities"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MaxNumberOfNonInteractiveUsers"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MaxNumberOfPublishedWorkflows"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MaxStorage"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""OrganizationResources"" nillable=""true"" type=""tns:OrganizationResources"" />
  <xs:complexType name=""ArrayOfOrganizationResources"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrganizationResources"" nillable=""true"" type=""tns:OrganizationResources"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfOrganizationResources"" nillable=""true"" type=""tns:ArrayOfOrganizationResources"" />
  <xs:complexType name=""ArrayOfArrayOfOrganizationResources"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfOrganizationResources"" nillable=""true"" type=""tns:ArrayOfOrganizationResources"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfOrganizationResources"" nillable=""true"" type=""tns:ArrayOfArrayOfOrganizationResources"" />
  <xs:complexType name=""PrincipalAccess"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AccessMask"" type=""tns:AccessRights"" />
      <xs:element xmlns:q106=""http://schemas.microsoft.com/xrm/2011/Contracts"" minOccurs=""0"" name=""Principal"" nillable=""true"" type=""q106:EntityReference"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""PrincipalAccess"" nillable=""true"" type=""tns:PrincipalAccess"" />
  <xs:complexType name=""ArrayOfPrincipalAccess"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PrincipalAccess"" nillable=""true"" type=""tns:PrincipalAccess"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPrincipalAccess"" nillable=""true"" type=""tns:ArrayOfPrincipalAccess"" />
  <xs:complexType name=""ArrayOfArrayOfPrincipalAccess"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfPrincipalAccess"" nillable=""true"" type=""tns:ArrayOfPrincipalAccess"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfPrincipalAccess"" nillable=""true"" type=""tns:ArrayOfArrayOfPrincipalAccess"" />
  <xs:complexType name=""ArrayOfAccessRights"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AccessRights"" type=""tns:AccessRights"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfAccessRights"" nillable=""true"" type=""tns:ArrayOfAccessRights"" />
  <xs:complexType name=""ArrayOfArrayOfAccessRights"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfAccessRights"" nillable=""true"" type=""tns:ArrayOfAccessRights"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfAccessRights"" nillable=""true"" type=""tns:ArrayOfArrayOfAccessRights"" />
  <xs:complexType name=""ArrayOfArrayOfProposalParty"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfProposalParty"" nillable=""true"" type=""tns:ArrayOfProposalParty"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfProposalParty"" nillable=""true"" type=""tns:ArrayOfArrayOfProposalParty"" />
  <xs:complexType name=""ArrayOfRelationshipAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RelationshipAuditDetail"" nillable=""true"" type=""tns:RelationshipAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRelationshipAuditDetail"" nillable=""true"" type=""tns:ArrayOfRelationshipAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfRelationshipAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfRelationshipAuditDetail"" nillable=""true"" type=""tns:ArrayOfRelationshipAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfRelationshipAuditDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfRelationshipAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfRequiredResource"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfRequiredResource"" nillable=""true"" type=""tns:ArrayOfRequiredResource"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfRequiredResource"" nillable=""true"" type=""tns:ArrayOfArrayOfRequiredResource"" />
  <xs:complexType name=""ArrayOfArrayOfResourceInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfResourceInfo"" nillable=""true"" type=""tns:ArrayOfResourceInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfResourceInfo"" nillable=""true"" type=""tns:ArrayOfArrayOfResourceInfo"" />
  <xs:simpleType name=""RibbonLocationFilters"">
    <xs:list>
      <xs:simpleType>
        <xs:restriction base=""xs:string"">
          <xs:enumeration value=""Form"" />
          <xs:enumeration value=""HomepageGrid"" />
          <xs:enumeration value=""SubGrid"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:list>
  </xs:simpleType>
  <xs:element name=""RibbonLocationFilters"" nillable=""true"" type=""tns:RibbonLocationFilters"" />
  <xs:complexType name=""ArrayOfRibbonLocationFilters"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RibbonLocationFilters"" type=""tns:RibbonLocationFilters"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRibbonLocationFilters"" nillable=""true"" type=""tns:ArrayOfRibbonLocationFilters"" />
  <xs:complexType name=""ArrayOfArrayOfRibbonLocationFilters"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfRibbonLocationFilters"" nillable=""true"" type=""tns:ArrayOfRibbonLocationFilters"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfRibbonLocationFilters"" nillable=""true"" type=""tns:ArrayOfArrayOfRibbonLocationFilters"" />
  <xs:simpleType name=""PrivilegeDepth"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Basic"" />
      <xs:enumeration value=""Local"" />
      <xs:enumeration value=""Deep"" />
      <xs:enumeration value=""Global"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""PrivilegeDepth"" nillable=""true"" type=""tns:PrivilegeDepth"" />
  <xs:complexType name=""ArrayOfPrivilegeDepth"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PrivilegeDepth"" type=""tns:PrivilegeDepth"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfPrivilegeDepth"" nillable=""true"" type=""tns:ArrayOfPrivilegeDepth"" />
  <xs:complexType name=""ArrayOfArrayOfPrivilegeDepth"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfPrivilegeDepth"" nillable=""true"" type=""tns:ArrayOfPrivilegeDepth"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfPrivilegeDepth"" nillable=""true"" type=""tns:ArrayOfArrayOfPrivilegeDepth"" />
  <xs:complexType name=""RolePrivilege"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BusinessUnitId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""Depth"" type=""tns:PrivilegeDepth"" />
      <xs:element minOccurs=""0"" name=""PrivilegeId"" type=""ns1:guid"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""RolePrivilege"" nillable=""true"" type=""tns:RolePrivilege"" />
  <xs:complexType name=""ArrayOfRolePrivilege"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RolePrivilege"" nillable=""true"" type=""tns:RolePrivilege"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRolePrivilege"" nillable=""true"" type=""tns:ArrayOfRolePrivilege"" />
  <xs:complexType name=""ArrayOfArrayOfRolePrivilege"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfRolePrivilege"" nillable=""true"" type=""tns:ArrayOfRolePrivilege"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfRolePrivilege"" nillable=""true"" type=""tns:ArrayOfArrayOfRolePrivilege"" />
  <xs:complexType name=""SearchResults"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Proposals"" nillable=""true"" type=""tns:ArrayOfAppointmentProposal"" />
      <xs:element minOccurs=""0"" name=""TraceInfo"" nillable=""true"" type=""tns:TraceInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""SearchResults"" nillable=""true"" type=""tns:SearchResults"" />
  <xs:complexType name=""TraceInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ErrorInfoList"" nillable=""true"" type=""tns:ArrayOfErrorInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""TraceInfo"" nillable=""true"" type=""tns:TraceInfo"" />
  <xs:complexType name=""ArrayOfSearchResults"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SearchResults"" nillable=""true"" type=""tns:SearchResults"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSearchResults"" nillable=""true"" type=""tns:ArrayOfSearchResults"" />
  <xs:complexType name=""ArrayOfArrayOfSearchResults"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfSearchResults"" nillable=""true"" type=""tns:ArrayOfSearchResults"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfSearchResults"" nillable=""true"" type=""tns:ArrayOfArrayOfSearchResults"" />
  <xs:complexType name=""ArrayOfShareAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ShareAuditDetail"" nillable=""true"" type=""tns:ShareAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfShareAuditDetail"" nillable=""true"" type=""tns:ArrayOfShareAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfShareAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfShareAuditDetail"" nillable=""true"" type=""tns:ArrayOfShareAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfShareAuditDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfShareAuditDetail"" />
  <xs:complexType name=""RolePrivilegeAuditDetail"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AuditDetail"">
        <xs:sequence>
          <xs:element xmlns:q107=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""InvalidNewPrivileges"" nillable=""true"" type=""q107:ArrayOfguid"" />
          <xs:element minOccurs=""0"" name=""NewRolePrivileges"" nillable=""true"" type=""tns:ArrayOfRolePrivilege"" />
          <xs:element minOccurs=""0"" name=""OldRolePrivileges"" nillable=""true"" type=""tns:ArrayOfRolePrivilege"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""RolePrivilegeAuditDetail"" nillable=""true"" type=""tns:RolePrivilegeAuditDetail"" />
  <xs:complexType name=""ArrayOfRolePrivilegeAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RolePrivilegeAuditDetail"" nillable=""true"" type=""tns:RolePrivilegeAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfRolePrivilegeAuditDetail"" nillable=""true"" type=""tns:ArrayOfRolePrivilegeAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfRolePrivilegeAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfRolePrivilegeAuditDetail"" nillable=""true"" type=""tns:ArrayOfRolePrivilegeAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfRolePrivilegeAuditDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfRolePrivilegeAuditDetail"" />
  <xs:complexType name=""TimeInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ActivityStatusCode"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""CalendarId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""DisplayText"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Effort"" type=""xs:double"" />
      <xs:element minOccurs=""0"" name=""End"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""IsActivity"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""SourceId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""SourceTypeCode"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Start"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""SubCode"" type=""tns:SubCode"" />
      <xs:element minOccurs=""0"" name=""TimeCode"" type=""tns:TimeCode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""TimeInfo"" nillable=""true"" type=""tns:TimeInfo"" />
  <xs:simpleType name=""SubCode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Unspecified"" />
      <xs:enumeration value=""Schedulable"" />
      <xs:enumeration value=""Committed"" />
      <xs:enumeration value=""Uncommitted"" />
      <xs:enumeration value=""Break"" />
      <xs:enumeration value=""Holiday"" />
      <xs:enumeration value=""Vacation"" />
      <xs:enumeration value=""Appointment"" />
      <xs:enumeration value=""ResourceStartTime"" />
      <xs:enumeration value=""ResourceServiceRestriction"" />
      <xs:enumeration value=""ResourceCapacity"" />
      <xs:enumeration value=""ServiceRestriction"" />
      <xs:enumeration value=""ServiceCost"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""SubCode"" nillable=""true"" type=""tns:SubCode"" />
  <xs:simpleType name=""TimeCode"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Available"" />
      <xs:enumeration value=""Busy"" />
      <xs:enumeration value=""Unavailable"" />
      <xs:enumeration value=""Filter"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""TimeCode"" nillable=""true"" type=""tns:TimeCode"" />
  <xs:complexType name=""ArrayOfTimeInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TimeInfo"" nillable=""true"" type=""tns:TimeInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfTimeInfo"" nillable=""true"" type=""tns:ArrayOfTimeInfo"" />
  <xs:complexType name=""ArrayOfArrayOfTimeInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfTimeInfo"" nillable=""true"" type=""tns:ArrayOfTimeInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfTimeInfo"" nillable=""true"" type=""tns:ArrayOfArrayOfTimeInfo"" />
  <xs:complexType name=""ArrayOfTimeCode"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TimeCode"" type=""tns:TimeCode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfTimeCode"" nillable=""true"" type=""tns:ArrayOfTimeCode"" />
  <xs:complexType name=""ArrayOfArrayOfTimeCode"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfTimeCode"" nillable=""true"" type=""tns:ArrayOfTimeCode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfTimeCode"" nillable=""true"" type=""tns:ArrayOfArrayOfTimeCode"" />
  <xs:complexType name=""ArrayOfSubCode"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SubCode"" type=""tns:SubCode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSubCode"" nillable=""true"" type=""tns:ArrayOfSubCode"" />
  <xs:complexType name=""ArrayOfArrayOfSubCode"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfSubCode"" nillable=""true"" type=""tns:ArrayOfSubCode"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfSubCode"" nillable=""true"" type=""tns:ArrayOfArrayOfSubCode"" />
  <xs:complexType name=""ArrayOfTraceInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TraceInfo"" nillable=""true"" type=""tns:TraceInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfTraceInfo"" nillable=""true"" type=""tns:ArrayOfTraceInfo"" />
  <xs:complexType name=""ArrayOfArrayOfTraceInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfTraceInfo"" nillable=""true"" type=""tns:ArrayOfTraceInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfTraceInfo"" nillable=""true"" type=""tns:ArrayOfArrayOfTraceInfo"" />
  <xs:complexType name=""UserAccessAuditDetail"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""tns:AuditDetail"">
        <xs:sequence>
          <xs:element minOccurs=""0"" name=""AccessTime"" type=""xs:dateTime"" />
          <xs:element minOccurs=""0"" name=""Interval"" type=""xs:int"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""UserAccessAuditDetail"" nillable=""true"" type=""tns:UserAccessAuditDetail"" />
  <xs:complexType name=""ArrayOfUserAccessAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UserAccessAuditDetail"" nillable=""true"" type=""tns:UserAccessAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfUserAccessAuditDetail"" nillable=""true"" type=""tns:ArrayOfUserAccessAuditDetail"" />
  <xs:complexType name=""ArrayOfArrayOfUserAccessAuditDetail"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfUserAccessAuditDetail"" nillable=""true"" type=""tns:ArrayOfUserAccessAuditDetail"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfUserAccessAuditDetail"" nillable=""true"" type=""tns:ArrayOfArrayOfUserAccessAuditDetail"" />
  <xs:complexType name=""ValidationResult"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ActivityId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""TraceInfo"" nillable=""true"" type=""tns:TraceInfo"" />
      <xs:element minOccurs=""0"" name=""ValidationSuccess"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ValidationResult"" nillable=""true"" type=""tns:ValidationResult"" />
  <xs:complexType name=""ArrayOfValidationResult"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ValidationResult"" nillable=""true"" type=""tns:ValidationResult"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfValidationResult"" nillable=""true"" type=""tns:ArrayOfValidationResult"" />
  <xs:complexType name=""ArrayOfArrayOfValidationResult"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfValidationResult"" nillable=""true"" type=""tns:ArrayOfValidationResult"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfValidationResult"" nillable=""true"" type=""tns:ArrayOfArrayOfValidationResult"" />
  <xs:complexType name=""CacheItem"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Data"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Key"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""CacheItem"" nillable=""true"" type=""tns:CacheItem"" />
  <xs:complexType name=""ArrayOfCacheItem"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CacheItem"" nillable=""true"" type=""tns:CacheItem"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfCacheItem"" nillable=""true"" type=""tns:ArrayOfCacheItem"" />
  <xs:complexType name=""ArrayOfArrayOfCacheItem"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfCacheItem"" nillable=""true"" type=""tns:ArrayOfCacheItem"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfCacheItem"" nillable=""true"" type=""tns:ArrayOfArrayOfCacheItem"" />
  <xs:simpleType name=""FaultType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CrmException"" />
      <xs:enumeration value=""ClrException"" />
      <xs:enumeration value=""Assertion"" />
      <xs:enumeration value=""Watson"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""FaultType"" nillable=""true"" type=""tns:FaultType"" />
  <xs:complexType name=""ArrayOfFaultType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FaultType"" type=""tns:FaultType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfFaultType"" nillable=""true"" type=""tns:ArrayOfFaultType"" />
  <xs:complexType name=""ArrayOfArrayOfFaultType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfFaultType"" nillable=""true"" type=""tns:ArrayOfFaultType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfFaultType"" nillable=""true"" type=""tns:ArrayOfArrayOfFaultType"" />
  <xs:complexType name=""QueryByEntityNameDictionary"">
    <xs:sequence>
      <xs:element xmlns:q108=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"" minOccurs=""0"" maxOccurs=""unbounded"" name=""KeyValuePairOfstringQueryBasegUGIFE1S"" type=""q108:KeyValuePairOfstringQueryBasegUGIFE1S"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""QueryByEntityNameDictionary"" nillable=""true"" type=""tns:QueryByEntityNameDictionary"" />
  <xs:complexType name=""ArrayOfQueryByEntityNameDictionary"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QueryByEntityNameDictionary"" nillable=""true"" type=""tns:QueryByEntityNameDictionary"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfQueryByEntityNameDictionary"" nillable=""true"" type=""tns:ArrayOfQueryByEntityNameDictionary"" />
  <xs:complexType name=""ArrayOfArrayOfQueryByEntityNameDictionary"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfQueryByEntityNameDictionary"" nillable=""true"" type=""tns:ArrayOfQueryByEntityNameDictionary"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfQueryByEntityNameDictionary"" nillable=""true"" type=""tns:ArrayOfArrayOfQueryByEntityNameDictionary"" />
  <xs:complexType name=""ResetSyncStateInfo"">
    <xs:sequence>
      <xs:element xmlns:q109=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""EntityIds"" nillable=""true"" type=""q109:ArrayOfguid"" />
      <xs:element minOccurs=""0"" name=""ObjectTypeCode"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ResetSyncStateInfo"" nillable=""true"" type=""tns:ResetSyncStateInfo"" />
  <xs:complexType name=""ArrayOfResetSyncStateInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ResetSyncStateInfo"" nillable=""true"" type=""tns:ResetSyncStateInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfResetSyncStateInfo"" nillable=""true"" type=""tns:ArrayOfResetSyncStateInfo"" />
  <xs:complexType name=""ArrayOfArrayOfResetSyncStateInfo"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfResetSyncStateInfo"" nillable=""true"" type=""tns:ArrayOfResetSyncStateInfo"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfResetSyncStateInfo"" nillable=""true"" type=""tns:ArrayOfArrayOfResetSyncStateInfo"" />
  <xs:complexType name=""SdkMessageProcessingStepImageRegistration"">
    <xs:sequence>
      <xs:element xmlns:q110=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" minOccurs=""0"" name=""Attributes"" nillable=""true"" type=""q110:ArrayOfstring"" />
      <xs:element minOccurs=""0"" name=""EntityAlias"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ImageType"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MessagePropertyName"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""SdkMessageProcessingStepImageRegistration"" nillable=""true"" type=""tns:SdkMessageProcessingStepImageRegistration"" />
  <xs:complexType name=""ArrayOfSdkMessageProcessingStepImageRegistration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SdkMessageProcessingStepImageRegistration"" nillable=""true"" type=""tns:SdkMessageProcessingStepImageRegistration"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSdkMessageProcessingStepImageRegistration"" nillable=""true"" type=""tns:ArrayOfSdkMessageProcessingStepImageRegistration"" />
  <xs:complexType name=""ArrayOfArrayOfSdkMessageProcessingStepImageRegistration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfSdkMessageProcessingStepImageRegistration"" nillable=""true"" type=""tns:ArrayOfSdkMessageProcessingStepImageRegistration"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfSdkMessageProcessingStepImageRegistration"" nillable=""true"" type=""tns:ArrayOfArrayOfSdkMessageProcessingStepImageRegistration"" />
  <xs:complexType name=""SdkMessageProcessingStepRegistration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CustomConfiguration"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Description"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FilteringAttributes"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Images"" nillable=""true"" type=""tns:ArrayOfSdkMessageProcessingStepImageRegistration"" />
      <xs:element minOccurs=""0"" name=""ImpersonatingUserId"" type=""ns1:guid"" />
      <xs:element minOccurs=""0"" name=""InvocationSource"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""MessageName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Mode"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PluginTypeFriendlyName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PluginTypeName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""PrimaryEntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""SecondaryEntityName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Stage"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""SupportedDeployment"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""SdkMessageProcessingStepRegistration"" nillable=""true"" type=""tns:SdkMessageProcessingStepRegistration"" />
  <xs:complexType name=""ArrayOfSdkMessageProcessingStepRegistration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SdkMessageProcessingStepRegistration"" nillable=""true"" type=""tns:SdkMessageProcessingStepRegistration"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSdkMessageProcessingStepRegistration"" nillable=""true"" type=""tns:ArrayOfSdkMessageProcessingStepRegistration"" />
  <xs:complexType name=""ArrayOfArrayOfSdkMessageProcessingStepRegistration"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfSdkMessageProcessingStepRegistration"" nillable=""true"" type=""tns:ArrayOfSdkMessageProcessingStepRegistration"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfSdkMessageProcessingStepRegistration"" nillable=""true"" type=""tns:ArrayOfArrayOfSdkMessageProcessingStepRegistration"" />
  <xs:simpleType name=""SyncAction"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""None"" />
      <xs:enumeration value=""Insert"" />
      <xs:enumeration value=""Delete"" />
      <xs:enumeration value=""Update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""SyncAction"" nillable=""true"" type=""tns:SyncAction"" />
  <xs:complexType name=""ArrayOfSyncAction"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SyncAction"" type=""tns:SyncAction"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfSyncAction"" nillable=""true"" type=""tns:ArrayOfSyncAction"" />
  <xs:complexType name=""ArrayOfArrayOfSyncAction"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ArrayOfSyncAction"" nillable=""true"" type=""tns:ArrayOfSyncAction"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfArrayOfSyncAction"" nillable=""true"" type=""tns:ArrayOfArrayOfSyncAction"" />
</xs:schema>";
        
        public OrganizationService_schemas_microsoft_com_crm_2011_Contracts() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [141];
                _RootElements[0] = "AppointmentProposal";
                _RootElements[1] = "ArrayOfProposalParty";
                _RootElements[2] = "ProposalParty";
                _RootElements[3] = "ArrayOfAppointmentProposal";
                _RootElements[4] = "ArrayOfArrayOfAppointmentProposal";
                _RootElements[5] = "SearchDirection";
                _RootElements[6] = "ArrayOfSearchDirection";
                _RootElements[7] = "ArrayOfArrayOfSearchDirection";
                _RootElements[8] = "AppointmentRequest";
                _RootElements[9] = "ArrayOfAppointmentsToIgnore";
                _RootElements[10] = "AppointmentsToIgnore";
                _RootElements[11] = "ArrayOfConstraintRelation";
                _RootElements[12] = "ConstraintRelation";
                _RootElements[13] = "ArrayOfObjectiveRelation";
                _RootElements[14] = "ObjectiveRelation";
                _RootElements[15] = "ArrayOfRequiredResource";
                _RootElements[16] = "RequiredResource";
                _RootElements[17] = "ArrayOfAppointmentRequest";
                _RootElements[18] = "ArrayOfArrayOfAppointmentRequest";
                _RootElements[19] = "ArrayOfArrayOfAppointmentsToIgnore";
                _RootElements[20] = "AuditDetail";
                _RootElements[21] = "ShareAuditDetail";
                _RootElements[22] = "AccessRights";
                _RootElements[23] = "AttributeAuditDetail";
                _RootElements[24] = "RelationshipAuditDetail";
                _RootElements[25] = "ArrayOfAuditDetail";
                _RootElements[26] = "ArrayOfArrayOfAuditDetail";
                _RootElements[27] = "ArrayOfAttributeAuditDetail";
                _RootElements[28] = "ArrayOfArrayOfAttributeAuditDetail";
                _RootElements[29] = "AuditDetailCollection";
                _RootElements[30] = "ArrayOfAuditDetailCollection";
                _RootElements[31] = "ArrayOfArrayOfAuditDetailCollection";
                _RootElements[32] = "AuditPartitionDetail";
                _RootElements[33] = "ArrayOfAuditPartitionDetail";
                _RootElements[34] = "ArrayOfArrayOfAuditPartitionDetail";
                _RootElements[35] = "AuditPartitionDetailCollection";
                _RootElements[36] = "ArrayOfAuditPartitionDetailCollection";
                _RootElements[37] = "ArrayOfArrayOfAuditPartitionDetailCollection";
                _RootElements[38] = "ComponentDetail";
                _RootElements[39] = "ArrayOfComponentDetail";
                _RootElements[40] = "ArrayOfArrayOfComponentDetail";
                _RootElements[41] = "ArrayOfArrayOfConstraintRelation";
                _RootElements[42] = "BulkOperationSource";
                _RootElements[43] = "ArrayOfBulkOperationSource";
                _RootElements[44] = "ArrayOfArrayOfBulkOperationSource";
                _RootElements[45] = "EntitySource";
                _RootElements[46] = "ArrayOfEntitySource";
                _RootElements[47] = "ArrayOfArrayOfEntitySource";
                _RootElements[48] = "TargetFieldType";
                _RootElements[49] = "ArrayOfTargetFieldType";
                _RootElements[50] = "ArrayOfArrayOfTargetFieldType";
                _RootElements[51] = "PropagationOwnershipOptions";
                _RootElements[52] = "ArrayOfPropagationOwnershipOptions";
                _RootElements[53] = "ArrayOfArrayOfPropagationOwnershipOptions";
                _RootElements[54] = "RollupType";
                _RootElements[55] = "ArrayOfRollupType";
                _RootElements[56] = "ArrayOfArrayOfRollupType";
                _RootElements[57] = "ErrorInfo";
                _RootElements[58] = "ArrayOfResourceInfo";
                _RootElements[59] = "ResourceInfo";
                _RootElements[60] = "ArrayOfErrorInfo";
                _RootElements[61] = "ArrayOfArrayOfErrorInfo";
                _RootElements[62] = "InputArgumentCollection";
                _RootElements[63] = "ArrayOfInputArgumentCollection";
                _RootElements[64] = "ArrayOfArrayOfInputArgumentCollection";
                _RootElements[65] = "BusinessNotification";
                _RootElements[66] = "ArrayOfBusinessNotification";
                _RootElements[67] = "ArrayOfArrayOfBusinessNotification";
                _RootElements[68] = "MissingComponent";
                _RootElements[69] = "ArrayOfMissingComponent";
                _RootElements[70] = "ArrayOfArrayOfMissingComponent";
                _RootElements[71] = "ArrayOfArrayOfObjectiveRelation";
                _RootElements[72] = "OrganizationResources";
                _RootElements[73] = "ArrayOfOrganizationResources";
                _RootElements[74] = "ArrayOfArrayOfOrganizationResources";
                _RootElements[75] = "PrincipalAccess";
                _RootElements[76] = "ArrayOfPrincipalAccess";
                _RootElements[77] = "ArrayOfArrayOfPrincipalAccess";
                _RootElements[78] = "ArrayOfAccessRights";
                _RootElements[79] = "ArrayOfArrayOfAccessRights";
                _RootElements[80] = "ArrayOfArrayOfProposalParty";
                _RootElements[81] = "ArrayOfRelationshipAuditDetail";
                _RootElements[82] = "ArrayOfArrayOfRelationshipAuditDetail";
                _RootElements[83] = "ArrayOfArrayOfRequiredResource";
                _RootElements[84] = "ArrayOfArrayOfResourceInfo";
                _RootElements[85] = "RibbonLocationFilters";
                _RootElements[86] = "ArrayOfRibbonLocationFilters";
                _RootElements[87] = "ArrayOfArrayOfRibbonLocationFilters";
                _RootElements[88] = "PrivilegeDepth";
                _RootElements[89] = "ArrayOfPrivilegeDepth";
                _RootElements[90] = "ArrayOfArrayOfPrivilegeDepth";
                _RootElements[91] = "RolePrivilege";
                _RootElements[92] = "ArrayOfRolePrivilege";
                _RootElements[93] = "ArrayOfArrayOfRolePrivilege";
                _RootElements[94] = "SearchResults";
                _RootElements[95] = "TraceInfo";
                _RootElements[96] = "ArrayOfSearchResults";
                _RootElements[97] = "ArrayOfArrayOfSearchResults";
                _RootElements[98] = "ArrayOfShareAuditDetail";
                _RootElements[99] = "ArrayOfArrayOfShareAuditDetail";
                _RootElements[100] = "RolePrivilegeAuditDetail";
                _RootElements[101] = "ArrayOfRolePrivilegeAuditDetail";
                _RootElements[102] = "ArrayOfArrayOfRolePrivilegeAuditDetail";
                _RootElements[103] = "TimeInfo";
                _RootElements[104] = "SubCode";
                _RootElements[105] = "TimeCode";
                _RootElements[106] = "ArrayOfTimeInfo";
                _RootElements[107] = "ArrayOfArrayOfTimeInfo";
                _RootElements[108] = "ArrayOfTimeCode";
                _RootElements[109] = "ArrayOfArrayOfTimeCode";
                _RootElements[110] = "ArrayOfSubCode";
                _RootElements[111] = "ArrayOfArrayOfSubCode";
                _RootElements[112] = "ArrayOfTraceInfo";
                _RootElements[113] = "ArrayOfArrayOfTraceInfo";
                _RootElements[114] = "UserAccessAuditDetail";
                _RootElements[115] = "ArrayOfUserAccessAuditDetail";
                _RootElements[116] = "ArrayOfArrayOfUserAccessAuditDetail";
                _RootElements[117] = "ValidationResult";
                _RootElements[118] = "ArrayOfValidationResult";
                _RootElements[119] = "ArrayOfArrayOfValidationResult";
                _RootElements[120] = "CacheItem";
                _RootElements[121] = "ArrayOfCacheItem";
                _RootElements[122] = "ArrayOfArrayOfCacheItem";
                _RootElements[123] = "FaultType";
                _RootElements[124] = "ArrayOfFaultType";
                _RootElements[125] = "ArrayOfArrayOfFaultType";
                _RootElements[126] = "QueryByEntityNameDictionary";
                _RootElements[127] = "ArrayOfQueryByEntityNameDictionary";
                _RootElements[128] = "ArrayOfArrayOfQueryByEntityNameDictionary";
                _RootElements[129] = "ResetSyncStateInfo";
                _RootElements[130] = "ArrayOfResetSyncStateInfo";
                _RootElements[131] = "ArrayOfArrayOfResetSyncStateInfo";
                _RootElements[132] = "SdkMessageProcessingStepImageRegistration";
                _RootElements[133] = "ArrayOfSdkMessageProcessingStepImageRegistration";
                _RootElements[134] = "ArrayOfArrayOfSdkMessageProcessingStepImageRegistration";
                _RootElements[135] = "SdkMessageProcessingStepRegistration";
                _RootElements[136] = "ArrayOfSdkMessageProcessingStepRegistration";
                _RootElements[137] = "ArrayOfArrayOfSdkMessageProcessingStepRegistration";
                _RootElements[138] = "SyncAction";
                _RootElements[139] = "ArrayOfSyncAction";
                _RootElements[140] = "ArrayOfArrayOfSyncAction";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AppointmentProposal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AppointmentProposal"})]
        public sealed class AppointmentProposal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AppointmentProposal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AppointmentProposal";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfProposalParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfProposalParty"})]
        public sealed class ArrayOfProposalParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfProposalParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfProposalParty";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ProposalParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProposalParty"})]
        public sealed class ProposalParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProposalParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProposalParty";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAppointmentProposal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAppointmentProposal"})]
        public sealed class ArrayOfAppointmentProposal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAppointmentProposal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAppointmentProposal";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAppointmentProposal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAppointmentProposal"})]
        public sealed class ArrayOfArrayOfAppointmentProposal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAppointmentProposal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAppointmentProposal";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"SearchDirection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SearchDirection"})]
        public sealed class SearchDirection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SearchDirection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SearchDirection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfSearchDirection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSearchDirection"})]
        public sealed class ArrayOfSearchDirection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSearchDirection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSearchDirection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfSearchDirection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfSearchDirection"})]
        public sealed class ArrayOfArrayOfSearchDirection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfSearchDirection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfSearchDirection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AppointmentRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AppointmentRequest"})]
        public sealed class AppointmentRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AppointmentRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AppointmentRequest";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAppointmentsToIgnore")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAppointmentsToIgnore"})]
        public sealed class ArrayOfAppointmentsToIgnore : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAppointmentsToIgnore() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAppointmentsToIgnore";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AppointmentsToIgnore")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AppointmentsToIgnore"})]
        public sealed class AppointmentsToIgnore : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AppointmentsToIgnore() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AppointmentsToIgnore";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfConstraintRelation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfConstraintRelation"})]
        public sealed class ArrayOfConstraintRelation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfConstraintRelation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfConstraintRelation";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ConstraintRelation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConstraintRelation"})]
        public sealed class ConstraintRelation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConstraintRelation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConstraintRelation";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfObjectiveRelation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfObjectiveRelation"})]
        public sealed class ArrayOfObjectiveRelation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfObjectiveRelation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfObjectiveRelation";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ObjectiveRelation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ObjectiveRelation"})]
        public sealed class ObjectiveRelation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ObjectiveRelation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ObjectiveRelation";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfRequiredResource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRequiredResource"})]
        public sealed class ArrayOfRequiredResource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRequiredResource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRequiredResource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"RequiredResource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RequiredResource"})]
        public sealed class RequiredResource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RequiredResource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RequiredResource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAppointmentRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAppointmentRequest"})]
        public sealed class ArrayOfAppointmentRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAppointmentRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAppointmentRequest";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAppointmentRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAppointmentRequest"})]
        public sealed class ArrayOfArrayOfAppointmentRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAppointmentRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAppointmentRequest";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAppointmentsToIgnore")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAppointmentsToIgnore"})]
        public sealed class ArrayOfArrayOfAppointmentsToIgnore : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAppointmentsToIgnore() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAppointmentsToIgnore";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AuditDetail"})]
        public sealed class AuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ShareAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShareAuditDetail"})]
        public sealed class ShareAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShareAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShareAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AccessRights")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccessRights"})]
        public sealed class AccessRights : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccessRights() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccessRights";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AttributeAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AttributeAuditDetail"})]
        public sealed class AttributeAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AttributeAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AttributeAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"RelationshipAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RelationshipAuditDetail"})]
        public sealed class RelationshipAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RelationshipAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RelationshipAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAuditDetail"})]
        public sealed class ArrayOfAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAuditDetail"})]
        public sealed class ArrayOfArrayOfAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAttributeAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAttributeAuditDetail"})]
        public sealed class ArrayOfAttributeAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAttributeAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAttributeAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAttributeAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAttributeAuditDetail"})]
        public sealed class ArrayOfArrayOfAttributeAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAttributeAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAttributeAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AuditDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AuditDetailCollection"})]
        public sealed class AuditDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AuditDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AuditDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAuditDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAuditDetailCollection"})]
        public sealed class ArrayOfAuditDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAuditDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAuditDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAuditDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAuditDetailCollection"})]
        public sealed class ArrayOfArrayOfAuditDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAuditDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAuditDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AuditPartitionDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AuditPartitionDetail"})]
        public sealed class AuditPartitionDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AuditPartitionDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AuditPartitionDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAuditPartitionDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAuditPartitionDetail"})]
        public sealed class ArrayOfAuditPartitionDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAuditPartitionDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAuditPartitionDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAuditPartitionDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAuditPartitionDetail"})]
        public sealed class ArrayOfArrayOfAuditPartitionDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAuditPartitionDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAuditPartitionDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"AuditPartitionDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AuditPartitionDetailCollection"})]
        public sealed class AuditPartitionDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AuditPartitionDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AuditPartitionDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAuditPartitionDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAuditPartitionDetailCollection"})]
        public sealed class ArrayOfAuditPartitionDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAuditPartitionDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAuditPartitionDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAuditPartitionDetailCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAuditPartitionDetailCollection"})]
        public sealed class ArrayOfArrayOfAuditPartitionDetailCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAuditPartitionDetailCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAuditPartitionDetailCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ComponentDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ComponentDetail"})]
        public sealed class ComponentDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ComponentDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ComponentDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfComponentDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfComponentDetail"})]
        public sealed class ArrayOfComponentDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfComponentDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfComponentDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfComponentDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfComponentDetail"})]
        public sealed class ArrayOfArrayOfComponentDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfComponentDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfComponentDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfConstraintRelation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfConstraintRelation"})]
        public sealed class ArrayOfArrayOfConstraintRelation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfConstraintRelation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfConstraintRelation";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"BulkOperationSource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BulkOperationSource"})]
        public sealed class BulkOperationSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BulkOperationSource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BulkOperationSource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfBulkOperationSource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfBulkOperationSource"})]
        public sealed class ArrayOfBulkOperationSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfBulkOperationSource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfBulkOperationSource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfBulkOperationSource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfBulkOperationSource"})]
        public sealed class ArrayOfArrayOfBulkOperationSource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfBulkOperationSource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfBulkOperationSource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"EntitySource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EntitySource"})]
        public sealed class EntitySource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EntitySource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EntitySource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfEntitySource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfEntitySource"})]
        public sealed class ArrayOfEntitySource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfEntitySource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfEntitySource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfEntitySource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfEntitySource"})]
        public sealed class ArrayOfArrayOfEntitySource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfEntitySource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfEntitySource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"TargetFieldType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TargetFieldType"})]
        public sealed class TargetFieldType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TargetFieldType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TargetFieldType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfTargetFieldType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfTargetFieldType"})]
        public sealed class ArrayOfTargetFieldType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfTargetFieldType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfTargetFieldType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfTargetFieldType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfTargetFieldType"})]
        public sealed class ArrayOfArrayOfTargetFieldType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfTargetFieldType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfTargetFieldType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"PropagationOwnershipOptions")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PropagationOwnershipOptions"})]
        public sealed class PropagationOwnershipOptions : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PropagationOwnershipOptions() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PropagationOwnershipOptions";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfPropagationOwnershipOptions")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPropagationOwnershipOptions"})]
        public sealed class ArrayOfPropagationOwnershipOptions : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPropagationOwnershipOptions() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPropagationOwnershipOptions";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfPropagationOwnershipOptions")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfPropagationOwnershipOptions"})]
        public sealed class ArrayOfArrayOfPropagationOwnershipOptions : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfPropagationOwnershipOptions() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfPropagationOwnershipOptions";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"RollupType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RollupType"})]
        public sealed class RollupType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RollupType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RollupType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfRollupType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRollupType"})]
        public sealed class ArrayOfRollupType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRollupType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRollupType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfRollupType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfRollupType"})]
        public sealed class ArrayOfArrayOfRollupType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfRollupType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfRollupType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ErrorInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ErrorInfo"})]
        public sealed class ErrorInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ErrorInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ErrorInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfResourceInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfResourceInfo"})]
        public sealed class ArrayOfResourceInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfResourceInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfResourceInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ResourceInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ResourceInfo"})]
        public sealed class ResourceInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ResourceInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ResourceInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfErrorInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfErrorInfo"})]
        public sealed class ArrayOfErrorInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfErrorInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfErrorInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfErrorInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfErrorInfo"})]
        public sealed class ArrayOfArrayOfErrorInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfErrorInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfErrorInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"InputArgumentCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InputArgumentCollection"})]
        public sealed class InputArgumentCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InputArgumentCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InputArgumentCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfInputArgumentCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfInputArgumentCollection"})]
        public sealed class ArrayOfInputArgumentCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfInputArgumentCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfInputArgumentCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfInputArgumentCollection")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfInputArgumentCollection"})]
        public sealed class ArrayOfArrayOfInputArgumentCollection : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfInputArgumentCollection() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfInputArgumentCollection";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"BusinessNotification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BusinessNotification"})]
        public sealed class BusinessNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BusinessNotification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BusinessNotification";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfBusinessNotification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfBusinessNotification"})]
        public sealed class ArrayOfBusinessNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfBusinessNotification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfBusinessNotification";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfBusinessNotification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfBusinessNotification"})]
        public sealed class ArrayOfArrayOfBusinessNotification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfBusinessNotification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfBusinessNotification";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"MissingComponent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MissingComponent"})]
        public sealed class MissingComponent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MissingComponent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MissingComponent";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfMissingComponent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfMissingComponent"})]
        public sealed class ArrayOfMissingComponent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfMissingComponent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfMissingComponent";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfMissingComponent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfMissingComponent"})]
        public sealed class ArrayOfArrayOfMissingComponent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfMissingComponent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfMissingComponent";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfObjectiveRelation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfObjectiveRelation"})]
        public sealed class ArrayOfArrayOfObjectiveRelation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfObjectiveRelation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfObjectiveRelation";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"OrganizationResources")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrganizationResources"})]
        public sealed class OrganizationResources : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrganizationResources() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrganizationResources";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfOrganizationResources")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfOrganizationResources"})]
        public sealed class ArrayOfOrganizationResources : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfOrganizationResources() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfOrganizationResources";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfOrganizationResources")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfOrganizationResources"})]
        public sealed class ArrayOfArrayOfOrganizationResources : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfOrganizationResources() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfOrganizationResources";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"PrincipalAccess")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PrincipalAccess"})]
        public sealed class PrincipalAccess : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PrincipalAccess() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PrincipalAccess";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfPrincipalAccess")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPrincipalAccess"})]
        public sealed class ArrayOfPrincipalAccess : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPrincipalAccess() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPrincipalAccess";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfPrincipalAccess")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfPrincipalAccess"})]
        public sealed class ArrayOfArrayOfPrincipalAccess : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfPrincipalAccess() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfPrincipalAccess";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfAccessRights")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfAccessRights"})]
        public sealed class ArrayOfAccessRights : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfAccessRights() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfAccessRights";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfAccessRights")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfAccessRights"})]
        public sealed class ArrayOfArrayOfAccessRights : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfAccessRights() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfAccessRights";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfProposalParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfProposalParty"})]
        public sealed class ArrayOfArrayOfProposalParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfProposalParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfProposalParty";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfRelationshipAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRelationshipAuditDetail"})]
        public sealed class ArrayOfRelationshipAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRelationshipAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRelationshipAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfRelationshipAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfRelationshipAuditDetail"})]
        public sealed class ArrayOfArrayOfRelationshipAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfRelationshipAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfRelationshipAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfRequiredResource")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfRequiredResource"})]
        public sealed class ArrayOfArrayOfRequiredResource : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfRequiredResource() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfRequiredResource";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfResourceInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfResourceInfo"})]
        public sealed class ArrayOfArrayOfResourceInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfResourceInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfResourceInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"RibbonLocationFilters")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RibbonLocationFilters"})]
        public sealed class RibbonLocationFilters : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RibbonLocationFilters() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RibbonLocationFilters";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfRibbonLocationFilters")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRibbonLocationFilters"})]
        public sealed class ArrayOfRibbonLocationFilters : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRibbonLocationFilters() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRibbonLocationFilters";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfRibbonLocationFilters")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfRibbonLocationFilters"})]
        public sealed class ArrayOfArrayOfRibbonLocationFilters : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfRibbonLocationFilters() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfRibbonLocationFilters";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"PrivilegeDepth")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PrivilegeDepth"})]
        public sealed class PrivilegeDepth : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PrivilegeDepth() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PrivilegeDepth";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfPrivilegeDepth")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfPrivilegeDepth"})]
        public sealed class ArrayOfPrivilegeDepth : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfPrivilegeDepth() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfPrivilegeDepth";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfPrivilegeDepth")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfPrivilegeDepth"})]
        public sealed class ArrayOfArrayOfPrivilegeDepth : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfPrivilegeDepth() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfPrivilegeDepth";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"RolePrivilege")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RolePrivilege"})]
        public sealed class RolePrivilege : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RolePrivilege() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RolePrivilege";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfRolePrivilege")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRolePrivilege"})]
        public sealed class ArrayOfRolePrivilege : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRolePrivilege() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRolePrivilege";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfRolePrivilege")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfRolePrivilege"})]
        public sealed class ArrayOfArrayOfRolePrivilege : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfRolePrivilege() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfRolePrivilege";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"SearchResults")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SearchResults"})]
        public sealed class SearchResults : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SearchResults() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SearchResults";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"TraceInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TraceInfo"})]
        public sealed class TraceInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TraceInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TraceInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfSearchResults")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSearchResults"})]
        public sealed class ArrayOfSearchResults : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSearchResults() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSearchResults";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfSearchResults")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfSearchResults"})]
        public sealed class ArrayOfArrayOfSearchResults : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfSearchResults() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfSearchResults";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfShareAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfShareAuditDetail"})]
        public sealed class ArrayOfShareAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfShareAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfShareAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfShareAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfShareAuditDetail"})]
        public sealed class ArrayOfArrayOfShareAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfShareAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfShareAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"RolePrivilegeAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RolePrivilegeAuditDetail"})]
        public sealed class RolePrivilegeAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RolePrivilegeAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RolePrivilegeAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfRolePrivilegeAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfRolePrivilegeAuditDetail"})]
        public sealed class ArrayOfRolePrivilegeAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfRolePrivilegeAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfRolePrivilegeAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfRolePrivilegeAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfRolePrivilegeAuditDetail"})]
        public sealed class ArrayOfArrayOfRolePrivilegeAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfRolePrivilegeAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfRolePrivilegeAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"TimeInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TimeInfo"})]
        public sealed class TimeInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TimeInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TimeInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"SubCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SubCode"})]
        public sealed class SubCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SubCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SubCode";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"TimeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TimeCode"})]
        public sealed class TimeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TimeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TimeCode";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfTimeInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfTimeInfo"})]
        public sealed class ArrayOfTimeInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfTimeInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfTimeInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfTimeInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfTimeInfo"})]
        public sealed class ArrayOfArrayOfTimeInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfTimeInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfTimeInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfTimeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfTimeCode"})]
        public sealed class ArrayOfTimeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfTimeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfTimeCode";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfTimeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfTimeCode"})]
        public sealed class ArrayOfArrayOfTimeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfTimeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfTimeCode";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfSubCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSubCode"})]
        public sealed class ArrayOfSubCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSubCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSubCode";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfSubCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfSubCode"})]
        public sealed class ArrayOfArrayOfSubCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfSubCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfSubCode";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfTraceInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfTraceInfo"})]
        public sealed class ArrayOfTraceInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfTraceInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfTraceInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfTraceInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfTraceInfo"})]
        public sealed class ArrayOfArrayOfTraceInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfTraceInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfTraceInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"UserAccessAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UserAccessAuditDetail"})]
        public sealed class UserAccessAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UserAccessAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UserAccessAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfUserAccessAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfUserAccessAuditDetail"})]
        public sealed class ArrayOfUserAccessAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfUserAccessAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfUserAccessAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfUserAccessAuditDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfUserAccessAuditDetail"})]
        public sealed class ArrayOfArrayOfUserAccessAuditDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfUserAccessAuditDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfUserAccessAuditDetail";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ValidationResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ValidationResult"})]
        public sealed class ValidationResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ValidationResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ValidationResult";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfValidationResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfValidationResult"})]
        public sealed class ArrayOfValidationResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfValidationResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfValidationResult";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfValidationResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfValidationResult"})]
        public sealed class ArrayOfArrayOfValidationResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfValidationResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfValidationResult";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"CacheItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CacheItem"})]
        public sealed class CacheItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CacheItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CacheItem";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfCacheItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfCacheItem"})]
        public sealed class ArrayOfCacheItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfCacheItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfCacheItem";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfCacheItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfCacheItem"})]
        public sealed class ArrayOfArrayOfCacheItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfCacheItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfCacheItem";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"FaultType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FaultType"})]
        public sealed class FaultType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FaultType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FaultType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfFaultType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfFaultType"})]
        public sealed class ArrayOfFaultType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfFaultType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfFaultType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfFaultType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfFaultType"})]
        public sealed class ArrayOfArrayOfFaultType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfFaultType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfFaultType";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"QueryByEntityNameDictionary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QueryByEntityNameDictionary"})]
        public sealed class QueryByEntityNameDictionary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QueryByEntityNameDictionary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QueryByEntityNameDictionary";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfQueryByEntityNameDictionary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfQueryByEntityNameDictionary"})]
        public sealed class ArrayOfQueryByEntityNameDictionary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfQueryByEntityNameDictionary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfQueryByEntityNameDictionary";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfQueryByEntityNameDictionary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfQueryByEntityNameDictionary"})]
        public sealed class ArrayOfArrayOfQueryByEntityNameDictionary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfQueryByEntityNameDictionary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfQueryByEntityNameDictionary";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ResetSyncStateInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ResetSyncStateInfo"})]
        public sealed class ResetSyncStateInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ResetSyncStateInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ResetSyncStateInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfResetSyncStateInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfResetSyncStateInfo"})]
        public sealed class ArrayOfResetSyncStateInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfResetSyncStateInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfResetSyncStateInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfResetSyncStateInfo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfResetSyncStateInfo"})]
        public sealed class ArrayOfArrayOfResetSyncStateInfo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfResetSyncStateInfo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfResetSyncStateInfo";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"SdkMessageProcessingStepImageRegistration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SdkMessageProcessingStepImageRegistration"})]
        public sealed class SdkMessageProcessingStepImageRegistration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SdkMessageProcessingStepImageRegistration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SdkMessageProcessingStepImageRegistration";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfSdkMessageProcessingStepImageRegistration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSdkMessageProcessingStepImageRegistration"})]
        public sealed class ArrayOfSdkMessageProcessingStepImageRegistration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSdkMessageProcessingStepImageRegistration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSdkMessageProcessingStepImageRegistration";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfSdkMessageProcessingStepImageRegistration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfSdkMessageProcessingStepImageRegistration"})]
        public sealed class ArrayOfArrayOfSdkMessageProcessingStepImageRegistration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfSdkMessageProcessingStepImageRegistration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfSdkMessageProcessingStepImageRegistration";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"SdkMessageProcessingStepRegistration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SdkMessageProcessingStepRegistration"})]
        public sealed class SdkMessageProcessingStepRegistration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SdkMessageProcessingStepRegistration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SdkMessageProcessingStepRegistration";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfSdkMessageProcessingStepRegistration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSdkMessageProcessingStepRegistration"})]
        public sealed class ArrayOfSdkMessageProcessingStepRegistration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSdkMessageProcessingStepRegistration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSdkMessageProcessingStepRegistration";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfSdkMessageProcessingStepRegistration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfSdkMessageProcessingStepRegistration"})]
        public sealed class ArrayOfArrayOfSdkMessageProcessingStepRegistration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfSdkMessageProcessingStepRegistration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfSdkMessageProcessingStepRegistration";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"SyncAction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SyncAction"})]
        public sealed class SyncAction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SyncAction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SyncAction";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfSyncAction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfSyncAction"})]
        public sealed class ArrayOfSyncAction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfSyncAction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfSyncAction";
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
        
        [Schema(@"http://schemas.microsoft.com/crm/2011/Contracts",@"ArrayOfArrayOfSyncAction")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfArrayOfSyncAction"})]
        public sealed class ArrayOfArrayOfSyncAction : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfArrayOfSyncAction() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfArrayOfSyncAction";
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
