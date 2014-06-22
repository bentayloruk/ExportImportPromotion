using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public class PromoCodeOperationStatus
	{
		private BatchInfo batchInformationField;
		public BatchInfo BatchInformation
		{
			get
			{
				return this.batchInformationField;
			}
			set
			{
				this.batchInformationField = value;
			}
		}
	}
}
