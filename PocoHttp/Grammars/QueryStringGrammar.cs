using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;

namespace PocoHttp.Grammars
{
	public abstract class QueryStringGrammar : IHttpDataGrammar
	{
		public void Compose(Expression expression, HttpRequestMessage request)
		{
			var queryString = GetQueryString(expression);
			
				request.RequestUri = new Uri(request.RequestUri.ToString() + 
					((request.RequestUri.ToString().IndexOf("?") >= 0) ? "&" : "?")
					+ queryString, request.RequestUri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative);
			
		}

		protected abstract string GetQueryString(Expression expression);
	}
}
