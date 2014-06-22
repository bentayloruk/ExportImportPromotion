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
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/CommerceServer/2006/06/MarketingWebService")]
#endif

	[Serializable]
	public class PromoCodeDefinitionData
	{
		private int idField;
		private string nameField;
		private int numberOfCodesField;
		private string publicPromoCodeField;
		private int usageLimitField;
		private PromoCodeUsageOption usageOptionField;
		private PromoCodeOperationStatusCode codeGenerationStatusField;
		private string codeGenerationErrorField;
		private DateTime createdDateField;
		private DateTime lastModifiedDateField;
		private string lastModifiedByField;
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
		public int NumberOfCodes
		{
			get
			{
				return this.numberOfCodesField;
			}
			set
			{
				this.numberOfCodesField = value;
			}
		}
		public string PublicPromoCode
		{
			get
			{
				return this.publicPromoCodeField;
			}
			set
			{
				this.publicPromoCodeField = value;
			}
		}
		public int UsageLimit
		{
			get
			{
				return this.usageLimitField;
			}
			set
			{
				this.usageLimitField = value;
			}
		}
		public PromoCodeUsageOption UsageOption
		{
			get
			{
				return this.usageOptionField;
			}
			set
			{
				this.usageOptionField = value;
			}
		}
		public PromoCodeOperationStatusCode CodeGenerationStatus
		{
			get
			{
				return this.codeGenerationStatusField;
			}
			set
			{
				this.codeGenerationStatusField = value;
			}
		}
		public string CodeGenerationError
		{
			get
			{
				return this.codeGenerationErrorField;
			}
			set
			{
				this.codeGenerationErrorField = value;
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
	}
}
