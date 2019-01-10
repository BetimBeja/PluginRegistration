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
	public enum ProductSubstituteState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productsubstitute")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class ProductSubstitute : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Direction = "direction";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProductId = "productid";
			public const string ProductSubstituteId = "productsubstituteid";
			public const string Id = "productsubstituteid";
			public const string SalesRelationshipType = "salesrelationshiptype";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string SubstitutedProductId = "substitutedproductid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_ProductSubstitute_createdby = "lk_ProductSubstitute_createdby";
			public const string lk_ProductSubstitute_createdonbehalfby = "lk_ProductSubstitute_createdonbehalfby";
			public const string lk_ProductSubstitute_modifiedby = "lk_ProductSubstitute_modifiedby";
			public const string lk_ProductSubstitute_modifiedonbehalfby = "lk_ProductSubstitute_modifiedonbehalfby";
			public const string organization_ProductSubstitute = "organization_ProductSubstitute";
			public const string product_ProductSubstitute_productid = "product_ProductSubstitute_productid";
			public const string product_ProductSubstitute_substitutedproductid = "product_ProductSubstitute_substitutedproductid";
			public const string transactioncurrency_ProductSubstitute = "transactioncurrency_ProductSubstitute";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ProductSubstitute() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "productsubstitute";
		
		public const string PrimaryIdAttribute = "productsubstituteid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1028;
		
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
		/// Shows who created the record.
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
		/// Shows who created the record on behalf of another user.
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
		/// Select whether the relationship is unidirectional or bidirectional.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("direction")]
		public Microsoft.Xrm.Sdk.OptionSetValue Direction
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("direction");
			}
			set
			{
				this.OnPropertyChanging("Direction");
				this.SetAttributeValue("direction", value);
				this.OnPropertyChanged("Direction");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
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
		/// Shows who last updated the record.
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
		/// Shows who created the record on behalf of another user.
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
		/// name
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
		/// Shows the product that the relationship is defined for.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		public Microsoft.Xrm.Sdk.EntityReference ProductId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("productid");
			}
			set
			{
				this.OnPropertyChanging("ProductId");
				this.SetAttributeValue("productid", value);
				this.OnPropertyChanged("ProductId");
			}
		}
		
		/// <summary>
		/// Shows the unique identifier of the product relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productsubstituteid")]
		public System.Nullable<System.Guid> ProductSubstituteId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("productsubstituteid");
			}
			set
			{
				this.OnPropertyChanging("ProductSubstituteId");
				this.SetAttributeValue("productsubstituteid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ProductSubstituteId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productsubstituteid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ProductSubstituteId = value;
			}
		}
		
		/// <summary>
		/// Select the type of the product relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesrelationshiptype")]
		public Microsoft.Xrm.Sdk.OptionSetValue SalesRelationshipType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesrelationshiptype");
			}
			set
			{
				this.OnPropertyChanging("SalesRelationshipType");
				this.SetAttributeValue("salesrelationshiptype", value);
				this.OnPropertyChanged("SalesRelationshipType");
			}
		}
		
		/// <summary>
		/// Select the product relationship's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.ProductSubstituteState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.ProductSubstituteState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.ProductSubstituteState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Shows whether the product relationship is active or inactive.
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
		/// Select the related product that the relationship needs to be defined for.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("substitutedproductid")]
		public Microsoft.Xrm.Sdk.EntityReference SubstitutedProductId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("substitutedproductid");
			}
			set
			{
				this.OnPropertyChanging("SubstitutedProductId");
				this.SetAttributeValue("substitutedproductid", value);
				this.OnPropertyChanged("SubstitutedProductId");
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
		/// Shows the currency associated with the record.
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
		/// 1:N ProductSubstitute_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> ProductSubstitute_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("ProductSubstitute_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("ProductSubstitute_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("ProductSubstitute_AsyncOperations", null, value);
				this.OnPropertyChanged("ProductSubstitute_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ProductSubstitute_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> ProductSubstitute_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("ProductSubstitute_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("ProductSubstitute_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("ProductSubstitute_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ProductSubstitute_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N productsubstitute_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productsubstitute_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> productsubstitute_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("productsubstitute_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("productsubstitute_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("productsubstitute_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("productsubstitute_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N ProductSubstitute_PrincipalObjectAttributeAccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_PrincipalObjectAttributeAccess")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> ProductSubstitute_PrincipalObjectAttributeAccess
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("ProductSubstitute_PrincipalObjectAttributeAccess", null);
			}
			set
			{
				this.OnPropertyChanging("ProductSubstitute_PrincipalObjectAttributeAccess");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("ProductSubstitute_PrincipalObjectAttributeAccess", null, value);
				this.OnPropertyChanged("ProductSubstitute_PrincipalObjectAttributeAccess");
			}
		}
		
		/// <summary>
		/// 1:N ProductSubstitute_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> ProductSubstitute_ProcessSession
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("ProductSubstitute_ProcessSession", null);
			}
			set
			{
				this.OnPropertyChanging("ProductSubstitute_ProcessSession");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("ProductSubstitute_ProcessSession", null, value);
				this.OnPropertyChanged("ProductSubstitute_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N ProductSubstitute_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> ProductSubstitute_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("ProductSubstitute_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("ProductSubstitute_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("ProductSubstitute_SyncErrors", null, value);
				this.OnPropertyChanged("ProductSubstitute_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N productsubstitute_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productsubstitute_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> productsubstitute_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("productsubstitute_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("productsubstitute_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("productsubstitute_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("productsubstitute_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_ProductSubstitute_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ProductSubstitute_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ProductSubstitute_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ProductSubstitute_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ProductSubstitute_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ProductSubstitute_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ProductSubstitute_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ProductSubstitute_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ProductSubstitute_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_ProductSubstitute_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ProductSubstitute_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ProductSubstitute_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ProductSubstitute_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ProductSubstitute_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ProductSubstitute_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ProductSubstitute_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ProductSubstitute_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ProductSubstitute_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_ProductSubstitute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ProductSubstitute")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_ProductSubstitute
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_ProductSubstitute", null);
			}
		}
		
		/// <summary>
		/// N:1 product_ProductSubstitute_productid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_ProductSubstitute_productid")]
		public Xrm.Sdk.PluginRegistration.Entities.Product product_ProductSubstitute_productid
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Product>("product_ProductSubstitute_productid", null);
			}
			set
			{
				this.OnPropertyChanging("product_ProductSubstitute_productid");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Product>("product_ProductSubstitute_productid", null, value);
				this.OnPropertyChanged("product_ProductSubstitute_productid");
			}
		}
		
		/// <summary>
		/// N:1 product_ProductSubstitute_substitutedproductid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("substitutedproductid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_ProductSubstitute_substitutedproductid")]
		public Xrm.Sdk.PluginRegistration.Entities.Product product_ProductSubstitute_substitutedproductid
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Product>("product_ProductSubstitute_substitutedproductid", null);
			}
			set
			{
				this.OnPropertyChanging("product_ProductSubstitute_substitutedproductid");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Product>("product_ProductSubstitute_substitutedproductid", null, value);
				this.OnPropertyChanged("product_ProductSubstitute_substitutedproductid");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_ProductSubstitute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_ProductSubstitute")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency transactioncurrency_ProductSubstitute
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("transactioncurrency_ProductSubstitute", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_ProductSubstitute");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("transactioncurrency_ProductSubstitute", null, value);
				this.OnPropertyChanged("transactioncurrency_ProductSubstitute");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public ProductSubstitute(object anonymousType) : 
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
                        Attributes["productsubstituteid"] = base.Id;
                        break;
                    case "productsubstituteid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("direction")]
		public virtual productsellingrelationshipdirection? DirectionEnum
		{
			get
			{
				return ((productsellingrelationshipdirection?)(EntityOptionSetEnum.GetEnum(this, "direction")));
			}
			set
			{
				Direction = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesrelationshiptype")]
		public virtual productsellingrelationshiptype? SalesRelationshipTypeEnum
		{
			get
			{
				return ((productsellingrelationshiptype?)(EntityOptionSetEnum.GetEnum(this, "salesrelationshiptype")));
			}
			set
			{
				SalesRelationshipType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual productsubstitute_statuscode? StatusCodeEnum
		{
			get
			{
				return ((productsubstitute_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}