using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService")]
#endif

	[Serializable]
	public enum UrlEncodingType
	{
		NoEncoding,
		Full,
		SpacesAndPluses
	}
}
