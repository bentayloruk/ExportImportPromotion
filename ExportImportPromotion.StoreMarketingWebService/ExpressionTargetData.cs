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
	public class ExpressionTargetData
	{
		private ExpressionRefData expressionField;
		private TargetAction actionField;
		public ExpressionRefData Expression
		{
			get
			{
				return this.expressionField;
			}
			set
			{
				this.expressionField = value;
			}
		}
		public TargetAction Action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}
	}
}
