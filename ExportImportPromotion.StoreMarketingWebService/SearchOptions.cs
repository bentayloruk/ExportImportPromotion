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
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/CommerceServer/2006/06/MarketingWebService")]
#endif

	[Serializable]
	public class SearchOptions
	{
		private int numberOfRecordsToReturnField;
		private int startRecordField;
		private string sortPropertiesField;
		private bool sortDescendingField;
		private string propertiesToReturnField;
		public int NumberOfRecordsToReturn
		{
			get
			{
				return this.numberOfRecordsToReturnField;
			}
			set
			{
				this.numberOfRecordsToReturnField = value;
			}
		}
		public int StartRecord
		{
			get
			{
				return this.startRecordField;
			}
			set
			{
				this.startRecordField = value;
			}
		}
		public string SortProperties
		{
			get
			{
				return this.sortPropertiesField;
			}
			set
			{
				this.sortPropertiesField = value;
			}
		}
		public bool SortDescending
		{
			get
			{
				return this.sortDescendingField;
			}
			set
			{
				this.sortDescendingField = value;
			}
		}
		public string PropertiesToReturn
		{
			get
			{
				return this.propertiesToReturnField;
			}
			set
			{
				this.propertiesToReturnField = value;
			}
		}
	}
}
