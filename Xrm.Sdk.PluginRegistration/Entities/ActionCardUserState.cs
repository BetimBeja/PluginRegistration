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
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("actioncarduserstate")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class ActionCardUserState : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActionCardId = "actioncardid";
			public const string ActionCardUserStateId = "actioncarduserstateid";
			public const string Id = "actioncarduserstateid";
			public const string ExchangeRate = "exchangerate";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string StartDate = "startdate";
			public const string State = "state";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string ActionCardUserState_ActionCard = "ActionCardUserState_ActionCard";
			public const string TransactionCurrency_ActionCardUserState = "TransactionCurrency_ActionCardUserState";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ActionCardUserState() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "actioncarduserstate";
		
		public const string PrimaryIdAttribute = "actioncarduserstateid";
		
		public const int EntityTypeCode = 9968;
		
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
		/// Parent ActionCard Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actioncardid")]
		public Microsoft.Xrm.Sdk.EntityReference ActionCardId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("actioncardid");
			}
			set
			{
				this.OnPropertyChanging("ActionCardId");
				this.SetAttributeValue("actioncardid", value);
				this.OnPropertyChanged("ActionCardId");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actioncarduserstateid")]
		public System.Nullable<System.Guid> ActionCardUserStateId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("actioncarduserstateid");
			}
			set
			{
				this.OnPropertyChanging("ActionCardUserStateId");
				this.SetAttributeValue("actioncarduserstateid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActionCardUserStateId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actioncarduserstateid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ActionCardUserStateId = value;
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the ActionCardUserState with respect to the base currency.
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
		/// Unique identifier of the user or team who owns the state of this action card.
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
		/// Shows the Start Date
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startdate")]
		public System.Nullable<System.DateTime> StartDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("startdate");
			}
			set
			{
				this.OnPropertyChanging("StartDate");
				this.SetAttributeValue("startdate", value);
				this.OnPropertyChanged("StartDate");
			}
		}
		
		/// <summary>
		/// State of the Action Card
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("state")]
		public Microsoft.Xrm.Sdk.OptionSetValue State
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("state");
			}
			set
			{
				this.OnPropertyChanging("State");
				this.SetAttributeValue("state", value);
				this.OnPropertyChanged("State");
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
		/// Exchange rate for the currency associated with the ActionCardUserState with respect to the base currency.
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
		/// 
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
		/// N:1 ActionCardUserState_ActionCard
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actioncardid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActionCardUserState_ActionCard")]
		public Xrm.Sdk.PluginRegistration.Entities.ActionCard ActionCardUserState_ActionCard
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ActionCard>("ActionCardUserState_ActionCard", null);
			}
			set
			{
				this.OnPropertyChanging("ActionCardUserState_ActionCard");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ActionCard>("ActionCardUserState_ActionCard", null, value);
				this.OnPropertyChanged("ActionCardUserState_ActionCard");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_ActionCardUserState
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ActionCardUserState")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency TransactionCurrency_ActionCardUserState
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_ActionCardUserState", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_ActionCardUserState");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_ActionCardUserState", null, value);
				this.OnPropertyChanged("TransactionCurrency_ActionCardUserState");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public ActionCardUserState(object anonymousType) : 
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
                        Attributes["actioncarduserstateid"] = base.Id;
                        break;
                    case "actioncarduserstateid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("state")]
		public virtual actioncarduserstate_state? StateEnum
		{
			get
			{
				return ((actioncarduserstate_state?)(EntityOptionSetEnum.GetEnum(this, "state")));
			}
			set
			{
				State = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}