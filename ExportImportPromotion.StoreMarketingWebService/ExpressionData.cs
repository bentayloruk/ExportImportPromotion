using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService")]
#endif

	[Serializable]
	public class ExpressionData
	{
		private int idField;
		private string nameField;
		private string descriptionField;
		private string categoryField;
		private bool localField;
		private XmlElement bodyField;
		private string productPickerCatalogField;
		private string productPickerCategoryField;
		private string productPickerProductField;
		private DateTime createdDateField;
		private DateTime lastModifiedDateField;
		private string lastModifiedByField;
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
		[XmlElement(IsNullable = true)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		public bool Local
		{
			get
			{
				return this.localField;
			}
			set
			{
				this.localField = value;
			}
		}
#if MS
		[XmlElement(Namespace = "http://schemas.microsoft.com/CommerceServer/2004/02/Expressions", IsNullable = true)]
#else
		[XmlElement(Namespace = "http://schemas.commerceserver.net/2013/01/Expressions", IsNullable = true)]
#endif

		public XmlElement Body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
			}
		}
		public string ProductPickerCatalog
		{
			get
			{
				return this.productPickerCatalogField;
			}
			set
			{
				this.productPickerCatalogField = value;
			}
		}
		public string ProductPickerCategory
		{
			get
			{
				return this.productPickerCategoryField;
			}
			set
			{
				this.productPickerCategoryField = value;
			}
		}
		public string ProductPickerProduct
		{
			get
			{
				return this.productPickerProductField;
			}
			set
			{
				this.productPickerProductField = value;
			}
		}
		public DateTime CreatedDate
		{
			get
			{
				return this.createdDateField;
			}
			set
			{
				this.createdDateField = value;
			}
		}
		public DateTime LastModifiedDate
		{
			get
			{
				return this.lastModifiedDateField;
			}
			set
			{
				this.lastModifiedDateField = value;
			}
		}
		[XmlElement(IsNullable = true)]
		public string LastModifiedBy
		{
			get
			{
				return this.lastModifiedByField;
			}
			set
			{
				this.lastModifiedByField = value;
			}
		}
	}
}
