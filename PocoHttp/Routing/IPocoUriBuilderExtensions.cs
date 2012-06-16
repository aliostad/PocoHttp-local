using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocoHttp.Routing
{
	public static class IPocoUriBuilderExtensions
	{
		public static Uri BuildUri<TEntity>(this IPocoUriBuilder uriBuilder, 
			bool usePluralUris, string overrideUrl)
		{
			return uriBuilder.BuildUri(typeof (TEntity), usePluralUris);
		}
	}
}
