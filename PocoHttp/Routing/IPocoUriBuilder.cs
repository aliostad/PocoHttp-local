using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocoHttp.Routing
{
	public interface IPocoUriBuilder
	{
		Uri BuildUri(Type type, bool usePluralUris);
	}
}
