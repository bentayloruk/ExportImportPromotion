using ExportImportPromotion.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
namespace ExportImportPromotion.StoreMarketingWebService
{
#if MS
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "MarketingServiceSoap", Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService"), XmlInclude(typeof(ExpressionTargetData)), XmlInclude(typeof(DisplayPropertyData)), XmlInclude(typeof(LanguageStringData))]
#else
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "MarketingServiceSoap", Namespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService"), XmlInclude(typeof(ExpressionTargetData)), XmlInclude(typeof(DisplayPropertyData)), XmlInclude(typeof(LanguageStringData))]
#endif

	public class MarketingService : SoapHttpClientProtocol
	{
		private SendOrPostCallback GetAuthorizedTasksOperationCompleted;
		private SendOrPostCallback GetAllLanguagesInUseOperationCompleted;
		private SendOrPostCallback GetDefaultLanguageOperationCompleted;
		private SendOrPostCallback GetServiceVersionOperationCompleted;
		private SendOrPostCallback AccessCheckCancelCouponExportOperationCompleted;
		private SendOrPostCallback GetSearchablePropertiesOperationCompleted;
		private SendOrPostCallback ExecuteSearchOperationCompleted;
		private SendOrPostCallback ExecuteSearchWithCountOperationCompleted;
		private SendOrPostCallback GetCustomerOperationCompleted;
		private SendOrPostCallback NewCustomerOperationCompleted;
		private SendOrPostCallback SaveCustomerOperationCompleted;
		private SendOrPostCallback DeleteCustomerOperationCompleted;
		private SendOrPostCallback RestoreCustomerOperationCompleted;
		private SendOrPostCallback GetCampaignOperationCompleted;
		private SendOrPostCallback NewCampaignOperationCompleted;
		private SendOrPostCallback SaveCampaignOperationCompleted;
		private SendOrPostCallback ActivateCampaignOperationCompleted;
		private SendOrPostCallback DeleteCampaignOperationCompleted;
		private SendOrPostCallback RestoreCampaignOperationCompleted;
		private SendOrPostCallback MoveCampaignToCustomerOperationCompleted;
		private SendOrPostCallback NewCampaignItemOperationCompleted;
		private SendOrPostCallback GetCampaignItemOperationCompleted;
		private SendOrPostCallback TestDirectMailOperationCompleted;
		private SendOrPostCallback SaveCampaignItemOperationCompleted;
		private SendOrPostCallback CopyCampaignItemOperationCompleted;
		private SendOrPostCallback DeleteCampaignItemOperationCompleted;
		private SendOrPostCallback RestoreCampaignItemOperationCompleted;
		private SendOrPostCallback MoveCampaignItemToCampaignOperationCompleted;
		private SendOrPostCallback ActivateCampaignItemOperationCompleted;
		private SendOrPostCallback GenerateCampaignItemPreviewOperationCompleted;
		private SendOrPostCallback NewExpressionOperationCompleted;
		private SendOrPostCallback GetExpressionOperationCompleted;
		private SendOrPostCallback SaveExpressionOperationCompleted;
		private SendOrPostCallback CopyExpressionOperationCompleted;
		private SendOrPostCallback DeleteExpressionOperationCompleted;
		private SendOrPostCallback GetAllExpressionCategoriesOperationCompleted;
		private SendOrPostCallback SaveExpressionCategoriesOperationCompleted;
		private SendOrPostCallback GetProfileDefinitionsOperationCompleted;
		private SendOrPostCallback GetSiteTermsOperationCompleted;
		private SendOrPostCallback UpdateDiscountPrioritiesOperationCompleted;
		private SendOrPostCallback PrioritizeDiscountOperationCompleted;
		private SendOrPostCallback GetDisplaySizeOperationCompleted;
		private SendOrPostCallback GetDisplaySizeByNameOperationCompleted;
		private SendOrPostCallback GetAllDisplaySizesOperationCompleted;
		private SendOrPostCallback SaveDisplaySizeOperationCompleted;
		private SendOrPostCallback DeleteDisplaySizeOperationCompleted;
		private SendOrPostCallback GetPageGroupOperationCompleted;
		private SendOrPostCallback GetAllPageGroupsOperationCompleted;
		private SendOrPostCallback SavePageGroupOperationCompleted;
		private SendOrPostCallback DeletePageGroupOperationCompleted;
		private SendOrPostCallback GetDisplayTemplateOperationCompleted;
		private SendOrPostCallback GetDisplayTemplateByNameOperationCompleted;
		private SendOrPostCallback GetAllDisplayTemplatesOperationCompleted;
		private SendOrPostCallback SaveDisplayTemplateOperationCompleted;
		private SendOrPostCallback DeleteDisplayTemplateOperationCompleted;
		private SendOrPostCallback GetAllIndustryCodesOperationCompleted;
		private SendOrPostCallback GetIndustryCodeOperationCompleted;
		private SendOrPostCallback SaveIndustryCodeOperationCompleted;
		private SendOrPostCallback DeleteIndustryCodeOperationCompleted;
		private SendOrPostCallback GetCampaignEventTypeOperationCompleted;
		private SendOrPostCallback GetAllCampaignEventTypesOperationCompleted;
		private SendOrPostCallback SaveCampaignEventTypeOperationCompleted;
		private SendOrPostCallback DeleteCampaignEventTypeOperationCompleted;
		private SendOrPostCallback RefreshCacheOperationCompleted;
		private SendOrPostCallback GetMailingListOperationCompleted;
		private SendOrPostCallback GetAllMailingListsOperationCompleted;
		private SendOrPostCallback SaveMailingListOperationCompleted;
		private SendOrPostCallback GetUserFromListOperationCompleted;
		private SendOrPostCallback AddUserToListOperationCompleted;
		private SendOrPostCallback UpdateUserInListOperationCompleted;
		private SendOrPostCallback RemoveUserFromListOperationCompleted;
		private SendOrPostCallback DeleteListOperationCompleted;
		private SendOrPostCallback SubtractListsOperationCompleted;
		private SendOrPostCallback AppendListsOperationCompleted;
		private SendOrPostCallback AppendExpressionToListOperationCompleted;
		private SendOrPostCallback InitImportMailingListOperationCompleted;
		private SendOrPostCallback ImportMailingListOperationCompleted;
		private SendOrPostCallback AbortListOperationOperationCompleted;
		private SendOrPostCallback GetListOperationOperationCompleted;
		private SendOrPostCallback GetListOperationHistoryOperationCompleted;
		private SendOrPostCallback GetMostRecentListOperationOperationCompleted;
		private SendOrPostCallback CreateListCopyOperationCompleted;
		private SendOrPostCallback GetAllowedProfileDefinitionOperationCompleted;
		private SendOrPostCallback NewPromoCodeDefinitionOperationCompleted;
		private SendOrPostCallback SavePromoCodeDefinitionOperationCompleted;
		private SendOrPostCallback DeletePromoCodeDefinitionOperationCompleted;
		private SendOrPostCallback DeleteBatchOperationCompleted;
		private SendOrPostCallback GenerateRandomPromoCodesOperationCompleted;
		private SendOrPostCallback LookupPromoCodeDefinitionByCodeOperationCompleted;
		private SendOrPostCallback GetPromoCodeDefinitionOperationCompleted;
		private SendOrPostCallback GetBatchInfosForDefinitionOperationCompleted;
		private SendOrPostCallback InitImportPromoCodesOperationCompleted;
		private SendOrPostCallback ImportPromoCodesOperationCompleted;
		private SendOrPostCallback GetPromoCodeGenerationStatusOperationCompleted;
		private SendOrPostCallback CancelPromoCodeGenerationOperationCompleted;
		private SendOrPostCallback RevertPromoCodeRedemptionOperationCompleted;
		private SendOrPostCallback GetMaximumPromoCodeBatchSizeOperationCompleted;
		private SendOrPostCallback UploadChunkOperationCompleted;
		private bool useDefaultCredentialsSetExplicitly;
		public event GetAuthorizedTasksCompletedEventHandler GetAuthorizedTasksCompleted;
		public event GetAllLanguagesInUseCompletedEventHandler GetAllLanguagesInUseCompleted;
		public event GetDefaultLanguageCompletedEventHandler GetDefaultLanguageCompleted;
		public event GetServiceVersionCompletedEventHandler GetServiceVersionCompleted;
		public event AccessCheckCancelCouponExportCompletedEventHandler AccessCheckCancelCouponExportCompleted;
		public event GetSearchablePropertiesCompletedEventHandler GetSearchablePropertiesCompleted;
		public event ExecuteSearchCompletedEventHandler ExecuteSearchCompleted;
		public event ExecuteSearchWithCountCompletedEventHandler ExecuteSearchWithCountCompleted;
		public event GetCustomerCompletedEventHandler GetCustomerCompleted;
		public event NewCustomerCompletedEventHandler NewCustomerCompleted;
		public event SaveCustomerCompletedEventHandler SaveCustomerCompleted;
		public event DeleteCustomerCompletedEventHandler DeleteCustomerCompleted;
		public event RestoreCustomerCompletedEventHandler RestoreCustomerCompleted;
		public event GetCampaignCompletedEventHandler GetCampaignCompleted;
		public event NewCampaignCompletedEventHandler NewCampaignCompleted;
		public event SaveCampaignCompletedEventHandler SaveCampaignCompleted;
		public event ActivateCampaignCompletedEventHandler ActivateCampaignCompleted;
		public event DeleteCampaignCompletedEventHandler DeleteCampaignCompleted;
		public event RestoreCampaignCompletedEventHandler RestoreCampaignCompleted;
		public event MoveCampaignToCustomerCompletedEventHandler MoveCampaignToCustomerCompleted;
		public event NewCampaignItemCompletedEventHandler NewCampaignItemCompleted;
		public event GetCampaignItemCompletedEventHandler GetCampaignItemCompleted;
		public event TestDirectMailCompletedEventHandler TestDirectMailCompleted;
		public event SaveCampaignItemCompletedEventHandler SaveCampaignItemCompleted;
		public event CopyCampaignItemCompletedEventHandler CopyCampaignItemCompleted;
		public event DeleteCampaignItemCompletedEventHandler DeleteCampaignItemCompleted;
		public event RestoreCampaignItemCompletedEventHandler RestoreCampaignItemCompleted;
		public event MoveCampaignItemToCampaignCompletedEventHandler MoveCampaignItemToCampaignCompleted;
		public event ActivateCampaignItemCompletedEventHandler ActivateCampaignItemCompleted;
		public event GenerateCampaignItemPreviewCompletedEventHandler GenerateCampaignItemPreviewCompleted;
		public event NewExpressionCompletedEventHandler NewExpressionCompleted;
		public event GetExpressionCompletedEventHandler GetExpressionCompleted;
		public event SaveExpressionCompletedEventHandler SaveExpressionCompleted;
		public event CopyExpressionCompletedEventHandler CopyExpressionCompleted;
		public event DeleteExpressionCompletedEventHandler DeleteExpressionCompleted;
		public event GetAllExpressionCategoriesCompletedEventHandler GetAllExpressionCategoriesCompleted;
		public event SaveExpressionCategoriesCompletedEventHandler SaveExpressionCategoriesCompleted;
		public event GetProfileDefinitionsCompletedEventHandler GetProfileDefinitionsCompleted;
		public event GetSiteTermsCompletedEventHandler GetSiteTermsCompleted;
		public event UpdateDiscountPrioritiesCompletedEventHandler UpdateDiscountPrioritiesCompleted;
		public event PrioritizeDiscountCompletedEventHandler PrioritizeDiscountCompleted;
		public event GetDisplaySizeCompletedEventHandler GetDisplaySizeCompleted;
		public event GetDisplaySizeByNameCompletedEventHandler GetDisplaySizeByNameCompleted;
		public event GetAllDisplaySizesCompletedEventHandler GetAllDisplaySizesCompleted;
		public event SaveDisplaySizeCompletedEventHandler SaveDisplaySizeCompleted;
		public event DeleteDisplaySizeCompletedEventHandler DeleteDisplaySizeCompleted;
		public event GetPageGroupCompletedEventHandler GetPageGroupCompleted;
		public event GetAllPageGroupsCompletedEventHandler GetAllPageGroupsCompleted;
		public event SavePageGroupCompletedEventHandler SavePageGroupCompleted;
		public event DeletePageGroupCompletedEventHandler DeletePageGroupCompleted;
		public event GetDisplayTemplateCompletedEventHandler GetDisplayTemplateCompleted;
		public event GetDisplayTemplateByNameCompletedEventHandler GetDisplayTemplateByNameCompleted;
		public event GetAllDisplayTemplatesCompletedEventHandler GetAllDisplayTemplatesCompleted;
		public event SaveDisplayTemplateCompletedEventHandler SaveDisplayTemplateCompleted;
		public event DeleteDisplayTemplateCompletedEventHandler DeleteDisplayTemplateCompleted;
		public event GetAllIndustryCodesCompletedEventHandler GetAllIndustryCodesCompleted;
		public event GetIndustryCodeCompletedEventHandler GetIndustryCodeCompleted;
		public event SaveIndustryCodeCompletedEventHandler SaveIndustryCodeCompleted;
		public event DeleteIndustryCodeCompletedEventHandler DeleteIndustryCodeCompleted;
		public event GetCampaignEventTypeCompletedEventHandler GetCampaignEventTypeCompleted;
		public event GetAllCampaignEventTypesCompletedEventHandler GetAllCampaignEventTypesCompleted;
		public event SaveCampaignEventTypeCompletedEventHandler SaveCampaignEventTypeCompleted;
		public event DeleteCampaignEventTypeCompletedEventHandler DeleteCampaignEventTypeCompleted;
		public event RefreshCacheCompletedEventHandler RefreshCacheCompleted;
		public event GetMailingListCompletedEventHandler GetMailingListCompleted;
		public event GetAllMailingListsCompletedEventHandler GetAllMailingListsCompleted;
		public event SaveMailingListCompletedEventHandler SaveMailingListCompleted;
		public event GetUserFromListCompletedEventHandler GetUserFromListCompleted;
		public event AddUserToListCompletedEventHandler AddUserToListCompleted;
		public event UpdateUserInListCompletedEventHandler UpdateUserInListCompleted;
		public event RemoveUserFromListCompletedEventHandler RemoveUserFromListCompleted;
		public event DeleteListCompletedEventHandler DeleteListCompleted;
		public event SubtractListsCompletedEventHandler SubtractListsCompleted;
		public event AppendListsCompletedEventHandler AppendListsCompleted;
		public event AppendExpressionToListCompletedEventHandler AppendExpressionToListCompleted;
		public event InitImportMailingListCompletedEventHandler InitImportMailingListCompleted;
		public event ImportMailingListCompletedEventHandler ImportMailingListCompleted;
		public event AbortListOperationCompletedEventHandler AbortListOperationCompleted;
		public event GetListOperationCompletedEventHandler GetListOperationCompleted;
		public event GetListOperationHistoryCompletedEventHandler GetListOperationHistoryCompleted;
		public event GetMostRecentListOperationCompletedEventHandler GetMostRecentListOperationCompleted;
		public event CreateListCopyCompletedEventHandler CreateListCopyCompleted;
		public event GetAllowedProfileDefinitionCompletedEventHandler GetAllowedProfileDefinitionCompleted;
		public event NewPromoCodeDefinitionCompletedEventHandler NewPromoCodeDefinitionCompleted;
		public event SavePromoCodeDefinitionCompletedEventHandler SavePromoCodeDefinitionCompleted;
		public event DeletePromoCodeDefinitionCompletedEventHandler DeletePromoCodeDefinitionCompleted;
		public event DeleteBatchCompletedEventHandler DeleteBatchCompleted;
		public event GenerateRandomPromoCodesCompletedEventHandler GenerateRandomPromoCodesCompleted;
		public event LookupPromoCodeDefinitionByCodeCompletedEventHandler LookupPromoCodeDefinitionByCodeCompleted;
		public event GetPromoCodeDefinitionCompletedEventHandler GetPromoCodeDefinitionCompleted;
		public event GetBatchInfosForDefinitionCompletedEventHandler GetBatchInfosForDefinitionCompleted;
		public event InitImportPromoCodesCompletedEventHandler InitImportPromoCodesCompleted;
		public event ImportPromoCodesCompletedEventHandler ImportPromoCodesCompleted;
		public event GetPromoCodeGenerationStatusCompletedEventHandler GetPromoCodeGenerationStatusCompleted;
		public event CancelPromoCodeGenerationCompletedEventHandler CancelPromoCodeGenerationCompleted;
		public event RevertPromoCodeRedemptionCompletedEventHandler RevertPromoCodeRedemptionCompleted;
		public event GetMaximumPromoCodeBatchSizeCompletedEventHandler GetMaximumPromoCodeBatchSizeCompleted;
		public event UploadChunkCompletedEventHandler UploadChunkCompleted;
		public new string Url
		{
			get
			{
				return base.Url;
			}
			set
			{
				if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}
		public new bool UseDefaultCredentials
		{
			get
			{
				return base.UseDefaultCredentials;
			}
			set
			{
				base.UseDefaultCredentials = value;
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		public MarketingService()
		{
			this.Url = Settings.Default.ExportImportPromotion_StoreMarketingWebService_MarketingService;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		public MarketingService(string webServiceUri)
		{
			this.Url = webServiceUri;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAuthorizedTasks", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAuthorizedTasks", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public DataSet GetAuthorizedTasks()
		{
			object[] array = base.Invoke("GetAuthorizedTasks", new object[0]);
			return (DataSet)array[0];
		}
		public void GetAuthorizedTasksAsync()
		{
			this.GetAuthorizedTasksAsync(null);
		}
		public void GetAuthorizedTasksAsync(object userState)
		{
			if (this.GetAuthorizedTasksOperationCompleted == null)
			{
				this.GetAuthorizedTasksOperationCompleted = new SendOrPostCallback(this.OnGetAuthorizedTasksOperationCompleted);
			}
			base.InvokeAsync("GetAuthorizedTasks", new object[0], this.GetAuthorizedTasksOperationCompleted, userState);
		}
		private void OnGetAuthorizedTasksOperationCompleted(object arg)
		{
			if (this.GetAuthorizedTasksCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAuthorizedTasksCompleted(this, new GetAuthorizedTasksCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllLanguagesInUse", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllLanguagesInUse", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public string[] GetAllLanguagesInUse()
		{
			object[] array = base.Invoke("GetAllLanguagesInUse", new object[0]);
			return (string[])array[0];
		}
		public void GetAllLanguagesInUseAsync()
		{
			this.GetAllLanguagesInUseAsync(null);
		}
		public void GetAllLanguagesInUseAsync(object userState)
		{
			if (this.GetAllLanguagesInUseOperationCompleted == null)
			{
				this.GetAllLanguagesInUseOperationCompleted = new SendOrPostCallback(this.OnGetAllLanguagesInUseOperationCompleted);
			}
			base.InvokeAsync("GetAllLanguagesInUse", new object[0], this.GetAllLanguagesInUseOperationCompleted, userState);
		}
		private void OnGetAllLanguagesInUseOperationCompleted(object arg)
		{
			if (this.GetAllLanguagesInUseCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllLanguagesInUseCompleted(this, new GetAllLanguagesInUseCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetDefaultLanguage", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetDefaultLanguage", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public string GetDefaultLanguage()
		{
			object[] array = base.Invoke("GetDefaultLanguage", new object[0]);
			return (string)array[0];
		}
		public void GetDefaultLanguageAsync()
		{
			this.GetDefaultLanguageAsync(null);
		}
		public void GetDefaultLanguageAsync(object userState)
		{
			if (this.GetDefaultLanguageOperationCompleted == null)
			{
				this.GetDefaultLanguageOperationCompleted = new SendOrPostCallback(this.OnGetDefaultLanguageOperationCompleted);
			}
			base.InvokeAsync("GetDefaultLanguage", new object[0], this.GetDefaultLanguageOperationCompleted, userState);
		}
		private void OnGetDefaultLanguageOperationCompleted(object arg)
		{
			if (this.GetDefaultLanguageCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetDefaultLanguageCompleted(this, new GetDefaultLanguageCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2004/02/WebServices/GetServiceVersion", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2004/02/WebServices", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2004/02/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/WebServices/GetServiceVersion", RequestNamespace = "http://schemas.commerceserver.net/2013/01/WebServices", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public WebServiceVersion GetServiceVersion()
		{
			object[] array = base.Invoke("GetServiceVersion", new object[0]);
			return (WebServiceVersion)array[0];
		}
		public void GetServiceVersionAsync()
		{
			this.GetServiceVersionAsync(null);
		}
		public void GetServiceVersionAsync(object userState)
		{
			if (this.GetServiceVersionOperationCompleted == null)
			{
				this.GetServiceVersionOperationCompleted = new SendOrPostCallback(this.OnGetServiceVersionOperationCompleted);
			}
			base.InvokeAsync("GetServiceVersion", new object[0], this.GetServiceVersionOperationCompleted, userState);
		}
		private void OnGetServiceVersionOperationCompleted(object arg)
		{
			if (this.GetServiceVersionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetServiceVersionCompleted(this, new GetServiceVersionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/AccessCheckCancelCouponExport", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/AccessCheckCancelCouponExport", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void AccessCheckCancelCouponExport(string filePath)
		{
			base.Invoke("AccessCheckCancelCouponExport", new object[]
			{
				filePath
			});
		}
		public void AccessCheckCancelCouponExportAsync(string filePath)
		{
			this.AccessCheckCancelCouponExportAsync(filePath, null);
		}
		public void AccessCheckCancelCouponExportAsync(string filePath, object userState)
		{
			if (this.AccessCheckCancelCouponExportOperationCompleted == null)
			{
				this.AccessCheckCancelCouponExportOperationCompleted = new SendOrPostCallback(this.OnAccessCheckCancelCouponExportOperationCompleted);
			}
			base.InvokeAsync("AccessCheckCancelCouponExport", new object[]
			{
				filePath
			}, this.AccessCheckCancelCouponExportOperationCompleted, userState);
		}
		private void OnAccessCheckCancelCouponExportOperationCompleted(object arg)
		{
			if (this.AccessCheckCancelCouponExportCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.AccessCheckCancelCouponExportCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetSearchableProperties", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetSearchableProperties", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public DataSet GetSearchableProperties()
		{
			object[] array = base.Invoke("GetSearchableProperties", new object[0]);
			return (DataSet)array[0];
		}
		public void GetSearchablePropertiesAsync()
		{
			this.GetSearchablePropertiesAsync(null);
		}
		public void GetSearchablePropertiesAsync(object userState)
		{
			if (this.GetSearchablePropertiesOperationCompleted == null)
			{
				this.GetSearchablePropertiesOperationCompleted = new SendOrPostCallback(this.OnGetSearchablePropertiesOperationCompleted);
			}
			base.InvokeAsync("GetSearchableProperties", new object[0], this.GetSearchablePropertiesOperationCompleted, userState);
		}
		private void OnGetSearchablePropertiesOperationCompleted(object arg)
		{
			if (this.GetSearchablePropertiesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetSearchablePropertiesCompleted(this, new GetSearchablePropertiesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ExecuteSearch", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/ExecuteSearch", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public DataSet ExecuteSearch(string entityType, XmlElement searchClause, SearchOptions searchOptions, bool includePerformanceData)
		{
			object[] array = base.Invoke("ExecuteSearch", new object[]
			{
				entityType,
				searchClause,
				searchOptions,
				includePerformanceData
			});
			return (DataSet)array[0];
		}
		public void ExecuteSearchAsync(string entityType, XmlElement searchClause, SearchOptions searchOptions, bool includePerformanceData)
		{
			this.ExecuteSearchAsync(entityType, searchClause, searchOptions, includePerformanceData, null);
		}
		public void ExecuteSearchAsync(string entityType, XmlElement searchClause, SearchOptions searchOptions, bool includePerformanceData, object userState)
		{
			if (this.ExecuteSearchOperationCompleted == null)
			{
				this.ExecuteSearchOperationCompleted = new SendOrPostCallback(this.OnExecuteSearchOperationCompleted);
			}
			base.InvokeAsync("ExecuteSearch", new object[]
			{
				entityType,
				searchClause,
				searchOptions,
				includePerformanceData
			}, this.ExecuteSearchOperationCompleted, userState);
		}
		private void OnExecuteSearchOperationCompleted(object arg)
		{
			if (this.ExecuteSearchCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.ExecuteSearchCompleted(this, new ExecuteSearchCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ExecuteSearchWithCount", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/ExecuteSearchWithCount", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public DataSet ExecuteSearchWithCount(string entityType, XmlElement searchClause, SearchOptions searchOptions, bool includePerformanceData, out int recordsMatched)
		{
			object[] array = base.Invoke("ExecuteSearchWithCount", new object[]
			{
				entityType,
				searchClause,
				searchOptions,
				includePerformanceData
			});
			recordsMatched = (int)array[1];
			return (DataSet)array[0];
		}
		public void ExecuteSearchWithCountAsync(string entityType, XmlElement searchClause, SearchOptions searchOptions, bool includePerformanceData)
		{
			this.ExecuteSearchWithCountAsync(entityType, searchClause, searchOptions, includePerformanceData, null);
		}
		public void ExecuteSearchWithCountAsync(string entityType, XmlElement searchClause, SearchOptions searchOptions, bool includePerformanceData, object userState)
		{
			if (this.ExecuteSearchWithCountOperationCompleted == null)
			{
				this.ExecuteSearchWithCountOperationCompleted = new SendOrPostCallback(this.OnExecuteSearchWithCountOperationCompleted);
			}
			base.InvokeAsync("ExecuteSearchWithCount", new object[]
			{
				entityType,
				searchClause,
				searchOptions,
				includePerformanceData
			}, this.ExecuteSearchWithCountOperationCompleted, userState);
		}
		private void OnExecuteSearchWithCountOperationCompleted(object arg)
		{
			if (this.ExecuteSearchWithCountCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.ExecuteSearchWithCountCompleted(this, new ExecuteSearchWithCountCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetCustomer", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetCustomer", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Customer", IsNullable = true)]
		public CustomerData GetCustomer(int customerId)
		{
			object[] array = base.Invoke("GetCustomer", new object[]
			{
				customerId
			});
			return (CustomerData)array[0];
		}
		public void GetCustomerAsync(int customerId)
		{
			this.GetCustomerAsync(customerId, null);
		}
		public void GetCustomerAsync(int customerId, object userState)
		{
			if (this.GetCustomerOperationCompleted == null)
			{
				this.GetCustomerOperationCompleted = new SendOrPostCallback(this.OnGetCustomerOperationCompleted);
			}
			base.InvokeAsync("GetCustomer", new object[]
			{
				customerId
			}, this.GetCustomerOperationCompleted, userState);
		}
		private void OnGetCustomerOperationCompleted(object arg)
		{
			if (this.GetCustomerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetCustomerCompleted(this, new GetCustomerCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/NewCustomer", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/NewCustomer", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Customer", IsNullable = true)]
		public CustomerData NewCustomer()
		{
			object[] array = base.Invoke("NewCustomer", new object[0]);
			return (CustomerData)array[0];
		}
		public void NewCustomerAsync()
		{
			this.NewCustomerAsync(null);
		}
		public void NewCustomerAsync(object userState)
		{
			if (this.NewCustomerOperationCompleted == null)
			{
				this.NewCustomerOperationCompleted = new SendOrPostCallback(this.OnNewCustomerOperationCompleted);
			}
			base.InvokeAsync("NewCustomer", new object[0], this.NewCustomerOperationCompleted, userState);
		}
		private void OnNewCustomerOperationCompleted(object arg)
		{
			if (this.NewCustomerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.NewCustomerCompleted(this, new NewCustomerCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveCustomer", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveCustomer", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveCustomer([XmlElement(IsNullable = true)] ref CustomerData Customer, bool forceOverwrite)
		{
			object[] array = base.Invoke("SaveCustomer", new object[]
			{
				Customer,
				forceOverwrite
			});
			Customer = (CustomerData)array[0];
		}
		public void SaveCustomerAsync(CustomerData Customer, bool forceOverwrite)
		{
			this.SaveCustomerAsync(Customer, forceOverwrite, null);
		}
		public void SaveCustomerAsync(CustomerData Customer, bool forceOverwrite, object userState)
		{
			if (this.SaveCustomerOperationCompleted == null)
			{
				this.SaveCustomerOperationCompleted = new SendOrPostCallback(this.OnSaveCustomerOperationCompleted);
			}
			base.InvokeAsync("SaveCustomer", new object[]
			{
				Customer,
				forceOverwrite
			}, this.SaveCustomerOperationCompleted, userState);
		}
		private void OnSaveCustomerOperationCompleted(object arg)
		{
			if (this.SaveCustomerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveCustomerCompleted(this, new SaveCustomerCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteCustomer", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteCustomer", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteCustomer(int customerId)
		{
			base.Invoke("DeleteCustomer", new object[]
			{
				customerId
			});
		}
		public void DeleteCustomerAsync(int customerId)
		{
			this.DeleteCustomerAsync(customerId, null);
		}
		public void DeleteCustomerAsync(int customerId, object userState)
		{
			if (this.DeleteCustomerOperationCompleted == null)
			{
				this.DeleteCustomerOperationCompleted = new SendOrPostCallback(this.OnDeleteCustomerOperationCompleted);
			}
			base.InvokeAsync("DeleteCustomer", new object[]
			{
				customerId
			}, this.DeleteCustomerOperationCompleted, userState);
		}
		private void OnDeleteCustomerOperationCompleted(object arg)
		{
			if (this.DeleteCustomerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteCustomerCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/RestoreCustomer", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/RestoreCustomer", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void RestoreCustomer(int customerId, string newCustomerName)
		{
			base.Invoke("RestoreCustomer", new object[]
			{
				customerId,
				newCustomerName
			});
		}
		public void RestoreCustomerAsync(int customerId, string newCustomerName)
		{
			this.RestoreCustomerAsync(customerId, newCustomerName, null);
		}
		public void RestoreCustomerAsync(int customerId, string newCustomerName, object userState)
		{
			if (this.RestoreCustomerOperationCompleted == null)
			{
				this.RestoreCustomerOperationCompleted = new SendOrPostCallback(this.OnRestoreCustomerOperationCompleted);
			}
			base.InvokeAsync("RestoreCustomer", new object[]
			{
				customerId,
				newCustomerName
			}, this.RestoreCustomerOperationCompleted, userState);
		}
		private void OnRestoreCustomerOperationCompleted(object arg)
		{
			if (this.RestoreCustomerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.RestoreCustomerCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Campaign", IsNullable = true)]
		public CampaignData GetCampaign(int campaignId)
		{
			object[] array = base.Invoke("GetCampaign", new object[]
			{
				campaignId
			});
			return (CampaignData)array[0];
		}
		public void GetCampaignAsync(int campaignId)
		{
			this.GetCampaignAsync(campaignId, null);
		}
		public void GetCampaignAsync(int campaignId, object userState)
		{
			if (this.GetCampaignOperationCompleted == null)
			{
				this.GetCampaignOperationCompleted = new SendOrPostCallback(this.OnGetCampaignOperationCompleted);
			}
			base.InvokeAsync("GetCampaign", new object[]
			{
				campaignId
			}, this.GetCampaignOperationCompleted, userState);
		}
		private void OnGetCampaignOperationCompleted(object arg)
		{
			if (this.GetCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetCampaignCompleted(this, new GetCampaignCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/NewCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/NewCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Campaign", IsNullable = true)]
		public CampaignData NewCampaign(int parentCustomerId)
		{
			object[] array = base.Invoke("NewCampaign", new object[]
			{
				parentCustomerId
			});
			return (CampaignData)array[0];
		}
		public void NewCampaignAsync(int parentCustomerId)
		{
			this.NewCampaignAsync(parentCustomerId, null);
		}
		public void NewCampaignAsync(int parentCustomerId, object userState)
		{
			if (this.NewCampaignOperationCompleted == null)
			{
				this.NewCampaignOperationCompleted = new SendOrPostCallback(this.OnNewCampaignOperationCompleted);
			}
			base.InvokeAsync("NewCampaign", new object[]
			{
				parentCustomerId
			}, this.NewCampaignOperationCompleted, userState);
		}
		private void OnNewCampaignOperationCompleted(object arg)
		{
			if (this.NewCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.NewCampaignCompleted(this, new NewCampaignCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveCampaign([XmlElement(IsNullable = true)] ref CampaignData Campaign, bool forceOverwrite)
		{
			object[] array = base.Invoke("SaveCampaign", new object[]
			{
				Campaign,
				forceOverwrite
			});
			Campaign = (CampaignData)array[0];
		}
		public void SaveCampaignAsync(CampaignData Campaign, bool forceOverwrite)
		{
			this.SaveCampaignAsync(Campaign, forceOverwrite, null);
		}
		public void SaveCampaignAsync(CampaignData Campaign, bool forceOverwrite, object userState)
		{
			if (this.SaveCampaignOperationCompleted == null)
			{
				this.SaveCampaignOperationCompleted = new SendOrPostCallback(this.OnSaveCampaignOperationCompleted);
			}
			base.InvokeAsync("SaveCampaign", new object[]
			{
				Campaign,
				forceOverwrite
			}, this.SaveCampaignOperationCompleted, userState);
		}
		private void OnSaveCampaignOperationCompleted(object arg)
		{
			if (this.SaveCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveCampaignCompleted(this, new SaveCampaignCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ActivateCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/ActivateCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void ActivateCampaign(int campaignId, bool active, DateTime timestamp)
		{
			base.Invoke("ActivateCampaign", new object[]
			{
				campaignId,
				active,
				timestamp
			});
		}
		public void ActivateCampaignAsync(int campaignId, bool active, DateTime timestamp)
		{
			this.ActivateCampaignAsync(campaignId, active, timestamp, null);
		}
		public void ActivateCampaignAsync(int campaignId, bool active, DateTime timestamp, object userState)
		{
			if (this.ActivateCampaignOperationCompleted == null)
			{
				this.ActivateCampaignOperationCompleted = new SendOrPostCallback(this.OnActivateCampaignOperationCompleted);
			}
			base.InvokeAsync("ActivateCampaign", new object[]
			{
				campaignId,
				active,
				timestamp
			}, this.ActivateCampaignOperationCompleted, userState);
		}
		private void OnActivateCampaignOperationCompleted(object arg)
		{
			if (this.ActivateCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.ActivateCampaignCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteCampaign(int campaignId)
		{
			base.Invoke("DeleteCampaign", new object[]
			{
				campaignId
			});
		}
		public void DeleteCampaignAsync(int campaignId)
		{
			this.DeleteCampaignAsync(campaignId, null);
		}
		public void DeleteCampaignAsync(int campaignId, object userState)
		{
			if (this.DeleteCampaignOperationCompleted == null)
			{
				this.DeleteCampaignOperationCompleted = new SendOrPostCallback(this.OnDeleteCampaignOperationCompleted);
			}
			base.InvokeAsync("DeleteCampaign", new object[]
			{
				campaignId
			}, this.DeleteCampaignOperationCompleted, userState);
		}
		private void OnDeleteCampaignOperationCompleted(object arg)
		{
			if (this.DeleteCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteCampaignCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/RestoreCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/RestoreCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void RestoreCampaign(int campaignId, int newParentCustomerId, string newCampaignName)
		{
			base.Invoke("RestoreCampaign", new object[]
			{
				campaignId,
				newParentCustomerId,
				newCampaignName
			});
		}
		public void RestoreCampaignAsync(int campaignId, int newParentCustomerId, string newCampaignName)
		{
			this.RestoreCampaignAsync(campaignId, newParentCustomerId, newCampaignName, null);
		}
		public void RestoreCampaignAsync(int campaignId, int newParentCustomerId, string newCampaignName, object userState)
		{
			if (this.RestoreCampaignOperationCompleted == null)
			{
				this.RestoreCampaignOperationCompleted = new SendOrPostCallback(this.OnRestoreCampaignOperationCompleted);
			}
			base.InvokeAsync("RestoreCampaign", new object[]
			{
				campaignId,
				newParentCustomerId,
				newCampaignName
			}, this.RestoreCampaignOperationCompleted, userState);
		}
		private void OnRestoreCampaignOperationCompleted(object arg)
		{
			if (this.RestoreCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.RestoreCampaignCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/MoveCampaignToCustomer", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/MoveCampaignToCustomer", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void MoveCampaignToCustomer(int campaignId, int newParentCustomerId)
		{
			base.Invoke("MoveCampaignToCustomer", new object[]
			{
				campaignId,
				newParentCustomerId
			});
		}
		public void MoveCampaignToCustomerAsync(int campaignId, int newParentCustomerId)
		{
			this.MoveCampaignToCustomerAsync(campaignId, newParentCustomerId, null);
		}
		public void MoveCampaignToCustomerAsync(int campaignId, int newParentCustomerId, object userState)
		{
			if (this.MoveCampaignToCustomerOperationCompleted == null)
			{
				this.MoveCampaignToCustomerOperationCompleted = new SendOrPostCallback(this.OnMoveCampaignToCustomerOperationCompleted);
			}
			base.InvokeAsync("MoveCampaignToCustomer", new object[]
			{
				campaignId,
				newParentCustomerId
			}, this.MoveCampaignToCustomerOperationCompleted, userState);
		}
		private void OnMoveCampaignToCustomerOperationCompleted(object arg)
		{
			if (this.MoveCampaignToCustomerCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.MoveCampaignToCustomerCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/NewCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/NewCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("CampaignItem", IsNullable = true)]
		public CampaignItemData NewCampaignItem(CampaignItemType campaignItemType, int parentCampaignId)
		{
			object[] array = base.Invoke("NewCampaignItem", new object[]
			{
				campaignItemType,
				parentCampaignId
			});
			return (CampaignItemData)array[0];
		}
		public void NewCampaignItemAsync(CampaignItemType campaignItemType, int parentCampaignId)
		{
			this.NewCampaignItemAsync(campaignItemType, parentCampaignId, null);
		}
		public void NewCampaignItemAsync(CampaignItemType campaignItemType, int parentCampaignId, object userState)
		{
			if (this.NewCampaignItemOperationCompleted == null)
			{
				this.NewCampaignItemOperationCompleted = new SendOrPostCallback(this.OnNewCampaignItemOperationCompleted);
			}
			base.InvokeAsync("NewCampaignItem", new object[]
			{
				campaignItemType,
				parentCampaignId
			}, this.NewCampaignItemOperationCompleted, userState);
		}
		private void OnNewCampaignItemOperationCompleted(object arg)
		{
			if (this.NewCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.NewCampaignItemCompleted(this, new NewCampaignItemCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("CampaignItem", IsNullable = true)]
		public CampaignItemData GetCampaignItem(int campaignItemId)
		{
			object[] array = base.Invoke("GetCampaignItem", new object[]
			{
				campaignItemId
			});
			return (CampaignItemData)array[0];
		}
		public void GetCampaignItemAsync(int campaignItemId)
		{
			this.GetCampaignItemAsync(campaignItemId, null);
		}
		public void GetCampaignItemAsync(int campaignItemId, object userState)
		{
			if (this.GetCampaignItemOperationCompleted == null)
			{
				this.GetCampaignItemOperationCompleted = new SendOrPostCallback(this.OnGetCampaignItemOperationCompleted);
			}
			base.InvokeAsync("GetCampaignItem", new object[]
			{
				campaignItemId
			}, this.GetCampaignItemOperationCompleted, userState);
		}
		private void OnGetCampaignItemOperationCompleted(object arg)
		{
			if (this.GetCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetCampaignItemCompleted(this, new GetCampaignItemCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/TestDirectMail", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/TestDirectMail", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void TestDirectMail(int campaignItemId)
		{
			base.Invoke("TestDirectMail", new object[]
			{
				campaignItemId
			});
		}
		public void TestDirectMailAsync(int campaignItemId)
		{
			this.TestDirectMailAsync(campaignItemId, null);
		}
		public void TestDirectMailAsync(int campaignItemId, object userState)
		{
			if (this.TestDirectMailOperationCompleted == null)
			{
				this.TestDirectMailOperationCompleted = new SendOrPostCallback(this.OnTestDirectMailOperationCompleted);
			}
			base.InvokeAsync("TestDirectMail", new object[]
			{
				campaignItemId
			}, this.TestDirectMailOperationCompleted, userState);
		}
		private void OnTestDirectMailOperationCompleted(object arg)
		{
			if (this.TestDirectMailCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.TestDirectMailCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveCampaignItem([XmlElement(IsNullable = true)] ref CampaignItemData CampaignItem, bool forceOverwrite)
		{
			object[] array = base.Invoke("SaveCampaignItem", new object[]
			{
				CampaignItem,
				forceOverwrite
			});
			CampaignItem = (CampaignItemData)array[0];
		}
		public void SaveCampaignItemAsync(CampaignItemData CampaignItem, bool forceOverwrite)
		{
			this.SaveCampaignItemAsync(CampaignItem, forceOverwrite, null);
		}
		public void SaveCampaignItemAsync(CampaignItemData CampaignItem, bool forceOverwrite, object userState)
		{
			if (this.SaveCampaignItemOperationCompleted == null)
			{
				this.SaveCampaignItemOperationCompleted = new SendOrPostCallback(this.OnSaveCampaignItemOperationCompleted);
			}
			base.InvokeAsync("SaveCampaignItem", new object[]
			{
				CampaignItem,
				forceOverwrite
			}, this.SaveCampaignItemOperationCompleted, userState);
		}
		private void OnSaveCampaignItemOperationCompleted(object arg)
		{
			if (this.SaveCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveCampaignItemCompleted(this, new SaveCampaignItemCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/CopyCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/CopyCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("CampaignItem", IsNullable = true)]
		public CampaignItemData CopyCampaignItem(int campaignItemId, int newParentCampaignId)
		{
			object[] array = base.Invoke("CopyCampaignItem", new object[]
			{
				campaignItemId,
				newParentCampaignId
			});
			return (CampaignItemData)array[0];
		}
		public void CopyCampaignItemAsync(int campaignItemId, int newParentCampaignId)
		{
			this.CopyCampaignItemAsync(campaignItemId, newParentCampaignId, null);
		}
		public void CopyCampaignItemAsync(int campaignItemId, int newParentCampaignId, object userState)
		{
			if (this.CopyCampaignItemOperationCompleted == null)
			{
				this.CopyCampaignItemOperationCompleted = new SendOrPostCallback(this.OnCopyCampaignItemOperationCompleted);
			}
			base.InvokeAsync("CopyCampaignItem", new object[]
			{
				campaignItemId,
				newParentCampaignId
			}, this.CopyCampaignItemOperationCompleted, userState);
		}
		private void OnCopyCampaignItemOperationCompleted(object arg)
		{
			if (this.CopyCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.CopyCampaignItemCompleted(this, new CopyCampaignItemCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteCampaignItem(int campaignItemId)
		{
			base.Invoke("DeleteCampaignItem", new object[]
			{
				campaignItemId
			});
		}
		public void DeleteCampaignItemAsync(int campaignItemId)
		{
			this.DeleteCampaignItemAsync(campaignItemId, null);
		}
		public void DeleteCampaignItemAsync(int campaignItemId, object userState)
		{
			if (this.DeleteCampaignItemOperationCompleted == null)
			{
				this.DeleteCampaignItemOperationCompleted = new SendOrPostCallback(this.OnDeleteCampaignItemOperationCompleted);
			}
			base.InvokeAsync("DeleteCampaignItem", new object[]
			{
				campaignItemId
			}, this.DeleteCampaignItemOperationCompleted, userState);
		}
		private void OnDeleteCampaignItemOperationCompleted(object arg)
		{
			if (this.DeleteCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteCampaignItemCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/RestoreCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/RestoreCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void RestoreCampaignItem(int campaignItemId, int newParentCampaignId, string newCampaignItemName)
		{
			base.Invoke("RestoreCampaignItem", new object[]
			{
				campaignItemId,
				newParentCampaignId,
				newCampaignItemName
			});
		}
		public void RestoreCampaignItemAsync(int campaignItemId, int newParentCampaignId, string newCampaignItemName)
		{
			this.RestoreCampaignItemAsync(campaignItemId, newParentCampaignId, newCampaignItemName, null);
		}
		public void RestoreCampaignItemAsync(int campaignItemId, int newParentCampaignId, string newCampaignItemName, object userState)
		{
			if (this.RestoreCampaignItemOperationCompleted == null)
			{
				this.RestoreCampaignItemOperationCompleted = new SendOrPostCallback(this.OnRestoreCampaignItemOperationCompleted);
			}
			base.InvokeAsync("RestoreCampaignItem", new object[]
			{
				campaignItemId,
				newParentCampaignId,
				newCampaignItemName
			}, this.RestoreCampaignItemOperationCompleted, userState);
		}
		private void OnRestoreCampaignItemOperationCompleted(object arg)
		{
			if (this.RestoreCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.RestoreCampaignItemCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/MoveCampaignItemToCampaign", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/MoveCampaignItemToCampaign", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void MoveCampaignItemToCampaign(int campaignItemId, int newParentCampaignId)
		{
			base.Invoke("MoveCampaignItemToCampaign", new object[]
			{
				campaignItemId,
				newParentCampaignId
			});
		}
		public void MoveCampaignItemToCampaignAsync(int campaignItemId, int newParentCampaignId)
		{
			this.MoveCampaignItemToCampaignAsync(campaignItemId, newParentCampaignId, null);
		}
		public void MoveCampaignItemToCampaignAsync(int campaignItemId, int newParentCampaignId, object userState)
		{
			if (this.MoveCampaignItemToCampaignOperationCompleted == null)
			{
				this.MoveCampaignItemToCampaignOperationCompleted = new SendOrPostCallback(this.OnMoveCampaignItemToCampaignOperationCompleted);
			}
			base.InvokeAsync("MoveCampaignItemToCampaign", new object[]
			{
				campaignItemId,
				newParentCampaignId
			}, this.MoveCampaignItemToCampaignOperationCompleted, userState);
		}
		private void OnMoveCampaignItemToCampaignOperationCompleted(object arg)
		{
			if (this.MoveCampaignItemToCampaignCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.MoveCampaignItemToCampaignCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ActivateCampaignItem", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/ActivateCampaignItem", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void ActivateCampaignItem(int campaignItemId, bool active, DateTime timestamp)
		{
			base.Invoke("ActivateCampaignItem", new object[]
			{
				campaignItemId,
				active,
				timestamp
			});
		}
		public void ActivateCampaignItemAsync(int campaignItemId, bool active, DateTime timestamp)
		{
			this.ActivateCampaignItemAsync(campaignItemId, active, timestamp, null);
		}
		public void ActivateCampaignItemAsync(int campaignItemId, bool active, DateTime timestamp, object userState)
		{
			if (this.ActivateCampaignItemOperationCompleted == null)
			{
				this.ActivateCampaignItemOperationCompleted = new SendOrPostCallback(this.OnActivateCampaignItemOperationCompleted);
			}
			base.InvokeAsync("ActivateCampaignItem", new object[]
			{
				campaignItemId,
				active,
				timestamp
			}, this.ActivateCampaignItemOperationCompleted, userState);
		}
		private void OnActivateCampaignItemOperationCompleted(object arg)
		{
			if (this.ActivateCampaignItemCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.ActivateCampaignItemCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GenerateCampaignItemPreview", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GenerateCampaignItemPreview", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public string GenerateCampaignItemPreview(string templateName, DisplayPropertyValueData[] propertyValues)
		{
			object[] array = base.Invoke("GenerateCampaignItemPreview", new object[]
			{
				templateName,
				propertyValues
			});
			return (string)array[0];
		}
		public void GenerateCampaignItemPreviewAsync(string templateName, DisplayPropertyValueData[] propertyValues)
		{
			this.GenerateCampaignItemPreviewAsync(templateName, propertyValues, null);
		}
		public void GenerateCampaignItemPreviewAsync(string templateName, DisplayPropertyValueData[] propertyValues, object userState)
		{
			if (this.GenerateCampaignItemPreviewOperationCompleted == null)
			{
				this.GenerateCampaignItemPreviewOperationCompleted = new SendOrPostCallback(this.OnGenerateCampaignItemPreviewOperationCompleted);
			}
			base.InvokeAsync("GenerateCampaignItemPreview", new object[]
			{
				templateName,
				propertyValues
			}, this.GenerateCampaignItemPreviewOperationCompleted, userState);
		}
		private void OnGenerateCampaignItemPreviewOperationCompleted(object arg)
		{
			if (this.GenerateCampaignItemPreviewCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GenerateCampaignItemPreviewCompleted(this, new GenerateCampaignItemPreviewCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/NewExpression", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/NewExpression", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Expression", IsNullable = true)]
		public ExpressionData NewExpression()
		{
			object[] array = base.Invoke("NewExpression", new object[0]);
			return (ExpressionData)array[0];
		}
		public void NewExpressionAsync()
		{
			this.NewExpressionAsync(null);
		}
		public void NewExpressionAsync(object userState)
		{
			if (this.NewExpressionOperationCompleted == null)
			{
				this.NewExpressionOperationCompleted = new SendOrPostCallback(this.OnNewExpressionOperationCompleted);
			}
			base.InvokeAsync("NewExpression", new object[0], this.NewExpressionOperationCompleted, userState);
		}
		private void OnNewExpressionOperationCompleted(object arg)
		{
			if (this.NewExpressionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.NewExpressionCompleted(this, new NewExpressionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetExpression", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetExpression", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Expression", IsNullable = true)]
		public ExpressionData GetExpression(int expressionId)
		{
			object[] array = base.Invoke("GetExpression", new object[]
			{
				expressionId
			});
			return (ExpressionData)array[0];
		}
		public void GetExpressionAsync(int expressionId)
		{
			this.GetExpressionAsync(expressionId, null);
		}
		public void GetExpressionAsync(int expressionId, object userState)
		{
			if (this.GetExpressionOperationCompleted == null)
			{
				this.GetExpressionOperationCompleted = new SendOrPostCallback(this.OnGetExpressionOperationCompleted);
			}
			base.InvokeAsync("GetExpression", new object[]
			{
				expressionId
			}, this.GetExpressionOperationCompleted, userState);
		}
		private void OnGetExpressionOperationCompleted(object arg)
		{
			if (this.GetExpressionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetExpressionCompleted(this, new GetExpressionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveExpression", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveExpression", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveExpression([XmlElement(IsNullable = true)] ref ExpressionData Expression, bool forceOverwrite)
		{
			object[] array = base.Invoke("SaveExpression", new object[]
			{
				Expression,
				forceOverwrite
			});
			Expression = (ExpressionData)array[0];
		}
		public void SaveExpressionAsync(ExpressionData Expression, bool forceOverwrite)
		{
			this.SaveExpressionAsync(Expression, forceOverwrite, null);
		}
		public void SaveExpressionAsync(ExpressionData Expression, bool forceOverwrite, object userState)
		{
			if (this.SaveExpressionOperationCompleted == null)
			{
				this.SaveExpressionOperationCompleted = new SendOrPostCallback(this.OnSaveExpressionOperationCompleted);
			}
			base.InvokeAsync("SaveExpression", new object[]
			{
				Expression,
				forceOverwrite
			}, this.SaveExpressionOperationCompleted, userState);
		}
		private void OnSaveExpressionOperationCompleted(object arg)
		{
			if (this.SaveExpressionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveExpressionCompleted(this, new SaveExpressionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/CopyExpression", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/CopyExpression", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("Expression", IsNullable = true)]
		public ExpressionData CopyExpression(int expressionId)
		{
			object[] array = base.Invoke("CopyExpression", new object[]
			{
				expressionId
			});
			return (ExpressionData)array[0];
		}
		public void CopyExpressionAsync(int expressionId)
		{
			this.CopyExpressionAsync(expressionId, null);
		}
		public void CopyExpressionAsync(int expressionId, object userState)
		{
			if (this.CopyExpressionOperationCompleted == null)
			{
				this.CopyExpressionOperationCompleted = new SendOrPostCallback(this.OnCopyExpressionOperationCompleted);
			}
			base.InvokeAsync("CopyExpression", new object[]
			{
				expressionId
			}, this.CopyExpressionOperationCompleted, userState);
		}
		private void OnCopyExpressionOperationCompleted(object arg)
		{
			if (this.CopyExpressionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.CopyExpressionCompleted(this, new CopyExpressionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteExpression", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteExpression", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteExpression(int expressionId)
		{
			base.Invoke("DeleteExpression", new object[]
			{
				expressionId
			});
		}
		public void DeleteExpressionAsync(int expressionId)
		{
			this.DeleteExpressionAsync(expressionId, null);
		}
		public void DeleteExpressionAsync(int expressionId, object userState)
		{
			if (this.DeleteExpressionOperationCompleted == null)
			{
				this.DeleteExpressionOperationCompleted = new SendOrPostCallback(this.OnDeleteExpressionOperationCompleted);
			}
			base.InvokeAsync("DeleteExpression", new object[]
			{
				expressionId
			}, this.DeleteExpressionOperationCompleted, userState);
		}
		private void OnDeleteExpressionOperationCompleted(object arg)
		{
			if (this.DeleteExpressionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteExpressionCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllExpressionCategories", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllExpressionCategories", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public ExpressionCategorySet GetAllExpressionCategories()
		{
			object[] array = base.Invoke("GetAllExpressionCategories", new object[0]);
			return (ExpressionCategorySet)array[0];
		}
		public void GetAllExpressionCategoriesAsync()
		{
			this.GetAllExpressionCategoriesAsync(null);
		}
		public void GetAllExpressionCategoriesAsync(object userState)
		{
			if (this.GetAllExpressionCategoriesOperationCompleted == null)
			{
				this.GetAllExpressionCategoriesOperationCompleted = new SendOrPostCallback(this.OnGetAllExpressionCategoriesOperationCompleted);
			}
			base.InvokeAsync("GetAllExpressionCategories", new object[0], this.GetAllExpressionCategoriesOperationCompleted, userState);
		}
		private void OnGetAllExpressionCategoriesOperationCompleted(object arg)
		{
			if (this.GetAllExpressionCategoriesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllExpressionCategoriesCompleted(this, new GetAllExpressionCategoriesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveExpressionCategories", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveExpressionCategories", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveExpressionCategories(ExpressionCategorySet expressionCategorySet)
		{
			base.Invoke("SaveExpressionCategories", new object[]
			{
				expressionCategorySet
			});
		}
		public void SaveExpressionCategoriesAsync(ExpressionCategorySet expressionCategorySet)
		{
			this.SaveExpressionCategoriesAsync(expressionCategorySet, null);
		}
		public void SaveExpressionCategoriesAsync(ExpressionCategorySet expressionCategorySet, object userState)
		{
			if (this.SaveExpressionCategoriesOperationCompleted == null)
			{
				this.SaveExpressionCategoriesOperationCompleted = new SendOrPostCallback(this.OnSaveExpressionCategoriesOperationCompleted);
			}
			base.InvokeAsync("SaveExpressionCategories", new object[]
			{
				expressionCategorySet
			}, this.SaveExpressionCategoriesOperationCompleted, userState);
		}
		private void OnSaveExpressionCategoriesOperationCompleted(object arg)
		{
			if (this.SaveExpressionCategoriesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveExpressionCategoriesCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetProfileDefinitions", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetProfileDefinitions", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

#if MS
		[return: XmlElement(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/ProfileDefinitions")]
#else
		[return: XmlElement(Namespace = "http://schemas.commerceserver.net/2013/01/ProfileDefinitions")]
#endif

		public XmlElement GetProfileDefinitions(string[] profileNames)
		{
			object[] array = base.Invoke("GetProfileDefinitions", new object[]
			{
				profileNames
			});
			return (XmlElement)array[0];
		}
		public void GetProfileDefinitionsAsync(string[] profileNames)
		{
			this.GetProfileDefinitionsAsync(profileNames, null);
		}
		public void GetProfileDefinitionsAsync(string[] profileNames, object userState)
		{
			if (this.GetProfileDefinitionsOperationCompleted == null)
			{
				this.GetProfileDefinitionsOperationCompleted = new SendOrPostCallback(this.OnGetProfileDefinitionsOperationCompleted);
			}
			base.InvokeAsync("GetProfileDefinitions", new object[]
			{
				profileNames
			}, this.GetProfileDefinitionsOperationCompleted, userState);
		}
		private void OnGetProfileDefinitionsOperationCompleted(object arg)
		{
			if (this.GetProfileDefinitionsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetProfileDefinitionsCompleted(this, new GetProfileDefinitionsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetSiteTerms", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetSiteTerms", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

#if MS
		[return: XmlElement(Namespace = "http://schemas.microsoft.com/CommerceServer/2006/06/SiteTerms")]
#else
		[return: XmlElement(Namespace = "http://schemas.commerceserver.net/2013/01/SiteTerms")]
#endif

		public XmlElement GetSiteTerms()
		{
			object[] array = base.Invoke("GetSiteTerms", new object[0]);
			return (XmlElement)array[0];
		}
		public void GetSiteTermsAsync()
		{
			this.GetSiteTermsAsync(null);
		}
		public void GetSiteTermsAsync(object userState)
		{
			if (this.GetSiteTermsOperationCompleted == null)
			{
				this.GetSiteTermsOperationCompleted = new SendOrPostCallback(this.OnGetSiteTermsOperationCompleted);
			}
			base.InvokeAsync("GetSiteTerms", new object[0], this.GetSiteTermsOperationCompleted, userState);
		}
		private void OnGetSiteTermsOperationCompleted(object arg)
		{
			if (this.GetSiteTermsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetSiteTermsCompleted(this, new GetSiteTermsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/UpdateDiscountPriorities", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/UpdateDiscountPriorities", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void UpdateDiscountPriorities(DiscountPrioritySet discountPrioritySet)
		{
			base.Invoke("UpdateDiscountPriorities", new object[]
			{
				discountPrioritySet
			});
		}
		public void UpdateDiscountPrioritiesAsync(DiscountPrioritySet discountPrioritySet)
		{
			this.UpdateDiscountPrioritiesAsync(discountPrioritySet, null);
		}
		public void UpdateDiscountPrioritiesAsync(DiscountPrioritySet discountPrioritySet, object userState)
		{
			if (this.UpdateDiscountPrioritiesOperationCompleted == null)
			{
				this.UpdateDiscountPrioritiesOperationCompleted = new SendOrPostCallback(this.OnUpdateDiscountPrioritiesOperationCompleted);
			}
			base.InvokeAsync("UpdateDiscountPriorities", new object[]
			{
				discountPrioritySet
			}, this.UpdateDiscountPrioritiesOperationCompleted, userState);
		}
		private void OnUpdateDiscountPrioritiesOperationCompleted(object arg)
		{
			if (this.UpdateDiscountPrioritiesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.UpdateDiscountPrioritiesCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/PrioritizeDiscount", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/PrioritizeDiscount", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void PrioritizeDiscount(int campaignItemId, int newPriority, PrioritizeOption prioritizeOption)
		{
			base.Invoke("PrioritizeDiscount", new object[]
			{
				campaignItemId,
				newPriority,
				prioritizeOption
			});
		}
		public void PrioritizeDiscountAsync(int campaignItemId, int newPriority, PrioritizeOption prioritizeOption)
		{
			this.PrioritizeDiscountAsync(campaignItemId, newPriority, prioritizeOption, null);
		}
		public void PrioritizeDiscountAsync(int campaignItemId, int newPriority, PrioritizeOption prioritizeOption, object userState)
		{
			if (this.PrioritizeDiscountOperationCompleted == null)
			{
				this.PrioritizeDiscountOperationCompleted = new SendOrPostCallback(this.OnPrioritizeDiscountOperationCompleted);
			}
			base.InvokeAsync("PrioritizeDiscount", new object[]
			{
				campaignItemId,
				newPriority,
				prioritizeOption
			}, this.PrioritizeDiscountOperationCompleted, userState);
		}
		private void OnPrioritizeDiscountOperationCompleted(object arg)
		{
			if (this.PrioritizeDiscountCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.PrioritizeDiscountCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetDisplaySize", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetDisplaySize", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("DisplaySize", IsNullable = true)]
		public DisplaySizeData GetDisplaySize(int displaySizeId)
		{
			object[] array = base.Invoke("GetDisplaySize", new object[]
			{
				displaySizeId
			});
			return (DisplaySizeData)array[0];
		}
		public void GetDisplaySizeAsync(int displaySizeId)
		{
			this.GetDisplaySizeAsync(displaySizeId, null);
		}
		public void GetDisplaySizeAsync(int displaySizeId, object userState)
		{
			if (this.GetDisplaySizeOperationCompleted == null)
			{
				this.GetDisplaySizeOperationCompleted = new SendOrPostCallback(this.OnGetDisplaySizeOperationCompleted);
			}
			base.InvokeAsync("GetDisplaySize", new object[]
			{
				displaySizeId
			}, this.GetDisplaySizeOperationCompleted, userState);
		}
		private void OnGetDisplaySizeOperationCompleted(object arg)
		{
			if (this.GetDisplaySizeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetDisplaySizeCompleted(this, new GetDisplaySizeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetDisplaySizeByName", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetDisplaySizeByName", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("DisplaySize", IsNullable = true)]
		public DisplaySizeData GetDisplaySizeByName(string displaySizeName)
		{
			object[] array = base.Invoke("GetDisplaySizeByName", new object[]
			{
				displaySizeName
			});
			return (DisplaySizeData)array[0];
		}
		public void GetDisplaySizeByNameAsync(string displaySizeName)
		{
			this.GetDisplaySizeByNameAsync(displaySizeName, null);
		}
		public void GetDisplaySizeByNameAsync(string displaySizeName, object userState)
		{
			if (this.GetDisplaySizeByNameOperationCompleted == null)
			{
				this.GetDisplaySizeByNameOperationCompleted = new SendOrPostCallback(this.OnGetDisplaySizeByNameOperationCompleted);
			}
			base.InvokeAsync("GetDisplaySizeByName", new object[]
			{
				displaySizeName
			}, this.GetDisplaySizeByNameOperationCompleted, userState);
		}
		private void OnGetDisplaySizeByNameOperationCompleted(object arg)
		{
			if (this.GetDisplaySizeByNameCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetDisplaySizeByNameCompleted(this, new GetDisplaySizeByNameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllDisplaySizes", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllDisplaySizes", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public DisplaySizeData[] GetAllDisplaySizes()
		{
			object[] array = base.Invoke("GetAllDisplaySizes", new object[0]);
			return (DisplaySizeData[])array[0];
		}
		public void GetAllDisplaySizesAsync()
		{
			this.GetAllDisplaySizesAsync(null);
		}
		public void GetAllDisplaySizesAsync(object userState)
		{
			if (this.GetAllDisplaySizesOperationCompleted == null)
			{
				this.GetAllDisplaySizesOperationCompleted = new SendOrPostCallback(this.OnGetAllDisplaySizesOperationCompleted);
			}
			base.InvokeAsync("GetAllDisplaySizes", new object[0], this.GetAllDisplaySizesOperationCompleted, userState);
		}
		private void OnGetAllDisplaySizesOperationCompleted(object arg)
		{
			if (this.GetAllDisplaySizesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllDisplaySizesCompleted(this, new GetAllDisplaySizesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveDisplaySize", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveDisplaySize", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveDisplaySize([XmlElement(IsNullable = true)] ref DisplaySizeData DisplaySize)
		{
			object[] array = base.Invoke("SaveDisplaySize", new object[]
			{
				DisplaySize
			});
			DisplaySize = (DisplaySizeData)array[0];
		}
		public void SaveDisplaySizeAsync(DisplaySizeData DisplaySize)
		{
			this.SaveDisplaySizeAsync(DisplaySize, null);
		}
		public void SaveDisplaySizeAsync(DisplaySizeData DisplaySize, object userState)
		{
			if (this.SaveDisplaySizeOperationCompleted == null)
			{
				this.SaveDisplaySizeOperationCompleted = new SendOrPostCallback(this.OnSaveDisplaySizeOperationCompleted);
			}
			base.InvokeAsync("SaveDisplaySize", new object[]
			{
				DisplaySize
			}, this.SaveDisplaySizeOperationCompleted, userState);
		}
		private void OnSaveDisplaySizeOperationCompleted(object arg)
		{
			if (this.SaveDisplaySizeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveDisplaySizeCompleted(this, new SaveDisplaySizeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteDisplaySize", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteDisplaySize", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteDisplaySize(int displaySizeId)
		{
			base.Invoke("DeleteDisplaySize", new object[]
			{
				displaySizeId
			});
		}
		public void DeleteDisplaySizeAsync(int displaySizeId)
		{
			this.DeleteDisplaySizeAsync(displaySizeId, null);
		}
		public void DeleteDisplaySizeAsync(int displaySizeId, object userState)
		{
			if (this.DeleteDisplaySizeOperationCompleted == null)
			{
				this.DeleteDisplaySizeOperationCompleted = new SendOrPostCallback(this.OnDeleteDisplaySizeOperationCompleted);
			}
			base.InvokeAsync("DeleteDisplaySize", new object[]
			{
				displaySizeId
			}, this.DeleteDisplaySizeOperationCompleted, userState);
		}
		private void OnDeleteDisplaySizeOperationCompleted(object arg)
		{
			if (this.DeleteDisplaySizeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteDisplaySizeCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetPageGroup", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetPageGroup", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("PageGroup", IsNullable = true)]
		public PageGroupData GetPageGroup(int pageGroupId)
		{
			object[] array = base.Invoke("GetPageGroup", new object[]
			{
				pageGroupId
			});
			return (PageGroupData)array[0];
		}
		public void GetPageGroupAsync(int pageGroupId)
		{
			this.GetPageGroupAsync(pageGroupId, null);
		}
		public void GetPageGroupAsync(int pageGroupId, object userState)
		{
			if (this.GetPageGroupOperationCompleted == null)
			{
				this.GetPageGroupOperationCompleted = new SendOrPostCallback(this.OnGetPageGroupOperationCompleted);
			}
			base.InvokeAsync("GetPageGroup", new object[]
			{
				pageGroupId
			}, this.GetPageGroupOperationCompleted, userState);
		}
		private void OnGetPageGroupOperationCompleted(object arg)
		{
			if (this.GetPageGroupCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetPageGroupCompleted(this, new GetPageGroupCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllPageGroups", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllPageGroups", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public PageGroupData[] GetAllPageGroups()
		{
			object[] array = base.Invoke("GetAllPageGroups", new object[0]);
			return (PageGroupData[])array[0];
		}
		public void GetAllPageGroupsAsync()
		{
			this.GetAllPageGroupsAsync(null);
		}
		public void GetAllPageGroupsAsync(object userState)
		{
			if (this.GetAllPageGroupsOperationCompleted == null)
			{
				this.GetAllPageGroupsOperationCompleted = new SendOrPostCallback(this.OnGetAllPageGroupsOperationCompleted);
			}
			base.InvokeAsync("GetAllPageGroups", new object[0], this.GetAllPageGroupsOperationCompleted, userState);
		}
		private void OnGetAllPageGroupsOperationCompleted(object arg)
		{
			if (this.GetAllPageGroupsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllPageGroupsCompleted(this, new GetAllPageGroupsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SavePageGroup", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SavePageGroup", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SavePageGroup([XmlElement(IsNullable = true)] ref PageGroupData PageGroup)
		{
			object[] array = base.Invoke("SavePageGroup", new object[]
			{
				PageGroup
			});
			PageGroup = (PageGroupData)array[0];
		}
		public void SavePageGroupAsync(PageGroupData PageGroup)
		{
			this.SavePageGroupAsync(PageGroup, null);
		}
		public void SavePageGroupAsync(PageGroupData PageGroup, object userState)
		{
			if (this.SavePageGroupOperationCompleted == null)
			{
				this.SavePageGroupOperationCompleted = new SendOrPostCallback(this.OnSavePageGroupOperationCompleted);
			}
			base.InvokeAsync("SavePageGroup", new object[]
			{
				PageGroup
			}, this.SavePageGroupOperationCompleted, userState);
		}
		private void OnSavePageGroupOperationCompleted(object arg)
		{
			if (this.SavePageGroupCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SavePageGroupCompleted(this, new SavePageGroupCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeletePageGroup", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeletePageGroup", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeletePageGroup(int pageGroupId)
		{
			base.Invoke("DeletePageGroup", new object[]
			{
				pageGroupId
			});
		}
		public void DeletePageGroupAsync(int pageGroupId)
		{
			this.DeletePageGroupAsync(pageGroupId, null);
		}
		public void DeletePageGroupAsync(int pageGroupId, object userState)
		{
			if (this.DeletePageGroupOperationCompleted == null)
			{
				this.DeletePageGroupOperationCompleted = new SendOrPostCallback(this.OnDeletePageGroupOperationCompleted);
			}
			base.InvokeAsync("DeletePageGroup", new object[]
			{
				pageGroupId
			}, this.DeletePageGroupOperationCompleted, userState);
		}
		private void OnDeletePageGroupOperationCompleted(object arg)
		{
			if (this.DeletePageGroupCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeletePageGroupCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetDisplayTemplate", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetDisplayTemplate", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("DisplayTemplate", IsNullable = true)]
		public DisplayTemplateData GetDisplayTemplate(int displayTemplateId)
		{
			object[] array = base.Invoke("GetDisplayTemplate", new object[]
			{
				displayTemplateId
			});
			return (DisplayTemplateData)array[0];
		}
		public void GetDisplayTemplateAsync(int displayTemplateId)
		{
			this.GetDisplayTemplateAsync(displayTemplateId, null);
		}
		public void GetDisplayTemplateAsync(int displayTemplateId, object userState)
		{
			if (this.GetDisplayTemplateOperationCompleted == null)
			{
				this.GetDisplayTemplateOperationCompleted = new SendOrPostCallback(this.OnGetDisplayTemplateOperationCompleted);
			}
			base.InvokeAsync("GetDisplayTemplate", new object[]
			{
				displayTemplateId
			}, this.GetDisplayTemplateOperationCompleted, userState);
		}
		private void OnGetDisplayTemplateOperationCompleted(object arg)
		{
			if (this.GetDisplayTemplateCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetDisplayTemplateCompleted(this, new GetDisplayTemplateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetDisplayTemplateByName", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetDisplayTemplateByName", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("DisplayTemplate", IsNullable = true)]
		public DisplayTemplateData GetDisplayTemplateByName(string displayTemplateName)
		{
			object[] array = base.Invoke("GetDisplayTemplateByName", new object[]
			{
				displayTemplateName
			});
			return (DisplayTemplateData)array[0];
		}
		public void GetDisplayTemplateByNameAsync(string displayTemplateName)
		{
			this.GetDisplayTemplateByNameAsync(displayTemplateName, null);
		}
		public void GetDisplayTemplateByNameAsync(string displayTemplateName, object userState)
		{
			if (this.GetDisplayTemplateByNameOperationCompleted == null)
			{
				this.GetDisplayTemplateByNameOperationCompleted = new SendOrPostCallback(this.OnGetDisplayTemplateByNameOperationCompleted);
			}
			base.InvokeAsync("GetDisplayTemplateByName", new object[]
			{
				displayTemplateName
			}, this.GetDisplayTemplateByNameOperationCompleted, userState);
		}
		private void OnGetDisplayTemplateByNameOperationCompleted(object arg)
		{
			if (this.GetDisplayTemplateByNameCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetDisplayTemplateByNameCompleted(this, new GetDisplayTemplateByNameCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllDisplayTemplates", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllDisplayTemplates", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public DisplayTemplateData[] GetAllDisplayTemplates()
		{
			object[] array = base.Invoke("GetAllDisplayTemplates", new object[0]);
			return (DisplayTemplateData[])array[0];
		}
		public void GetAllDisplayTemplatesAsync()
		{
			this.GetAllDisplayTemplatesAsync(null);
		}
		public void GetAllDisplayTemplatesAsync(object userState)
		{
			if (this.GetAllDisplayTemplatesOperationCompleted == null)
			{
				this.GetAllDisplayTemplatesOperationCompleted = new SendOrPostCallback(this.OnGetAllDisplayTemplatesOperationCompleted);
			}
			base.InvokeAsync("GetAllDisplayTemplates", new object[0], this.GetAllDisplayTemplatesOperationCompleted, userState);
		}
		private void OnGetAllDisplayTemplatesOperationCompleted(object arg)
		{
			if (this.GetAllDisplayTemplatesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllDisplayTemplatesCompleted(this, new GetAllDisplayTemplatesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveDisplayTemplate", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveDisplayTemplate", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveDisplayTemplate([XmlElement(IsNullable = true)] ref DisplayTemplateData DisplayTemplate)
		{
			object[] array = base.Invoke("SaveDisplayTemplate", new object[]
			{
				DisplayTemplate
			});
			DisplayTemplate = (DisplayTemplateData)array[0];
		}
		public void SaveDisplayTemplateAsync(DisplayTemplateData DisplayTemplate)
		{
			this.SaveDisplayTemplateAsync(DisplayTemplate, null);
		}
		public void SaveDisplayTemplateAsync(DisplayTemplateData DisplayTemplate, object userState)
		{
			if (this.SaveDisplayTemplateOperationCompleted == null)
			{
				this.SaveDisplayTemplateOperationCompleted = new SendOrPostCallback(this.OnSaveDisplayTemplateOperationCompleted);
			}
			base.InvokeAsync("SaveDisplayTemplate", new object[]
			{
				DisplayTemplate
			}, this.SaveDisplayTemplateOperationCompleted, userState);
		}
		private void OnSaveDisplayTemplateOperationCompleted(object arg)
		{
			if (this.SaveDisplayTemplateCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveDisplayTemplateCompleted(this, new SaveDisplayTemplateCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteDisplayTemplate", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteDisplayTemplate", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteDisplayTemplate(int displayTemplateId)
		{
			base.Invoke("DeleteDisplayTemplate", new object[]
			{
				displayTemplateId
			});
		}
		public void DeleteDisplayTemplateAsync(int displayTemplateId)
		{
			this.DeleteDisplayTemplateAsync(displayTemplateId, null);
		}
		public void DeleteDisplayTemplateAsync(int displayTemplateId, object userState)
		{
			if (this.DeleteDisplayTemplateOperationCompleted == null)
			{
				this.DeleteDisplayTemplateOperationCompleted = new SendOrPostCallback(this.OnDeleteDisplayTemplateOperationCompleted);
			}
			base.InvokeAsync("DeleteDisplayTemplate", new object[]
			{
				displayTemplateId
			}, this.DeleteDisplayTemplateOperationCompleted, userState);
		}
		private void OnDeleteDisplayTemplateOperationCompleted(object arg)
		{
			if (this.DeleteDisplayTemplateCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteDisplayTemplateCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllIndustryCodes", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllIndustryCodes", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public IndustryCodeData[] GetAllIndustryCodes()
		{
			object[] array = base.Invoke("GetAllIndustryCodes", new object[0]);
			return (IndustryCodeData[])array[0];
		}
		public void GetAllIndustryCodesAsync()
		{
			this.GetAllIndustryCodesAsync(null);
		}
		public void GetAllIndustryCodesAsync(object userState)
		{
			if (this.GetAllIndustryCodesOperationCompleted == null)
			{
				this.GetAllIndustryCodesOperationCompleted = new SendOrPostCallback(this.OnGetAllIndustryCodesOperationCompleted);
			}
			base.InvokeAsync("GetAllIndustryCodes", new object[0], this.GetAllIndustryCodesOperationCompleted, userState);
		}
		private void OnGetAllIndustryCodesOperationCompleted(object arg)
		{
			if (this.GetAllIndustryCodesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllIndustryCodesCompleted(this, new GetAllIndustryCodesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetIndustryCode", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetIndustryCode", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("IndustryCode", IsNullable = true)]
		public IndustryCodeData GetIndustryCode(int industryCodeId)
		{
			object[] array = base.Invoke("GetIndustryCode", new object[]
			{
				industryCodeId
			});
			return (IndustryCodeData)array[0];
		}
		public void GetIndustryCodeAsync(int industryCodeId)
		{
			this.GetIndustryCodeAsync(industryCodeId, null);
		}
		public void GetIndustryCodeAsync(int industryCodeId, object userState)
		{
			if (this.GetIndustryCodeOperationCompleted == null)
			{
				this.GetIndustryCodeOperationCompleted = new SendOrPostCallback(this.OnGetIndustryCodeOperationCompleted);
			}
			base.InvokeAsync("GetIndustryCode", new object[]
			{
				industryCodeId
			}, this.GetIndustryCodeOperationCompleted, userState);
		}
		private void OnGetIndustryCodeOperationCompleted(object arg)
		{
			if (this.GetIndustryCodeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetIndustryCodeCompleted(this, new GetIndustryCodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveIndustryCode", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveIndustryCode", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveIndustryCode([XmlElement(IsNullable = true)] ref IndustryCodeData IndustryCode)
		{
			object[] array = base.Invoke("SaveIndustryCode", new object[]
			{
				IndustryCode
			});
			IndustryCode = (IndustryCodeData)array[0];
		}
		public void SaveIndustryCodeAsync(IndustryCodeData IndustryCode)
		{
			this.SaveIndustryCodeAsync(IndustryCode, null);
		}
		public void SaveIndustryCodeAsync(IndustryCodeData IndustryCode, object userState)
		{
			if (this.SaveIndustryCodeOperationCompleted == null)
			{
				this.SaveIndustryCodeOperationCompleted = new SendOrPostCallback(this.OnSaveIndustryCodeOperationCompleted);
			}
			base.InvokeAsync("SaveIndustryCode", new object[]
			{
				IndustryCode
			}, this.SaveIndustryCodeOperationCompleted, userState);
		}
		private void OnSaveIndustryCodeOperationCompleted(object arg)
		{
			if (this.SaveIndustryCodeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveIndustryCodeCompleted(this, new SaveIndustryCodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteIndustryCode", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteIndustryCode", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteIndustryCode(int industryCodeId)
		{
			base.Invoke("DeleteIndustryCode", new object[]
			{
				industryCodeId
			});
		}
		public void DeleteIndustryCodeAsync(int industryCodeId)
		{
			this.DeleteIndustryCodeAsync(industryCodeId, null);
		}
		public void DeleteIndustryCodeAsync(int industryCodeId, object userState)
		{
			if (this.DeleteIndustryCodeOperationCompleted == null)
			{
				this.DeleteIndustryCodeOperationCompleted = new SendOrPostCallback(this.OnDeleteIndustryCodeOperationCompleted);
			}
			base.InvokeAsync("DeleteIndustryCode", new object[]
			{
				industryCodeId
			}, this.DeleteIndustryCodeOperationCompleted, userState);
		}
		private void OnDeleteIndustryCodeOperationCompleted(object arg)
		{
			if (this.DeleteIndustryCodeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteIndustryCodeCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetCampaignEventType", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetCampaignEventType", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("CampaignEventType", IsNullable = true)]
		public CampaignEventTypeData GetCampaignEventType(int campaignEventTypeId)
		{
			object[] array = base.Invoke("GetCampaignEventType", new object[]
			{
				campaignEventTypeId
			});
			return (CampaignEventTypeData)array[0];
		}
		public void GetCampaignEventTypeAsync(int campaignEventTypeId)
		{
			this.GetCampaignEventTypeAsync(campaignEventTypeId, null);
		}
		public void GetCampaignEventTypeAsync(int campaignEventTypeId, object userState)
		{
			if (this.GetCampaignEventTypeOperationCompleted == null)
			{
				this.GetCampaignEventTypeOperationCompleted = new SendOrPostCallback(this.OnGetCampaignEventTypeOperationCompleted);
			}
			base.InvokeAsync("GetCampaignEventType", new object[]
			{
				campaignEventTypeId
			}, this.GetCampaignEventTypeOperationCompleted, userState);
		}
		private void OnGetCampaignEventTypeOperationCompleted(object arg)
		{
			if (this.GetCampaignEventTypeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetCampaignEventTypeCompleted(this, new GetCampaignEventTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllCampaignEventTypes", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllCampaignEventTypes", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public CampaignEventTypeData[] GetAllCampaignEventTypes()
		{
			object[] array = base.Invoke("GetAllCampaignEventTypes", new object[0]);
			return (CampaignEventTypeData[])array[0];
		}
		public void GetAllCampaignEventTypesAsync()
		{
			this.GetAllCampaignEventTypesAsync(null);
		}
		public void GetAllCampaignEventTypesAsync(object userState)
		{
			if (this.GetAllCampaignEventTypesOperationCompleted == null)
			{
				this.GetAllCampaignEventTypesOperationCompleted = new SendOrPostCallback(this.OnGetAllCampaignEventTypesOperationCompleted);
			}
			base.InvokeAsync("GetAllCampaignEventTypes", new object[0], this.GetAllCampaignEventTypesOperationCompleted, userState);
		}
		private void OnGetAllCampaignEventTypesOperationCompleted(object arg)
		{
			if (this.GetAllCampaignEventTypesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllCampaignEventTypesCompleted(this, new GetAllCampaignEventTypesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveCampaignEventType", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveCampaignEventType", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveCampaignEventType([XmlElement(IsNullable = true)] ref CampaignEventTypeData CampaignEventType)
		{
			object[] array = base.Invoke("SaveCampaignEventType", new object[]
			{
				CampaignEventType
			});
			CampaignEventType = (CampaignEventTypeData)array[0];
		}
		public void SaveCampaignEventTypeAsync(CampaignEventTypeData CampaignEventType)
		{
			this.SaveCampaignEventTypeAsync(CampaignEventType, null);
		}
		public void SaveCampaignEventTypeAsync(CampaignEventTypeData CampaignEventType, object userState)
		{
			if (this.SaveCampaignEventTypeOperationCompleted == null)
			{
				this.SaveCampaignEventTypeOperationCompleted = new SendOrPostCallback(this.OnSaveCampaignEventTypeOperationCompleted);
			}
			base.InvokeAsync("SaveCampaignEventType", new object[]
			{
				CampaignEventType
			}, this.SaveCampaignEventTypeOperationCompleted, userState);
		}
		private void OnSaveCampaignEventTypeOperationCompleted(object arg)
		{
			if (this.SaveCampaignEventTypeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveCampaignEventTypeCompleted(this, new SaveCampaignEventTypeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteCampaignEventType", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteCampaignEventType", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteCampaignEventType(int campaignEventTypeId)
		{
			base.Invoke("DeleteCampaignEventType", new object[]
			{
				campaignEventTypeId
			});
		}
		public void DeleteCampaignEventTypeAsync(int campaignEventTypeId)
		{
			this.DeleteCampaignEventTypeAsync(campaignEventTypeId, null);
		}
		public void DeleteCampaignEventTypeAsync(int campaignEventTypeId, object userState)
		{
			if (this.DeleteCampaignEventTypeOperationCompleted == null)
			{
				this.DeleteCampaignEventTypeOperationCompleted = new SendOrPostCallback(this.OnDeleteCampaignEventTypeOperationCompleted);
			}
			base.InvokeAsync("DeleteCampaignEventType", new object[]
			{
				campaignEventTypeId
			}, this.DeleteCampaignEventTypeOperationCompleted, userState);
		}
		private void OnDeleteCampaignEventTypeOperationCompleted(object arg)
		{
			if (this.DeleteCampaignEventTypeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteCampaignEventTypeCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/RefreshCache", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/RefreshCache", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void RefreshCache(string cacheName)
		{
			base.Invoke("RefreshCache", new object[]
			{
				cacheName
			});
		}
		public void RefreshCacheAsync(string cacheName)
		{
			this.RefreshCacheAsync(cacheName, null);
		}
		public void RefreshCacheAsync(string cacheName, object userState)
		{
			if (this.RefreshCacheOperationCompleted == null)
			{
				this.RefreshCacheOperationCompleted = new SendOrPostCallback(this.OnRefreshCacheOperationCompleted);
			}
			base.InvokeAsync("RefreshCache", new object[]
			{
				cacheName
			}, this.RefreshCacheOperationCompleted, userState);
		}
		private void OnRefreshCacheOperationCompleted(object arg)
		{
			if (this.RefreshCacheCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.RefreshCacheCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetMailingList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetMailingList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("List", IsNullable = true)]
		public MailingListData GetMailingList(Guid listId)
		{
			object[] array = base.Invoke("GetMailingList", new object[]
			{
				listId
			});
			return (MailingListData)array[0];
		}
		public void GetMailingListAsync(Guid listId)
		{
			this.GetMailingListAsync(listId, null);
		}
		public void GetMailingListAsync(Guid listId, object userState)
		{
			if (this.GetMailingListOperationCompleted == null)
			{
				this.GetMailingListOperationCompleted = new SendOrPostCallback(this.OnGetMailingListOperationCompleted);
			}
			base.InvokeAsync("GetMailingList", new object[]
			{
				listId
			}, this.GetMailingListOperationCompleted, userState);
		}
		private void OnGetMailingListOperationCompleted(object arg)
		{
			if (this.GetMailingListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetMailingListCompleted(this, new GetMailingListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllMailingLists", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllMailingLists", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public MailingListData[] GetAllMailingLists()
		{
			object[] array = base.Invoke("GetAllMailingLists", new object[0]);
			return (MailingListData[])array[0];
		}
		public void GetAllMailingListsAsync()
		{
			this.GetAllMailingListsAsync(null);
		}
		public void GetAllMailingListsAsync(object userState)
		{
			if (this.GetAllMailingListsOperationCompleted == null)
			{
				this.GetAllMailingListsOperationCompleted = new SendOrPostCallback(this.OnGetAllMailingListsOperationCompleted);
			}
			base.InvokeAsync("GetAllMailingLists", new object[0], this.GetAllMailingListsOperationCompleted, userState);
		}
		private void OnGetAllMailingListsOperationCompleted(object arg)
		{
			if (this.GetAllMailingListsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllMailingListsCompleted(this, new GetAllMailingListsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SaveMailingList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SaveMailingList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SaveMailingList([XmlElement(IsNullable = true)] ref MailingListData List)
		{
			object[] array = base.Invoke("SaveMailingList", new object[]
			{
				List
			});
			List = (MailingListData)array[0];
		}
		public void SaveMailingListAsync(MailingListData List)
		{
			this.SaveMailingListAsync(List, null);
		}
		public void SaveMailingListAsync(MailingListData List, object userState)
		{
			if (this.SaveMailingListOperationCompleted == null)
			{
				this.SaveMailingListOperationCompleted = new SendOrPostCallback(this.OnSaveMailingListOperationCompleted);
			}
			base.InvokeAsync("SaveMailingList", new object[]
			{
				List
			}, this.SaveMailingListOperationCompleted, userState);
		}
		private void OnSaveMailingListOperationCompleted(object arg)
		{
			if (this.SaveMailingListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SaveMailingListCompleted(this, new SaveMailingListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetUserFromList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetUserFromList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("ListUser", IsNullable = true)]
		public MailingListUserData GetUserFromList(Guid listId, string email)
		{
			object[] array = base.Invoke("GetUserFromList", new object[]
			{
				listId,
				email
			});
			return (MailingListUserData)array[0];
		}
		public void GetUserFromListAsync(Guid listId, string email)
		{
			this.GetUserFromListAsync(listId, email, null);
		}
		public void GetUserFromListAsync(Guid listId, string email, object userState)
		{
			if (this.GetUserFromListOperationCompleted == null)
			{
				this.GetUserFromListOperationCompleted = new SendOrPostCallback(this.OnGetUserFromListOperationCompleted);
			}
			base.InvokeAsync("GetUserFromList", new object[]
			{
				listId,
				email
			}, this.GetUserFromListOperationCompleted, userState);
		}
		private void OnGetUserFromListOperationCompleted(object arg)
		{
			if (this.GetUserFromListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetUserFromListCompleted(this, new GetUserFromListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/AddUserToList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/AddUserToList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public int AddUserToList(Guid listId, [XmlElement(IsNullable = true)] MailingListUserData ListUser)
		{
			object[] array = base.Invoke("AddUserToList", new object[]
			{
				listId,
				ListUser
			});
			return (int)array[0];
		}
		public void AddUserToListAsync(Guid listId, MailingListUserData ListUser)
		{
			this.AddUserToListAsync(listId, ListUser, null);
		}
		public void AddUserToListAsync(Guid listId, MailingListUserData ListUser, object userState)
		{
			if (this.AddUserToListOperationCompleted == null)
			{
				this.AddUserToListOperationCompleted = new SendOrPostCallback(this.OnAddUserToListOperationCompleted);
			}
			base.InvokeAsync("AddUserToList", new object[]
			{
				listId,
				ListUser
			}, this.AddUserToListOperationCompleted, userState);
		}
		private void OnAddUserToListOperationCompleted(object arg)
		{
			if (this.AddUserToListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.AddUserToListCompleted(this, new AddUserToListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/UpdateUserInList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/UpdateUserInList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void UpdateUserInList(Guid listId, [XmlElement(IsNullable = true)] MailingListUserData ListUser)
		{
			base.Invoke("UpdateUserInList", new object[]
			{
				listId,
				ListUser
			});
		}
		public void UpdateUserInListAsync(Guid listId, MailingListUserData ListUser)
		{
			this.UpdateUserInListAsync(listId, ListUser, null);
		}
		public void UpdateUserInListAsync(Guid listId, MailingListUserData ListUser, object userState)
		{
			if (this.UpdateUserInListOperationCompleted == null)
			{
				this.UpdateUserInListOperationCompleted = new SendOrPostCallback(this.OnUpdateUserInListOperationCompleted);
			}
			base.InvokeAsync("UpdateUserInList", new object[]
			{
				listId,
				ListUser
			}, this.UpdateUserInListOperationCompleted, userState);
		}
		private void OnUpdateUserInListOperationCompleted(object arg)
		{
			if (this.UpdateUserInListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.UpdateUserInListCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/RemoveUserFromList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/RemoveUserFromList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public int RemoveUserFromList(Guid listId, string email)
		{
			object[] array = base.Invoke("RemoveUserFromList", new object[]
			{
				listId,
				email
			});
			return (int)array[0];
		}
		public void RemoveUserFromListAsync(Guid listId, string email)
		{
			this.RemoveUserFromListAsync(listId, email, null);
		}
		public void RemoveUserFromListAsync(Guid listId, string email, object userState)
		{
			if (this.RemoveUserFromListOperationCompleted == null)
			{
				this.RemoveUserFromListOperationCompleted = new SendOrPostCallback(this.OnRemoveUserFromListOperationCompleted);
			}
			base.InvokeAsync("RemoveUserFromList", new object[]
			{
				listId,
				email
			}, this.RemoveUserFromListOperationCompleted, userState);
		}
		private void OnRemoveUserFromListOperationCompleted(object arg)
		{
			if (this.RemoveUserFromListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.RemoveUserFromListCompleted(this, new RemoveUserFromListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteList(Guid listId)
		{
			base.Invoke("DeleteList", new object[]
			{
				listId
			});
		}
		public void DeleteListAsync(Guid listId)
		{
			this.DeleteListAsync(listId, null);
		}
		public void DeleteListAsync(Guid listId, object userState)
		{
			if (this.DeleteListOperationCompleted == null)
			{
				this.DeleteListOperationCompleted = new SendOrPostCallback(this.OnDeleteListOperationCompleted);
			}
			base.InvokeAsync("DeleteList", new object[]
			{
				listId
			}, this.DeleteListOperationCompleted, userState);
		}
		private void OnDeleteListOperationCompleted(object arg)
		{
			if (this.DeleteListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteListCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SubtractLists", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SubtractLists", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public Guid SubtractLists(Guid outputListId, Guid inputListId)
		{
			object[] array = base.Invoke("SubtractLists", new object[]
			{
				outputListId,
				inputListId
			});
			return (Guid)array[0];
		}
		public void SubtractListsAsync(Guid outputListId, Guid inputListId)
		{
			this.SubtractListsAsync(outputListId, inputListId, null);
		}
		public void SubtractListsAsync(Guid outputListId, Guid inputListId, object userState)
		{
			if (this.SubtractListsOperationCompleted == null)
			{
				this.SubtractListsOperationCompleted = new SendOrPostCallback(this.OnSubtractListsOperationCompleted);
			}
			base.InvokeAsync("SubtractLists", new object[]
			{
				outputListId,
				inputListId
			}, this.SubtractListsOperationCompleted, userState);
		}
		private void OnSubtractListsOperationCompleted(object arg)
		{
			if (this.SubtractListsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SubtractListsCompleted(this, new SubtractListsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/AppendLists", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/AppendLists", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public Guid AppendLists(Guid outputListId, Guid inputListId)
		{
			object[] array = base.Invoke("AppendLists", new object[]
			{
				outputListId,
				inputListId
			});
			return (Guid)array[0];
		}
		public void AppendListsAsync(Guid outputListId, Guid inputListId)
		{
			this.AppendListsAsync(outputListId, inputListId, null);
		}
		public void AppendListsAsync(Guid outputListId, Guid inputListId, object userState)
		{
			if (this.AppendListsOperationCompleted == null)
			{
				this.AppendListsOperationCompleted = new SendOrPostCallback(this.OnAppendListsOperationCompleted);
			}
			base.InvokeAsync("AppendLists", new object[]
			{
				outputListId,
				inputListId
			}, this.AppendListsOperationCompleted, userState);
		}
		private void OnAppendListsOperationCompleted(object arg)
		{
			if (this.AppendListsCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.AppendListsCompleted(this, new AppendListsCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/AppendExpressionToList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/AppendExpressionToList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public Guid AppendExpressionToList(Guid outputListId, int expressionId)
		{
			object[] array = base.Invoke("AppendExpressionToList", new object[]
			{
				outputListId,
				expressionId
			});
			return (Guid)array[0];
		}
		public void AppendExpressionToListAsync(Guid outputListId, int expressionId)
		{
			this.AppendExpressionToListAsync(outputListId, expressionId, null);
		}
		public void AppendExpressionToListAsync(Guid outputListId, int expressionId, object userState)
		{
			if (this.AppendExpressionToListOperationCompleted == null)
			{
				this.AppendExpressionToListOperationCompleted = new SendOrPostCallback(this.OnAppendExpressionToListOperationCompleted);
			}
			base.InvokeAsync("AppendExpressionToList", new object[]
			{
				outputListId,
				expressionId
			}, this.AppendExpressionToListOperationCompleted, userState);
		}
		private void OnAppendExpressionToListOperationCompleted(object arg)
		{
			if (this.AppendExpressionToListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.AppendExpressionToListCompleted(this, new AppendExpressionToListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/InitImportMailingList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/InitImportMailingList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public UploadHandshake InitImportMailingList(Guid listId, string filePath, long fileSize, DateTime fileLastWriteTime)
		{
			object[] array = base.Invoke("InitImportMailingList", new object[]
			{
				listId,
				filePath,
				fileSize,
				fileLastWriteTime
			});
			return (UploadHandshake)array[0];
		}
		public void InitImportMailingListAsync(Guid listId, string filePath, long fileSize, DateTime fileLastWriteTime)
		{
			this.InitImportMailingListAsync(listId, filePath, fileSize, fileLastWriteTime, null);
		}
		public void InitImportMailingListAsync(Guid listId, string filePath, long fileSize, DateTime fileLastWriteTime, object userState)
		{
			if (this.InitImportMailingListOperationCompleted == null)
			{
				this.InitImportMailingListOperationCompleted = new SendOrPostCallback(this.OnInitImportMailingListOperationCompleted);
			}
			base.InvokeAsync("InitImportMailingList", new object[]
			{
				listId,
				filePath,
				fileSize,
				fileLastWriteTime
			}, this.InitImportMailingListOperationCompleted, userState);
		}
		private void OnInitImportMailingListOperationCompleted(object arg)
		{
			if (this.InitImportMailingListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.InitImportMailingListCompleted(this, new InitImportMailingListCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ImportMailingList", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/ImportMailingList", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void ImportMailingList(Guid operationId)
		{
			base.Invoke("ImportMailingList", new object[]
			{
				operationId
			});
		}
		public void ImportMailingListAsync(Guid operationId)
		{
			this.ImportMailingListAsync(operationId, null);
		}
		public void ImportMailingListAsync(Guid operationId, object userState)
		{
			if (this.ImportMailingListOperationCompleted == null)
			{
				this.ImportMailingListOperationCompleted = new SendOrPostCallback(this.OnImportMailingListOperationCompleted);
			}
			base.InvokeAsync("ImportMailingList", new object[]
			{
				operationId
			}, this.ImportMailingListOperationCompleted, userState);
		}
		private void OnImportMailingListOperationCompleted(object arg)
		{
			if (this.ImportMailingListCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.ImportMailingListCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/AbortListOperation", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/AbortListOperation", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void AbortListOperation(Guid operationId)
		{
			base.Invoke("AbortListOperation", new object[]
			{
				operationId
			});
		}
		public void AbortListOperationAsync(Guid operationId)
		{
			this.AbortListOperationAsync(operationId, null);
		}
		public void AbortListOperationAsync(Guid operationId, object userState)
		{
			if (this.AbortListOperationOperationCompleted == null)
			{
				this.AbortListOperationOperationCompleted = new SendOrPostCallback(this.OnAbortListOperationOperationCompleted);
			}
			base.InvokeAsync("AbortListOperation", new object[]
			{
				operationId
			}, this.AbortListOperationOperationCompleted, userState);
		}
		private void OnAbortListOperationOperationCompleted(object arg)
		{
			if (this.AbortListOperationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.AbortListOperationCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetListOperation", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetListOperation", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public MailingListOperationData GetListOperation(Guid operationId)
		{
			object[] array = base.Invoke("GetListOperation", new object[]
			{
				operationId
			});
			return (MailingListOperationData)array[0];
		}
		public void GetListOperationAsync(Guid operationId)
		{
			this.GetListOperationAsync(operationId, null);
		}
		public void GetListOperationAsync(Guid operationId, object userState)
		{
			if (this.GetListOperationOperationCompleted == null)
			{
				this.GetListOperationOperationCompleted = new SendOrPostCallback(this.OnGetListOperationOperationCompleted);
			}
			base.InvokeAsync("GetListOperation", new object[]
			{
				operationId
			}, this.GetListOperationOperationCompleted, userState);
		}
		private void OnGetListOperationOperationCompleted(object arg)
		{
			if (this.GetListOperationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetListOperationCompleted(this, new GetListOperationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetListOperationHistory", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetListOperationHistory", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public MailingListOperationData[] GetListOperationHistory(Guid listId)
		{
			object[] array = base.Invoke("GetListOperationHistory", new object[]
			{
				listId
			});
			return (MailingListOperationData[])array[0];
		}
		public void GetListOperationHistoryAsync(Guid listId)
		{
			this.GetListOperationHistoryAsync(listId, null);
		}
		public void GetListOperationHistoryAsync(Guid listId, object userState)
		{
			if (this.GetListOperationHistoryOperationCompleted == null)
			{
				this.GetListOperationHistoryOperationCompleted = new SendOrPostCallback(this.OnGetListOperationHistoryOperationCompleted);
			}
			base.InvokeAsync("GetListOperationHistory", new object[]
			{
				listId
			}, this.GetListOperationHistoryOperationCompleted, userState);
		}
		private void OnGetListOperationHistoryOperationCompleted(object arg)
		{
			if (this.GetListOperationHistoryCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetListOperationHistoryCompleted(this, new GetListOperationHistoryCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetMostRecentListOperation", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetMostRecentListOperation", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public MailingListOperationData GetMostRecentListOperation(Guid listId)
		{
			object[] array = base.Invoke("GetMostRecentListOperation", new object[]
			{
				listId
			});
			return (MailingListOperationData)array[0];
		}
		public void GetMostRecentListOperationAsync(Guid listId)
		{
			this.GetMostRecentListOperationAsync(listId, null);
		}
		public void GetMostRecentListOperationAsync(Guid listId, object userState)
		{
			if (this.GetMostRecentListOperationOperationCompleted == null)
			{
				this.GetMostRecentListOperationOperationCompleted = new SendOrPostCallback(this.OnGetMostRecentListOperationOperationCompleted);
			}
			base.InvokeAsync("GetMostRecentListOperation", new object[]
			{
				listId
			}, this.GetMostRecentListOperationOperationCompleted, userState);
		}
		private void OnGetMostRecentListOperationOperationCompleted(object arg)
		{
			if (this.GetMostRecentListOperationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetMostRecentListOperationCompleted(this, new GetMostRecentListOperationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/CreateListCopy", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/CreateListCopy", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("List", IsNullable = true)]
		public MailingListData CreateListCopy(string name, Guid sourceListId)
		{
			object[] array = base.Invoke("CreateListCopy", new object[]
			{
				name,
				sourceListId
			});
			return (MailingListData)array[0];
		}
		public void CreateListCopyAsync(string name, Guid sourceListId)
		{
			this.CreateListCopyAsync(name, sourceListId, null);
		}
		public void CreateListCopyAsync(string name, Guid sourceListId, object userState)
		{
			if (this.CreateListCopyOperationCompleted == null)
			{
				this.CreateListCopyOperationCompleted = new SendOrPostCallback(this.OnCreateListCopyOperationCompleted);
			}
			base.InvokeAsync("CreateListCopy", new object[]
			{
				name,
				sourceListId
			}, this.CreateListCopyOperationCompleted, userState);
		}
		private void OnCreateListCopyOperationCompleted(object arg)
		{
			if (this.CreateListCopyCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.CreateListCopyCompleted(this, new CreateListCopyCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetAllowedProfileDefinition", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetAllowedProfileDefinition", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public string GetAllowedProfileDefinition()
		{
			object[] array = base.Invoke("GetAllowedProfileDefinition", new object[0]);
			return (string)array[0];
		}
		public void GetAllowedProfileDefinitionAsync()
		{
			this.GetAllowedProfileDefinitionAsync(null);
		}
		public void GetAllowedProfileDefinitionAsync(object userState)
		{
			if (this.GetAllowedProfileDefinitionOperationCompleted == null)
			{
				this.GetAllowedProfileDefinitionOperationCompleted = new SendOrPostCallback(this.OnGetAllowedProfileDefinitionOperationCompleted);
			}
			base.InvokeAsync("GetAllowedProfileDefinition", new object[0], this.GetAllowedProfileDefinitionOperationCompleted, userState);
		}
		private void OnGetAllowedProfileDefinitionOperationCompleted(object arg)
		{
			if (this.GetAllowedProfileDefinitionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetAllowedProfileDefinitionCompleted(this, new GetAllowedProfileDefinitionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/NewPromoCodeDefinition", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/NewPromoCodeDefinition", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("PromoCodeDefinition", IsNullable = true)]
		public PromoCodeDefinitionData NewPromoCodeDefinition()
		{
			object[] array = base.Invoke("NewPromoCodeDefinition", new object[0]);
			return (PromoCodeDefinitionData)array[0];
		}
		public void NewPromoCodeDefinitionAsync()
		{
			this.NewPromoCodeDefinitionAsync(null);
		}
		public void NewPromoCodeDefinitionAsync(object userState)
		{
			if (this.NewPromoCodeDefinitionOperationCompleted == null)
			{
				this.NewPromoCodeDefinitionOperationCompleted = new SendOrPostCallback(this.OnNewPromoCodeDefinitionOperationCompleted);
			}
			base.InvokeAsync("NewPromoCodeDefinition", new object[0], this.NewPromoCodeDefinitionOperationCompleted, userState);
		}
		private void OnNewPromoCodeDefinitionOperationCompleted(object arg)
		{
			if (this.NewPromoCodeDefinitionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.NewPromoCodeDefinitionCompleted(this, new NewPromoCodeDefinitionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/SavePromoCodeDefinition", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/SavePromoCodeDefinition", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void SavePromoCodeDefinition([XmlElement(IsNullable = true)] ref PromoCodeDefinitionData PromoCodeDefinition, bool forceOverwrite)
		{
			object[] array = base.Invoke("SavePromoCodeDefinition", new object[]
			{
				PromoCodeDefinition,
				forceOverwrite
			});
			PromoCodeDefinition = (PromoCodeDefinitionData)array[0];
		}
		public void SavePromoCodeDefinitionAsync(PromoCodeDefinitionData PromoCodeDefinition, bool forceOverwrite)
		{
			this.SavePromoCodeDefinitionAsync(PromoCodeDefinition, forceOverwrite, null);
		}
		public void SavePromoCodeDefinitionAsync(PromoCodeDefinitionData PromoCodeDefinition, bool forceOverwrite, object userState)
		{
			if (this.SavePromoCodeDefinitionOperationCompleted == null)
			{
				this.SavePromoCodeDefinitionOperationCompleted = new SendOrPostCallback(this.OnSavePromoCodeDefinitionOperationCompleted);
			}
			base.InvokeAsync("SavePromoCodeDefinition", new object[]
			{
				PromoCodeDefinition,
				forceOverwrite
			}, this.SavePromoCodeDefinitionOperationCompleted, userState);
		}
		private void OnSavePromoCodeDefinitionOperationCompleted(object arg)
		{
			if (this.SavePromoCodeDefinitionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.SavePromoCodeDefinitionCompleted(this, new SavePromoCodeDefinitionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeletePromoCodeDefinition", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeletePromoCodeDefinition", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeletePromoCodeDefinition(int promoCodeDefinitionId)
		{
			base.Invoke("DeletePromoCodeDefinition", new object[]
			{
				promoCodeDefinitionId
			});
		}
		public void DeletePromoCodeDefinitionAsync(int promoCodeDefinitionId)
		{
			this.DeletePromoCodeDefinitionAsync(promoCodeDefinitionId, null);
		}
		public void DeletePromoCodeDefinitionAsync(int promoCodeDefinitionId, object userState)
		{
			if (this.DeletePromoCodeDefinitionOperationCompleted == null)
			{
				this.DeletePromoCodeDefinitionOperationCompleted = new SendOrPostCallback(this.OnDeletePromoCodeDefinitionOperationCompleted);
			}
			base.InvokeAsync("DeletePromoCodeDefinition", new object[]
			{
				promoCodeDefinitionId
			}, this.DeletePromoCodeDefinitionOperationCompleted, userState);
		}
		private void OnDeletePromoCodeDefinitionOperationCompleted(object arg)
		{
			if (this.DeletePromoCodeDefinitionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeletePromoCodeDefinitionCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/DeleteBatch", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/DeleteBatch", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void DeleteBatch(Guid batchId)
		{
			base.Invoke("DeleteBatch", new object[]
			{
				batchId
			});
		}
		public void DeleteBatchAsync(Guid batchId)
		{
			this.DeleteBatchAsync(batchId, null);
		}
		public void DeleteBatchAsync(Guid batchId, object userState)
		{
			if (this.DeleteBatchOperationCompleted == null)
			{
				this.DeleteBatchOperationCompleted = new SendOrPostCallback(this.OnDeleteBatchOperationCompleted);
			}
			base.InvokeAsync("DeleteBatch", new object[]
			{
				batchId
			}, this.DeleteBatchOperationCompleted, userState);
		}
		private void OnDeleteBatchOperationCompleted(object arg)
		{
			if (this.DeleteBatchCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteBatchCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GenerateRandomPromoCodes", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GenerateRandomPromoCodes", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public Guid GenerateRandomPromoCodes(int promoCodeDefinitionId, string batchName, int numberOfCodes, RandomGenerationParameters generationParameters)
		{
			object[] array = base.Invoke("GenerateRandomPromoCodes", new object[]
			{
				promoCodeDefinitionId,
				batchName,
				numberOfCodes,
				generationParameters
			});
			return (Guid)array[0];
		}
		public void GenerateRandomPromoCodesAsync(int promoCodeDefinitionId, string batchName, int numberOfCodes, RandomGenerationParameters generationParameters)
		{
			this.GenerateRandomPromoCodesAsync(promoCodeDefinitionId, batchName, numberOfCodes, generationParameters, null);
		}
		public void GenerateRandomPromoCodesAsync(int promoCodeDefinitionId, string batchName, int numberOfCodes, RandomGenerationParameters generationParameters, object userState)
		{
			if (this.GenerateRandomPromoCodesOperationCompleted == null)
			{
				this.GenerateRandomPromoCodesOperationCompleted = new SendOrPostCallback(this.OnGenerateRandomPromoCodesOperationCompleted);
			}
			base.InvokeAsync("GenerateRandomPromoCodes", new object[]
			{
				promoCodeDefinitionId,
				batchName,
				numberOfCodes,
				generationParameters
			}, this.GenerateRandomPromoCodesOperationCompleted, userState);
		}
		private void OnGenerateRandomPromoCodesOperationCompleted(object arg)
		{
			if (this.GenerateRandomPromoCodesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GenerateRandomPromoCodesCompleted(this, new GenerateRandomPromoCodesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/LookupPromoCodeDefinitionByCode", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/LookupPromoCodeDefinitionByCode", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("PromoCodeDefinition", IsNullable = true)]
		public PromoCodeDefinitionData LookupPromoCodeDefinitionByCode(string promoCode)
		{
			object[] array = base.Invoke("LookupPromoCodeDefinitionByCode", new object[]
			{
				promoCode
			});
			return (PromoCodeDefinitionData)array[0];
		}
		public void LookupPromoCodeDefinitionByCodeAsync(string promoCode)
		{
			this.LookupPromoCodeDefinitionByCodeAsync(promoCode, null);
		}
		public void LookupPromoCodeDefinitionByCodeAsync(string promoCode, object userState)
		{
			if (this.LookupPromoCodeDefinitionByCodeOperationCompleted == null)
			{
				this.LookupPromoCodeDefinitionByCodeOperationCompleted = new SendOrPostCallback(this.OnLookupPromoCodeDefinitionByCodeOperationCompleted);
			}
			base.InvokeAsync("LookupPromoCodeDefinitionByCode", new object[]
			{
				promoCode
			}, this.LookupPromoCodeDefinitionByCodeOperationCompleted, userState);
		}
		private void OnLookupPromoCodeDefinitionByCodeOperationCompleted(object arg)
		{
			if (this.LookupPromoCodeDefinitionByCodeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.LookupPromoCodeDefinitionByCodeCompleted(this, new LookupPromoCodeDefinitionByCodeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetPromoCodeDefinition", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetPromoCodeDefinition", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		[return: XmlElement("PromoCodeDefinition", IsNullable = true)]
		public PromoCodeDefinitionData GetPromoCodeDefinition(int promoCodeDefinitionId)
		{
			object[] array = base.Invoke("GetPromoCodeDefinition", new object[]
			{
				promoCodeDefinitionId
			});
			return (PromoCodeDefinitionData)array[0];
		}
		public void GetPromoCodeDefinitionAsync(int promoCodeDefinitionId)
		{
			this.GetPromoCodeDefinitionAsync(promoCodeDefinitionId, null);
		}
		public void GetPromoCodeDefinitionAsync(int promoCodeDefinitionId, object userState)
		{
			if (this.GetPromoCodeDefinitionOperationCompleted == null)
			{
				this.GetPromoCodeDefinitionOperationCompleted = new SendOrPostCallback(this.OnGetPromoCodeDefinitionOperationCompleted);
			}
			base.InvokeAsync("GetPromoCodeDefinition", new object[]
			{
				promoCodeDefinitionId
			}, this.GetPromoCodeDefinitionOperationCompleted, userState);
		}
		private void OnGetPromoCodeDefinitionOperationCompleted(object arg)
		{
			if (this.GetPromoCodeDefinitionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetPromoCodeDefinitionCompleted(this, new GetPromoCodeDefinitionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetBatchInfosForDefinition", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetBatchInfosForDefinition", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public BatchInfo[] GetBatchInfosForDefinition(int promoCodeDefinitionId, bool onlyCompletedBatches)
		{
			object[] array = base.Invoke("GetBatchInfosForDefinition", new object[]
			{
				promoCodeDefinitionId,
				onlyCompletedBatches
			});
			return (BatchInfo[])array[0];
		}
		public void GetBatchInfosForDefinitionAsync(int promoCodeDefinitionId, bool onlyCompletedBatches)
		{
			this.GetBatchInfosForDefinitionAsync(promoCodeDefinitionId, onlyCompletedBatches, null);
		}
		public void GetBatchInfosForDefinitionAsync(int promoCodeDefinitionId, bool onlyCompletedBatches, object userState)
		{
			if (this.GetBatchInfosForDefinitionOperationCompleted == null)
			{
				this.GetBatchInfosForDefinitionOperationCompleted = new SendOrPostCallback(this.OnGetBatchInfosForDefinitionOperationCompleted);
			}
			base.InvokeAsync("GetBatchInfosForDefinition", new object[]
			{
				promoCodeDefinitionId,
				onlyCompletedBatches
			}, this.GetBatchInfosForDefinitionOperationCompleted, userState);
		}
		private void OnGetBatchInfosForDefinitionOperationCompleted(object arg)
		{
			if (this.GetBatchInfosForDefinitionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetBatchInfosForDefinitionCompleted(this, new GetBatchInfosForDefinitionCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/InitImportPromoCodes", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/InitImportPromoCodes", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public UploadHandshake InitImportPromoCodes(int promoCodeDefinitionId, string batchName, string filePath, long fileSize, DateTime fileLastWriteTime, int codeLength, string prefix, string suffix)
		{
			object[] array = base.Invoke("InitImportPromoCodes", new object[]
			{
				promoCodeDefinitionId,
				batchName,
				filePath,
				fileSize,
				fileLastWriteTime,
				codeLength,
				prefix,
				suffix
			});
			return (UploadHandshake)array[0];
		}
		public void InitImportPromoCodesAsync(int promoCodeDefinitionId, string batchName, string filePath, long fileSize, DateTime fileLastWriteTime, int codeLength, string prefix, string suffix)
		{
			this.InitImportPromoCodesAsync(promoCodeDefinitionId, batchName, filePath, fileSize, fileLastWriteTime, codeLength, prefix, suffix, null);
		}
		public void InitImportPromoCodesAsync(int promoCodeDefinitionId, string batchName, string filePath, long fileSize, DateTime fileLastWriteTime, int codeLength, string prefix, string suffix, object userState)
		{
			if (this.InitImportPromoCodesOperationCompleted == null)
			{
				this.InitImportPromoCodesOperationCompleted = new SendOrPostCallback(this.OnInitImportPromoCodesOperationCompleted);
			}
			base.InvokeAsync("InitImportPromoCodes", new object[]
			{
				promoCodeDefinitionId,
				batchName,
				filePath,
				fileSize,
				fileLastWriteTime,
				codeLength,
				prefix,
				suffix
			}, this.InitImportPromoCodesOperationCompleted, userState);
		}
		private void OnInitImportPromoCodesOperationCompleted(object arg)
		{
			if (this.InitImportPromoCodesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.InitImportPromoCodesCompleted(this, new InitImportPromoCodesCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/ImportPromoCodes", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/ImportPromoCodes", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void ImportPromoCodes(Guid importToken)
		{
			base.Invoke("ImportPromoCodes", new object[]
			{
				importToken
			});
		}
		public void ImportPromoCodesAsync(Guid importToken)
		{
			this.ImportPromoCodesAsync(importToken, null);
		}
		public void ImportPromoCodesAsync(Guid importToken, object userState)
		{
			if (this.ImportPromoCodesOperationCompleted == null)
			{
				this.ImportPromoCodesOperationCompleted = new SendOrPostCallback(this.OnImportPromoCodesOperationCompleted);
			}
			base.InvokeAsync("ImportPromoCodes", new object[]
			{
				importToken
			}, this.ImportPromoCodesOperationCompleted, userState);
		}
		private void OnImportPromoCodesOperationCompleted(object arg)
		{
			if (this.ImportPromoCodesCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.ImportPromoCodesCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetPromoCodeGenerationStatus", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetPromoCodeGenerationStatus", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public PromoCodeOperationStatus GetPromoCodeGenerationStatus(int promoCodeDefinitionId)
		{
			object[] array = base.Invoke("GetPromoCodeGenerationStatus", new object[]
			{
				promoCodeDefinitionId
			});
			return (PromoCodeOperationStatus)array[0];
		}
		public void GetPromoCodeGenerationStatusAsync(int promoCodeDefinitionId)
		{
			this.GetPromoCodeGenerationStatusAsync(promoCodeDefinitionId, null);
		}
		public void GetPromoCodeGenerationStatusAsync(int promoCodeDefinitionId, object userState)
		{
			if (this.GetPromoCodeGenerationStatusOperationCompleted == null)
			{
				this.GetPromoCodeGenerationStatusOperationCompleted = new SendOrPostCallback(this.OnGetPromoCodeGenerationStatusOperationCompleted);
			}
			base.InvokeAsync("GetPromoCodeGenerationStatus", new object[]
			{
				promoCodeDefinitionId
			}, this.GetPromoCodeGenerationStatusOperationCompleted, userState);
		}
		private void OnGetPromoCodeGenerationStatusOperationCompleted(object arg)
		{
			if (this.GetPromoCodeGenerationStatusCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetPromoCodeGenerationStatusCompleted(this, new GetPromoCodeGenerationStatusCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/CancelPromoCodeGeneration", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/CancelPromoCodeGeneration", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public Guid CancelPromoCodeGeneration(int promoCodeDefinitionId)
		{
			object[] array = base.Invoke("CancelPromoCodeGeneration", new object[]
			{
				promoCodeDefinitionId
			});
			return (Guid)array[0];
		}
		public void CancelPromoCodeGenerationAsync(int promoCodeDefinitionId)
		{
			this.CancelPromoCodeGenerationAsync(promoCodeDefinitionId, null);
		}
		public void CancelPromoCodeGenerationAsync(int promoCodeDefinitionId, object userState)
		{
			if (this.CancelPromoCodeGenerationOperationCompleted == null)
			{
				this.CancelPromoCodeGenerationOperationCompleted = new SendOrPostCallback(this.OnCancelPromoCodeGenerationOperationCompleted);
			}
			base.InvokeAsync("CancelPromoCodeGeneration", new object[]
			{
				promoCodeDefinitionId
			}, this.CancelPromoCodeGenerationOperationCompleted, userState);
		}
		private void OnCancelPromoCodeGenerationOperationCompleted(object arg)
		{
			if (this.CancelPromoCodeGenerationCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.CancelPromoCodeGenerationCompleted(this, new CancelPromoCodeGenerationCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/RevertPromoCodeRedemption", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/RevertPromoCodeRedemption", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void RevertPromoCodeRedemption(string promoCode, Guid basketOrderGroupId)
		{
			base.Invoke("RevertPromoCodeRedemption", new object[]
			{
				promoCode,
				basketOrderGroupId
			});
		}
		public void RevertPromoCodeRedemptionAsync(string promoCode, Guid basketOrderGroupId)
		{
			this.RevertPromoCodeRedemptionAsync(promoCode, basketOrderGroupId, null);
		}
		public void RevertPromoCodeRedemptionAsync(string promoCode, Guid basketOrderGroupId, object userState)
		{
			if (this.RevertPromoCodeRedemptionOperationCompleted == null)
			{
				this.RevertPromoCodeRedemptionOperationCompleted = new SendOrPostCallback(this.OnRevertPromoCodeRedemptionOperationCompleted);
			}
			base.InvokeAsync("RevertPromoCodeRedemption", new object[]
			{
				promoCode,
				basketOrderGroupId
			}, this.RevertPromoCodeRedemptionOperationCompleted, userState);
		}
		private void OnRevertPromoCodeRedemptionOperationCompleted(object arg)
		{
			if (this.RevertPromoCodeRedemptionCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.RevertPromoCodeRedemptionCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService/GetMaximumPromoCodeBatchSize", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2006/06/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService/GetMaximumPromoCodeBatchSize", RequestNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/Marketing/MarketingWebService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public int GetMaximumPromoCodeBatchSize()
		{
			object[] array = base.Invoke("GetMaximumPromoCodeBatchSize", new object[0]);
			return (int)array[0];
		}
		public void GetMaximumPromoCodeBatchSizeAsync()
		{
			this.GetMaximumPromoCodeBatchSizeAsync(null);
		}
		public void GetMaximumPromoCodeBatchSizeAsync(object userState)
		{
			if (this.GetMaximumPromoCodeBatchSizeOperationCompleted == null)
			{
				this.GetMaximumPromoCodeBatchSizeOperationCompleted = new SendOrPostCallback(this.OnGetMaximumPromoCodeBatchSizeOperationCompleted);
			}
			base.InvokeAsync("GetMaximumPromoCodeBatchSize", new object[0], this.GetMaximumPromoCodeBatchSizeOperationCompleted, userState);
		}
		private void OnGetMaximumPromoCodeBatchSizeOperationCompleted(object arg)
		{
			if (this.GetMaximumPromoCodeBatchSizeCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.GetMaximumPromoCodeBatchSizeCompleted(this, new GetMaximumPromoCodeBatchSizeCompletedEventArgs(invokeCompletedEventArgs.Results, invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
#if MS
		[SoapDocumentMethod("http://schemas.microsoft.com/CommerceServer/2004/02/UploadService/UploadChunk", RequestNamespace = "http://schemas.microsoft.com/CommerceServer/2004/02/UploadService", ResponseNamespace = "http://schemas.microsoft.com/CommerceServer/2004/02/UploadService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#else
		[SoapDocumentMethod("http://schemas.commerceserver.net/2013/01/UploadService/UploadChunk", RequestNamespace = "http://schemas.commerceserver.net/2013/01/UploadService", ResponseNamespace = "http://schemas.commerceserver.net/2013/01/UploadService", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
#endif

		public void UploadChunk(Guid token, int ordinal, [XmlElement(DataType = "base64Binary")] byte[] data)
		{
			base.Invoke("UploadChunk", new object[]
			{
				token,
				ordinal,
				data
			});
		}
		public void UploadChunkAsync(Guid token, int ordinal, byte[] data)
		{
			this.UploadChunkAsync(token, ordinal, data, null);
		}
		public void UploadChunkAsync(Guid token, int ordinal, byte[] data, object userState)
		{
			if (this.UploadChunkOperationCompleted == null)
			{
				this.UploadChunkOperationCompleted = new SendOrPostCallback(this.OnUploadChunkOperationCompleted);
			}
			base.InvokeAsync("UploadChunk", new object[]
			{
				token,
				ordinal,
				data
			}, this.UploadChunkOperationCompleted, userState);
		}
		private void OnUploadChunkOperationCompleted(object arg)
		{
			if (this.UploadChunkCompleted != null)
			{
				InvokeCompletedEventArgs invokeCompletedEventArgs = (InvokeCompletedEventArgs)arg;
				this.UploadChunkCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArgs.Error, invokeCompletedEventArgs.Cancelled, invokeCompletedEventArgs.UserState));
			}
		}
		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}
		private bool IsLocalFileSystemWebService(string url)
		{
			bool result;
			if (url == null || url == string.Empty)
			{
				result = false;
			}
			else
			{
				Uri uri = new Uri(url);
				result = (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0);
			}
			return result;
		}
	}
}
