using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), Flags, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/MarketingWebService")]
#endif

	[Serializable]
	public enum MailingListErrorCode
	{
		None = 1,
		FatalError = 2,
		NonFatalError = 4,
		NoEmailColumn = 8,
		OnlyEmailColumn = 16,
		BadFormat = 32,
		ExtraColumns = 64,
		DuplicateEmail = 128,
		BadUrl = 256
	}
}
