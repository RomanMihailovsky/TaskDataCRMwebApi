using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskDataCRMwebApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ExtensionData
    {
    }

    public class CreatedBy
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public string Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class ModifiedBy
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public string Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class NewPersoninit
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public string Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class NewPersonresp
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public string Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class OwnerId
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public string Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class OwningBusinessUnit
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public object Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class OwningUser
    {
        public string Id { get; set; }
        public string LogicalName { get; set; }
        public object Name { get; set; }
        public List<object> KeyAttributes { get; set; }
        public object RowVersion { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

    public class Attribute
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }

    public class FormattedValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Root
    {
        public CreatedBy CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public object CreatedOnBehalfBy { get; set; }
        public object ImportSequenceNumber { get; set; }
        public ModifiedBy ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public object ModifiedOnBehalfBy { get; set; }
        public bool new_completed { get; set; }
        public DateTime new_enddate { get; set; }
        public int new_hoursspend { get; set; }
        public string new_name { get; set; }
        public string new_number { get; set; }
        public NewPersoninit new_personinit { get; set; }
        public NewPersonresp new_personresp { get; set; }
        public string new_taskId { get; set; }
        public string Id { get; set; }
        public int new_type { get; set; }
        public object OverriddenCreatedOn { get; set; }
        public OwnerId OwnerId { get; set; }
        public OwningBusinessUnit OwningBusinessUnit { get; set; }
        public object OwningTeam { get; set; }
        public OwningUser OwningUser { get; set; }
        public int StateCode { get; set; }
        public int StatusCode { get; set; }
        public int TimeZoneRuleVersionNumber { get; set; }
        public object UTCConversionTimeZoneCode { get; set; }
        public object VersionNumber { get; set; }
        public object new_task_AsyncOperations { get; set; }
        public object new_task_BulkDeleteFailures { get; set; }
        public object new_task_MailboxTrackingFolders { get; set; }
        public object new_task_PrincipalObjectAttributeAccesses { get; set; }
        public object new_task_ProcessSession { get; set; }
        public object new_task_SyncErrors { get; set; }
        public object new_task_UserEntityInstanceDatas { get; set; }
        public object business_unit_new_task { get; set; }
        public object lk_new_task_createdby { get; set; }
        public object lk_new_task_createdonbehalfby { get; set; }
        public object lk_new_task_modifiedby { get; set; }
        public object lk_new_task_modifiedonbehalfby { get; set; }
        public object new_systemuser_new_task_personinit { get; set; }
        public object new_systemuser_new_task_personresp { get; set; }
        public object team_new_task { get; set; }
        public object user_new_task { get; set; }
        public string LogicalName { get; set; }
        public List<Attribute> Attributes { get; set; }
        public object EntityState { get; set; }
        public List<FormattedValue> FormattedValues { get; set; }
        public List<object> RelatedEntities { get; set; }
        public string RowVersion { get; set; }
        public List<object> KeyAttributes { get; set; }
        public ExtensionData ExtensionData { get; set; }
    }

}