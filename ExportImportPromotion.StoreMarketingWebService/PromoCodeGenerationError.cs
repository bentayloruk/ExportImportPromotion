using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public class PromoCodeGenerationError
	{
		private PromoCodeGenerationErrorCode codeField;
		private int lineNumberField;
		public PromoCodeGenerationErrorCode Code
		{
			get
			{
				return this.codeField;
			}
			set
			{
				this.codeField = value;
			}
		}
		public int LineNumber
		{
			get
			{
				return this.lineNumberField;
			}
			set
			{
				this.lineNumberField = value;
			}
		}
	}
}
