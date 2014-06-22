using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public enum PromoCodeGenerationErrorCode
	{
		NoError,
		IncorrectFileFormat,
		MissingHeaders,
		MissingFields,
		MissingUserForRestrictedDefinition,
		MissingCode,
		FieldLengthExceeded,
		InvalidCharacters,
		NoData,
		UploadProblem,
		DuplicatePromoCode,
		OutOfRandomCodes,
		TooManyErrors,
		TooManyCodes,
		InternalError,
		UnknownProblem
	}
}
