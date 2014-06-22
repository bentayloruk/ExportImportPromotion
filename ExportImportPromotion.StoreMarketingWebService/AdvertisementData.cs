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
	public class AdvertisementData : DisplayableCampaignItemData
	{
		private string industryField;
		private AdvertisementType typeField;
		private RecurrenceDays daysOfWeekToRunField;
		private int hourOfDayToStartField;
		private int hourOfDayToEndField;
		private int numberOfEventsScheduledField;
		private int houseAdWeightField;
		private int numberOfEventsCurrentlyServedField;
		private int numberOfEventsAtCheckpointField;
		private DateTime checkpointTimeField;
		public string Industry
		{
			get
			{
				return this.industryField;
			}
			set
			{
				this.industryField = value;
			}
		}
		public AdvertisementType Type
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
		public RecurrenceDays DaysOfWeekToRun
		{
			get
			{
				return this.daysOfWeekToRunField;
			}
			set
			{
				this.daysOfWeekToRunField = value;
			}
		}
		public int HourOfDayToStart
		{
			get
			{
				return this.hourOfDayToStartField;
			}
			set
			{
				this.hourOfDayToStartField = value;
			}
		}
		public int HourOfDayToEnd
		{
			get
			{
				return this.hourOfDayToEndField;
			}
			set
			{
				this.hourOfDayToEndField = value;
			}
		}
		public int NumberOfEventsScheduled
		{
			get
			{
				return this.numberOfEventsScheduledField;
			}
			set
			{
				this.numberOfEventsScheduledField = value;
			}
		}
		public int HouseAdWeight
		{
			get
			{
				return this.houseAdWeightField;
			}
			set
			{
				this.houseAdWeightField = value;
			}
		}
		public int NumberOfEventsCurrentlyServed
		{
			get
			{
				return this.numberOfEventsCurrentlyServedField;
			}
			set
			{
				this.numberOfEventsCurrentlyServedField = value;
			}
		}
		public int NumberOfEventsAtCheckpoint
		{
			get
			{
				return this.numberOfEventsAtCheckpointField;
			}
			set
			{
				this.numberOfEventsAtCheckpointField = value;
			}
		}
		public DateTime CheckpointTime
		{
			get
			{
				return this.checkpointTimeField;
			}
			set
			{
				this.checkpointTimeField = value;
			}
		}
	}
}
