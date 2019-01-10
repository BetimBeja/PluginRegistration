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
	/// Organization-owned entity customizations including form layout and dashboards.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemform")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SystemForm : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AncestorFormId = "ancestorformid";
			public const string CanBeDeleted = "canbedeleted";
			public const string ComponentState = "componentstate";
			public const string Description = "description";
			public const string FormActivationState = "formactivationstate";
			public const string FormId = "formid";
			public const string Id = "formid";
			public const string FormIdUnique = "formidunique";
			public const string FormJson = "formjson";
			public const string FormPresentation = "formpresentation";
			public const string FormXml = "formxml";
			public const string IntroducedVersion = "introducedversion";
			public const string IsAIRMerged = "isairmerged";
			public const string IsCustomizable = "iscustomizable";
			public const string IsDefault = "isdefault";
			public const string IsDesktopEnabled = "isdesktopenabled";
			public const string IsManaged = "ismanaged";
			public const string IsTabletEnabled = "istabletenabled";
			public const string Name = "name";
			public const string ObjectTypeCode = "objecttypecode";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string PublishedOn = "publishedon";
			public const string SolutionId = "solutionid";
			public const string Type = "type";
			public const string UniqueName = "uniquename";
			public const string Version = "version";
			public const string VersionNumber = "versionnumber";
			public const string Referencingform_ancestor_form = "form_ancestor_form";
			public const string organization_systemforms = "organization_systemforms";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SystemForm() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "systemform";
		
		public const string PrimaryIdAttribute = "formid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1030;
		
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
		/// Unique identifier of the parent form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ancestorformid")]
		public Microsoft.Xrm.Sdk.EntityReference AncestorFormId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ancestorformid");
			}
			set
			{
				this.OnPropertyChanging("AncestorFormId");
				this.SetAttributeValue("ancestorformid", value);
				this.OnPropertyChanged("AncestorFormId");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be deleted.
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
		/// Description of the form or dashboard.
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
		/// Specifies the state of the form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formactivationstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue FormActivationState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("formactivationstate");
			}
			set
			{
				this.OnPropertyChanging("FormActivationState");
				this.SetAttributeValue("formactivationstate", value);
				this.OnPropertyChanged("FormActivationState");
			}
		}
		
		/// <summary>
		/// Unique identifier of the record type form.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		public System.Nullable<System.Guid> FormId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("formid");
			}
			set
			{
				this.OnPropertyChanging("FormId");
				this.SetAttributeValue("formid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("FormId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.FormId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formidunique")]
		public System.Nullable<System.Guid> FormIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("formidunique");
			}
		}
		
		/// <summary>
		/// Json representation of the form layout.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formjson")]
		public string FormJson
		{
			get
			{
				return this.GetAttributeValue<string>("formjson");
			}
			set
			{
				this.OnPropertyChanging("FormJson");
				this.SetAttributeValue("formjson", value);
				this.OnPropertyChanged("FormJson");
			}
		}
		
		/// <summary>
		/// Specifies whether this form is in the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formpresentation")]
		public Microsoft.Xrm.Sdk.OptionSetValue FormPresentation
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("formpresentation");
			}
			set
			{
				this.OnPropertyChanging("FormPresentation");
				this.SetAttributeValue("formpresentation", value);
				this.OnPropertyChanged("FormPresentation");
			}
		}
		
		/// <summary>
		/// XML representation of the form layout.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formxml")]
		public string FormXml
		{
			get
			{
				return this.GetAttributeValue<string>("formxml");
			}
			set
			{
				this.OnPropertyChanging("FormXml");
				this.SetAttributeValue("formxml", value);
				this.OnPropertyChanged("FormXml");
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
		/// Specifies whether this form is merged with the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isairmerged")]
		public System.Nullable<bool> IsAIRMerged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isairmerged");
			}
			set
			{
				this.OnPropertyChanging("IsAIRMerged");
				this.SetAttributeValue("isairmerged", value);
				this.OnPropertyChanged("IsAIRMerged");
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
		/// Information that specifies whether the form or the dashboard is the system default.
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
		/// Information that specifies whether the dashboard is enabled for desktop.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdesktopenabled")]
		public System.Nullable<bool> IsDesktopEnabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdesktopenabled");
			}
			set
			{
				this.OnPropertyChanging("IsDesktopEnabled");
				this.SetAttributeValue("isdesktopenabled", value);
				this.OnPropertyChanged("IsDesktopEnabled");
			}
		}
		
		/// <summary>
		/// 
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
		/// Information that specifies whether the dashboard is enabled for tablet.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istabletenabled")]
		public System.Nullable<bool> IsTabletEnabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("istabletenabled");
			}
			set
			{
				this.OnPropertyChanging("IsTabletEnabled");
				this.SetAttributeValue("istabletenabled", value);
				this.OnPropertyChanged("IsTabletEnabled");
			}
		}
		
		/// <summary>
		/// Name of the form.
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
		/// Code that represents the record type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization.
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
		public System.Nullable<System.DateTime> PublishedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon");
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
		/// Type of the form, for example, Dashboard or Preview.
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
		/// Unique Name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public System.Nullable<int> Version
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("version");
			}
			set
			{
				this.OnPropertyChanging("Version");
				this.SetAttributeValue("version", value);
				this.OnPropertyChanged("Version");
			}
		}
		
		/// <summary>
		/// Represents a version of customizations to be synchronized with the Microsoft Dynamics 365 client for Outlook.
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
		/// 1:N form_ancestor_form
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SystemForm> Referencedform_ancestor_form
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedform_ancestor_form");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedform_ancestor_form");
			}
		}
		
		/// <summary>
		/// 1:N processtrigger_systemform
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processtrigger_systemform")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessTrigger> processtrigger_systemform
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessTrigger>("processtrigger_systemform", null);
			}
			set
			{
				this.OnPropertyChanging("processtrigger_systemform");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessTrigger>("processtrigger_systemform", null, value);
				this.OnPropertyChanged("processtrigger_systemform");
			}
		}
		
		/// <summary>
		/// 1:N socialinsightsconfiguration_systemform
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_systemform")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SocialInsightsConfiguration> socialinsightsconfiguration_systemform
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SocialInsightsConfiguration>("socialinsightsconfiguration_systemform", null);
			}
			set
			{
				this.OnPropertyChanging("socialinsightsconfiguration_systemform");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SocialInsightsConfiguration>("socialinsightsconfiguration_systemform", null, value);
				this.OnPropertyChanged("socialinsightsconfiguration_systemform");
			}
		}
		
		/// <summary>
		/// 1:N SystemForm_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> SystemForm_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("SystemForm_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("SystemForm_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("SystemForm_AsyncOperations", null, value);
				this.OnPropertyChanged("SystemForm_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N SystemForm_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> SystemForm_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("SystemForm_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("SystemForm_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// N:1 form_ancestor_form
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ancestorformid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Xrm.Sdk.PluginRegistration.Entities.SystemForm Referencingform_ancestor_form
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingform_ancestor_form");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingform_ancestor_form");
			}
		}
		
		/// <summary>
		/// N:1 organization_systemforms
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_systemforms")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_systemforms
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_systemforms", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public SystemForm(object anonymousType) : 
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
                        Attributes["formid"] = base.Id;
                        break;
                    case "formid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual componentstate? ComponentStateEnum
		{
			get
			{
				return ((componentstate?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formactivationstate")]
		public virtual systemform_formactivationstate? FormActivationStateEnum
		{
			get
			{
				return ((systemform_formactivationstate?)(EntityOptionSetEnum.GetEnum(this, "formactivationstate")));
			}
			set
			{
				FormActivationState = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formpresentation")]
		public virtual systemform_formpresentation? FormPresentationEnum
		{
			get
			{
				return ((systemform_formpresentation?)(EntityOptionSetEnum.GetEnum(this, "formpresentation")));
			}
			set
			{
				FormPresentation = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
		public virtual systemform_type? TypeEnum
		{
			get
			{
				return ((systemform_type?)(EntityOptionSetEnum.GetEnum(this, "type")));
			}
			set
			{
				Type = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}