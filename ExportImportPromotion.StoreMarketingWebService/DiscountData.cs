using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Xml", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService")]
	[Serializable]
	public class DiscountData : DisplayableCampaignItemData
	{
		private DiscountType discountTypeField;
		private object[] multilingualBasketDisplayField;
		private bool useEligibilityRequirementForTargetingField;
		private int wizardTypeField;
		private int priorityField;
		private int perOrderLimitField;
		private bool clickRequiredField;
		private ExpressionRefData awardExpressionField;
		private int maxAwardsField;
		private OfferType offerTypeField;
		private decimal offerAmountField;
		private bool offerDisjointField;
		private string customOrderLevelOfferTypeField;
		private bool autoAddAwardField;
		private int promoCodeDefinitionIdField;
		private bool reuseConditionsAsConditionsField;
		private bool reuseConditionsAsAwardsField;
		private bool reuseAwardsAsConditionsField;
		private bool reuseAwardsAsAwardsField;
		private DiscountConditionData conditionField;
		private object[] eligibilityRequirementsField;
		public DiscountType DiscountType
		{
			get
			{
				return this.discountTypeField;
			}
			set
			{
				this.discountTypeField = value;
			}
		}
		public object[] MultilingualBasketDisplay
		{
			get
			{
				return this.multilingualBasketDisplayField;
			}
			set
			{
				this.multilingualBasketDisplayField = value;
			}
		}
		public bool UseEligibilityRequirementForTargeting
		{
			get
			{
				return this.useEligibilityRequirementForTargetingField;
			}
			set
			{
				this.useEligibilityRequirementForTargetingField = value;
			}
		}
		public int WizardType
		{
			get
			{
				return this.wizardTypeField;
			}
			set
			{
				this.wizardTypeField = value;
			}
		}
		public int Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}
		public int PerOrderLimit
		{
			get
			{
				return this.perOrderLimitField;
			}
			set
			{
				this.perOrderLimitField = value;
			}
		}
		public bool ClickRequired
		{
			get
			{
				return this.clickRequiredField;
			}
			set
			{
				this.clickRequiredField = value;
			}
		}
		public ExpressionRefData AwardExpression
		{
			get
			{
				return this.awardExpressionField;
			}
			set
			{
				this.awardExpressionField = value;
			}
		}
		public int MaxAwards
		{
			get
			{
				return this.maxAwardsField;
			}
			set
			{
				this.maxAwardsField = value;
			}
		}
		public OfferType OfferType
		{
			get
			{
				return this.offerTypeField;
			}
			set
			{
				this.offerTypeField = value;
			}
		}
		public decimal OfferAmount
		{
			get
			{
				return this.offerAmountField;
			}
			set
			{
				this.offerAmountField = value;
			}
		}
		public bool OfferDisjoint
		{
			get
			{
				return this.offerDisjointField;
			}
			set
			{
				this.offerDisjointField = value;
			}
		}
		public string CustomOrderLevelOfferType
		{
			get
			{
				return this.customOrderLevelOfferTypeField;
			}
			set
			{
				this.customOrderLevelOfferTypeField = value;
			}
		}
		public bool AutoAddAward
		{
			get
			{
				return this.autoAddAwardField;
			}
			set
			{
				this.autoAddAwardField = value;
			}
		}
		public int PromoCodeDefinitionId
		{
			get
			{
				return this.promoCodeDefinitionIdField;
			}
			set
			{
				this.promoCodeDefinitionIdField = value;
			}
		}
		public bool ReuseConditionsAsConditions
		{
			get
			{
				return this.reuseConditionsAsConditionsField;
			}
			set
			{
				this.reuseConditionsAsConditionsField = value;
			}
		}
		public bool ReuseConditionsAsAwards
		{
			get
			{
				return this.reuseConditionsAsAwardsField;
			}
			set
			{
				this.reuseConditionsAsAwardsField = value;
			}
		}
		public bool ReuseAwardsAsConditions
		{
			get
			{
				return this.reuseAwardsAsConditionsField;
			}
			set
			{
				this.reuseAwardsAsConditionsField = value;
			}
		}
		public bool ReuseAwardsAsAwards
		{
			get
			{
				return this.reuseAwardsAsAwardsField;
			}
			set
			{
				this.reuseAwardsAsAwardsField = value;
			}
		}
		public DiscountConditionData Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}
		public object[] EligibilityRequirements
		{
			get
			{
				return this.eligibilityRequirementsField;
			}
			set
			{
				this.eligibilityRequirementsField = value;
			}
		}
	}
}
