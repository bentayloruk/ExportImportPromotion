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
	public class DiscountConditionData
	{
		private ConditionBasis basisField;
		private decimal minAmountField;
		private ExpressionRefData conditionExpressionField;
		public ConditionBasis Basis
		{
			get
			{
				return this.basisField;
			}
			set
			{
				this.basisField = value;
			}
		}
		public decimal MinAmount
		{
			get
			{
				return this.minAmountField;
			}
			set
			{
				this.minAmountField = value;
			}
		}
		public ExpressionRefData ConditionExpression
		{
			get
			{
				return this.conditionExpressionField;
			}
			set
			{
				this.conditionExpressionField = value;
			}
		}
	}
}
