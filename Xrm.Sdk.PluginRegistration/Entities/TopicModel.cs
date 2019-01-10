//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xrm.Sdk.PluginRegistration.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public enum TopicModelState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// The model for automatic identification of topics using text analytics.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("topicmodel")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class TopicModel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AvgNumberofTopics = "avgnumberoftopics";
			public const string AzureSchedulerJobName = "azureschedulerjobname";
			public const string AzureSchedulerOnDemandJobName = "azureschedulerondemandjobname";
			public const string AzureSchedulerTestJobName = "azureschedulertestjobname";
			public const string AzureServiceConnectionId = "azureserviceconnectionid";
			public const string BuildRecurrence = "buildrecurrence";
			public const string ConfigurationUsed = "configurationused";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string EndTime = "endtime";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string MaxNumberofTopics = "maxnumberoftopics";
			public const string MaxTopics = "maxtopics";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string SourceEntity = "sourceentity";
			public const string StartTime = "starttime";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TopicModelId = "topicmodelid";
			public const string Id = "topicmodelid";
			public const string TopicsLastCreatedOn = "topicslastcreatedon";
			public const string TotalTopicsFound = "totaltopicsfound";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string azureserviceconnection_topicmodel = "azureserviceconnection_topicmodel";
			public const string lk_topicmodel_createdby = "lk_topicmodel_createdby";
			public const string lk_topicmodel_createdonbehalfby = "lk_topicmodel_createdonbehalfby";
			public const string lk_topicmodel_modifiedby = "lk_topicmodel_modifiedby";
			public const string lk_topicmodel_modifiedonbehalfby = "lk_topicmodel_modifiedonbehalfby";
			public const string organization_topicmodel = "organization_topicmodel";
			public const string topicmodelconfiguration_topicmodel = "topicmodelconfiguration_topicmodel";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public TopicModel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "topicmodel";
		
		public const string PrimaryIdAttribute = "topicmodelid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9944;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Shows the average number of topics found per build.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("avgnumberoftopics")]
		public System.Nullable<int> AvgNumberofTopics
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("avgnumberoftopics");
			}
			set
			{
				this.OnPropertyChanging("AvgNumberofTopics");
				this.SetAttributeValue("avgnumberoftopics", value);
				this.OnPropertyChanged("AvgNumberofTopics");
			}
		}
		
		/// <summary>
		/// Azure Scheduler Job Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureschedulerjobname")]
		public string AzureSchedulerJobName
		{
			get
			{
				return this.GetAttributeValue<string>("azureschedulerjobname");
			}
			set
			{
				this.OnPropertyChanging("AzureSchedulerJobName");
				this.SetAttributeValue("azureschedulerjobname", value);
				this.OnPropertyChanged("AzureSchedulerJobName");
			}
		}
		
		/// <summary>
		/// Azure Scheduler Job Name for build model
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureschedulerondemandjobname")]
		public string AzureSchedulerOnDemandJobName
		{
			get
			{
				return this.GetAttributeValue<string>("azureschedulerondemandjobname");
			}
			set
			{
				this.OnPropertyChanging("AzureSchedulerOnDemandJobName");
				this.SetAttributeValue("azureschedulerondemandjobname", value);
				this.OnPropertyChanged("AzureSchedulerOnDemandJobName");
			}
		}
		
		/// <summary>
		/// Azure Scheduler Job Name for test model
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureschedulertestjobname")]
		public string AzureSchedulerTestJobName
		{
			get
			{
				return this.GetAttributeValue<string>("azureschedulertestjobname");
			}
			set
			{
				this.OnPropertyChanging("AzureSchedulerTestJobName");
				this.SetAttributeValue("azureschedulertestjobname", value);
				this.OnPropertyChanged("AzureSchedulerTestJobName");
			}
		}
		
		/// <summary>
		/// Unique identifier for AzureServiceConnection associated with TopicModel.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		public Microsoft.Xrm.Sdk.EntityReference AzureServiceConnectionId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("azureserviceconnectionid");
			}
			set
			{
				this.OnPropertyChanging("AzureServiceConnectionId");
				this.SetAttributeValue("azureserviceconnectionid", value);
				this.OnPropertyChanged("AzureServiceConnectionId");
			}
		}
		
		/// <summary>
		/// Shows how frequently topic analysis is done.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("buildrecurrence")]
		public string BuildRecurrence
		{
			get
			{
				return this.GetAttributeValue<string>("buildrecurrence");
			}
			set
			{
				this.OnPropertyChanging("BuildRecurrence");
				this.SetAttributeValue("buildrecurrence", value);
				this.OnPropertyChanged("BuildRecurrence");
			}
		}
		
		/// <summary>
		/// Shows the configuration used for topic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationused")]
		public Microsoft.Xrm.Sdk.EntityReference ConfigurationUsed
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("configurationused");
			}
			set
			{
				this.OnPropertyChanging("ConfigurationUsed");
				this.SetAttributeValue("configurationused", value);
				this.OnPropertyChanged("ConfigurationUsed");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the Topic Model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the topic Model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Enter a description for the model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Shows the time when topic analysis will stop
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endtime")]
		public System.Nullable<System.DateTime> EndTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("endtime");
			}
			set
			{
				this.OnPropertyChanging("EndTime");
				this.SetAttributeValue("endtime", value);
				this.OnPropertyChanged("EndTime");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Shows the maximum number of topics found across builds.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxnumberoftopics")]
		public System.Nullable<int> MaxNumberofTopics
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("maxnumberoftopics");
			}
			set
			{
				this.OnPropertyChanging("MaxNumberofTopics");
				this.SetAttributeValue("maxnumberoftopics", value);
				this.OnPropertyChanged("MaxNumberofTopics");
			}
		}
		
		/// <summary>
		/// Shows the maximum number of topics to be determined.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxtopics")]
		public System.Nullable<int> MaxTopics
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("maxtopics");
			}
			set
			{
				this.OnPropertyChanging("MaxTopics");
				this.SetAttributeValue("maxtopics", value);
				this.OnPropertyChanged("MaxTopics");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the Topic Model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the Topic model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Shows the name of the topic model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Shows the entity whose records are used for topic analysis.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceentity")]
		public string SourceEntity
		{
			get
			{
				return this.GetAttributeValue<string>("sourceentity");
			}
			set
			{
				this.OnPropertyChanging("SourceEntity");
				this.SetAttributeValue("sourceentity", value);
				this.OnPropertyChanged("SourceEntity");
			}
		}
		
		/// <summary>
		/// Shows the time when topic analysis will start according to the recurrence schedule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
		public System.Nullable<System.DateTime> StartTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime");
			}
			set
			{
				this.OnPropertyChanging("StartTime");
				this.SetAttributeValue("starttime", value);
				this.OnPropertyChanged("StartTime");
			}
		}
		
		/// <summary>
		/// Shows the status of the topic model build
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.TopicModelState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.TopicModelState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.TopicModelState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the TopicModel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelid")]
		public System.Nullable<System.Guid> TopicModelId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("topicmodelid");
			}
			set
			{
				this.OnPropertyChanging("TopicModelId");
				this.SetAttributeValue("topicmodelid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TopicModelId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.TopicModelId = value;
			}
		}
		
		/// <summary>
		/// Shows when the topics were last created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicslastcreatedon")]
		public System.Nullable<System.DateTime> TopicsLastCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("topicslastcreatedon");
			}
			set
			{
				this.OnPropertyChanging("TopicsLastCreatedOn");
				this.SetAttributeValue("topicslastcreatedon", value);
				this.OnPropertyChanged("TopicsLastCreatedOn");
			}
		}
		
		/// <summary>
		/// Shows the total number of topics found.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltopicsfound")]
		public System.Nullable<int> TotalTopicsFound
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("totaltopicsfound");
			}
			set
			{
				this.OnPropertyChanging("TotalTopicsFound");
				this.SetAttributeValue("totaltopicsfound", value);
				this.OnPropertyChanged("TotalTopicsFound");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> topicmodel_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("topicmodel_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("topicmodel_AsyncOperations", null, value);
				this.OnPropertyChanged("topicmodel_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> topicmodel_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("topicmodel_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("topicmodel_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("topicmodel_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> topicmodel_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("topicmodel_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("topicmodel_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("topicmodel_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> topicmodel_PrincipalObjectAttributeAccesses
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("topicmodel_PrincipalObjectAttributeAccesses", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("topicmodel_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("topicmodel_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> topicmodel_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("topicmodel_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("topicmodel_SyncErrors", null, value);
				this.OnPropertyChanged("topicmodel_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_topicmodelconfiguration
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_topicmodelconfiguration")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.TopicModelConfiguration> topicmodel_topicmodelconfiguration
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.TopicModelConfiguration>("topicmodel_topicmodelconfiguration", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_topicmodelconfiguration");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.TopicModelConfiguration>("topicmodel_topicmodelconfiguration", null, value);
				this.OnPropertyChanged("topicmodel_topicmodelconfiguration");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_topicmodelexecutionhistory
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_topicmodelexecutionhistory")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.TopicModelExecutionHistory> topicmodel_topicmodelexecutionhistory
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.TopicModelExecutionHistory>("topicmodel_topicmodelexecutionhistory", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_topicmodelexecutionhistory");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.TopicModelExecutionHistory>("topicmodel_topicmodelexecutionhistory", null, value);
				this.OnPropertyChanged("topicmodel_topicmodelexecutionhistory");
			}
		}
		
		/// <summary>
		/// 1:N topicmodel_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> topicmodel_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("topicmodel_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodel_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("topicmodel_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("topicmodel_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 azureserviceconnection_topicmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_topicmodel")]
		public Xrm.Sdk.PluginRegistration.Entities.AzureServiceConnection azureserviceconnection_topicmodel
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.AzureServiceConnection>("azureserviceconnection_topicmodel", null);
			}
			set
			{
				this.OnPropertyChanging("azureserviceconnection_topicmodel");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.AzureServiceConnection>("azureserviceconnection_topicmodel", null, value);
				this.OnPropertyChanged("azureserviceconnection_topicmodel");
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodel_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodel_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_topicmodel_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_topicmodel_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodel_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_topicmodel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_topicmodel_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_topicmodel_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_topicmodel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_topicmodel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodel_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodel_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_topicmodel_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_topicmodel_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodel_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_topicmodel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_topicmodel_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_topicmodel_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_topicmodel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_topicmodel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_topicmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_topicmodel")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_topicmodel
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_topicmodel", null);
			}
		}
		
		/// <summary>
		/// N:1 topicmodelconfiguration_topicmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationused")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodelconfiguration_topicmodel")]
		public Xrm.Sdk.PluginRegistration.Entities.TopicModelConfiguration topicmodelconfiguration_topicmodel
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TopicModelConfiguration>("topicmodelconfiguration_topicmodel", null);
			}
			set
			{
				this.OnPropertyChanging("topicmodelconfiguration_topicmodel");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TopicModelConfiguration>("topicmodelconfiguration_topicmodel", null, value);
				this.OnPropertyChanged("topicmodelconfiguration_topicmodel");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public TopicModel(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["topicmodelid"] = base.Id;
                        break;
                    case "topicmodelid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual topicmodel_statuscode? StatusCodeEnum
		{
			get
			{
				return ((topicmodel_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}