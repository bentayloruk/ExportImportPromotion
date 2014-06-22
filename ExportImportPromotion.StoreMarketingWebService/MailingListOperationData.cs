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
	public class MailingListOperationData
	{
		private ListOperationType typeField;
		private ListOperationStatusCode statusField;
		private Guid operationIdField;
		private Guid mainListIdField;
		private Guid secondListIdField;
		private string originalFileNameField;
		private string expressionBodyField;
		private string descriptionField;
		private string userNameField;
		private DateTime startDateField;
		private DateTime endDateField;
		private int progressField;
		private MailingListError[] errorsField;
		public ListOperationType Type
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
		public ListOperationStatusCode Status
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
		public Guid OperationId
		{
			get
			{
				return this.operationIdField;
			}
			set
			{
				this.operationIdField = value;
			}
		}
		public Guid MainListId
		{
			get
			{
				return this.mainListIdField;
			}
			set
			{
				this.mainListIdField = value;
			}
		}
		public Guid SecondListId
		{
			get
			{
				return this.secondListIdField;
			}
			set
			{
				this.secondListIdField = value;
			}
		}
		public string OriginalFileName
		{
			get
			{
				return this.originalFileNameField;
			}
			set
			{
				this.originalFileNameField = value;
			}
		}
		public string ExpressionBody
		{
			get
			{
				return this.expressionBodyField;
			}
			set
			{
				this.expressionBodyField = value;
			}
		}
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
		public string UserName
		{
			get
			{
				return this.userNameField;
			}
			set
			{
				this.userNameField = value;
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
		public int Progress
		{
			get
			{
				return this.progressField;
			}
			set
			{
				this.progressField = value;
			}
		}
		public MailingListError[] Errors
		{
			get
			{
				return this.errorsField;
			}
			set
			{
				this.errorsField = value;
			}
		}
	}
}
