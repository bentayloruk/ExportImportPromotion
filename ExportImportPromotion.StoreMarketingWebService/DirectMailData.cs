using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public class DirectMailData : CampaignItemData
	{
		private MailingListData destinationListField;
		private MailingListData optOutListField;
		private StaticListData testListField;
		private object[] multilingualSubjectField;
		private string fromField;
		private string replyToField;
		private string sourceLocationField;
		private object[] attachmentsField;
		private bool isPersonalizedField;
		private MessageFormat defaultFormatField;
		private string defaultCharacterSetField;
		private string defaultCultureCodeField;
		private bool ignoreGlobalOptOutListField;
		private DirectMailRecurrence recurrenceField;
		public MailingListData DestinationList
		{
			get
			{
				return this.destinationListField;
			}
			set
			{
				this.destinationListField = value;
			}
		}
		public MailingListData OptOutList
		{
			get
			{
				return this.optOutListField;
			}
			set
			{
				this.optOutListField = value;
			}
		}
		public StaticListData TestList
		{
			get
			{
				return this.testListField;
			}
			set
			{
				this.testListField = value;
			}
		}
		public object[] MultilingualSubject
		{
			get
			{
				return this.multilingualSubjectField;
			}
			set
			{
				this.multilingualSubjectField = value;
			}
		}
		public string From
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
			}
		}
		public string ReplyTo
		{
			get
			{
				return this.replyToField;
			}
			set
			{
				this.replyToField = value;
			}
		}
		public string SourceLocation
		{
			get
			{
				return this.sourceLocationField;
			}
			set
			{
				this.sourceLocationField = value;
			}
		}
		public object[] Attachments
		{
			get
			{
				return this.attachmentsField;
			}
			set
			{
				this.attachmentsField = value;
			}
		}
		public bool IsPersonalized
		{
			get
			{
				return this.isPersonalizedField;
			}
			set
			{
				this.isPersonalizedField = value;
			}
		}
		public MessageFormat DefaultFormat
		{
			get
			{
				return this.defaultFormatField;
			}
			set
			{
				this.defaultFormatField = value;
			}
		}
		public string DefaultCharacterSet
		{
			get
			{
				return this.defaultCharacterSetField;
			}
			set
			{
				this.defaultCharacterSetField = value;
			}
		}
		public string DefaultCultureCode
		{
			get
			{
				return this.defaultCultureCodeField;
			}
			set
			{
				this.defaultCultureCodeField = value;
			}
		}
		public bool IgnoreGlobalOptOutList
		{
			get
			{
				return this.ignoreGlobalOptOutListField;
			}
			set
			{
				this.ignoreGlobalOptOutListField = value;
			}
		}
		public DirectMailRecurrence Recurrence
		{
			get
			{
				return this.recurrenceField;
			}
			set
			{
				this.recurrenceField = value;
			}
		}
	}
}
