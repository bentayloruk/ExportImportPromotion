using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/MarketingWebService")]
#endif

	[Serializable]
	public class CampaignData
	{
		private int idField;
		private string nameField;
		private string descriptionField;
		private bool activeField;
		private DateTime startDateField;
		private DateTime endDateField;
		private int customerIdField;
		private string eventTypeNameField;
		private bool campaignLevelGoalingField;
		private int numberOfEventsOrderedField;
		private string customerNameField;
		private DateTime createdDateField;
		private DateTime lastModifiedDateField;
		private string lastModifiedByField;
		private DateTime deletedDateField;
		public int Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
			}
		}
		public DateTime StartDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		public DateTime EndDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}
		public int CustomerId
		{
			get
			{
				return this.customerIdField;
			}
			set
			{
				this.customerIdField = value;
			}
		}
		public string EventTypeName
		{
			get
			{
				return this.eventTypeNameField;
			}
			set
			{
				this.eventTypeNameField = value;
			}
		}
		public bool CampaignLevelGoaling
		{
			get
			{
				return this.campaignLevelGoalingField;
			}
			set
			{
				this.campaignLevelGoalingField = value;
			}
		}
		public int NumberOfEventsOrdered
		{
			get
			{
				return this.numberOfEventsOrderedField;
			}
			set
			{
				this.numberOfEventsOrderedField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string CustomerName
		{
			get
			{
				return this.customerNameField;
			}
			set
			{
				this.customerNameField = value;
			}
		}
		public DateTime CreatedDate
		{
			get
			{
				return this.createdDateField;
			}
			set
			{
				this.createdDateField = value;
			}
		}
		public DateTime LastModifiedDate
		{
			get
			{
				return this.lastModifiedDateField;
			}
			set
			{
				this.lastModifiedDateField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string LastModifiedBy
		{
			get
			{
				return this.lastModifiedByField;
			}
			set
			{
				this.lastModifiedByField = value;
			}
		}
		public DateTime DeletedDate
		{
			get
			{
				return this.deletedDateField;
			}
			set
			{
				this.deletedDateField = value;
			}
		}
	}
}
