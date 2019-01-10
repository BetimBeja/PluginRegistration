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
	/// System chart attached to an entity.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("savedqueryvisualization")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SavedQueryVisualization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CanBeDeleted = "canbedeleted";
			public const string ChartType = "charttype";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DataDescription = "datadescription";
			public const string Description = "description";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCustomizable = "iscustomizable";
			public const string IsDefault = "isdefault";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string PresentationDescription = "presentationdescription";
			public const string PrimaryEntityTypeCode = "primaryentitytypecode";
			public const string SavedQueryVisualizationId = "savedqueryvisualizationid";
			public const string Id = "savedqueryvisualizationid";
			public const string SavedQueryVisualizationIdUnique = "savedqueryvisualizationidunique";
			public const string SolutionId = "solutionid";
			public const string Type = "type";
			public const string VersionNumber = "versionnumber";
			public const string WebResourceId = "webresourceid";
			public const string lk_savedqueryvisualizationbase_createdby = "lk_savedqueryvisualizationbase_createdby";
			public const string lk_savedqueryvisualizationbase_createdonbehalfby = "lk_savedqueryvisualizationbase_createdonbehalfby";
			public const string lk_savedqueryvisualizationbase_modifiedby = "lk_savedqueryvisualizationbase_modifiedby";
			public const string lk_savedqueryvisualizationbase_modifiedonbehalfby = "lk_savedqueryvisualizationbase_modifiedonbehalfby";
			public const string organization_saved_query_visualizations = "organization_saved_query_visualizations";
			public const string webresource_savedqueryvisualizations = "webresource_savedqueryvisualizations";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SavedQueryVisualization() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "savedqueryvisualization";
		
		public const string PrimaryIdAttribute = "savedqueryvisualizationid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1111;
		
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
		/// Tells whether the saved query visualization can be deleted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty CanBeDeleted
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("canbedeleted");
			}
			set
			{
				this.OnPropertyChanging("CanBeDeleted");
				this.SetAttributeValue("canbedeleted", value);
				this.OnPropertyChanged("CanBeDeleted");
			}
		}
		
		/// <summary>
		/// Indicates the library used to render the visualization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("charttype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ChartType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("charttype");
			}
			set
			{
				this.OnPropertyChanging("ChartType");
				this.SetAttributeValue("charttype", value);
				this.OnPropertyChanged("ChartType");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the system chart.
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
		/// Date and time when the system chart was created.
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
		/// Unique identifier of the delegate user who created the system chart.
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
		/// XML string used to define the underlying data for the system chart.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datadescription")]
		public string DataDescription
		{
			get
			{
				return this.GetAttributeValue<string>("datadescription");
			}
			set
			{
				this.OnPropertyChanging("DataDescription");
				this.SetAttributeValue("datadescription", value);
				this.OnPropertyChanged("DataDescription");
			}
		}
		
		/// <summary>
		/// Description of the system chart.
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
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Indicates whether the system chart is the default chart for the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
		public System.Nullable<bool> IsDefault
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdefault");
			}
			set
			{
				this.OnPropertyChanging("IsDefault");
				this.SetAttributeValue("isdefault", value);
				this.OnPropertyChanged("IsDefault");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the system chart.
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
		/// Date and time when the system chart was last modified.
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
		/// Unique identifier of the delegate user who last modified the system chart.
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
		/// Name of the system chart.
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
		/// Unique identifier of the organization associated with the system chart.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// XML string used to define the presentation properties of the system chart.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentationdescription")]
		public string PresentationDescription
		{
			get
			{
				return this.GetAttributeValue<string>("presentationdescription");
			}
			set
			{
				this.OnPropertyChanging("PresentationDescription");
				this.SetAttributeValue("presentationdescription", value);
				this.OnPropertyChanged("PresentationDescription");
			}
		}
		
		/// <summary>
		/// Type of entity with which the system chart is attached.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
		public string PrimaryEntityTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("primaryentitytypecode");
			}
			set
			{
				this.OnPropertyChanging("PrimaryEntityTypeCode");
				this.SetAttributeValue("primaryentitytypecode", value);
				this.OnPropertyChanged("PrimaryEntityTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the system chart.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryvisualizationid")]
		public System.Nullable<System.Guid> SavedQueryVisualizationId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("savedqueryvisualizationid");
			}
			set
			{
				this.OnPropertyChanging("SavedQueryVisualizationId");
				this.SetAttributeValue("savedqueryvisualizationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SavedQueryVisualizationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryvisualizationid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SavedQueryVisualizationId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryvisualizationidunique")]
		public System.Nullable<System.Guid> SavedQueryVisualizationIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("savedqueryvisualizationidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Specifies where the chart will be used, 0 for data centric as well as interaction centric and 1 for just interaction centric
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
		public Microsoft.Xrm.Sdk.OptionSetValue Type
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type");
			}
			set
			{
				this.OnPropertyChanging("Type");
				this.SetAttributeValue("type", value);
				this.OnPropertyChanged("Type");
			}
		}
		
		/// <summary>
		/// Version number of the system chart.
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
		/// Unique identifier of the Web resource that will be displayed in the system chart.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
		public Microsoft.Xrm.Sdk.EntityReference WebResourceId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("webresourceid");
			}
			set
			{
				this.OnPropertyChanging("WebResourceId");
				this.SetAttributeValue("webresourceid", value);
				this.OnPropertyChanged("WebResourceId");
			}
		}
		
		/// <summary>
		/// 1:N SavedQueryVisualization_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SavedQueryVisualization_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> SavedQueryVisualization_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("SavedQueryVisualization_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("SavedQueryVisualization_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("SavedQueryVisualization_SyncErrors", null, value);
				this.OnPropertyChanged("SavedQueryVisualization_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_savedqueryvisualization
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_savedqueryvisualization")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_savedqueryvisualization
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_savedqueryvisualization", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_savedqueryvisualization");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_savedqueryvisualization", null, value);
				this.OnPropertyChanged("userentityinstancedata_savedqueryvisualization");
			}
		}
		
		/// <summary>
		/// N:1 lk_savedqueryvisualizationbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_savedqueryvisualizationbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_savedqueryvisualizationbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_savedqueryvisualizationbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_savedqueryvisualizationbase_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_savedqueryvisualizationbase_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_savedqueryvisualizationbase_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_savedqueryvisualizationbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_savedqueryvisualizationbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_savedqueryvisualizationbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_savedqueryvisualizationbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_savedqueryvisualizationbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_savedqueryvisualizationbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_savedqueryvisualizationbase_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_saved_query_visualizations
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_query_visualizations")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_saved_query_visualizations
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_saved_query_visualizations", null);
			}
		}
		
		/// <summary>
		/// N:1 webresource_savedqueryvisualizations
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_savedqueryvisualizations")]
		public Xrm.Sdk.PluginRegistration.Entities.WebResource webresource_savedqueryvisualizations
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.WebResource>("webresource_savedqueryvisualizations", null);
			}
			set
			{
				this.OnPropertyChanging("webresource_savedqueryvisualizations");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.WebResource>("webresource_savedqueryvisualizations", null, value);
				this.OnPropertyChanged("webresource_savedqueryvisualizations");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SavedQueryVisualization(object anonymousType) : 
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
                        Attributes["savedqueryvisualizationid"] = base.Id;
                        break;
                    case "savedqueryvisualizationid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("charttype")]
		public virtual savedqueryvisualization_charttype? ChartTypeEnum
		{
			get
			{
				return ((savedqueryvisualization_charttype?)(EntityOptionSetEnum.GetEnum(this, "charttype")));
			}
			set
			{
				ChartType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual componentstate? ComponentStateEnum
		{
			get
			{
				return ((componentstate?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
		public virtual chart_usage? TypeEnum
		{
			get
			{
				return ((chart_usage?)(EntityOptionSetEnum.GetEnum(this, "type")));
			}
			set
			{
				Type = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}