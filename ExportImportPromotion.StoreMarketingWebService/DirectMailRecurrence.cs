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
	public class DirectMailRecurrence
	{
		private DirectMailRecurrenceType typeField;
		private int dailyIntervalField;
		private int weeklyIntervalField;
		private int dayOfMonthField;
		private RecurrenceWeek weekField;
		private RecurrenceMonths monthsField;
		private RecurrenceDays daysOfWeekField;
		public DirectMailRecurrenceType Type
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
		public int DailyInterval
		{
			get
			{
				return this.dailyIntervalField;
			}
			set
			{
				this.dailyIntervalField = value;
			}
		}
		public int WeeklyInterval
		{
			get
			{
				return this.weeklyIntervalField;
			}
			set
			{
				this.weeklyIntervalField = value;
			}
		}
		public int DayOfMonth
		{
			get
			{
				return this.dayOfMonthField;
			}
			set
			{
				this.dayOfMonthField = value;
			}
		}
		public RecurrenceWeek Week
		{
			get
			{
				return this.weekField;
			}
			set
			{
				this.weekField = value;
			}
		}
		public RecurrenceMonths Months
		{
			get
			{
				return this.monthsField;
			}
			set
			{
				this.monthsField = value;
			}
		}
		public RecurrenceDays DaysOfWeek
		{
			get
			{
				return this.daysOfWeekField;
			}
			set
			{
				this.daysOfWeekField = value;
			}
		}
	}
}
