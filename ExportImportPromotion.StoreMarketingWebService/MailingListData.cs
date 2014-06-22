using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(ExpressionListData)), XmlInclude(typeof(StaticListData)), XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(ExpressionListData)), XmlInclude(typeof(StaticListData)), XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/MarketingWebService")]
#endif

	[Serializable]
	public abstract class MailingListData
	{
		private string nameField;
		private Guid idField;
		private string descriptionField;
		private Guid currentOperationIdField;
		private DateTime createdDateField;
		private DateTime lastModifiedDateField;
		private MailingListStatusCode statusField;
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
		public Guid Id
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
		public Guid CurrentOperationId
		{
			get
			{
				return this.currentOperationIdField;
			}
			set
			{
				this.currentOperationIdField = value;
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
		public MailingListStatusCode Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
	}
}
