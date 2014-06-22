using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetDisplaySizeCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public DisplaySizeData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (DisplaySizeData)this.results[0];
			}
		}
		internal GetDisplaySizeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
