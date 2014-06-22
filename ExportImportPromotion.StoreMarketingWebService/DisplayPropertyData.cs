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
	public class DisplayPropertyData
	{
		private int idField;
		private string templateNameField;
		private string nameField;
		private DisplayPropertyType typeField;
		private string labelField;
		private short orderField;
		private UrlEncodingType encodingField;
		private TemplatePropertySource sourceField;
		private string defaultValueField;
		private bool isRequiredField;
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
		public string TemplateName
		{
			get
			{
				return this.templateNameField;
			}
			set
			{
				this.templateNameField = value;
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
		public DisplayPropertyType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		public string Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
			}
		}
		public short Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
			}
		}
		public UrlEncodingType Encoding
		{
			get
			{
				return this.encodingField;
			}
			set
			{
				this.encodingField = value;
			}
		}
		public TemplatePropertySource Source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
			}
		}
		public string DefaultValue
		{
			get
			{
				return this.defaultValueField;
			}
			set
			{
				this.defaultValueField = value;
			}
		}
		public bool IsRequired
		{
			get
			{
				return this.isRequiredField;
			}
			set
			{
				this.isRequiredField = value;
			}
		}
	}
}
