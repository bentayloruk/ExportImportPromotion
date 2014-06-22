using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ExportImportPromotion.StoreMarketingWebService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.1"), DesignerCategory("code"), DebuggerStepThrough]
	public class CopyExpressionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public ExpressionData Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ExpressionData)this.results[0];
			}
		}
		internal CopyExpressionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
