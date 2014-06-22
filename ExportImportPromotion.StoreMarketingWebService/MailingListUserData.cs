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
	public class MailingListUserData
	{
		private string emailAddressField;
		private string userIdField;
		private string cultureCodeField;
		private string characterSetField;
		private MessageFormat preferredFormatField;
		private string urlStringField;
		public string EmailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		public string UserId
		{
			get
			{
				return this.userIdField;
			}
			set
			{
				this.userIdField = value;
			}
		}
		public string CultureCode
		{
			get
			{
				return this.cultureCodeField;
			}
			set
			{
				this.cultureCodeField = value;
			}
		}
		public string CharacterSet
		{
			get
			{
				return this.characterSetField;
			}
			set
			{
				this.characterSetField = value;
			}
		}
		public MessageFormat PreferredFormat
		{
			get
			{
				return this.preferredFormatField;
			}
			set
			{
				this.preferredFormatField = value;
			}
		}
		public string UrlString
		{
			get
			{
				return this.urlStringField;
			}
			set
			{
				this.urlStringField = value;
			}
		}
	}
}
