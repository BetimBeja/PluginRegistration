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
	public enum CharacteristicState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Skills, education and certifications of resources.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("characteristic")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class Characteristic : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CharacteristicId = "characteristicid";
			public const string Id = "characteristicid";
			public const string CharacteristicType = "characteristictype";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_characteristic = "business_unit_characteristic";
			public const string lk_characteristic_createdby = "lk_characteristic_createdby";
			public const string lk_characteristic_createdonbehalfby = "lk_characteristic_createdonbehalfby";
			public const string lk_characteristic_modifiedby = "lk_characteristic_modifiedby";
			public const string lk_characteristic_modifiedonbehalfby = "lk_characteristic_modifiedonbehalfby";
			public const string team_characteristic = "team_characteristic";
			public const string TransactionCurrency_characteristic = "TransactionCurrency_characteristic";
			public const string user_characteristic = "user_characteristic";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Characteristic() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "characteristic";
		
		public const string PrimaryIdAttribute = "characteristicid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1141;
		
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
		/// Unique identifier of the characteristic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("characteristicid")]
		public System.Nullable<System.Guid> CharacteristicId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("characteristicid");
			}
			set
			{
				this.OnPropertyChanging("CharacteristicId");
				this.SetAttributeValue("characteristicid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CharacteristicId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("characteristicid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.CharacteristicId = value;
			}
		}
		
		/// <summary>
		/// Select the type of characteristic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("characteristictype")]
		public Microsoft.Xrm.Sdk.OptionSetValue CharacteristicType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("characteristictype");
			}
			set
			{
				this.OnPropertyChanging("CharacteristicType");
				this.SetAttributeValue("characteristictype", value);
				this.OnPropertyChanged("CharacteristicType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
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
		/// Unique identifier of the delegate user who created the record.
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
		/// Type a detailed description of the characteristic.
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
		/// Exchange rate for the currency associated with the characteristic with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
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
		/// Unique identifier of the user who modified the record.
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
		/// Unique identifier of the delegate user who modified the record.
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
		/// Type a name for the characteristic.
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
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Characteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.CharacteristicState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.CharacteristicState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.CharacteristicState), optionSet.Value)));
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
		/// Reason for the status of the Characteristic
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
		/// Exchange rate for the currency associated with the Characteristic with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
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
		/// 1:N characteristic_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> characteristic_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("characteristic_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("characteristic_AsyncOperations", null, value);
				this.OnPropertyChanged("characteristic_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_bookableresourcecharacteristic_Characteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_bookableresourcecharacteristic_Characteristic")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BookableResourceCharacteristic> characteristic_bookableresourcecharacteristic_Characteristic
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BookableResourceCharacteristic>("characteristic_bookableresourcecharacteristic_Characteristic", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_bookableresourcecharacteristic_Characteristic");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BookableResourceCharacteristic>("characteristic_bookableresourcecharacteristic_Characteristic", null, value);
				this.OnPropertyChanged("characteristic_bookableresourcecharacteristic_Characteristic");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> characteristic_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("characteristic_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("characteristic_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("characteristic_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> characteristic_DuplicateBaseRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("characteristic_DuplicateBaseRecord", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_DuplicateBaseRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("characteristic_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("characteristic_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> characteristic_DuplicateMatchingRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("characteristic_DuplicateMatchingRecord", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_DuplicateMatchingRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("characteristic_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("characteristic_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> characteristic_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("characteristic_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("characteristic_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("characteristic_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_PrincipalObjectAttributeAccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_PrincipalObjectAttributeAccess")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> characteristic_PrincipalObjectAttributeAccess
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("characteristic_PrincipalObjectAttributeAccess", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_PrincipalObjectAttributeAccess");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("characteristic_PrincipalObjectAttributeAccess", null, value);
				this.OnPropertyChanged("characteristic_PrincipalObjectAttributeAccess");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> characteristic_ProcessSession
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("characteristic_ProcessSession", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_ProcessSession");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("characteristic_ProcessSession", null, value);
				this.OnPropertyChanged("characteristic_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N Characteristic_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Characteristic_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> Characteristic_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("Characteristic_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("Characteristic_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("Characteristic_SyncErrors", null, value);
				this.OnPropertyChanged("Characteristic_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N characteristic_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("characteristic_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> characteristic_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("characteristic_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("characteristic_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("characteristic_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("characteristic_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_characteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_characteristic")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_characteristic
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_characteristic", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_characteristic_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_characteristic_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_characteristic_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_characteristic_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_characteristic_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_characteristic_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_characteristic_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_characteristic_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_characteristic_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_characteristic_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_characteristic_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_characteristic_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_characteristic_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_characteristic_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_characteristic_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_characteristic_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_characteristic_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_characteristic_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_characteristic_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_characteristic_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_characteristic_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_characteristic_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_characteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_characteristic")]
		public Xrm.Sdk.PluginRegistration.Entities.Team team_characteristic
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Team>("team_characteristic", null);
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_characteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_characteristic")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency TransactionCurrency_characteristic
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_characteristic", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_characteristic");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_characteristic", null, value);
				this.OnPropertyChanged("TransactionCurrency_characteristic");
			}
		}
		
		/// <summary>
		/// N:1 user_characteristic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_characteristic")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser user_characteristic
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("user_characteristic", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public Characteristic(object anonymousType) : 
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
                        Attributes["characteristicid"] = base.Id;
                        break;
                    case "characteristicid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("characteristictype")]
		public virtual bookableresourcecharacteristictype? CharacteristicTypeEnum
		{
			get
			{
				return ((bookableresourcecharacteristictype?)(EntityOptionSetEnum.GetEnum(this, "characteristictype")));
			}
			set
			{
				CharacteristicType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual characteristic_statuscode? StatusCodeEnum
		{
			get
			{
				return ((characteristic_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}