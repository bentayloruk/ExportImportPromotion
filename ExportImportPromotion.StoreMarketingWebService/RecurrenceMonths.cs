using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), Flags, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/CommerceServer/2006/06/MarketingWebService")]
#endif

	[Serializable]
	public enum RecurrenceMonths
	{
		None = 1,
		January = 2,
		February = 4,
		March = 8,
		April = 16,
		May = 32,
		June = 64,
		July = 128,
		August = 256,
		September = 512,
		October = 1024,
		November = 2048,
		December = 4096,
		Q1 = 8192,
		Q2 = 16384,
		Q3 = 32768,
		Q4 = 65536,
		QuarterlyOnFirstMonth = 131072,
		QuarterlyOnSecondMonth = 262144,
		QuarterlyOnThirdMonth = 524288,
		EvenMonths = 1048576,
		OddMonths = 2097152,
		AllMonths = 4194304
	}
}
