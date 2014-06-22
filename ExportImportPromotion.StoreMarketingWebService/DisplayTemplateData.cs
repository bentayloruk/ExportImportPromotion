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
	public class DisplayTemplateData
	{
		private int idField;
		private string nameField;
		private string textField;
		private object[] propertiesField;
		private object[] deletedPropertiesField;
		public int Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public string Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}
		public object[] Properties
		{
			get
			{
				return this.propertiesField;
			}
			set
			{
				this.propertiesField = value;
			}
		}
		public object[] DeletedProperties
		{
			get
			{
				return this.deletedPropertiesField;
			}
			set
			{
				this.deletedPropertiesField = value;
			}
		}
	}
}
