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
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService")]
#endif

	[Serializable]
	public class CustomerData
	{
		private int idField;
		private string nameField;
		private string descriptionField;
		private string contactNameField;
		private string contactAddressField;
		private string contactPhoneField;
		private string contactFaxField;
		private string contactEmailField;
		private string defaultUrlField;
		private string industryField;
		private CustomerType typeField;
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
		[XmlElement(IsNullable = true)]
		public string ContactName
		{
			get
			{
				return this.contactNameField;
			}
			set
			{
				this.contactNameField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string ContactAddress
		{
			get
			{
				return this.contactAddressField;
			}
			set
			{
				this.contactAddressField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string ContactPhone
		{
			get
			{
				return this.contactPhoneField;
			}
			set
			{
				this.contactPhoneField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string ContactFax
		{
			get
			{
				return this.contactFaxField;
			}
			set
			{
				this.contactFaxField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string ContactEmail
		{
			get
			{
				return this.contactEmailField;
			}
			set
			{
				this.contactEmailField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string DefaultUrl
		{
			get
			{
				return this.defaultUrlField;
			}
			set
			{
				this.defaultUrlField = value;
			}
		}
		public string Industry
		{
			get
			{
				return this.industryField;
			}
			set
			{
				this.industryField = value;
			}
		}
		public CustomerType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
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
