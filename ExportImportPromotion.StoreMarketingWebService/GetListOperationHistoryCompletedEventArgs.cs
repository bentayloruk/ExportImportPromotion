using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetListOperationHistoryCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public MailingListOperationData[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (MailingListOperationData[])this.results[0];
			}
		}
		internal GetListOperationHistoryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
