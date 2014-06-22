using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public enum ListOperationType
	{
		ImportStaticList,
		ExportStaticList,
		ExportExpression,
		AppendStaticList,
		SubtractStaticList,
		AppendExpression,
		PrepareDirectMailList,
		Upload,
		PrepareTestDirectMailList
	}
}
