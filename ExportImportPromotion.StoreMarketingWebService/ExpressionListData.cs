using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public class ExpressionListData : MailingListData
	{
		private int expressionIdField;
		public int ExpressionId
		{
			get
			{
				return this.expressionIdField;
			}
			set
			{
				this.expressionIdField = value;
			}
		}
	}
}
