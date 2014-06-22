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
	public class BatchInfo
	{
		private Guid batchIdField;
		private string batchNameField;
		private string originalFileNameField;
		private int numberOfCodesField;
		private PromoCodeOperationStatusCode statusField;
		private DateTime startTimeField;
		private DateTime deletedDateField;
		private PromoCodeGenerationMethod generationMethodField;
		private int phaseProgressField;
		private PromoCodeGenerationError[] errorsField;
		public Guid BatchId
		{
			get
			{
				return this.batchIdField;
			}
			set
			{
				this.batchIdField = value;
			}
		}
		public string BatchName
		{
			get
			{
				return this.batchNameField;
			}
			set
			{
				this.batchNameField = value;
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
		public PromoCodeOperationStatusCode Status
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
		public DateTime StartTime
		{
			get
			{
				return this.startTimeField;
			}
			set
			{
				this.startTimeField = value;
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
		public PromoCodeGenerationMethod GenerationMethod
		{
			get
			{
				return this.generationMethodField;
			}
			set
			{
				this.generationMethodField = value;
			}
		}
		public int PhaseProgress
		{
			get
			{
				return this.phaseProgressField;
			}
			set
			{
				this.phaseProgressField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public PromoCodeGenerationError[] Errors
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
