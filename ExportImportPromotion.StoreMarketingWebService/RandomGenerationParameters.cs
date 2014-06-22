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
	public class RandomGenerationParameters
	{
		private int codeLengthField;
		private string prefixField;
		private string suffixField;
		public int CodeLength
		{
			get
			{
				return this.codeLengthField;
			}
			set
			{
				this.codeLengthField = value;
			}
		}
		public string Prefix
		{
			get
			{
				return this.prefixField;
			}
			set
			{
				this.prefixField = value;
			}
		}
		public string Suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
			}
		}
	}
}
