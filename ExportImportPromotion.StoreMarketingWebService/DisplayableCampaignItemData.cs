using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(DiscountData)), XmlInclude(typeof(AdvertisementData)), XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
#else
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(DiscountData)), XmlInclude(typeof(AdvertisementData)), XmlType(Namespace = "http://schemas.commerceserver.net/2013/01/CommerceServer/2006/06/MarketingWebService")]
#endif

	[Serializable]
	public class DisplayableCampaignItemData : CampaignItemData
	{
		private int creativeIdField;
		private int exposureLimitField;
		private string sizeNameField;
		private string templateNameField;
		private DateTime dateReceivedField;
		private object[] propertyValuesField;
		private object[] pageGroupsField;
		private object[] targetsField;
		public int CreativeId
		{
			get
			{
				return this.creativeIdField;
			}
			set
			{
				this.creativeIdField = value;
			}
		}
		public int ExposureLimit
		{
			get
			{
				return this.exposureLimitField;
			}
			set
			{
				this.exposureLimitField = value;
			}
		}
		public string SizeName
		{
			get
			{
				return this.sizeNameField;
			}
			set
			{
				this.sizeNameField = value;
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
		public DateTime DateReceived
		{
			get
			{
				return this.dateReceivedField;
			}
			set
			{
				this.dateReceivedField = value;
			}
		}
		public object[] PropertyValues
		{
			get
			{
				return this.propertyValuesField;
			}
			set
			{
				this.propertyValuesField = value;
			}
		}
		public object[] PageGroups
		{
			get
			{
				return this.pageGroupsField;
			}
			set
			{
				this.pageGroupsField = value;
			}
		}
		public object[] Targets
		{
			get
			{
				return this.targetsField;
			}
			set
			{
				this.targetsField = value;
			}
		}
	}
}
